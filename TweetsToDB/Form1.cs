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
        delegate void SetPersistedCallback(int persisted);
        delegate void SetStreamStatusCallback(TweetStream.StreamStatus status);

        public Form1()
        {
            InitializeComponent();

            EnableFilterUi(SearchType.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {

                TweetStreamParameters param = new TweetStreamParameters(txtUsername.Text, txtPassword.Text);

                if (txtFilter.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                if (txtUsers.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                if (txtLatSw.Text != string.Empty && txtLatNe.Text != string.Empty)
                {
                    try
                    {
                        float swX = Convert.ToSingle(txtLatSw.Text.Split(',').First());
                        float swY = Convert.ToSingle(txtLatSw.Text.Split(',').Last());

                        float neX = Convert.ToSingle(txtLatNe.Text.Split(',').First());
                        float neY = Convert.ToSingle(txtLatNe.Text.Split(',').Last());

                        param.Locations.Add(new TweetLocation { SouthWestCorner = new PointF(swX, swY), NorthEastCorner = new PointF(neX, neY) });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fix your locations chump!", "You're a chump!");
                        return;
                    }
                }

                EnableUi(false);

                stream = new TweetStream(param);
                stream.OnException = (ex) => Log.Instance.ErrorException("Error Reading TweetStream", ex);

                var persistance = GetPersistance();

                Task task = new Task(() => stream.Stream(t =>
                    {
                        UpdateStreamStatus(stream.Status);

                        if (persistance.PersistTweet(t))
                        {
                            tweets++;
                            UpdatePersisted(tweets);
                        }
                    }));

                task.Start();
            }
            else
            {
                MessageBox.Show("Error!", "You need a username and password!");
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                stream.StopStream();
            }

            lblTweetsSaved.Text = "0";
            lblTweetsGrabbed.Text = "0";
            lblTweetsMissed.Text = "0";
            lblErrors.Text = "0";

            EnableUi(true);
        }

        void EnableUi(bool enabled)
        {
            groupBox1.Enabled = enabled;
            groupBox2.Enabled = enabled;
            groupBox3.Enabled = enabled;
            groupBox4.Enabled = enabled;
            groupBox5.Enabled = enabled;
        }

        void EnableFilterUi(SearchType type)
        {
            switch (type)
            {
                case SearchType.Location:
                    groupBox1.Enabled = true;
                    groupBox5.Enabled = false;
                    break;
                case SearchType.Filter:
                    groupBox5.Enabled = true;
                    groupBox1.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private ICanPersistTweet GetPersistance()
        {
            if (rdSqlServer.Checked)
                return new SqlServerHelper();
            else if (rdSqlite.Checked)
                return new SqliteHelper();

            return null;
        }
        private void UpdatePersisted(int persisted)
        {
            if (this.lblTweetsSaved.InvokeRequired)
            {
                SetPersistedCallback d = new SetPersistedCallback(UpdatePersisted);
                this.Invoke(d, new object[] { persisted });
            }
            else
            {
                lblTweetsSaved.Text = persisted.ToString();
            }
        }

        private void UpdateStreamStatus(TweetStream.StreamStatus status)
        {
            if (this.lblTweetsGrabbed.InvokeRequired || lblErrors.InvokeRequired || lblTweetsMissed.InvokeRequired)
            {
                SetStreamStatusCallback d = new SetStreamStatusCallback(UpdateStreamStatus);
                this.Invoke(d, new object[] { status });
            }
            else
            {
                lblTweetsGrabbed.Text = status.TweetsGrabbed.ToString();
                lblTweetsMissed.Text = status.MissedTweets.ToString();
                lblErrors.Text = status.Error.ToString();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(stream != null)
                stream.StopStream();
        }

        private void rdLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLocation.Checked)
                EnableFilterUi(SearchType.Location);
        }

        enum SearchType
        {
            Location,
            Filter
        }

        private void rdFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFilter.Checked)
                EnableFilterUi(SearchType.Filter);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
