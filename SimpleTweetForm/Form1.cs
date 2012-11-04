using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetStreamer;
using TweetStreamer.Model;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        TweetStream stream;
        delegate void SetTextCallback(Tweet tweet);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {

                TweetStreamParameters param = new TweetStreamParameters(txtUsername.Text, txtPassword.Text);

                if (txtFilter.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                if(txtUsers.Text != string.Empty)
                    param.Filters = txtFilter.Text.Split(',').ToList();

                stream = new TweetStream(param);
                Task task = new Task(() => stream.Stream(t => AddTweet(t)));
                task.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stream.StopStream();
        }

        private void AddTweet(Tweet tweet)
        {
            if (tweet != null)
            {
                if (this.grid.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(AddTweet);
                    this.Invoke(d, new object[] { tweet });
                }
                else
                {
                    this.grid.Rows.Add(grid.Rows.Count + 1, tweet.user.ToString(), tweet.text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
        }
    }
}
