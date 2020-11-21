namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.totalMessagesSent = new System.Windows.Forms.Label();
            this.choosefile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.header = new System.Windows.Forms.Label();
            this.totalMessagesReceived = new System.Windows.Forms.Label();
            this.totalPostsSent = new System.Windows.Forms.Label();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.totalPostsReceived = new System.Windows.Forms.Label();
            this.totalVideoCalls = new System.Windows.Forms.Label();
            this.totalDMcontacts = new System.Windows.Forms.Label();
            this.Receivedlikes = new System.Windows.Forms.Label();
            this.Sentlikes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DMcontactsTextbox = new System.Windows.Forms.RichTextBox();
            this.mediaownersTextbox = new System.Windows.Forms.RichTextBox();
            this.specificDMfield = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specificDMbutton = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalMessagesSent
            // 
            this.totalMessagesSent.AutoSize = true;
            this.totalMessagesSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalMessagesSent.Location = new System.Drawing.Point(12, 98);
            this.totalMessagesSent.Name = "totalMessagesSent";
            this.totalMessagesSent.Size = new System.Drawing.Size(162, 18);
            this.totalMessagesSent.TabIndex = 2;
            this.totalMessagesSent.Text = "Total messages sent: 0";
            this.totalMessagesSent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalMessagesSent.Click += new System.EventHandler(this.totalMessagesSent_Click);
            // 
            // choosefile
            // 
            this.choosefile.Location = new System.Drawing.Point(15, 56);
            this.choosefile.Name = "choosefile";
            this.choosefile.Size = new System.Drawing.Size(75, 23);
            this.choosefile.TabIndex = 4;
            this.choosefile.Text = "Choose file";
            this.choosefile.UseVisualStyleBackColor = true;
            this.choosefile.Click += new System.EventHandler(this.choosefile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose the messages.json file:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.header.Location = new System.Drawing.Point(268, 40);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(260, 26);
            this.header.TabIndex = 6;
            this.header.Text = "Statistics of your account:";
            // 
            // totalMessagesReceived
            // 
            this.totalMessagesReceived.AutoSize = true;
            this.totalMessagesReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalMessagesReceived.Location = new System.Drawing.Point(12, 128);
            this.totalMessagesReceived.Name = "totalMessagesReceived";
            this.totalMessagesReceived.Size = new System.Drawing.Size(189, 18);
            this.totalMessagesReceived.TabIndex = 7;
            this.totalMessagesReceived.Text = "Total messages received: 0";
            this.totalMessagesReceived.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalPostsSent
            // 
            this.totalPostsSent.AutoSize = true;
            this.totalPostsSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalPostsSent.Location = new System.Drawing.Point(270, 98);
            this.totalPostsSent.Name = "totalPostsSent";
            this.totalPostsSent.Size = new System.Drawing.Size(130, 18);
            this.totalPostsSent.TabIndex = 8;
            this.totalPostsSent.Text = "Total posts sent: 0";
            this.totalPostsSent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.aboutThisSoftwareToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutUsToolStripMenuItem.Text = "Home";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // aboutThisSoftwareToolStripMenuItem
            // 
            this.aboutThisSoftwareToolStripMenuItem.Name = "aboutThisSoftwareToolStripMenuItem";
            this.aboutThisSoftwareToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutThisSoftwareToolStripMenuItem.Text = "About this software";
            this.aboutThisSoftwareToolStripMenuItem.Click += new System.EventHandler(this.aboutThisSoftwareToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // totalPostsReceived
            // 
            this.totalPostsReceived.AutoSize = true;
            this.totalPostsReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalPostsReceived.Location = new System.Drawing.Point(270, 128);
            this.totalPostsReceived.Name = "totalPostsReceived";
            this.totalPostsReceived.Size = new System.Drawing.Size(157, 18);
            this.totalPostsReceived.TabIndex = 10;
            this.totalPostsReceived.Text = "Total posts received: 0";
            this.totalPostsReceived.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalVideoCalls
            // 
            this.totalVideoCalls.AutoSize = true;
            this.totalVideoCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalVideoCalls.Location = new System.Drawing.Point(493, 98);
            this.totalVideoCalls.Name = "totalVideoCalls";
            this.totalVideoCalls.Size = new System.Drawing.Size(130, 18);
            this.totalVideoCalls.TabIndex = 11;
            this.totalVideoCalls.Text = "Total video calls: 0";
            this.totalVideoCalls.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalDMcontacts
            // 
            this.totalDMcontacts.AutoSize = true;
            this.totalDMcontacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalDMcontacts.Location = new System.Drawing.Point(493, 128);
            this.totalDMcontacts.Name = "totalDMcontacts";
            this.totalDMcontacts.Size = new System.Drawing.Size(146, 18);
            this.totalDMcontacts.TabIndex = 12;
            this.totalDMcontacts.Text = "Total DM contacts: 0";
            this.totalDMcontacts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Receivedlikes
            // 
            this.Receivedlikes.AutoSize = true;
            this.Receivedlikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Receivedlikes.Location = new System.Drawing.Point(687, 128);
            this.Receivedlikes.Name = "Receivedlikes";
            this.Receivedlikes.Size = new System.Drawing.Size(150, 18);
            this.Receivedlikes.TabIndex = 14;
            this.Receivedlikes.Text = "Total likes received: 0";
            this.Receivedlikes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sentlikes
            // 
            this.Sentlikes.AutoSize = true;
            this.Sentlikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Sentlikes.Location = new System.Drawing.Point(687, 98);
            this.Sentlikes.Name = "Sentlikes";
            this.Sentlikes.Size = new System.Drawing.Size(123, 18);
            this.Sentlikes.TabIndex = 13;
            this.Sentlikes.Text = "Total likes sent: 0";
            this.Sentlikes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(687, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "(DMs only)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // DMcontactsTextbox
            // 
            this.DMcontactsTextbox.Location = new System.Drawing.Point(496, 160);
            this.DMcontactsTextbox.Name = "DMcontactsTextbox";
            this.DMcontactsTextbox.ReadOnly = true;
            this.DMcontactsTextbox.Size = new System.Drawing.Size(154, 176);
            this.DMcontactsTextbox.TabIndex = 17;
            this.DMcontactsTextbox.Text = "";
            this.DMcontactsTextbox.Visible = false;
            // 
            // mediaownersTextbox
            // 
            this.mediaownersTextbox.Location = new System.Drawing.Point(273, 160);
            this.mediaownersTextbox.Name = "mediaownersTextbox";
            this.mediaownersTextbox.ReadOnly = true;
            this.mediaownersTextbox.Size = new System.Drawing.Size(154, 176);
            this.mediaownersTextbox.TabIndex = 18;
            this.mediaownersTextbox.Text = "";
            this.mediaownersTextbox.Visible = false;
            // 
            // specificDMfield
            // 
            this.specificDMfield.Location = new System.Drawing.Point(116, 201);
            this.specificDMfield.Name = "specificDMfield";
            this.specificDMfield.ReadOnly = true;
            this.specificDMfield.Size = new System.Drawing.Size(98, 20);
            this.specificDMfield.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stats of a specific DM.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter username:";
            // 
            // specificDMbutton
            // 
            this.specificDMbutton.Enabled = false;
            this.specificDMbutton.Location = new System.Drawing.Point(215, 200);
            this.specificDMbutton.Name = "specificDMbutton";
            this.specificDMbutton.Size = new System.Drawing.Size(47, 23);
            this.specificDMbutton.TabIndex = 22;
            this.specificDMbutton.Text = "OK";
            this.specificDMbutton.UseVisualStyleBackColor = true;
            this.specificDMbutton.Click += new System.EventHandler(this.specificDMbutton_Click);
            // 
            // done
            // 
            this.done.AutoSize = true;
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.done.Location = new System.Drawing.Point(12, 399);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(0, 13);
            this.done.TabIndex = 23;
            this.done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.done);
            this.Controls.Add(this.specificDMbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.specificDMfield);
            this.Controls.Add(this.mediaownersTextbox);
            this.Controls.Add(this.DMcontactsTextbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Receivedlikes);
            this.Controls.Add(this.Sentlikes);
            this.Controls.Add(this.totalDMcontacts);
            this.Controls.Add(this.totalVideoCalls);
            this.Controls.Add(this.totalPostsReceived);
            this.Controls.Add(this.totalPostsSent);
            this.Controls.Add(this.totalMessagesReceived);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosefile);
            this.Controls.Add(this.totalMessagesSent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Instatistic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalMessagesSent;
        private System.Windows.Forms.Button choosefile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label totalMessagesReceived;
        private System.Windows.Forms.Label totalPostsSent;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label totalPostsReceived;
        private System.Windows.Forms.Label totalVideoCalls;
        private System.Windows.Forms.Label totalDMcontacts;
        private System.Windows.Forms.Label Receivedlikes;
        private System.Windows.Forms.Label Sentlikes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox DMcontactsTextbox;
        private System.Windows.Forms.RichTextBox mediaownersTextbox;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSoftwareToolStripMenuItem;
        private System.Windows.Forms.TextBox specificDMfield;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button specificDMbutton;
        private System.Windows.Forms.Label done;
    }
}

