using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            var organiser = new Organiser(txtOrganisedFolder.Text);
            var results = new List<PhotoAnalysis>();
            foreach (var photoExtension in GetPhotoExtensions())
            {
                results.AddRange(organiser.OrganiseDirectory(txtSourceFolder.Text, chkOrganiseSubDirectories.Checked, true, photoExtension.Trim()));
            }

            dataGridView1.DataSource = results;


        }

        private void btnOrganise_Click(object sender, EventArgs e)
        {
            var organiser = new Organiser(txtOrganisedFolder.Text);

            var results = new List<PhotoAnalysis>();
            foreach (var photoExtension in GetPhotoExtensions())
            {
                results.AddRange(organiser.OrganiseDirectory(txtSourceFolder.Text, chkOrganiseSubDirectories.Checked, false, photoExtension.Trim()));
            }
            dataGridView1.DataSource = results;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSourceFolder.Text = @"C:\photos\problems";
            txtOrganisedFolder.Text = @"C:\photos\testOutput";
            txtPhotoExtensions.Text = "*.jpg,*.jpeg";


            folderBrowserDialog1.SelectedPath = @"C:\photos\test";
        }

        private List<string> GetPhotoExtensions()
        {
            var extensions = txtPhotoExtensions.Text.Split(Convert.ToChar(",")).ToList();

            return extensions;
        }
    }
}
