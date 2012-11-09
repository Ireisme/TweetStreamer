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
using TweetsToDB.Sqlite;
using TweetsToDB.SqlServer;
using TweetStreamer;
using TweetStreamer.Model;

namespace TweetsToDB
{
    public partial class Form1 : Form
    {
        TweetStream stream;
        int tweets = 0;
        delegate void SetTextCallback(int tweets);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                EnableUi(false);

                TweetStreamParameters param = new TweetStreamParameters(txtUsername.Text, txtPassword.Text);

                if (txtFilter.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                if (txtUsers.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                stream = new TweetStream(param);
                stream.OnException = (ex) => Log.Instance.ErrorException("Error Reading TweetStream", ex);

                var persistance = GetPersistance();

                Task task = new Task(() => stream.Stream(t =>
                    {
                        if (persistance.PersistTweet(t))
                        {
                            tweets++;
                            UpdateNumber(tweets);
                        }
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

            EnableUi(true);
        }

        private void EnableUi(bool enabled)
        {
            groupBox1.Enabled = enabled;
            groupBox2.Enabled = enabled;
            groupBox3.Enabled = enabled;
            groupBox4.Enabled = enabled;
        }

        private ICanPersistTweet GetPersistance()
        {
            if (rdSqlServer.Checked)
                return new SqlServerHelper();
            else if (rdSqlite.Checked)
                return new SqliteHelper();

            return null;
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
