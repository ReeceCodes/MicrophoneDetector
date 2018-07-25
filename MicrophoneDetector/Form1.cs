using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrophoneDetector
{
    public partial class Form1 : Form
    {
        public int CurrentSilenceTime;
        WaveIn waveIn;
        //public int SampleRate = 8000; //may need to adjust sample rate to not get as frequently to be visually useful for adjusting thresholds


        public Form1()
        {
            InitializeComponent();

            tmrMinTime.Interval = int.Parse(nudTime.Value.ToString()) * 1000;

            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                //  lblDetails.Text += "Device " + waveInDevice + ": " + deviceInfo.ProductName + ", " + deviceInfo.Channels + " channels" + Environment.NewLine;
                cboMics.Items.Add(waveInDevice + " : " + deviceInfo.ProductName);
            }

            cboMics.SelectedIndex = 0;
            cboSampleRate.SelectedIndex = 9;

            GetData();

        }

        public void waveIn_DataAvailable(object sender, WaveInEventArgs args)
        {
            //wav in
            float max = 0;
            // interpret as 16 bit audio
            for (int index = 0; index < args.BytesRecorded; index += 2)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) |
                                        args.Buffer[index + 0]);
                // to floating point
                float sample32 = sample / 32768f;
                // absolute value 
                if (sample32 < 0)
                {
                    sample32 = -sample32;
                }
                // is this the max value?
                if (sample32 > max)
                {
                    max = sample32;
                }
            }

            //////wasapi in           
            //var buffer = new WaveBuffer(args.Buffer);
            //// interpret as 32 bit floating point audio
            //for (int index = 0; index < args.BytesRecorded / 4; index++)
            //{
            //    var sample = buffer.ShortBuffer[index];

            //    float sample2 = sample / 32768f;

            //    // absolute value 
            //    if (sample < 0)
            //    {
            //        sample2 = -sample2;
            //    }
            //    // is this the max value?
            //    if (sample > max)
            //    {
            //        max = (int)(sample2 * 100);
            //    }
            //}

            //ambient volume, unpreventable noise, should be lower than voice but higher than fan noise (adjustable)
            if (max < (float)nudDiscard.Value)
            {
                return;
            }

            //minimum noise to count as talking
            if (max > (float)nudDb.Value)
            {
                lblMicLvl.Text = max.ToString();

                tmrMinTime.Stop();
                tmrSecondsSince.Stop();
                CurrentSilenceTime = (int)nudTime.Value;
                lblDetails.Text = "";
                lblDetails.BackColor = Color.Gray;
                tmrMinTime.Interval = tmrMinTime.Interval = int.Parse(nudTime.Value.ToString()) * 1000;
                tmrMinTime.Start();
            }
            else
            {
                if (nudDiscard.Value == 0)
                {
                    lblMicLvl2.Text = max.ToString() + Environment.NewLine + "everything above threshold";
                }
                else
                {
                    lblMicLvl2.Text = max.ToString() + Environment.NewLine + "% " + Math.Round((((float)nudDiscard.Value / max) * 100)) + " difference between threshold and capture.";
                }                
            }
        }

        private void tmrMinTime_Tick(object sender, EventArgs e)
        {
            lblDetails.BackColor = Color.Red;
            lblDetails.Text = CurrentSilenceTime.ToString() + " seconds of silence";
            tmrSecondsSince.Start();
        }

        private void tmrSecondsSince_Tick_1(object sender, EventArgs e)
        {
            lblDetails.Text = CurrentSilenceTime.ToString() + " seconds of silence";
            CurrentSilenceTime++;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            waveIn.StopRecording();
            tmrSecondsSince.Stop();
            tmrMinTime.Stop();
            lblDetails.Text = "";
            lblDetails.BackColor = Color.Gray;
            lblMicLvl.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GetData();
            CurrentSilenceTime = (int)nudTime.Value;

            tmrMinTime.Start();
        }

        private void cboMics_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.PerformClick();
        }

        private void GetData()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
            }

            waveIn = new WaveIn();
            waveIn.DeviceNumber = int.Parse(cboMics.SelectedItem.ToString().Split(':')[0].Trim());
            waveIn.DataAvailable += waveIn_DataAvailable;
            int sampleRate = int.Parse(cboSampleRate.SelectedItem.ToString()); //SampleRate; // 8 kHz 
            int channels = 1; // mono
            waveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            waveIn.StartRecording();
        }

        private void cboSampleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
