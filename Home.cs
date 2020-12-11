using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            string fileName = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic\\username.txt";
            if (File.Exists(fileName))
            {
                usernameField.Text = File.ReadAllText(fileName);
                letsStart.Enabled = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic\\username.txt";
            string directory = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic";
            

            if (Directory.Exists(directory))
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
            }
            else
            {
                Directory.CreateDirectory(directory);
            }
            FileStream fs = File.Create(fileName);
            Byte[] txt = new UTF8Encoding(true).GetBytes(usernameField.Text);
            fs.Write(txt, 0, txt.Length);
            fs.Close();
            letsStart.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://instagram.com/download/request");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            ChooseJSON ChooseJSON = new ChooseJSON();
            ChooseJSON.Show();
            ChooseJSON.Location = this.Location;
            this.Hide();
            */

            Form1 form1 = new Form1();
            form1.Show();
            form1.Location = this.Location;
            this.Hide();
        }

        private void abstractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutThisSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aboutThisSoftwareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
            About.Location = this.Location;
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
