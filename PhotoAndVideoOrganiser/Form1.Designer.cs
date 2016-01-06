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
            this.btnOrganise = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseSourceFolder = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrganisedFolder = new System.Windows.Forms.TextBox();
            this.btnChooseOrganisedFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkOrganiseSubDirectories = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhotoExtensions = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrganise
            // 
            this.btnOrganise.Location = new System.Drawing.Point(697, 192);
            this.btnOrganise.Name = "btnOrganise";
            this.btnOrganise.Size = new System.Drawing.Size(75, 23);
            this.btnOrganise.TabIndex = 1;
            this.btnOrganise.Text = "Organise";
            this.btnOrganise.UseVisualStyleBackColor = true;
            this.btnOrganise.Click += new System.EventHandler(this.btnOrganise_Click);
            // 
            // btnChooseSourceFolder
            // 
            this.btnChooseSourceFolder.Location = new System.Drawing.Point(610, 9);
            this.btnChooseSourceFolder.Name = "btnChooseSourceFolder";
            this.btnChooseSourceFolder.Size = new System.Drawing.Size(162, 20);
            this.btnChooseSourceFolder.TabIndex = 3;
            this.btnChooseSourceFolder.Text = "choose...";
            this.btnChooseSourceFolder.UseVisualStyleBackColor = true;
            this.btnChooseSourceFolder.Click += new System.EventHandler(this.btnChooseSourceFolder_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(123, 9);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(481, 20);
            this.txtSourceFolder.TabIndex = 4;
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
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Organised Folder : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrganisedFolder
            // 
            this.txtOrganisedFolder.Location = new System.Drawing.Point(123, 41);
            this.txtOrganisedFolder.Name = "txtOrganisedFolder";
            this.txtOrganisedFolder.Size = new System.Drawing.Size(481, 20);
            this.txtOrganisedFolder.TabIndex = 7;
            // 
            // btnChooseOrganisedFolder
            // 
            this.btnChooseOrganisedFolder.Location = new System.Drawing.Point(610, 41);
            this.btnChooseOrganisedFolder.Name = "btnChooseOrganisedFolder";
            this.btnChooseOrganisedFolder.Size = new System.Drawing.Size(162, 20);
            this.btnChooseOrganisedFolder.TabIndex = 6;
            this.btnChooseOrganisedFolder.Text = "choose...";
            this.btnChooseOrganisedFolder.UseVisualStyleBackColor = true;
            this.btnChooseOrganisedFolder.Click += new System.EventHandler(this.btnChooseOrganisedFolder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkOrganiseSubDirectories);
            this.panel1.Location = new System.Drawing.Point(123, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 36);
            this.panel1.TabIndex = 9;
            // 
            // chkOrganiseSubDirectories
            // 
            this.chkOrganiseSubDirectories.AutoSize = true;
            this.chkOrganiseSubDirectories.Location = new System.Drawing.Point(3, 3);
            this.chkOrganiseSubDirectories.Name = "chkOrganiseSubDirectories";
            this.chkOrganiseSubDirectories.Size = new System.Drawing.Size(140, 17);
            this.chkOrganiseSubDirectories.TabIndex = 0;
            this.chkOrganiseSubDirectories.Text = "Organise SubDirectories";
            this.chkOrganiseSubDirectories.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Options : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(616, 192);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 11;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 328);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Photo Extensions :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhotoExtensions
            // 
            this.txtPhotoExtensions.Location = new System.Drawing.Point(123, 75);
            this.txtPhotoExtensions.Name = "txtPhotoExtensions";
            this.txtPhotoExtensions.Size = new System.Drawing.Size(481, 20);
            this.txtPhotoExtensions.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhotoExtensions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrganisedFolder);
            this.Controls.Add(this.btnChooseOrganisedFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.btnChooseSourceFolder);
            this.Controls.Add(this.btnOrganise);
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
        private System.Windows.Forms.Button btnOrganise;
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
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhotoExtensions;
    }
}

