namespace MicrophoneDetector
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDiscard = new System.Windows.Forms.NumericUpDown();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.tmrMinTime = new System.Windows.Forms.Timer(this.components);
            this.lblMicLvl = new System.Windows.Forms.Label();
            this.tmrSecondsSince = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cboMics = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMicLvl2 = new System.Windows.Forms.Label();
            this.nudDb = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSampleRate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discard Below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Silence Time";
            // 
            // nudDiscard
            // 
            this.nudDiscard.DecimalPlaces = 3;
            this.nudDiscard.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudDiscard.Location = new System.Drawing.Point(107, 14);
            this.nudDiscard.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiscard.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudDiscard.Name = "nudDiscard";
            this.nudDiscard.Size = new System.Drawing.Size(48, 20);
            this.nudDiscard.TabIndex = 2;
            this.nudDiscard.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(260, 49);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(48, 20);
            this.nudTime.TabIndex = 3;
            this.nudTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Mic Level Passing Threshold";
            // 
            // lblDetails
            // 
            this.lblDetails.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(12, 177);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(524, 181);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMinTime
            // 
            this.tmrMinTime.Tick += new System.EventHandler(this.tmrMinTime_Tick);
            // 
            // lblMicLvl
            // 
            this.lblMicLvl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMicLvl.Location = new System.Drawing.Point(12, 116);
            this.lblMicLvl.Name = "lblMicLvl";
            this.lblMicLvl.Size = new System.Drawing.Size(166, 34);
            this.lblMicLvl.TabIndex = 9;
            // 
            // tmrSecondsSince
            // 
            this.tmrSecondsSince.Interval = 1000;
            this.tmrSecondsSince.Tick += new System.EventHandler(this.tmrSecondsSince_Tick_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(465, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Get Audio";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(465, 46);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop Mic";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cboMics
            // 
            this.cboMics.FormattingEnabled = true;
            this.cboMics.Location = new System.Drawing.Point(170, 14);
            this.cboMics.Name = "cboMics";
            this.cboMics.Size = new System.Drawing.Size(204, 21);
            this.cboMics.TabIndex = 12;
            this.cboMics.SelectedIndexChanged += new System.EventHandler(this.cboMics_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Current Mic Level";
            // 
            // lblMicLvl2
            // 
            this.lblMicLvl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMicLvl2.Location = new System.Drawing.Point(212, 116);
            this.lblMicLvl2.Name = "lblMicLvl2";
            this.lblMicLvl2.Size = new System.Drawing.Size(312, 34);
            this.lblMicLvl2.TabIndex = 14;
            // 
            // nudDb
            // 
            this.nudDb.DecimalPlaces = 3;
            this.nudDb.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDb.Location = new System.Drawing.Point(107, 49);
            this.nudDb.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudDb.Name = "nudDb";
            this.nudDb.Size = new System.Drawing.Size(48, 20);
            this.nudDb.TabIndex = 16;
            this.nudDb.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Min Db Capture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sample Rate";
            // 
            // cboSampleRate
            // 
            this.cboSampleRate.FormattingEnabled = true;
            this.cboSampleRate.Items.AddRange(new object[] {
            "20",
            "44",
            "62",
            "125",
            "250",
            "500",
            "1000",
            "2000",
            "4000",
            "8000",
            "16000"});
            this.cboSampleRate.Location = new System.Drawing.Point(389, 47);
            this.cboSampleRate.Name = "cboSampleRate";
            this.cboSampleRate.Size = new System.Drawing.Size(70, 21);
            this.cboSampleRate.TabIndex = 18;
            this.cboSampleRate.SelectedIndexChanged += new System.EventHandler(this.cboSampleRate_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 367);
            this.Controls.Add(this.cboSampleRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudDb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMicLvl2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMics);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMicLvl);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.nudDiscard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDiscard;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Timer tmrMinTime;
        private System.Windows.Forms.Label lblMicLvl;
        private System.Windows.Forms.Timer tmrSecondsSince;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cboMics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMicLvl2;
        private System.Windows.Forms.NumericUpDown nudDb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSampleRate;
    }
}

