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
using TweetStreamer;
using TweetStreamer.Model;

namespace TweetsToSqlite
{
    public partial class Form1 : Form
    {
        TweetStream stream;
        int tweets = 0;
        delegate void SetTextCallback(int tweets);

        public Form1()
        {
            InitializeComponent();
            SqliteHelper.CheckSqliteDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;

                TweetStreamParameters param = new TweetStreamParameters(txtUsername.Text, txtPassword.Text);

                if (txtFilter.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                if (txtUsers.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                stream = new TweetStream(param);
                stream.OnException = (ex) => Log.Instance.ErrorException("Error Reading TweetStream", ex);

                Task task = new Task(() => stream.Stream(t =>
                    {
                        SqliteHelper.PersistTweet(t);
                        tweets++;
                        UpdateNumber(tweets);
                    }));

                task.Start();
            }
            else
            {
                MessageBox.Show("Error!", "You need a username and password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stream.StopStream();

            tweets = 0;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void UpdateNumber(int tweets)
        {
            if (this.lblTweetsSaved.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateNumber);
                this.Invoke(d, new object[] { tweets });
            }
            else
            {
                lblTweetsSaved.Text = tweets.ToString();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(stream != null)
                stream.StopStream();
        }
    }
}
