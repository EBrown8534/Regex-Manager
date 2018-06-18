using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Regex_Manager
{
    public partial class Main : Form
    {
        private bool _pendingChanges = false;

        private string _configurationFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Regex Manager", "Configuration.json");
        private string _profileList = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Regex Manager", "Recent.txt");
        private string _currentFile;

        private List<RegularExpression> _regularExpressions = new List<RegularExpression>();

        public Main()
        {
            if (!Directory.Exists(new FileInfo(_profileList).Directory.FullName))
            {
                Directory.CreateDirectory(new FileInfo(_profileList).Directory.FullName);
            }

            if (!Directory.Exists(new FileInfo(_configurationFile).Directory.FullName))
            {
                Directory.CreateDirectory(new FileInfo(_configurationFile).Directory.FullName);
            }

            InitializeComponent();
            statusStrip1.Renderer = new StatusStripRenderer();
            lblStatus.Text = null;

            var recent = _loadRecentFiles();
            _showOpenRecentFiles(recent);

            if (File.Exists(_configurationFile))
            {
                var config = new JavaScriptSerializer().Deserialize<Configuration>(File.ReadAllText(_configurationFile));
                Width = config.WindowSize.Width;
                Height = config.WindowSize.Height;

                if (config.Maximized)
                {
                    WindowState = FormWindowState.Maximized;
                }

                openMostRecentByDefaultToolStripMenuItem.Checked = config.OpenMostRecentByDefault;
                saveAddDeleteImmediatelyToolStripMenuItem.Checked = config.SaveAddDeleteImmediately;
                allowDuplicateNamesToolStripMenuItem.Checked = config.AllowDuplicateNames;
            }

            if (openMostRecentByDefaultToolStripMenuItem.Checked && recent.Count > 0)
            {
                _load(recent[0]);
            }
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegex.Text))
            {
                MessageBox.Show("You must enter a regular expression.", "No Regex", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You must enter a name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!allowDuplicateNamesToolStripMenuItem.Checked && _regularExpressions.Any(x => x.Name == txtName.Text))
            {
                MessageBox.Show($"You must enter a unique name or check {optionsToolStripMenuItem.Text} -> {allowDuplicateNamesToolStripMenuItem.Text}.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _regularExpressions.Add(new RegularExpression()
            {
                Name = txtName.Text,
                Regex = txtRegex.Text,
                Replacement = txtReplacement.Text
            });
            _updateRegexList(_regularExpressions);
            _status($"Regular expression added: {txtName.Text}");

            _pendingChanges = true;
            if (saveAddDeleteImmediatelyToolStripMenuItem.Checked)
            {
                _save(false);
            }
        }

        private void _loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvRegexes.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You must select a regular expression to load it.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selected = lvRegexes.SelectedIndices[0];
            if (selected < 0)
            {
                MessageBox.Show("You must select a regular expression to load it.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtName.Text = _regularExpressions[selected].Name;
            txtRegex.Text = _regularExpressions[selected].Regex;
            txtReplacement.Text = _regularExpressions[selected].Replacement;
            _status($"Regular expression selected: {_regularExpressions[selected].Name}");
        }

        private void _deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvRegexes.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You must select a regular expression to delete it.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selected = lvRegexes.SelectedIndices[0];
            if (selected < 0)
            {
                MessageBox.Show("You must select a regular expression to delete it.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var name = _regularExpressions[selected].Name;
            if (MessageBox.Show($"Delete this regular expression:{Environment.NewLine}{Environment.NewLine}{name}", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _regularExpressions.Remove(_regularExpressions[selected]);
                _updateRegexList(_regularExpressions);
                _status($"Regular expression deleted: {name}");

                _pendingChanges = true;

                if (saveAddDeleteImmediatelyToolStripMenuItem.Checked)
                {
                    _save(false);
                }
            }
        }

        private void _newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_pendingChanges)
            {
                var result = MessageBox.Show("Would you like to save your changes first?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _save(false);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            _currentFile = null;
            Text = Text.Split(new[] { " - " }, StringSplitOptions.None)[0];
            _regularExpressions = new List<RegularExpression>();
            _updateRegexList(_regularExpressions);
            _status("New database");
            _pendingChanges = false;
        }

        private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _save(false);
        }

        private void _saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _save(true);
        }

        private void _openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _load();
        }

        private void _loadFile(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem senderObj)
            {
                _load(senderObj.Text);
            }
        }

        private void _copyReplacementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReplacementText.Text))
            {
                Clipboard.SetText(txtReplacementText.Text);
                _status("Replacements copied to clipboard.");
            }
        }

        private void _pasteInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtRegexText.Text = Clipboard.GetText();
                _status("Input pasted from clipboard.");
            }
        }

        private void UpdateReplacements()
        {
            if (!string.IsNullOrEmpty(txtRegex.Text) && !string.IsNullOrEmpty(txtRegexText.Text))
            {
                try
                {
                    txtReplacementText.Text = Regex.Replace(txtRegexText.Text.Replace("\r\n", "\n"), txtRegex.Text, txtReplacement.Text, RegexOptions.Multiline).Replace("\n", "\r\n");
                }
                catch (ArgumentException) { }
            }
            else
            {
                txtReplacementText.Text = null;
            }
        }

        private void _txtRegex_TextChanged(object sender, EventArgs e)
        {
            UpdateReplacements();
        }

        private void _txtReplacement_TextChanged(object sender, EventArgs e)
        {
            UpdateReplacements();
        }

        private void _txtRegexText_TextChanged(object sender, EventArgs e)
        {
            UpdateReplacements();
        }

        private void _status(string text)
        {
            lblStatus.Text = $"{DateTime.Now.ToShortTimeString()}: {text}";
        }

        private bool _goodDialogResult(DialogResult result) => !(result == DialogResult.Abort || result == DialogResult.Cancel || result == DialogResult.No || result == DialogResult.None);

        private void _load(string lFile = null)
        {
            if (_pendingChanges)
            {
                var result = MessageBox.Show("Would you like to save your changes first?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _save(false);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(lFile))
            {
                var result = ofdRegexes.ShowDialog();
                if (!_goodDialogResult(result))
                {
                    return;
                }
                lFile = ofdRegexes.FileName;
            }

            try
            {
                var regexes = new JavaScriptSerializer().Deserialize<List<RegularExpression>>(File.ReadAllText(lFile));
                _updateCurrentFile(lFile);
                _updateRecentFiles();

                _regularExpressions = regexes;
                _updateRegexList(_regularExpressions);

                _status($"Loaded {_currentFile}");
                _pendingChanges = false;
            }
            catch
            {
                MessageBox.Show($"The file {lFile} could not be loaded.", "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _save(bool forceDialog)
        {
            var saveFile = _currentFile;

            if (string.IsNullOrWhiteSpace(_currentFile) || forceDialog)
            {
                var result = sfdRegexes.ShowDialog();
                if (!_goodDialogResult(result))
                {
                    return;
                }
                saveFile = sfdRegexes.FileName;
            }

            try
            {
                File.WriteAllText(saveFile, new JavaScriptSerializer().Serialize(_regularExpressions));
                _updateCurrentFile(saveFile);
                _updateRecentFiles();

                _status($"Saved {saveFile}");
                _pendingChanges = false;
            }
            catch
            {
                MessageBox.Show($"The file {saveFile} could not be saved.", "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _updateRegexList(List<RegularExpression> regularExpressions)
        {
            lvRegexes.Items.Clear();
            foreach (var regex in regularExpressions)
            {
                lvRegexes.Items.Add(new ListViewItem(regex.Name));
            }
        }

        private void _updateCurrentFile(string file)
        {
            _currentFile = file;
            Text = $"{Text.Split(new[] { " - " }, StringSplitOptions.None)[0]} - {_currentFile}";
        }

        private void _updateRecentFiles()
        {
            var files = _loadRecentFiles();
            files.Add(_currentFile);

            files =
                files
                    .Distinct()
                    .OrderBy(x => x == _currentFile ? 0 : 1)
                    .Take(10)
                    .ToList();

            _saveRecentFiles(files);
            _showOpenRecentFiles(files);
        }

        private List<string> _loadRecentFiles()
        {
            var results = new List<string>();

            if (File.Exists(_profileList))
            {
                var files = File.ReadAllLines(_profileList);
                foreach (var file in files)
                {
                    results.Add(file);
                }
            }

            return results;
        }

        private void _showOpenRecentFiles(IEnumerable<string> files)
        {
            openToolStripMenuItem.DropDownItems.Clear();
            foreach (var file in files)
            {
                openToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(file, null, _loadFile));
            }
        }

        private void _saveRecentFiles(IEnumerable<string> files)
        {
            File.WriteAllLines(_profileList, files);
        }

        private void _insertText(TextBox box, string txt)
        {
            var selectionStart = box.SelectionStart;
            box.Text = box.Text.Insert(selectionStart, txt);

            box.SelectionStart = selectionStart;
            box.SelectionLength = txt.Length;
        }

        private void _appendText(TextBox box, string txt)
        {
            var selectionStart = box.SelectionStart;
            var selectionEnd = box.SelectionStart + box.SelectionLength;
            box.Text = box.Text.Insert(selectionEnd, txt);

            box.SelectionStart = selectionStart;
            box.SelectionLength = selectionEnd - selectionStart + txt.Length;
        }

        private void _wrapSelectionText(TextBox box, string before, string after)
        {
            var selectionStart = box.SelectionStart;
            var selectionEnd = box.SelectionStart + box.SelectionLength;
            box.Text = box.Text.Insert(selectionEnd, after);
            box.Text = box.Text.Insert(selectionStart, before);

            box.SelectionStart = selectionStart;
            box.SelectionLength = selectionEnd - selectionStart + before.Length + after.Length;
        }

        private void _lowerAlphasazToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "[a-z]");
        private void _upperAlphasAZToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "[A-Z]");
        private void _alphasazAZToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "[a-zA-Z]");
        private void _digits09ToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "[0-9]");
        private void _alphaDigitsazAZ09ToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "[a-zA-Z0-9]");
        private void _cStyleIdentifierazAZazAZ09ToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "[a-zA-Z_][a-zA-Z0-9_]*");
        private void _captureGroupToolStripMenuItem_Click(object sender, EventArgs e) => _wrapSelectionText(txtRegex, "(", ")");
        private void _anyNumberToolStripMenuItem_Click(object sender, EventArgs e) => _appendText(txtRegex, "*");
        private void _atLeastOneToolStripMenuItem_Click(object sender, EventArgs e) => _appendText(txtRegex, "+");
        private void _beginningOfStringToolStripMenuItem_Click(object sender, EventArgs e) => _insertText(txtRegex, "^");
        private void _endOfStringToolStripMenuItem_Click(object sender, EventArgs e) => _appendText(txtRegex, "$");
        private void _exactStringToolStripMenuItem_Click(object sender, EventArgs e) => _wrapSelectionText(txtRegex, "^", "$");

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e) => new About().ShowDialog();

        private void _lvRegexes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvRegexes.SelectedIndices.Count > 0)
            {
                _loadToolStripMenuItem_Click(sender, e);
            }
        }

        private void _Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && _pendingChanges)
            {
                var result = MessageBox.Show("Would you like to save your changes first?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _save(false);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            var config = new Configuration
            {
                WindowSize = new Size() { Width = Width, Height = Height },
                Maximized = WindowState == FormWindowState.Maximized,
                OpenMostRecentByDefault = openMostRecentByDefaultToolStripMenuItem.Checked,
                SaveAddDeleteImmediately = saveAddDeleteImmediatelyToolStripMenuItem.Checked,
                AllowDuplicateNames = allowDuplicateNamesToolStripMenuItem.Checked
            };
            File.WriteAllText(_configurationFile, new JavaScriptSerializer().Serialize(config));
        }
    }
}
