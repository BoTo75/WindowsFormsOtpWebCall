
namespace WindowsFormsOtpWebCall
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.getAllFileButton = new System.Windows.Forms.Button();
            this.FilelistBox = new System.Windows.Forms.ListBox();
            this.DestinationFolderTextBox = new System.Windows.Forms.TextBox();
            this.FolderButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.downladTheFlileTextBox = new System.Windows.Forms.TextBox();
            this.DonloadedFilesLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.selectBt = new System.Windows.Forms.Button();
            this.UploadListBox = new System.Windows.Forms.ListBox();
            this.uploadBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getAllFileButton
            // 
            this.getAllFileButton.Location = new System.Drawing.Point(22, 61);
            this.getAllFileButton.Name = "getAllFileButton";
            this.getAllFileButton.Size = new System.Drawing.Size(180, 20);
            this.getAllFileButton.TabIndex = 0;
            this.getAllFileButton.Text = "Az össze file letöltése";
            this.getAllFileButton.UseVisualStyleBackColor = true;
            this.getAllFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilelistBox
            // 
            this.FilelistBox.FormattingEnabled = true;
            this.FilelistBox.Location = new System.Drawing.Point(22, 159);
            this.FilelistBox.Name = "FilelistBox";
            this.FilelistBox.Size = new System.Drawing.Size(380, 173);
            this.FilelistBox.TabIndex = 1;
            // 
            // DestinationFolderTextBox
            // 
            this.DestinationFolderTextBox.Location = new System.Drawing.Point(22, 35);
            this.DestinationFolderTextBox.Name = "DestinationFolderTextBox";
            this.DestinationFolderTextBox.Size = new System.Drawing.Size(380, 20);
            this.DestinationFolderTextBox.TabIndex = 3;
            // 
            // FolderButton
            // 
            this.FolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FolderButton.Location = new System.Drawing.Point(129, 9);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(180, 20);
            this.FolderButton.TabIndex = 4;
            this.FolderButton.Text = "A letőltésikönyvtár kiválasztása";
            this.FolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "A konkrét fájl letöltése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // downladTheFlileTextBox
            // 
            this.downladTheFlileTextBox.Location = new System.Drawing.Point(239, 107);
            this.downladTheFlileTextBox.Name = "downladTheFlileTextBox";
            this.downladTheFlileTextBox.Size = new System.Drawing.Size(163, 20);
            this.downladTheFlileTextBox.TabIndex = 6;
            // 
            // DonloadedFilesLbl
            // 
            this.DonloadedFilesLbl.AutoSize = true;
            this.DonloadedFilesLbl.Location = new System.Drawing.Point(19, 143);
            this.DonloadedFilesLbl.Name = "DonloadedFilesLbl";
            this.DonloadedFilesLbl.Size = new System.Drawing.Size(108, 13);
            this.DonloadedFilesLbl.TabIndex = 7;
            this.DonloadedFilesLbl.Text = "A letöltött fájlok listája";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Location = new System.Drawing.Point(236, 91);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(141, 13);
            this.InfoLbl.TabIndex = 8;
            this.InfoLbl.Text = "írja be a letőltendő fájl nevét";
            // 
            // selectBt
            // 
            this.selectBt.Location = new System.Drawing.Point(503, 133);
            this.selectBt.Name = "selectBt";
            this.selectBt.Size = new System.Drawing.Size(213, 20);
            this.selectBt.TabIndex = 9;
            this.selectBt.Text = "Feltöltési fájl meadása";
            this.selectBt.UseVisualStyleBackColor = true;
            this.selectBt.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // UploadListBox
            // 
            this.UploadListBox.FormattingEnabled = true;
            this.UploadListBox.Location = new System.Drawing.Point(408, 159);
            this.UploadListBox.Name = "UploadListBox";
            this.UploadListBox.Size = new System.Drawing.Size(380, 173);
            this.UploadListBox.TabIndex = 10;
            // 
            // uploadBt
            // 
            this.uploadBt.Location = new System.Drawing.Point(503, 338);
            this.uploadBt.Name = "uploadBt";
            this.uploadBt.Size = new System.Drawing.Size(213, 23);
            this.uploadBt.TabIndex = 11;
            this.uploadBt.Text = "Feltöltés";
            this.uploadBt.UseVisualStyleBackColor = true;
            this.uploadBt.Click += new System.EventHandler(this.uploadBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uploadBt);
            this.Controls.Add(this.UploadListBox);
            this.Controls.Add(this.selectBt);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.DonloadedFilesLbl);
            this.Controls.Add(this.downladTheFlileTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.DestinationFolderTextBox);
            this.Controls.Add(this.FilelistBox);
            this.Controls.Add(this.getAllFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button getAllFileButton;
        private System.Windows.Forms.ListBox FilelistBox;
        private System.Windows.Forms.TextBox DestinationFolderTextBox;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox downladTheFlileTextBox;
        private System.Windows.Forms.Label DonloadedFilesLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Button selectBt;
        private System.Windows.Forms.ListBox UploadListBox;
        private System.Windows.Forms.Button uploadBt;
    }
}

