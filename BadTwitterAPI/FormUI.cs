using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BadTwitterAPI
{
    public partial class FormUI : Form
    {
        private List<Tweet> _tweets = new List<Tweet>();
        public static string UtcFormat = "yyyy-MM-ddTHH:mm:ss.fffZ";

        public FormUI()
        {
            InitializeComponent();
            lblWaiting.Visible = false;
            btnReadFile.Enabled = _tweets.Count > 0;
        }

        private async void btnGetTweets_Click(object sender, EventArgs e)
        {
            // display a wait message...
            Application.UseWaitCursor = true;
            lblWaiting.Visible = true;
            // convert datetime values to UTC strings
            string startDate = dtpStart.Value.ToUniversalTime().ToString(UtcFormat);
            string endDate = dtpEnd.Value.ToUniversalTime().ToString(UtcFormat);
            _tweets.Clear();
            // set a stopwatch to get retrieval time
            Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            _tweets = await BadApiClient.GetTweets(startDate, endDate);
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            lblRecordCount.Text = $@"(Retrieved {_tweets.Count} Records in {Convert.ToDecimal(elapsedMs) / 1000} Sec)";

            // Update grid display
            gridResults.DataSource = null;
            gridResults.DataSource = _tweets;
            gridResults.Refresh();
            
            // update stats and enable file button
            btnReadFile.Enabled = _tweets.Count > 0;
            lblWaiting.Visible = false;
            Application.UseWaitCursor = false;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            // Build text from results for save to fiile
            StringBuilder results = new StringBuilder();
            foreach (Tweet tweet in _tweets)
            {
                results.AppendLine($"ID: {tweet.id}, Stamp: {tweet.stamp}, Text: {tweet.text}");
            }
            results.AppendLine($"Records: {_tweets.Count}");

            // Save to file and open file for viewing/printing
            try
            {
                string fileName = $"{Application.StartupPath}\\SearchResults.txt";
                File.WriteAllText(fileName, results.ToString(), Encoding.UTF8);
                Process.Start(fileName);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                Cursor.Current = DefaultCursor;
                throw;
            }
            Application.UseWaitCursor = false;
        }
    }
}
