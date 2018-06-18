namespace Regex_Manager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyReplacementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMostRecentByDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAddDeleteImmediatelyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowDuplicateNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegexText = new System.Windows.Forms.TextBox();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.cmsQuickParts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lowerAlphasazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperAlphasAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphasazAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digits09ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaDigitsazAZ09ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cStyleIdentifierazAZazAZ09ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atLeastOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginningOfStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endOfStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exactStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReplacementText = new System.Windows.Forms.TextBox();
            this.txtReplacement = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ofdRegexes = new System.Windows.Forms.OpenFileDialog();
            this.sfdRegexes = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lvRegexes = new System.Windows.Forms.ListView();
            this.cmsRegexes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsQuickParts.SuspendLayout();
            this.cmsRegexes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this._newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this._saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this._saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this._openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyReplacementsToolStripMenuItem,
            this.pasteInputToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyReplacementsToolStripMenuItem
            // 
            this.copyReplacementsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copyReplacementsToolStripMenuItem.Name = "copyReplacementsToolStripMenuItem";
            this.copyReplacementsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.copyReplacementsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.copyReplacementsToolStripMenuItem.Text = "Copy Replacements";
            this.copyReplacementsToolStripMenuItem.Click += new System.EventHandler(this._copyReplacementsToolStripMenuItem_Click);
            // 
            // pasteInputToolStripMenuItem
            // 
            this.pasteInputToolStripMenuItem.Name = "pasteInputToolStripMenuItem";
            this.pasteInputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.pasteInputToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.pasteInputToolStripMenuItem.Text = "Paste Input";
            this.pasteInputToolStripMenuItem.Click += new System.EventHandler(this._pasteInputToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMostRecentByDefaultToolStripMenuItem,
            this.saveAddDeleteImmediatelyToolStripMenuItem,
            this.allowDuplicateNamesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // openMostRecentByDefaultToolStripMenuItem
            // 
            this.openMostRecentByDefaultToolStripMenuItem.CheckOnClick = true;
            this.openMostRecentByDefaultToolStripMenuItem.Name = "openMostRecentByDefaultToolStripMenuItem";
            this.openMostRecentByDefaultToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.openMostRecentByDefaultToolStripMenuItem.Text = "Open Most Recent By Default";
            // 
            // saveAddDeleteImmediatelyToolStripMenuItem
            // 
            this.saveAddDeleteImmediatelyToolStripMenuItem.CheckOnClick = true;
            this.saveAddDeleteImmediatelyToolStripMenuItem.Name = "saveAddDeleteImmediatelyToolStripMenuItem";
            this.saveAddDeleteImmediatelyToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.saveAddDeleteImmediatelyToolStripMenuItem.Text = "Save Add / Delete Immediately";
            // 
            // allowDuplicateNamesToolStripMenuItem
            // 
            this.allowDuplicateNamesToolStripMenuItem.CheckOnClick = true;
            this.allowDuplicateNamesToolStripMenuItem.Name = "allowDuplicateNamesToolStripMenuItem";
            this.allowDuplicateNamesToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.allowDuplicateNamesToolStripMenuItem.Text = "Allow Duplicate Names";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(684, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "lblStatus";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtRegexText);
            this.splitContainer1.Panel1.Controls.Add(this.txtRegex);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtReplacementText);
            this.splitContainer1.Panel2.Controls.Add(this.txtReplacement);
            this.splitContainer1.Size = new System.Drawing.Size(367, 340);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input (Global + Multiline Flags)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Regular Expression";
            // 
            // txtRegexText
            // 
            this.txtRegexText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexText.Location = new System.Drawing.Point(3, 58);
            this.txtRegexText.Multiline = true;
            this.txtRegexText.Name = "txtRegexText";
            this.txtRegexText.Size = new System.Drawing.Size(174, 279);
            this.txtRegexText.TabIndex = 0;
            this.txtRegexText.TextChanged += new System.EventHandler(this._txtRegexText_TextChanged);
            // 
            // txtRegex
            // 
            this.txtRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegex.ContextMenuStrip = this.cmsQuickParts;
            this.txtRegex.Location = new System.Drawing.Point(3, 19);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(174, 20);
            this.txtRegex.TabIndex = 0;
            this.txtRegex.TextChanged += new System.EventHandler(this._txtRegex_TextChanged);
            // 
            // cmsQuickParts
            // 
            this.cmsQuickParts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowerAlphasazToolStripMenuItem,
            this.upperAlphasAZToolStripMenuItem,
            this.alphasazAZToolStripMenuItem,
            this.digits09ToolStripMenuItem,
            this.alphaDigitsazAZ09ToolStripMenuItem,
            this.cStyleIdentifierazAZazAZ09ToolStripMenuItem,
            this.captureGroupToolStripMenuItem,
            this.anyNumberToolStripMenuItem,
            this.atLeastOneToolStripMenuItem,
            this.beginningOfStringToolStripMenuItem,
            this.endOfStringToolStripMenuItem,
            this.exactStringToolStripMenuItem});
            this.cmsQuickParts.Name = "cmsQuickParts";
            this.cmsQuickParts.Size = new System.Drawing.Size(289, 268);
            // 
            // lowerAlphasazToolStripMenuItem
            // 
            this.lowerAlphasazToolStripMenuItem.Name = "lowerAlphasazToolStripMenuItem";
            this.lowerAlphasazToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.lowerAlphasazToolStripMenuItem.Text = "Lower Alphas: [a-z]";
            this.lowerAlphasazToolStripMenuItem.Click += new System.EventHandler(this._lowerAlphasazToolStripMenuItem_Click);
            // 
            // upperAlphasAZToolStripMenuItem
            // 
            this.upperAlphasAZToolStripMenuItem.Name = "upperAlphasAZToolStripMenuItem";
            this.upperAlphasAZToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.upperAlphasAZToolStripMenuItem.Text = "Upper Alphas: [A-Z]";
            this.upperAlphasAZToolStripMenuItem.Click += new System.EventHandler(this._upperAlphasAZToolStripMenuItem_Click);
            // 
            // alphasazAZToolStripMenuItem
            // 
            this.alphasazAZToolStripMenuItem.Name = "alphasazAZToolStripMenuItem";
            this.alphasazAZToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.alphasazAZToolStripMenuItem.Text = "Alphas: [a-zA-Z]";
            this.alphasazAZToolStripMenuItem.Click += new System.EventHandler(this._alphasazAZToolStripMenuItem_Click);
            // 
            // digits09ToolStripMenuItem
            // 
            this.digits09ToolStripMenuItem.Name = "digits09ToolStripMenuItem";
            this.digits09ToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.digits09ToolStripMenuItem.Text = "Digits: [0-9]";
            this.digits09ToolStripMenuItem.Click += new System.EventHandler(this._digits09ToolStripMenuItem_Click);
            // 
            // alphaDigitsazAZ09ToolStripMenuItem
            // 
            this.alphaDigitsazAZ09ToolStripMenuItem.Name = "alphaDigitsazAZ09ToolStripMenuItem";
            this.alphaDigitsazAZ09ToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.alphaDigitsazAZ09ToolStripMenuItem.Text = "Alpha Digits: [a-zA-Z0-9]";
            this.alphaDigitsazAZ09ToolStripMenuItem.Click += new System.EventHandler(this._alphaDigitsazAZ09ToolStripMenuItem_Click);
            // 
            // cStyleIdentifierazAZazAZ09ToolStripMenuItem
            // 
            this.cStyleIdentifierazAZazAZ09ToolStripMenuItem.Name = "cStyleIdentifierazAZazAZ09ToolStripMenuItem";
            this.cStyleIdentifierazAZazAZ09ToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.cStyleIdentifierazAZazAZ09ToolStripMenuItem.Text = "C-Style Identifier: [a-zA-Z_][a-zA-Z0-9_]*";
            this.cStyleIdentifierazAZazAZ09ToolStripMenuItem.Click += new System.EventHandler(this._cStyleIdentifierazAZazAZ09ToolStripMenuItem_Click);
            // 
            // captureGroupToolStripMenuItem
            // 
            this.captureGroupToolStripMenuItem.Name = "captureGroupToolStripMenuItem";
            this.captureGroupToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.captureGroupToolStripMenuItem.Text = "Capture Group: ()";
            this.captureGroupToolStripMenuItem.Click += new System.EventHandler(this._captureGroupToolStripMenuItem_Click);
            // 
            // anyNumberToolStripMenuItem
            // 
            this.anyNumberToolStripMenuItem.Name = "anyNumberToolStripMenuItem";
            this.anyNumberToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.anyNumberToolStripMenuItem.Text = "Any Number: *";
            this.anyNumberToolStripMenuItem.Click += new System.EventHandler(this._anyNumberToolStripMenuItem_Click);
            // 
            // atLeastOneToolStripMenuItem
            // 
            this.atLeastOneToolStripMenuItem.Name = "atLeastOneToolStripMenuItem";
            this.atLeastOneToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.atLeastOneToolStripMenuItem.Text = "At Least One: +";
            this.atLeastOneToolStripMenuItem.Click += new System.EventHandler(this._atLeastOneToolStripMenuItem_Click);
            // 
            // beginningOfStringToolStripMenuItem
            // 
            this.beginningOfStringToolStripMenuItem.Name = "beginningOfStringToolStripMenuItem";
            this.beginningOfStringToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.beginningOfStringToolStripMenuItem.Text = "Beginning of String: ^";
            this.beginningOfStringToolStripMenuItem.Click += new System.EventHandler(this._beginningOfStringToolStripMenuItem_Click);
            // 
            // endOfStringToolStripMenuItem
            // 
            this.endOfStringToolStripMenuItem.Name = "endOfStringToolStripMenuItem";
            this.endOfStringToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.endOfStringToolStripMenuItem.Text = "End of String: $";
            this.endOfStringToolStripMenuItem.Click += new System.EventHandler(this._endOfStringToolStripMenuItem_Click);
            // 
            // exactStringToolStripMenuItem
            // 
            this.exactStringToolStripMenuItem.Name = "exactStringToolStripMenuItem";
            this.exactStringToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.exactStringToolStripMenuItem.Text = "Exact String: ^$";
            this.exactStringToolStripMenuItem.Click += new System.EventHandler(this._exactStringToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Replacements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Replacement Expression";
            // 
            // txtReplacementText
            // 
            this.txtReplacementText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplacementText.Location = new System.Drawing.Point(3, 58);
            this.txtReplacementText.Multiline = true;
            this.txtReplacementText.Name = "txtReplacementText";
            this.txtReplacementText.ReadOnly = true;
            this.txtReplacementText.Size = new System.Drawing.Size(177, 279);
            this.txtReplacementText.TabIndex = 0;
            // 
            // txtReplacement
            // 
            this.txtReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplacement.Location = new System.Drawing.Point(3, 19);
            this.txtReplacement.Name = "txtReplacement";
            this.txtReplacement.Size = new System.Drawing.Size(177, 20);
            this.txtReplacement.TabIndex = 0;
            this.txtReplacement.TextChanged += new System.EventHandler(this._txtReplacement_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(295, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // ofdRegexes
            // 
            this.ofdRegexes.DefaultExt = "regex.json";
            this.ofdRegexes.Filter = "Regex Json files|*.regex.json|Json files|*.json|All files|*.*";
            this.ofdRegexes.RestoreDirectory = true;
            this.ofdRegexes.ShowHelp = true;
            this.ofdRegexes.SupportMultiDottedExtensions = true;
            this.ofdRegexes.Title = "Load Regular Expression Set";
            // 
            // sfdRegexes
            // 
            this.sfdRegexes.CreatePrompt = true;
            this.sfdRegexes.DefaultExt = "regex.json";
            this.sfdRegexes.Filter = "Regex Json files|*.regex.json|Json files|*.json|All files|*.*";
            this.sfdRegexes.RestoreDirectory = true;
            this.sfdRegexes.SupportMultiDottedExtensions = true;
            this.sfdRegexes.Title = "Save Regular Expression Set";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(44, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this._txtRegex_TextChanged);
            // 
            // lvRegexes
            // 
            this.lvRegexes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRegexes.ContextMenuStrip = this.cmsRegexes;
            this.lvRegexes.Location = new System.Drawing.Point(3, 3);
            this.lvRegexes.MultiSelect = false;
            this.lvRegexes.Name = "lvRegexes";
            this.lvRegexes.ShowItemToolTips = true;
            this.lvRegexes.Size = new System.Drawing.Size(292, 369);
            this.lvRegexes.TabIndex = 7;
            this.lvRegexes.UseCompatibleStateImageBehavior = false;
            this.lvRegexes.View = System.Windows.Forms.View.List;
            this.lvRegexes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lvRegexes_MouseDoubleClick);
            // 
            // cmsRegexes
            // 
            this.cmsRegexes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsRegexes.Name = "contextMenuStrip1";
            this.cmsRegexes.Size = new System.Drawing.Size(108, 48);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this._loadToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this._deleteToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 27);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvRegexes);
            this.splitContainer2.Panel1MinSize = 287;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer2.Panel2.Controls.Add(this.txtName);
            this.splitContainer2.Size = new System.Drawing.Size(675, 375);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 427);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(715, 466);
            this.Name = "Main";
            this.Text = "Regex Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsQuickParts.ResumeLayout(false);
            this.cmsRegexes.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtRegexText;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.TextBox txtReplacementText;
        private System.Windows.Forms.TextBox txtReplacement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyReplacementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem pasteInputToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdRegexes;
        private System.Windows.Forms.SaveFileDialog sfdRegexes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView lvRegexes;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ContextMenuStrip cmsRegexes;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsQuickParts;
        private System.Windows.Forms.ToolStripMenuItem lowerAlphasazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperAlphasAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphasazAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digits09ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphaDigitsazAZ09ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cStyleIdentifierazAZazAZ09ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atLeastOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginningOfStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endOfStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exactStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMostRecentByDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAddDeleteImmediatelyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowDuplicateNamesToolStripMenuItem;
    }
}

