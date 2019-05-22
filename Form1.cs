using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace loopingsound_Good
{
    public partial class Form1 : Form
    {
        SoundPlayer Player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void playLoopingButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Note: You may need to change the location specified based on
                // the sounds loaded on your computer.
                this.Player.SoundLocation = @"c:\users\mohamed\documents\visual studio 2010\Projects\loopingsound\loopingsound\_-_-_MP3_MP3.wav";
                this.Player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void stopPlayingButton_Click(object sender, EventArgs e)
        {
            this.Player.Stop();
        }


        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btnOpenAudioFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((openFileDialog.OpenFile()) != null)
                {
                    string strfilename = openFileDialog.FileName;
                    Player.SoundLocation = strfilename;
                    Player.PlayLooping();

                }
            }
            //timer1.Interval = 1;
            //timer1.Tick += timer_Tick;
            //timer1.Start();
        }

        
        //void timer_Tick(object sender, EventArgs e)
        //{
        //    if ((openFileDialog.OpenFile()) != null)
        //        label1.Text = String.Format("{0} / {1}", Player.LoadTimeout.ToString(@"mm\:ss"), Player.TimeSpan.ToString(@"mm\:ss"));
        //    else
        //        label1.Text = "No file selected...";
        //}
    }
}
