using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Models;

namespace PhotoAndVideoOrganiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkOrganiseSubDirectories.Checked = false;
            chkIncludePhotos.Checked = true;
            chkIncludeVideo.Checked = false;
            txtVideoExtensions.Enabled = false;
            txtSourceFolder.Text = @"C:\dev\PhotoVideoOrganiser\PhotoAndVideoOrganiser\bin\Debug\TestFiles";
            txtOrganisedFolder.Text = txtSourceFolder.Text + @"\output";
            txtPhotoExtensions.Text = @"*.jpg,*.jpeg,*.png";
            txtVideoExtensions.Text = @"*.mp4, *.avi, *.mpg,*.mts";

            folderBrowserDialog1.SelectedPath = @"C:\photos\test";

            chkOrganiseFiles.Enabled = false;
            txtOrganisedFolder.Enabled = false;
        }

        private void ClearResults()
        {
            dataGridView1.DataSource = new List<Models.File>();
        }

        private List<string> GetPhotoExtensions()
        {
            var extensions = txtPhotoExtensions.Text.Split(Convert.ToChar(",")).ToList();

            return extensions;
        }

        private List<string> GetVideoExtensions()
        {
            var extensions = txtVideoExtensions.Text.Split(Convert.ToChar(",")).ToList();

            return extensions;
        }
        
        private void btnChooseSourceFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtSourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnChooseOrganisedFolder_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtOrganisedFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            txtOrganisedFolder.Text = txtSourceFolder.Text + @"\output";
        }

        private void chkIncludePhotos_CheckedChanged(object sender, EventArgs e)
        {
            txtPhotoExtensions.Enabled = chkIncludePhotos.Checked;
        }

        private void chkIncludeVideo_CheckedChanged(object sender, EventArgs e)
        {
            txtVideoExtensions.Enabled = chkIncludeVideo.Checked;
        }

        private void chkRenameFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRenameFiles.Checked)
            {
                chkOrganiseFiles.Enabled = true;
            }
            else
            {
                chkOrganiseFiles.Checked = false;
                chkOrganiseFiles.Enabled = false;
            }
        }

        private void chkOrganiseFiles_CheckedChanged(object sender, EventArgs e)
        {
            txtOrganisedFolder.Enabled = chkOrganiseFiles.Checked;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            ClearResults();
            btnGo.Enabled = false;

            var organiser = new Organiser(txtOrganisedFolder.Text);

            var options = new Options()
            {
                organiseSubDirectories = chkOrganiseSubDirectories.Checked,
                renameFiles = chkRenameFiles.Checked,
                organiseFiles = chkOrganiseFiles.Checked
            };
            var results = new List<FileAnalysis>();

            if (chkIncludePhotos.Checked)
            {
                foreach (var photoExtension in GetPhotoExtensions())
                {
                    results.AddRange(organiser.OrganiseDirectory(txtSourceFolder.Text, options, photoExtension.Trim(), new PhotoHelper()));
                }
            }

            if (chkIncludeVideo.Checked)
            {
                foreach (var extension in GetVideoExtensions())
                {
                    results.AddRange(organiser.OrganiseDirectory(txtSourceFolder.Text, options, extension.Trim(), new VideoHelper()));
                }
            }

            btnGo.Enabled = true;
            dataGridView1.DataSource = results;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(txtSourceFolder.Text);
        }
    }
}
