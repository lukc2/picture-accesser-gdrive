
namespace Accesser
{
    partial class EditFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFrame));
            this.settingsLabel = new System.Windows.Forms.Label();
            this.settingsCombo = new System.Windows.Forms.ComboBox();
            this.saveSetBtn = new System.Windows.Forms.Button();
            this.fileHeightBox = new System.Windows.Forms.NumericUpDown();
            this.fileWidthBox = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.delSettingBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsLabel.Location = new System.Drawing.Point(12, 269);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(96, 19);
            this.settingsLabel.TabIndex = 56;
            this.settingsLabel.Text = "Fast Settings";
            // 
            // settingsCombo
            // 
            this.settingsCombo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsCombo.FormattingEnabled = true;
            this.settingsCombo.Location = new System.Drawing.Point(12, 299);
            this.settingsCombo.Name = "settingsCombo";
            this.settingsCombo.Size = new System.Drawing.Size(199, 28);
            this.settingsCombo.TabIndex = 55;
            this.settingsCombo.SelectedIndexChanged += new System.EventHandler(this.loadSetBtn_Click);
            // 
            // saveSetBtn
            // 
            this.saveSetBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveSetBtn.BackColor = System.Drawing.Color.Silver;
            this.saveSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveSetBtn.Location = new System.Drawing.Point(139, 334);
            this.saveSetBtn.Name = "saveSetBtn";
            this.saveSetBtn.Size = new System.Drawing.Size(72, 23);
            this.saveSetBtn.TabIndex = 54;
            this.saveSetBtn.Text = "Save";
            this.saveSetBtn.UseVisualStyleBackColor = false;
            this.saveSetBtn.Click += new System.EventHandler(this.saveSetBtn_Click);
            // 
            // fileHeightBox
            // 
            this.fileHeightBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileHeightBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileHeightBox.Location = new System.Drawing.Point(295, 286);
            this.fileHeightBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fileHeightBox.Name = "fileHeightBox";
            this.fileHeightBox.Size = new System.Drawing.Size(44, 26);
            this.fileHeightBox.TabIndex = 52;
            this.fileHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileWidthBox
            // 
            this.fileWidthBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileWidthBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileWidthBox.Location = new System.Drawing.Point(222, 286);
            this.fileWidthBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fileWidthBox.Name = "fileWidthBox";
            this.fileWidthBox.Size = new System.Drawing.Size(44, 26);
            this.fileWidthBox.TabIndex = 53;
            this.fileWidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xLabel
            // 
            this.xLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xLabel.Location = new System.Drawing.Point(269, 288);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 19);
            this.xLabel.TabIndex = 49;
            this.xLabel.Text = "X";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sizeLabel.Location = new System.Drawing.Point(204, 264);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(155, 19);
            this.sizeLabel.TabIndex = 50;
            this.sizeLabel.Text = "Size  (W x H, 0 - auto)";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(28, 12);
            this.pictureBox.MaximumSize = new System.Drawing.Size(309, 241);
            this.pictureBox.MinimumSize = new System.Drawing.Size(309, 241);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(309, 241);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 58;
            this.pictureBox.TabStop = false;
            // 
            // delSettingBtn
            // 
            this.delSettingBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delSettingBtn.BackColor = System.Drawing.Color.Silver;
            this.delSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delSettingBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delSettingBtn.Location = new System.Drawing.Point(12, 334);
            this.delSettingBtn.Name = "delSettingBtn";
            this.delSettingBtn.Size = new System.Drawing.Size(70, 23);
            this.delSettingBtn.TabIndex = 59;
            this.delSettingBtn.Text = "Delete";
            this.delSettingBtn.UseVisualStyleBackColor = false;
            this.delSettingBtn.Click += new System.EventHandler(this.delSettingBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Silver;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.okBtn.Location = new System.Drawing.Point(226, 318);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(111, 39);
            this.okBtn.TabIndex = 60;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // EditFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.delSettingBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.settingsCombo);
            this.Controls.Add(this.saveSetBtn);
            this.Controls.Add(this.fileHeightBox);
            this.Controls.Add(this.fileWidthBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.sizeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(382, 405);
            this.MinimumSize = new System.Drawing.Size(382, 405);
            this.Name = "EditFrame";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditFrame_FormClosing);
            this.Shown += new System.EventHandler(this.EditFrame_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.fileHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button saveSetBtn;
        public System.Windows.Forms.NumericUpDown fileHeightBox;
        public System.Windows.Forms.NumericUpDown fileWidthBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label sizeLabel;
        public System.Windows.Forms.ComboBox settingsCombo;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button delSettingBtn;
        private System.Windows.Forms.Button okBtn;
    }
}