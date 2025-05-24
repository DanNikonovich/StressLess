using System;
using System.Windows.Forms;
using WMPLib;

namespace StressLess
{
    public partial class Form4 : Form
    {
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;

        Form mainForm;
        public Form4(Form mainForm)
        { InitializeComponent();
            this.mainForm = mainForm;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(audioPlayer)).BeginInit();
            this.Controls.Add(audioPlayer);
            ((System.ComponentModel.ISupportInitialize)(audioPlayer)).EndInit();
            audioPlayer.Visible = false;  }
        private void pictureBox1_Click(object sender, EventArgs e)
        { axWindowsMediaPlayer1.Ctlcontrols.stop();
            mainForm.Show();      // Показать Form1
            this.Close();}
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   string selected = listBox1.SelectedItem.ToString();
            string videoPath = "";
            string audioPath = "";
            switch (selected)
            {    case "Поза ваджрасана":
                    videoPath = @"Video\\video1.mp4";
                    audioPath = @"Audio\\meditation-spiritual-music.mp3";
                    break;
                case "Поза лодочка":
                    videoPath = @"Video\\video2.mp4";
                    audioPath = @"Audio\\meditation-relaxing-music.mp3";
                    break;
                case "Поза планка":
                    videoPath = @"Video\\video3.mp4";
                    audioPath = @"Audio\\calm-soul-meditation.mp3";
                    break;
                case "Поза кузнечика":
                    videoPath = @"Video\\video4.mp4";
                    audioPath = @"Audio\\clearing-negative-energy.mp3";
                    break;
                case "Поза лотоса":
                    videoPath = @"Video\\video5.mp4";
                    audioPath = @"Audio\\serenity-waves-zen-meditation.mp3";
                    break;
                case "Поза собака мордой вниз":
                    videoPath = @"Video\\video6.mp4";
                    audioPath = @"Audio\\deep-meditation-vibes.mp3";
                    break; }
            // Запуск видео
            if (!string.IsNullOrEmpty(videoPath))
            {   axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                axWindowsMediaPlayer1.Ctlcontrols.play(); }
            // Запуск звука
            if (!string.IsNullOrEmpty(audioPath))
            {    audioPlayer.URL = audioPath;
                audioPlayer.settings.setMode("loop", true);
                audioPlayer.Ctlcontrols.play();} }}}
