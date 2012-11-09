using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetStreamer.Model;
using Dapper;
using NLog;

namespace TweetsToDB.Sqlite
{
    public class SqliteHelper : ICanPersistTweet
    {
        const string PATH_TO_DB = "tweets.sqlite";
        const string CONNECTION_STRING = "Data Source={0};Version=3;New=True;Compress=True;";
        const string CREATE_TWEET_TABLE = @"Create Table Tweets
                                            (
                                                id BIGINT NOT NULL,
                                                created_at VARCHAR(50),
                                                in_reply_to_screen_name VARCHAR(100),
                                                in_reply_to_status_id BIGINT,
                                                place_full_name VARCHAR(100),
                                                retweet_count INT,
                                                retweeted BOOLEAN,
                                                text VARCHAR(150),
                                                user_name VARCHAR(35),
                                                user_id BIGINT NOT NULL,
                                                user_location VARCHAR(100),
                                                user_description VARCHAR(100),
                                                user_followers_count INT,
                                                user_friends_count INT,
                                                user_url VARCHAR(100),
                                                lat DECIMAL(10,6),
                                                lon DECIMAL(10,6)
                                            )";

        public SqliteHelper()
        {
            if (!File.Exists(PATH_TO_DB))
            {
                SQLiteConnection.CreateFile(PATH_TO_DB);
            }

            SQLiteConnection conn = new SQLiteConnection(string.Format(CONNECTION_STRING, PATH_TO_DB));

            SQLiteCommand cmd = conn.CreateCommand();

            conn.Open();
            cmd.CommandText = "SELECT 1 FROM sqlite_master WHERE type='table' AND name='Tweets'";

            var table = cmd.ExecuteScalar();

            if (table == null)
            {
                cmd.CommandText = CREATE_TWEET_TABLE;
                cmd.ExecuteNonQuery();
            }
        }

        public bool PersistTweet(Tweet tweet)
        {
            var t = new
            {
                id = tweet.id,
                created_at = tweet.created_at,
                in_reply_to_screen_name = tweet.in_reply_to_screen_name,
                in_reply_to_status_id = tweet.in_reply_to_status_id,
                place_full_name = tweet.place != null ? tweet.place.full_name : "",
                retweet_count = tweet.retweet_count,
                retweeted = tweet.retweeted,
                text = tweet.text,
                user_name = tweet.user.name,
                user_id = tweet.user.id,
                user_location = tweet.user.location,
                user_description = tweet.user.description,
                user_followers_count = tweet.user.followers_count,
                user_friends_count = tweet.user.friends_count,
                user_url = tweet.user.url,
                lat = tweet.coordinates != null ? tweet.coordinates.coordinates[1] : 0,
                lon = tweet.coordinates != null ? tweet.coordinates.coordinates[0] : 0
            };

            string query = @"Insert into Tweets
                                (
                                    id,
                                    created_at,
                                    in_reply_to_screen_name,
                                    in_reply_to_status_id,
                                    place_full_name,
                                    retweet_count,
                                    retweeted,
                                    text,
                                    user_name,
                                    user_id,
                                    user_location,
                                    user_description,
                                    user_followers_count,
                                    user_friends_count,
                                    user_url,
                                    lat,
                                    lon
                                )
                                values
                                (
                                    @id,
                                    @created_at,
                                    @in_reply_to_screen_name,
                                    @in_reply_to_status_id,
                                    @place_full_name,
                                    @retweet_count,
                                    @retweeted,
                                    @text,
                                    @user_name,
                                    @user_id,
                                    @user_location,
                                    @user_description,
                                    @user_followers_count,
                                    @user_friends_count,
                                    @user_url,
                                    @lat,
                                    @lon
                                )";

            using (SQLiteConnection conn = new SQLiteConnection(string.Format(CONNECTION_STRING, PATH_TO_DB)))
            {
                try
                {
                    conn.Open();
                    conn.Execute(query, t);
                }
                catch (Exception ex)
                {
                    Log.Instance.ErrorException("Failed to Persist Tweet to database.", ex);
                    return false;
                }
                finally
                {
                    conn.Close();
                }

                return true;
            }
        }
    }
}
