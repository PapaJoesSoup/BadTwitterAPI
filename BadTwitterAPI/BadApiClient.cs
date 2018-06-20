using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BadTwitterAPI
{
    internal static class BadApiClient
    {
        internal static string Url = "https://badapi.iqvia.io/api/v1";

        internal static async Task<List<Tweet>> GetTweets(string startDate, string endDate)
        {
            // Set up our list to return
            List<Tweet> tweets = new List<Tweet>();
            DateTime eDate = Convert.ToDateTime(endDate);
            bool gotAllTweets = false;
            while (!gotAllTweets)
            {
                //instantiate our client

                HttpClientHandler handler = new HttpClientHandler {UseDefaultCredentials = true};
                HttpClient client = new HttpClient();
                try
                {
                    // call api
                    string requestUri = $"{Url}/Tweets?startDate={startDate}&endDate={endDate}";
                    HttpResponseMessage response = await client.GetAsync(requestUri);

                    //Verify good response.
                    response.EnsureSuccessStatusCode();

                    // convert json response body to objects.
                    string content = await response.Content.ReadAsStringAsync();
                    List<Tweet> newtweets = JsonConvert.DeserializeObject<List<Tweet>>(content);
                    if (newtweets.Count > 0)
                    {
                        tweets.AddRange(newtweets);
                        // if we have not reached the end, grab the last timestamp and increment startDate.
                        DateTime sDate = Convert.ToDateTime(startDate).ToUniversalTime();
                        DateTime lDate = Convert.ToDateTime(newtweets.Last().stamp).Add(new TimeSpan(0,0,0,0,1)).ToUniversalTime();
                        if (lDate > eDate)
                        {
                            gotAllTweets = true;
                            break;
                        }
                        if (sDate < lDate) startDate = lDate.ToString(FormUI.UtcFormat);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                client.Dispose();
                handler.Dispose();
            }

            return tweets;
        }
    }
}
