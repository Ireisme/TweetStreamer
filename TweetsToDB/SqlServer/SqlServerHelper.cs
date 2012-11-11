using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetStreamer.Model;
using Dapper;
using Newtonsoft.Json;

namespace TweetsToDB.SqlServer
{
    public class SqlServerHelper : ICanPersistTweet
    {
        const string CONNECTION_STRING = "Data Source={0};Initial Catalog={1};User Id={2};Password={3};";

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
                user_description = tweet.user.description.Substring(0, 300),
                user_followers_count = tweet.user.followers_count,
                user_friends_count = tweet.user.friends_count,
                user_url = tweet.user.url.Substring(0, 150),
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

            using (SqlConnection conn = new SqlConnection(string.Format(CONNECTION_STRING, 
                SqlServerConfig.Config.DataSource, SqlServerConfig.Config.Database, SqlServerConfig.Config.User, SqlServerConfig.Config.Password)))
            {
                try
                {
                    conn.Open();
                    conn.Execute(query, t);
                }
                catch (Exception ex)
                {
                    Log.Instance.ErrorException("Failed to Persist Tweet to database.\n" + JsonConvert.SerializeObject(t), ex);
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
