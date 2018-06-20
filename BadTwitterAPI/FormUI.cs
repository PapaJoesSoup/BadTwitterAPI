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

        // These items could be moved to config and retrieved.
        public static string UtcFormat = "yyyy-MM-ddTHH:mm:ss.fffZ";
        public static DateTime defaultStart = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
        public static DateTime defaultEnd = new System.DateTime(2017, 12, 31, 23, 59, 59, 999);

        public FormUI()
        {
            InitializeComponent();
            lblWaiting.Visible = false;
            btnReadFile.Visible = _tweets.Count > 0;
            dtpStart.Value = defaultStart;
            dtpEnd.Value = defaultEnd;
        }

        private async void btnGetTweets_Click(object sender, EventArgs e)
        {
            // display a wait message...
            Application.UseWaitCursor = true;

            // Clear grid display
            _tweets.Clear();
            UpdateGridDisplay();

            // Set display state
            lblRecordCount.Text = $@"({_tweets.Count} Records)";
            btnReadFile.Visible = _tweets.Count > 0;
            lblWaiting.Visible = true;

            // convert datetime values to UTC strings
            string startDate = dtpStart.Value.ToUniversalTime().ToString(UtcFormat);
            string endDate = dtpEnd.Value.ToUniversalTime().ToString(UtcFormat);

            // set a stopwatch to get retrieval time
            Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            _tweets = await BadApiClient.GetTweets(startDate, endDate);
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;

            // Display record stats
            lblRecordCount.Text = $@"(Retrieved {_tweets.Count} Records in {Convert.ToDecimal(elapsedMs) / 1000} Sec)";

            // Update grid display
            UpdateGridDisplay();

            // update stats and show file button
            btnReadFile.Visible = _tweets.Count > 0;
            lblWaiting.Visible = false;
            Application.UseWaitCursor = false;
        }

        private void UpdateGridDisplay()
        {
            gridResults.DataSource = null;
            gridResults.DataSource = _tweets;
            gridResults.Refresh();
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
                Cursor.Current = DefaultCursor;
                MessageBox.Show(exception.ToString(), "Application Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.UseWaitCursor = false;
        }
    }
}
