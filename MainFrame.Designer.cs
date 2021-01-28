namespace Accesser
{
    partial class MainFrame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.loginBtn = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.filesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.onCloseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBtn = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.thumbLinkBtn = new System.Windows.Forms.Button();
            this.copyFileBtn = new System.Windows.Forms.Button();
            this.thumbLinkBox = new System.Windows.Forms.TextBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderBtn = new System.Windows.Forms.Button();
            this.fileLinkBox = new System.Windows.Forms.TextBox();
            this.thumbLinkLabel = new System.Windows.Forms.Label();
            this.fileLinkBtn = new System.Windows.Forms.Button();
            this.fileLinkLabel = new System.Windows.Forms.Label();
            this.copyThumbBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.copyCheckBox = new System.Windows.Forms.CheckBox();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.copyEditedThBtn = new System.Windows.Forms.Button();
            this.copyEditedBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.barIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.barMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openBar = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBar = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBar = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.Gray;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginBtn.Location = new System.Drawing.Point(638, 12);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(96, 27);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Log in";
            this.loginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesMenu,
            this.accountMenu,
            this.extraMenu});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.topMenu.Size = new System.Drawing.Size(280, 24);
            this.topMenu.TabIndex = 5;
            this.topMenu.Text = "topMenu";
            // 
            // filesMenu
            // 
            this.filesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.changeFolderToolStripMenuItem,
            this.removeTempToolStripMenuItem});
            this.filesMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filesMenu.Name = "filesMenu";
            this.filesMenu.Size = new System.Drawing.Size(42, 20);
            this.filesMenu.Text = "Files";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // changeFolderToolStripMenuItem
            // 
            this.changeFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeFolderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeFolderToolStripMenuItem.Name = "changeFolderToolStripMenuItem";
            this.changeFolderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.changeFolderToolStripMenuItem.Text = "Change folder";
            this.changeFolderToolStripMenuItem.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // removeTempToolStripMenuItem
            // 
            this.removeTempToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeTempToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeTempToolStripMenuItem.Name = "removeTempToolStripMenuItem";
            this.removeTempToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeTempToolStripMenuItem.Text = "Remove Temp";
            this.removeTempToolStripMenuItem.Click += new System.EventHandler(this.removeTempToolStripMenuItem_Click);
            // 
            // accountMenu
            // 
            this.accountMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountMenu.ForeColor = System.Drawing.Color.White;
            this.accountMenu.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.accountMenu.Name = "accountMenu";
            this.accountMenu.Size = new System.Drawing.Size(64, 20);
            this.accountMenu.Text = "Account";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // extraMenu
            // 
            this.extraMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBtn,
            this.onCloseBtn});
            this.extraMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extraMenu.Name = "extraMenu";
            this.extraMenu.Size = new System.Drawing.Size(45, 20);
            this.extraMenu.Text = "Extra";
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(181, 22);
            this.aboutBtn.Text = "About";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // onCloseBtn
            // 
            this.onCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.onCloseBtn.CheckOnClick = true;
            this.onCloseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onCloseBtn.Name = "onCloseBtn";
            this.onCloseBtn.Size = new System.Drawing.Size(181, 22);
            this.onCloseBtn.Text = "Minimalize on Close";
            this.onCloseBtn.Click += new System.EventHandler(this.onCloseMenu_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadBtn.BackColor = System.Drawing.Color.Gray;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadBtn.Location = new System.Drawing.Point(328, 328);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(89, 29);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // fileList
            // 
            this.fileList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(12, 54);
            this.fileList.MultiSelect = false;
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(722, 221);
            this.fileList.TabIndex = 7;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.ItemActivate += new System.EventHandler(this.fileList_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameText.Location = new System.Drawing.Point(12, 354);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(260, 26);
            this.nameText.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(12, 332);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // thumbLinkBtn
            // 
            this.thumbLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbLinkBtn.BackColor = System.Drawing.Color.Gray;
            this.thumbLinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thumbLinkBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.thumbLinkBtn.Location = new System.Drawing.Point(594, 357);
            this.thumbLinkBtn.Name = "thumbLinkBtn";
            this.thumbLinkBtn.Size = new System.Drawing.Size(130, 25);
            this.thumbLinkBtn.TabIndex = 11;
            this.thumbLinkBtn.Text = "Copy Thumbnail Link";
            this.thumbLinkBtn.UseVisualStyleBackColor = false;
            this.thumbLinkBtn.Click += new System.EventHandler(this.thumbLinkBtn_Click);
            // 
            // copyFileBtn
            // 
            this.copyFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyFileBtn.BackColor = System.Drawing.Color.Gray;
            this.copyFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyFileBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyFileBtn.Location = new System.Drawing.Point(541, 459);
            this.copyFileBtn.Name = "copyFileBtn";
            this.copyFileBtn.Size = new System.Drawing.Size(103, 25);
            this.copyFileBtn.TabIndex = 12;
            this.copyFileBtn.Text = "Copy File";
            this.copyFileBtn.UseVisualStyleBackColor = false;
            this.copyFileBtn.Click += new System.EventHandler(this.copyFileBtn_Click);
            // 
            // thumbLinkBox
            // 
            this.thumbLinkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbLinkBox.Location = new System.Drawing.Point(313, 384);
            this.thumbLinkBox.Name = "thumbLinkBox";
            this.thumbLinkBox.ReadOnly = true;
            this.thumbLinkBox.Size = new System.Drawing.Size(411, 20);
            this.thumbLinkBox.TabIndex = 13;
            this.thumbLinkBox.WordWrap = false;
            // 
            // folderLabel
            // 
            this.folderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.folderLabel.AutoSize = true;
            this.folderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.folderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.folderLabel.Location = new System.Drawing.Point(18, 28);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(97, 19);
            this.folderLabel.TabIndex = 14;
            this.folderLabel.Text = "Folder name:";
            // 
            // folderBtn
            // 
            this.folderBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.folderBtn.BackColor = System.Drawing.Color.Gray;
            this.folderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.folderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.folderBtn.Location = new System.Drawing.Point(118, 28);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(103, 23);
            this.folderBtn.TabIndex = 15;
            this.folderBtn.Text = "Emotes";
            this.folderBtn.UseVisualStyleBackColor = false;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // fileLinkBox
            // 
            this.fileLinkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLinkBox.Location = new System.Drawing.Point(313, 432);
            this.fileLinkBox.Name = "fileLinkBox";
            this.fileLinkBox.ReadOnly = true;
            this.fileLinkBox.Size = new System.Drawing.Size(411, 20);
            this.fileLinkBox.TabIndex = 16;
            this.fileLinkBox.WordWrap = false;
            // 
            // thumbLinkLabel
            // 
            this.thumbLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbLinkLabel.AutoSize = true;
            this.thumbLinkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thumbLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.thumbLinkLabel.Location = new System.Drawing.Point(412, 361);
            this.thumbLinkLabel.Name = "thumbLinkLabel";
            this.thumbLinkLabel.Size = new System.Drawing.Size(114, 19);
            this.thumbLinkLabel.TabIndex = 10;
            this.thumbLinkLabel.Text = "Thumbnail Link";
            // 
            // fileLinkBtn
            // 
            this.fileLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLinkBtn.BackColor = System.Drawing.Color.Gray;
            this.fileLinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileLinkBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileLinkBtn.Location = new System.Drawing.Point(594, 405);
            this.fileLinkBtn.Name = "fileLinkBtn";
            this.fileLinkBtn.Size = new System.Drawing.Size(130, 25);
            this.fileLinkBtn.TabIndex = 11;
            this.fileLinkBtn.Text = "Copy File Link";
            this.fileLinkBtn.UseVisualStyleBackColor = false;
            this.fileLinkBtn.Click += new System.EventHandler(this.fileLinkBtn_Click);
            // 
            // fileLinkLabel
            // 
            this.fileLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLinkLabel.AutoSize = true;
            this.fileLinkLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileLinkLabel.Location = new System.Drawing.Point(438, 410);
            this.fileLinkLabel.Name = "fileLinkLabel";
            this.fileLinkLabel.Size = new System.Drawing.Size(69, 19);
            this.fileLinkLabel.TabIndex = 17;
            this.fileLinkLabel.Text = "File Link";
            // 
            // copyThumbBtn
            // 
            this.copyThumbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyThumbBtn.BackColor = System.Drawing.Color.Gray;
            this.copyThumbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyThumbBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyThumbBtn.Location = new System.Drawing.Point(382, 459);
            this.copyThumbBtn.Name = "copyThumbBtn";
            this.copyThumbBtn.Size = new System.Drawing.Size(103, 25);
            this.copyThumbBtn.TabIndex = 12;
            this.copyThumbBtn.Text = "Copy Thumbnail";
            this.copyThumbBtn.UseVisualStyleBackColor = false;
            this.copyThumbBtn.Click += new System.EventHandler(this.copyThumbBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.BackColor = System.Drawing.Color.Gray;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(12, 440);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(58, 40);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete File";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editBtn.BackColor = System.Drawing.Color.Gray;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(12, 393);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(104, 42);
            this.editBtn.TabIndex = 26;
            this.editBtn.Text = "Edit More";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // copyCheckBox
            // 
            this.copyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyCheckBox.AutoSize = true;
            this.copyCheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyCheckBox.Checked = true;
            this.copyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.copyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyCheckBox.Location = new System.Drawing.Point(227, 440);
            this.copyCheckBox.Name = "copyCheckBox";
            this.copyCheckBox.Size = new System.Drawing.Size(64, 37);
            this.copyCheckBox.TabIndex = 53;
            this.copyCheckBox.Text = "Backup";
            this.copyCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveChangesBtn.BackColor = System.Drawing.Color.Gray;
            this.saveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveChangesBtn.Location = new System.Drawing.Point(76, 440);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(145, 40);
            this.saveChangesBtn.TabIndex = 52;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // copyEditedThBtn
            // 
            this.copyEditedThBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyEditedThBtn.BackColor = System.Drawing.Color.Gray;
            this.copyEditedThBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyEditedThBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyEditedThBtn.Location = new System.Drawing.Point(122, 393);
            this.copyEditedThBtn.Name = "copyEditedThBtn";
            this.copyEditedThBtn.Size = new System.Drawing.Size(78, 42);
            this.copyEditedThBtn.TabIndex = 12;
            this.copyEditedThBtn.Text = "Edited Thumbnail";
            this.copyEditedThBtn.UseVisualStyleBackColor = false;
            this.copyEditedThBtn.Click += new System.EventHandler(this.copyEditedThBtn_Click);
            // 
            // copyEditedBtn
            // 
            this.copyEditedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyEditedBtn.BackColor = System.Drawing.Color.Gray;
            this.copyEditedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyEditedBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyEditedBtn.Location = new System.Drawing.Point(206, 393);
            this.copyEditedBtn.Name = "copyEditedBtn";
            this.copyEditedBtn.Size = new System.Drawing.Size(66, 42);
            this.copyEditedBtn.TabIndex = 12;
            this.copyEditedBtn.Text = "Edited File";
            this.copyEditedBtn.UseVisualStyleBackColor = false;
            this.copyEditedBtn.Click += new System.EventHandler(this.copyEditedBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.AllowDrop = true;
            this.uploadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadBtn.BackColor = System.Drawing.Color.Gray;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uploadBtn.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uploadBtn.Location = new System.Drawing.Point(12, 275);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(722, 47);
            this.uploadBtn.TabIndex = 54;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            this.uploadBtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.uploadDragDrop);
            this.uploadBtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.uploadDragEnter);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(245, 21);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(240, 26);
            this.searchBox.TabIndex = 55;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.BackColor = System.Drawing.Color.Gray;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchBtn.Location = new System.Drawing.Point(491, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(67, 27);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // barIcon
            // 
            this.barIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.barIcon.BalloonTipText = "I\'ll be here...";
            this.barIcon.BalloonTipTitle = "Hey!";
            this.barIcon.ContextMenuStrip = this.barMenu;
            this.barIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("barIcon.Icon")));
            this.barIcon.Text = "Picture Accessor";
            this.barIcon.Visible = true;
            this.barIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.barIcon_MouseClick);
            // 
            // barMenu
            // 
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBar,
            this.clearBar,
            this.exitBar});
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(133, 70);
            // 
            // openBar
            // 
            this.openBar.Name = "openBar";
            this.openBar.Size = new System.Drawing.Size(132, 22);
            this.openBar.Text = "Open";
            this.openBar.Click += new System.EventHandler(this.barIcon_DoubleClick);
            // 
            // clearBar
            // 
            this.clearBar.Name = "clearBar";
            this.clearBar.Size = new System.Drawing.Size(132, 22);
            this.clearBar.Text = "Clear temp";
            this.clearBar.Click += new System.EventHandler(this.removeTempToolStripMenuItem_Click);
            // 
            // exitBar
            // 
            this.exitBar.Name = "exitBar";
            this.exitBar.Size = new System.Drawing.Size(132, 22);
            this.exitBar.Text = "Exit";
            this.exitBar.Click += new System.EventHandler(this.exitBar_Click);
            // 
            // MainFrame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(746, 492);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.copyCheckBox);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.fileLinkBtn);
            this.Controls.Add(this.fileLinkLabel);
            this.Controls.Add(this.fileLinkBox);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.thumbLinkBox);
            this.Controls.Add(this.copyEditedThBtn);
            this.Controls.Add(this.copyThumbBtn);
            this.Controls.Add(this.copyEditedBtn);
            this.Controls.Add(this.copyFileBtn);
            this.Controls.Add(this.thumbLinkBtn);
            this.Controls.Add(this.thumbLinkLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.topMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(762, 416);
            this.Name = "MainFrame";
            this.Text = "Picture Accessor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.uploadDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.uploadDragEnter);
            this.Resize += new System.EventHandler(this.MainFrame_Resize);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.barMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem filesMenu;
        private System.Windows.Forms.ToolStripMenuItem accountMenu;
        public System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button thumbLinkBtn;
        private System.Windows.Forms.Button copyFileBtn;
        private System.Windows.Forms.TextBox thumbLinkBox;
        public System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ToolStripMenuItem changeFolderToolStripMenuItem;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.TextBox fileLinkBox;
        private System.Windows.Forms.Label thumbLinkLabel;
        private System.Windows.Forms.Button fileLinkBtn;
        private System.Windows.Forms.Label fileLinkLabel;
        private System.Windows.Forms.Button copyThumbBtn;
        private System.Windows.Forms.ToolStripMenuItem removeTempToolStripMenuItem;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.CheckBox copyCheckBox;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button copyEditedThBtn;
        private System.Windows.Forms.Button copyEditedBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.NotifyIcon barIcon;
        private System.Windows.Forms.ContextMenuStrip barMenu;
        private System.Windows.Forms.ToolStripMenuItem openBar;
        private System.Windows.Forms.ToolStripMenuItem clearBar;
        private System.Windows.Forms.ToolStripMenuItem exitBar;
        private System.Windows.Forms.ToolStripMenuItem extraMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutBtn;
        private System.Windows.Forms.ToolStripMenuItem onCloseBtn;
    }
}

