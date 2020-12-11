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
using System.Web;
using System.Web.Script.Serialization;

namespace WindowsFormsApp2
{
    

    public partial class Form1 : Form
    {

        public string username = "";
        public string messages_json_saved = "";
        int SentMessages_count = 0;
        int ReceivedMessages_count = 0;
        int SentPosts_count = 0;
        int ReceivedPosts_count = 0;
        int Videocalls_count = 0;
        int DMcontacts_count = 0;
        int Sentlikes_count = 0;
        int Receivedlikes_count = 0;

        // Specified user //
        int uSentMessages_count = 0;
        int uReceivedMessages_count = 0;
        int uSentPosts_count = 0;
        int uReceivedPosts_count = 0;
        int uVideocalls_count = 0;
        int uSentlikes_count = 0;
        int uReceivedlikes_count = 0;
        // ************* //

        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void choosefile_Click(object sender, EventArgs e)
        {
            username = "";
            messages_json_saved = "";
            SentMessages_count = 0;
            ReceivedMessages_count = 0;
            SentPosts_count = 0;
            ReceivedPosts_count = 0;
            Videocalls_count = 0;
            DMcontacts_count = 0;
            Sentlikes_count = 0;
            Receivedlikes_count = 0;

  
            uSentMessages_count = 0;
            uReceivedMessages_count = 0;
            uSentPosts_count = 0;
            uReceivedPosts_count = 0;
            uVideocalls_count = 0;
            uSentlikes_count = 0;
            uReceivedlikes_count = 0;
    

            progressBar1.Value = 0;
            string directory = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JSON files (*.json)|*.json;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            string fileName = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic\\username.txt";

            if (File.Exists(fileName))
            {
                username = File.ReadAllText(fileName);
            }
            done.Text = "Loading...";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                specificDMfield.ReadOnly = false;
                specificDMbutton.Enabled = true;
                DMcontactsTextbox.Visible = true;
                mediaownersTextbox.Visible = true;

                string FileText = File.ReadAllText(openFileDialog1.FileName);
                messages_json_saved = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic\\messages_json_saved.txt";
                if (File.Exists(messages_json_saved))
                {
                    File.Delete(messages_json_saved);
                }
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                FileStream fs = File.Create(messages_json_saved);
                Byte[] txt = new UTF8Encoding(true).GetBytes(FileText);
                fs.Write(txt, 0, txt.Length);
                fs.Close();

                dynamic json = JsonConvert.DeserializeObject(FileText);
                string[] allTheParticipants = new String[json.Count];

                for (int i=0; i< json.Count; i++)
                {
                    for(int j=0; j<json[i].conversation.Count; j++)
                    {
                        if (json[i].conversation[j].sender == username)
                        {
                            SentMessages_count = SentMessages_count + 1;
                            if(json[i].conversation[j].media_owner != null)
                            {
                                SentPosts_count = SentPosts_count + 1;
                            }
                            if(json[i].conversation[j].likes != null)
                            {
                                Receivedlikes_count = Receivedlikes_count + json[i].conversation[j].likes.Count;
                            }
                        }

                        if (json[i].conversation[j].sender != username)
                        {
                            ReceivedMessages_count = ReceivedMessages_count + 1;
                            if (json[i].conversation[j].media_owner != null)
                            {
                                ReceivedPosts_count = ReceivedPosts_count + 1;
                                if (mediaownersTextbox.Text.Contains(json[i].conversation[j].media_owner.ToString()) == false)
                                {
                                    if(json[i].conversation[j].media_owner.ToString().Contains("Username unavailable") == false)
                                    {
                                        int mediacount = Regex.Matches(FileText, "\"media_owner\": \"" + json[i].conversation[j].media_owner.ToString() + "\"").Count;
                                        mediaownersTextbox.AppendText(json[i].conversation[j].media_owner.ToString() + ": " + mediacount + Environment.NewLine);
                                    }
                                }
                                
                            }
                        }

                        if (json[i].conversation[j].video_call_action != null)
                        {
                            Videocalls_count = Videocalls_count + 1;
                        }

                        if (json[i].conversation[j].likes != null)
                        {
                            for (int g = 0; g < json[i].conversation[j].likes.Count; g++)
                            {
                                if (json[i].conversation[j].likes[g].username == username)
                                {
                                    Sentlikes_count = Sentlikes_count + 1;
                                }
                            }
                        }
                        

                    }

                    if (json[i].participants.Count == 2)
                    {
                        for (int h = 0; h < 2; h++)
                        {
                            if (json[i].participants[h] != username)
                            {
                                DMcontactsTextbox.AppendText(json[i].participants[h].ToString() + Environment.NewLine);
                            }
                        }

                    }
                    
                    allTheParticipants[i] = json[i].participants.ToString();
                    DMcontacts_count = allTheParticipants.Distinct().Count();


                }

                progressBar1.Value = 100;
                done.Text = "Done.";
                totalMessagesSent.Text = "Total messages sent: " + SentMessages_count.ToString();
                totalMessagesReceived.Text = "Total messages received: " + ReceivedMessages_count.ToString();

                totalPostsSent.Text = "Total posts sent: " + SentPosts_count.ToString();
                totalPostsReceived.Text = "Total posts received: " + ReceivedPosts_count.ToString();

                totalVideoCalls.Text = "Total video calls: " + Videocalls_count.ToString();
                totalDMcontacts.Text = "Total DM contacts: " + DMcontacts_count.ToString();

                Sentlikes.Text = "Total likes sent: " + Sentlikes_count.ToString();
                Receivedlikes.Text = "Total likes received: " + Receivedlikes_count.ToString();

                
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void totalMessagesSent_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            home.Location = this.Location;
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void aboutThisSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            about.Location = this.Location;
            this.Hide();
        }

