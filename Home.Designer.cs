namespace WindowsFormsApp2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSoftwareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.letsStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(299, 34);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(184, 45);
            this.header.TabIndex = 0;
            this.header.Text = "Instatistic";
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(304, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "A deep statistical tool for your Instagram activity.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Checked = true;
            this.menuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisSoftwareToolStripMenuItem,
            this.aboutThisSoftwareToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutThisSoftwareToolStripMenuItem
            // 
            this.aboutThisSoftwareToolStripMenuItem.Name = "aboutThisSoftwareToolStripMenuItem";
            this.aboutThisSoftwareToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutThisSoftwareToolStripMenuItem.Text = "Home";
            this.aboutThisSoftwareToolStripMenuItem.Click += new System.EventHandler(this.aboutThisSoftwareToolStripMenuItem_Click);
            // 
            // aboutThisSoftwareToolStripMenuItem1
            // 
            this.aboutThisSoftwareToolStripMenuItem1.Name = "aboutThisSoftwareToolStripMenuItem1";
            this.aboutThisSoftwareToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.aboutThisSoftwareToolStripMenuItem1.Text = "About this software";
            this.aboutThisSoftwareToolStripMenuItem1.Click += new System.EventHandler(this.aboutThisSoftwareToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your username:";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(347, 176);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 5;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // step1
            // 
            this.step1.AutoSize = true;
            this.step1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.step1.Location = new System.Drawing.Point(251, 142);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(294, 19);
            this.step1.TabIndex = 7;
            this.step1.Text = "Step 1: You write your username below";
            // 
            // step2
            // 
            this.step2.AutoSize = true;
            this.step2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.step2.Location = new System.Drawing.Point(241, 238);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(318, 19);
            this.step2.TabIndex = 8;
            this.step2.Text = "Step 2: You download your instagram data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Go to                                                        and get a copy of wh" +
    "at you\'ve shared.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(252, 273);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "instagram.com/download/request";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letsStart
            // 
            this.letsStart.Enabled = false;
            this.letsStart.Location = new System.Drawing.Point(347, 379);
            this.letsStart.Name = "letsStart";
            this.letsStart.Size = new System.Drawing.Size(122, 23);
            this.letsStart.TabIndex = 12;
            this.letsStart.Text = "Okay, let\'s start!";
            this.letsStart.UseMnemonic = false;
            this.letsStart.UseVisualStyleBackColor = true;
            this.letsStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._160468074413584612;
            this.pictureBox1.Location = new System.Drawing.Point(245, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 52);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.letsStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Instatistic";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSoftwareToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label step1;
        private System.Windows.Forms.Label step2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button letsStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSoftwareToolStripMenuItem1;
    }
}