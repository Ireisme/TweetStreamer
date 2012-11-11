namespace TweetsToDB
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLatNe = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLatSw = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTweetsGrabbed = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdSqlite = new System.Windows.Forms.RadioButton();
            this.rdSqlServer = new System.Windows.Forms.RadioButton();
            this.rdLocation = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdFilter = new System.Windows.Forms.RadioButton();
            this.lblTweetsMissed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTweetsSaved = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(198, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(279, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(70, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(70, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(54, 10);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(260, 20);
            this.txtFilter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Users:";
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(54, 33);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(260, 20);
            this.txtUsers.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.txtLatNe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLatSw);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(7, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 84);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtLatNe
            // 
            this.txtLatNe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtLatNe.Location = new System.Drawing.Point(77, 49);
            this.txtLatNe.Name = "txtLatNe";
            this.txtLatNe.Size = new System.Drawing.Size(100, 20);
            this.txtLatNe.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Northeast:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Southwest:";
            // 
            // txtLatSw
            // 
            this.txtLatSw.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtLatSw.Location = new System.Drawing.Point(77, 23);
            this.txtLatSw.Name = "txtLatSw";
            this.txtLatSw.Size = new System.Drawing.Size(100, 20);
            this.txtLatSw.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Location = new System.Drawing.Point(16, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 68);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdFilter);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.rdLocation);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(203, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 227);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Query";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tweets Grabbed:";
            // 
            // lblTweetsGrabbed
            // 
            this.lblTweetsGrabbed.AutoSize = true;
            this.lblTweetsGrabbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetsGrabbed.Location = new System.Drawing.Point(113, 12);
            this.lblTweetsGrabbed.Name = "lblTweetsGrabbed";
            this.lblTweetsGrabbed.Size = new System.Drawing.Size(21, 24);
            this.lblTweetsGrabbed.TabIndex = 18;
            this.lblTweetsGrabbed.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdSqlite);
            this.groupBox4.Controls.Add(this.rdSqlServer);
            this.groupBox4.Location = new System.Drawing.Point(12, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 153);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Persistence";
            // 
            // rdSqlite
            // 
            this.rdSqlite.AutoSize = true;
            this.rdSqlite.Location = new System.Drawing.Point(7, 41);
            this.rdSqlite.Name = "rdSqlite";
            this.rdSqlite.Size = new System.Drawing.Size(51, 17);
            this.rdSqlite.TabIndex = 1;
            this.rdSqlite.Text = "Sqlite";
            this.rdSqlite.UseVisualStyleBackColor = true;
            // 
            // rdSqlServer
            // 
            this.rdSqlServer.AutoSize = true;
            this.rdSqlServer.Checked = true;
            this.rdSqlServer.Location = new System.Drawing.Point(7, 21);
            this.rdSqlServer.Name = "rdSqlServer";
            this.rdSqlServer.Size = new System.Drawing.Size(74, 17);
            this.rdSqlServer.TabIndex = 0;
            this.rdSqlServer.TabStop = true;
            this.rdSqlServer.Text = "Sql Server";
            this.rdSqlServer.UseVisualStyleBackColor = true;
            // 
            // rdLocation
            // 
            this.rdLocation.AutoSize = true;
            this.rdLocation.Checked = true;
            this.rdLocation.Location = new System.Drawing.Point(7, 115);
            this.rdLocation.Name = "rdLocation";
            this.rdLocation.Size = new System.Drawing.Size(66, 17);
            this.rdLocation.TabIndex = 13;
            this.rdLocation.TabStop = true;
            this.rdLocation.Text = "Location";
            this.rdLocation.UseVisualStyleBackColor = true;
            this.rdLocation.CheckedChanged += new System.EventHandler(this.rdLocation_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtFilter);
            this.groupBox5.Controls.Add(this.txtUsers);
            this.groupBox5.Location = new System.Drawing.Point(7, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 58);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // rdFilter
            // 
            this.rdFilter.AutoSize = true;
            this.rdFilter.Location = new System.Drawing.Point(7, 27);
            this.rdFilter.Name = "rdFilter";
            this.rdFilter.Size = new System.Drawing.Size(47, 17);
            this.rdFilter.TabIndex = 15;
            this.rdFilter.Text = "Filter";
            this.rdFilter.UseVisualStyleBackColor = true;
            this.rdFilter.CheckedChanged += new System.EventHandler(this.rdFilter_CheckedChanged);
            // 
            // lblTweetsMissed
            // 
            this.lblTweetsMissed.AutoSize = true;
            this.lblTweetsMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetsMissed.Location = new System.Drawing.Point(318, 12);
            this.lblTweetsMissed.Name = "lblTweetsMissed";
            this.lblTweetsMissed.Size = new System.Drawing.Size(21, 24);
            this.lblTweetsMissed.TabIndex = 21;
            this.lblTweetsMissed.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tweets Missed:";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.Location = new System.Drawing.Point(460, 12);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(21, 24);
            this.lblErrors.TabIndex = 23;
            this.lblErrors.Text = "0";
            this.lblErrors.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Errors:";
            // 
            // lblTweetsSaved
            // 
            this.lblTweetsSaved.AutoSize = true;
            this.lblTweetsSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetsSaved.Location = new System.Drawing.Point(113, 52);
            this.lblTweetsSaved.Name = "lblTweetsSaved";
            this.lblTweetsSaved.Size = new System.Drawing.Size(21, 24);
            this.lblTweetsSaved.TabIndex = 20;
            this.lblTweetsSaved.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tweets Saved:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.Controls.Add(this.lblTweetsSaved);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTweetsMissed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTweetsGrabbed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tweetins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtLatNe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLatSw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTweetsGrabbed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdSqlite;
        private System.Windows.Forms.RadioButton rdSqlServer;
        private System.Windows.Forms.RadioButton rdFilter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdLocation;
        private System.Windows.Forms.Label lblTweetsMissed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTweetsSaved;
        private System.Windows.Forms.Label label13;
    }
}

