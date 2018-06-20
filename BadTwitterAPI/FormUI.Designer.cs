namespace BadTwitterAPI
{
    partial class FormUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGetTweets = new System.Windows.Forms.Button();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(446, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bad Twitter API Client";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(12, 68);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(159, 17);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date and Time:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(12, 108);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(152, 17);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "End Date and Time:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM-dd-yyyy HH:mm:ss tt";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(178, 68);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM-dd-yyyy HH:mm:ss tt";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(178, 108);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.Value = new System.DateTime(2017, 12, 31, 23, 59, 0, 0);
            // 
            // btnGetTweets
            // 
            this.btnGetTweets.BackColor = System.Drawing.Color.Green;
            this.btnGetTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTweets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetTweets.Location = new System.Drawing.Point(391, 68);
            this.btnGetTweets.Name = "btnGetTweets";
            this.btnGetTweets.Size = new System.Drawing.Size(110, 60);
            this.btnGetTweets.TabIndex = 5;
            this.btnGetTweets.Text = "Get Tweets";
            this.btnGetTweets.UseVisualStyleBackColor = false;
            this.btnGetTweets.Click += new System.EventHandler(this.btnGetTweets_Click);
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.AllowUserToOrderColumns = true;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(12, 179);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResults.Size = new System.Drawing.Size(1078, 290);
            this.gridResults.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Results";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // stamp
            // 
            this.stamp.HeaderText = "TimeStamp (UTC)";
            this.stamp.Name = "stamp";
            this.stamp.ReadOnly = true;
            // 
            // text
            // 
            this.text.HeaderText = "Message";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReadFile.Location = new System.Drawing.Point(525, 68);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(110, 60);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.Text = "View File";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(740, 159);
            this.lblRecordCount.MinimumSize = new System.Drawing.Size(350, 17);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecordCount.Size = new System.Drawing.Size(350, 17);
            this.lblRecordCount.TabIndex = 9;
            this.lblRecordCount.Text = "(0 Records)";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWaiting.Location = new System.Drawing.Point(470, 325);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(162, 17);
            this.lblWaiting.TabIndex = 10;
            this.lblWaiting.Text = "Retrieving Records...";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 481);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnGetTweets);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(660, 520);
            this.Name = "FormUI";
            this.Text = "BadTwitterAPI Client";
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnGetTweets;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblWaiting;
    }
}

