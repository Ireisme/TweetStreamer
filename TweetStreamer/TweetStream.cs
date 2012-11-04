using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TweetStreamer.Model;

namespace TweetStreamer
{
    public class TweetStream
    {
        const string TWITTER_URI = "https://stream.twitter.com/1/statuses/filter.json";

        HttpWebRequest request;
        TweetStreamParameters streamParameters;
        bool stream = true;

        public Action<Exception> OnException { get; set; }

        public TweetStream(TweetStreamParameters streamParameters)
        {
            this.streamParameters = streamParameters;
        }

        void SetupStream()
        {
            if (streamParameters != null)
            {
                stream = true;

                request = HttpWebRequest.Create(TWITTER_URI) as HttpWebRequest;
                request.Credentials = new NetworkCredential(streamParameters.Username, streamParameters.Password);
                request.Timeout = -1;

                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                if (streamParameters.PostParameters().Length > 0)
                {
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    byte[] postBytes = encode.GetBytes(streamParameters.PostParameters());

                    request.ContentLength = postBytes.Length;
                    Stream postStream = request.GetRequestStream();
                    postStream.Write(postBytes, 0, postBytes.Length);
                    postStream.Close();
                }
            }
        }

        public void Stream(Action<Tweet> action)
        {
            SetupStream();

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader responseStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            while (stream)
            {
                try
                {
                    string json = responseStream.ReadLine();

                    if (json != null)
                    {
                        var tweet = JsonConvert.DeserializeObject<Tweet>(json);

                        if (tweet != null)
                        {
                            if (tweet.id != 0)
                            {
                                Task task = new Task(() => action(tweet));
                                task.Start();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (OnException != null)
                        OnException(ex);
                    else
                        throw ex;
                }
            }

            request.Abort();
            responseStream.Close();
            response.Close();
        }

        public void StopStream()
        {
            stream = false;
        }
    }
}
