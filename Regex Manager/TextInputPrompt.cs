using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Manager
{
    public partial class TextInputPrompt : Form
    {
        public string InputText { get; private set; }

        private TextInputPrompt()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            lblPrompt.Text = null;
        }

        private TextInputPrompt(string title)
            : this()
        {
            Text = title;
        }

        private TextInputPrompt(string title, string prompt)
            : this(title)
        {
            lblPrompt.Text = prompt;
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            InputText = txtInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            InputText = null;
            Close();
        }

        public static string GetTextInput(string title) => GetTextInput(title, null);
        public static string GetTextInput(string title, string prompt)
        {
            var form = new TextInputPrompt(title, prompt);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return form.InputText;
            }
            return null;
        }
    }
}
