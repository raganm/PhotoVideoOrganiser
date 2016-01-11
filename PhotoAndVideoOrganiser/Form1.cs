using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PhotoOrganiser;

namespace PhotoAndVideoOrganiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.Text = @"c:\photos\input";
        }

        public string Wibble { get; set; }

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

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            ClearResults();
            btnAnalyse.Enabled = false;

            if (chkIncludePhotos.Checked)
            {
                OrganisePhotos(txtSourceFolder.Text, chkOrganiseSubDirectories.Checked, true);
            }

            if (chkIncludeVideo.Checked)
            {
                OrganiseVideos(txtSourceFolder.Text, chkOrganiseSubDirectories.Checked, true);
            }

            btnAnalyse.Enabled = true;

        }

        private void btnOrganise_Click(object sender, EventArgs e)
        {
            ClearResults();
            btnOrganise.Enabled = false;

            if (chkIncludePhotos.Checked)
            {
                OrganisePhotos(txtSourceFolder.Text, chkOrganiseSubDirectories.Checked, false);
            }

            if (chkIncludeVideo.Checked)
            {
                OrganiseVideos(txtSourceFolder.Text,chkOrganiseSubDirectories.Checked, false);
            }

            btnOrganise.Enabled = true;
        }

        private void OrganisePhotos(string sourceFolder, bool organiseSubDirectories, bool analyseOnly)
        {
            var organiser = new PhotoOrganiser.Organiser(txtOrganisedFolder.Text);

            var results = new List<Models.File>();

            foreach (var photoExtension in GetPhotoExtensions())
            {
                results.AddRange(organiser.OrganiseDirectory(sourceFolder, organiseSubDirectories, analyseOnly, photoExtension.Trim()));
            }

            dataGridView1.DataSource = results;
        }

        private void OrganiseVideos(string sourceFolder, bool organiseSubDirectories, bool analyseOnly)
        {
            var organiser = new VideoOrganiser.Organiser(txtOrganisedFolder.Text);

            var results = new List<Models.File>();

            foreach (var extension in GetVideoExtensions())
            {
                results.AddRange(organiser.OrganiseDirectory(sourceFolder, organiseSubDirectories, analyseOnly, extension.Trim()));
            }

            dataGridView1.DataSource = results;
        }

        private void ClearResults()
        {
            dataGridView1.DataSource = new List<Models.File>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkIncludePhotos.Checked = true;
            chkIncludeVideo.Checked = false;
            txtVideoExtensions.Enabled = false;
            txtSourceFolder.Text = @"C:\photos\problems";
            txtOrganisedFolder.Text = txtSourceFolder.Text + @"\output";
            txtPhotoExtensions.Text = "*.jpg,*.jpeg";
            txtVideoExtensions.Text = "*.mp4, *.avi, *.mpg";

            folderBrowserDialog1.SelectedPath = @"C:\photos\test";
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
    }
}
