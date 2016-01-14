namespace PhotoAndVideoOrganiser
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
            this.btnChooseSourceFolder = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrganisedFolder = new System.Windows.Forms.TextBox();
            this.btnChooseOrganisedFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkOrganiseFiles = new System.Windows.Forms.CheckBox();
            this.chkRenameFiles = new System.Windows.Forms.CheckBox();
            this.chkOrganiseSubDirectories = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhotoExtensions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVideoExtensions = new System.Windows.Forms.TextBox();
            this.chkIncludePhotos = new System.Windows.Forms.CheckBox();
            this.chkIncludeVideo = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuplicatesDirectory = new System.Windows.Forms.TextBox();
            this.btnChooseDuplicatesFolder = new System.Windows.Forms.Button();
            this.chkIncorrectFilesOnly = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseSourceFolder
            // 
            this.btnChooseSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseSourceFolder.Location = new System.Drawing.Point(936, 9);
            this.btnChooseSourceFolder.Name = "btnChooseSourceFolder";
            this.btnChooseSourceFolder.Size = new System.Drawing.Size(162, 20);
            this.btnChooseSourceFolder.TabIndex = 3;
            this.btnChooseSourceFolder.Text = "choose...";
            this.btnChooseSourceFolder.UseVisualStyleBackColor = true;
            this.btnChooseSourceFolder.Click += new System.EventHandler(this.btnChooseSourceFolder_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(123, 9);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(761, 20);
            this.txtSourceFolder.TabIndex = 4;
            this.txtSourceFolder.TextChanged += new System.EventHandler(this.txtSourceFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source Folder : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Organised Folder : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrganisedFolder
            // 
            this.txtOrganisedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrganisedFolder.Location = new System.Drawing.Point(123, 61);
            this.txtOrganisedFolder.Name = "txtOrganisedFolder";
            this.txtOrganisedFolder.Size = new System.Drawing.Size(807, 20);
            this.txtOrganisedFolder.TabIndex = 7;
            // 
            // btnChooseOrganisedFolder
            // 
            this.btnChooseOrganisedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseOrganisedFolder.Location = new System.Drawing.Point(936, 61);
            this.btnChooseOrganisedFolder.Name = "btnChooseOrganisedFolder";
            this.btnChooseOrganisedFolder.Size = new System.Drawing.Size(162, 20);
            this.btnChooseOrganisedFolder.TabIndex = 6;
            this.btnChooseOrganisedFolder.Text = "choose...";
            this.btnChooseOrganisedFolder.UseVisualStyleBackColor = true;
            this.btnChooseOrganisedFolder.Click += new System.EventHandler(this.btnChooseOrganisedFolder_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkIncorrectFilesOnly);
            this.panel1.Controls.Add(this.chkOrganiseFiles);
            this.panel1.Controls.Add(this.chkRenameFiles);
            this.panel1.Controls.Add(this.chkOrganiseSubDirectories);
            this.panel1.Location = new System.Drawing.Point(789, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 55);
            this.panel1.TabIndex = 9;
            // 
            // chkOrganiseFiles
            // 
            this.chkOrganiseFiles.AutoSize = true;
            this.chkOrganiseFiles.Enabled = false;
            this.chkOrganiseFiles.Location = new System.Drawing.Point(192, 26);
            this.chkOrganiseFiles.Name = "chkOrganiseFiles";
            this.chkOrganiseFiles.Size = new System.Drawing.Size(89, 17);
            this.chkOrganiseFiles.TabIndex = 3;
            this.chkOrganiseFiles.Text = "Organise files";
            this.chkOrganiseFiles.UseVisualStyleBackColor = true;
            this.chkOrganiseFiles.CheckedChanged += new System.EventHandler(this.chkOrganiseFiles_CheckedChanged);
            // 
            // chkRenameFiles
            // 
            this.chkRenameFiles.AutoSize = true;
            this.chkRenameFiles.Location = new System.Drawing.Point(192, 3);
            this.chkRenameFiles.Name = "chkRenameFiles";
            this.chkRenameFiles.Size = new System.Drawing.Size(87, 17);
            this.chkRenameFiles.TabIndex = 2;
            this.chkRenameFiles.Text = "Rename files";
            this.chkRenameFiles.UseVisualStyleBackColor = true;
            this.chkRenameFiles.CheckedChanged += new System.EventHandler(this.chkRenameFiles_CheckedChanged);
            // 
            // chkOrganiseSubDirectories
            // 
            this.chkOrganiseSubDirectories.AutoSize = true;
            this.chkOrganiseSubDirectories.Location = new System.Drawing.Point(3, 3);
            this.chkOrganiseSubDirectories.Name = "chkOrganiseSubDirectories";
            this.chkOrganiseSubDirectories.Size = new System.Drawing.Size(139, 17);
            this.chkOrganiseSubDirectories.TabIndex = 0;
            this.chkOrganiseSubDirectories.Text = "Organise sub directories";
            this.chkOrganiseSubDirectories.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(678, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Options : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1083, 471);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Photo Extensions :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhotoExtensions
            // 
            this.txtPhotoExtensions.Location = new System.Drawing.Point(123, 93);
            this.txtPhotoExtensions.Name = "txtPhotoExtensions";
            this.txtPhotoExtensions.Size = new System.Drawing.Size(229, 20);
            this.txtPhotoExtensions.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Video Extensions :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVideoExtensions
            // 
            this.txtVideoExtensions.Location = new System.Drawing.Point(123, 114);
            this.txtVideoExtensions.Name = "txtVideoExtensions";
            this.txtVideoExtensions.Size = new System.Drawing.Size(229, 20);
            this.txtVideoExtensions.TabIndex = 17;
            // 
            // chkIncludePhotos
            // 
            this.chkIncludePhotos.AutoSize = true;
            this.chkIncludePhotos.Location = new System.Drawing.Point(358, 96);
            this.chkIncludePhotos.Name = "chkIncludePhotos";
            this.chkIncludePhotos.Size = new System.Drawing.Size(15, 14);
            this.chkIncludePhotos.TabIndex = 2;
            this.chkIncludePhotos.UseVisualStyleBackColor = true;
            this.chkIncludePhotos.CheckedChanged += new System.EventHandler(this.chkIncludePhotos_CheckedChanged);
            // 
            // chkIncludeVideo
            // 
            this.chkIncludeVideo.AutoSize = true;
            this.chkIncludeVideo.Location = new System.Drawing.Point(358, 116);
            this.chkIncludeVideo.Name = "chkIncludeVideo";
            this.chkIncludeVideo.Size = new System.Drawing.Size(15, 14);
            this.chkIncludeVideo.TabIndex = 19;
            this.chkIncludeVideo.UseVisualStyleBackColor = true;
            this.chkIncludeVideo.CheckedChanged += new System.EventHandler(this.chkIncludeVideo_CheckedChanged);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(1013, 167);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(85, 41);
            this.btnGo.TabIndex = 20;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(890, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Duplicates Folder : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDuplicatesDirectory
            // 
            this.txtDuplicatesDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuplicatesDirectory.Location = new System.Drawing.Point(123, 35);
            this.txtDuplicatesDirectory.Name = "txtDuplicatesDirectory";
            this.txtDuplicatesDirectory.Size = new System.Drawing.Size(807, 20);
            this.txtDuplicatesDirectory.TabIndex = 23;
            // 
            // btnChooseDuplicatesFolder
            // 
            this.btnChooseDuplicatesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseDuplicatesFolder.Location = new System.Drawing.Point(936, 35);
            this.btnChooseDuplicatesFolder.Name = "btnChooseDuplicatesFolder";
            this.btnChooseDuplicatesFolder.Size = new System.Drawing.Size(162, 20);
            this.btnChooseDuplicatesFolder.TabIndex = 22;
            this.btnChooseDuplicatesFolder.Text = "choose...";
            this.btnChooseDuplicatesFolder.UseVisualStyleBackColor = true;
            this.btnChooseDuplicatesFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkIncorrectFilesOnly
            // 
            this.chkIncorrectFilesOnly.AutoSize = true;
            this.chkIncorrectFilesOnly.Location = new System.Drawing.Point(3, 26);
            this.chkIncorrectFilesOnly.Name = "chkIncorrectFilesOnly";
            this.chkIncorrectFilesOnly.Size = new System.Drawing.Size(111, 17);
            this.chkIncorrectFilesOnly.TabIndex = 4;
            this.chkIncorrectFilesOnly.Text = "Incorrect files only";
            this.chkIncorrectFilesOnly.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 697);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDuplicatesDirectory);
            this.Controls.Add(this.btnChooseDuplicatesFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.chkIncludeVideo);
            this.Controls.Add(this.chkIncludePhotos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVideoExtensions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhotoExtensions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrganisedFolder);
            this.Controls.Add(this.btnChooseOrganisedFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.btnChooseSourceFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChooseSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrganisedFolder;
        private System.Windows.Forms.Button btnChooseOrganisedFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkOrganiseSubDirectories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhotoExtensions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVideoExtensions;
        private System.Windows.Forms.CheckBox chkIncludePhotos;
        private System.Windows.Forms.CheckBox chkIncludeVideo;
        private System.Windows.Forms.CheckBox chkOrganiseFiles;
        private System.Windows.Forms.CheckBox chkRenameFiles;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuplicatesDirectory;
        private System.Windows.Forms.Button btnChooseDuplicatesFolder;
        private System.Windows.Forms.CheckBox chkIncorrectFilesOnly;
    }
}