        private void specificDMbutton_Click(object sender, EventArgs e)
        {
            uSentMessages_count = 0;
            uReceivedMessages_count = 0;
            uSentPosts_count = 0;
            uReceivedPosts_count = 0;
            uVideocalls_count = 0;
            uSentlikes_count = 0;
            uReceivedlikes_count = 0;

           
            string json_content = File.ReadAllText(System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Roaming\\instatistic\\messages_json_saved.txt");
            dynamic json = JsonConvert.DeserializeObject(json_content);
            

            for(int i=0; i<json.Count; i++)
            {
                for(int h=0; h < json[i].participants.Count; h++)
                {
                    
                        if (json[i].participants.Count == 2)
                        {
                            if (json[i].participants[h] == specificDMfield.Text)
                            {
                                for (int j = 0; j < json[i].conversation.Count; j++)
                                {
                                    if (json[i].conversation[j].sender == specificDMfield.Text)
                                    {
                                        uReceivedMessages_count = uReceivedMessages_count + 1;
                                        if (json[i].conversation[j].media_owner != null)
                                        {
                                            uReceivedPosts_count = uReceivedPosts_count + 1;
                                        }
                                        if (json[i].conversation[j].likes != null)
                                        {
                                            for(int k=0; k<json[i].conversation[j].likes.Count; k++)
                                            {
                                                if(json[i].conversation[j].likes[k].username == username)
                                                {
                                                    uSentlikes_count = uSentlikes_count + 1;
                                                }
                                            }
                                        }
                                    }

                                    if (json[i].conversation[j].sender == username)
                                    {
                                        uSentMessages_count = uSentMessages_count + 1;
                                        if (json[i].conversation[j].media_owner != null)
                                        {
                                            uSentPosts_count = uSentPosts_count + 1;
                                            if (mediaownersTextbox.Text.Contains(json[i].conversation[j].media_owner.ToString()) == false)
                                            {
                                                if (json[i].conversation[j].media_owner.ToString().Contains("Username unavailable") == false)
                                                {
                                                    int mediacount = Regex.Matches(json_content, "\"media_owner\": \"" + json[i].conversation[j].media_owner.ToString() + "\"").Count;
                                                    mediaownersTextbox.AppendText(json[i].conversation[j].media_owner.ToString() + ": " + mediacount + Environment.NewLine);
                                                }
                                            }

                                           

                                        }

                                    if (json[i].conversation[j].likes != null)
                                    {
                                        for (int k = 0; k < json[i].conversation[j].likes.Count; k++)
                                        {
                                            if (json[i].conversation[j].likes[k].username == specificDMfield.Text)
                                            {
                                                uReceivedlikes_count = uReceivedlikes_count + 1;
                                            }
                                        }
                                    }
                                }

                                    if (json[i].conversation[j].video_call_action != null)
                                    {
                                        uVideocalls_count = uVideocalls_count + 1;
                                    }


                                }
                            
                        }
                    }
                    
                }

                progressBar1.Value = 0;
                progressBar1.Value = 100;
                totalMessagesSent.Text = "Total messages sent: " + uSentMessages_count.ToString();
                totalMessagesReceived.Text = "Total messages received: " + uReceivedMessages_count.ToString();

                totalPostsSent.Text = "Total posts sent: " + uSentPosts_count.ToString();
                totalPostsReceived.Text = "Total posts received: " + uReceivedPosts_count.ToString();

                totalVideoCalls.Text = "Total video calls: " + uVideocalls_count.ToString();
                totalDMcontacts.Text = "";

                Sentlikes.Text = "Total likes sent: " + uSentlikes_count.ToString();
                Receivedlikes.Text = "Total likes received: " + uReceivedlikes_count.ToString();
            
            }
        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
