namespace WindowsFormsApp2
{
    partial class ChooseJSON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseJSON));
            this.messages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.likes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(35, 115);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(110, 23);
            this.messages.TabIndex = 0;
            this.messages.Text = "Your messages";
            this.messages.UseVisualStyleBackColor = true;
            this.messages.Click += new System.EventHandler(this.messages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose what statistics you want to see";
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(161, 115);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(107, 23);
            this.likes.TabIndex = 2;
            this.likes.Text = "Posts you\'ve liked";
            this.likes.UseVisualStyleBackColor = true;
            this.likes.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 212);
            this.Controls.Add(this.likes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseJSON";
            this.Text = "Choose what statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button likes;
    }
}