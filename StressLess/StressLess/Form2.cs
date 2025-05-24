using System;
using System.Windows.Forms;

namespace StressLess
{
    public partial class Form2 : Form
    {
        private AxWMPLib.AxWindowsMediaPlayer audioPlayer;
        private int currentIndex = 0;
        private Timer timer;

        public Form2()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            audioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(audioPlayer)).BeginInit();
            audioPlayer.Visible = false; // чтобы не мешал интерфейсу
            this.Controls.Add(audioPlayer);
            ((System.ComponentModel.ISupportInitialize)(audioPlayer)).EndInit();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            audioPlayer.URL = @"Audio\\gong.mp3"; // путь к файлу
            audioPlayer.settings.setMode("loop", true); // если нужно зациклить
            audioPlayer.Ctlcontrols.play();

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (currentIndex)
            {
                case 1: pictureBox1.Visible = true; break;
                case 2: pictureBox2.Visible = true; break;
                case 3: pictureBox4.Visible = true; break;
                case 4: pictureBox3.Visible = true; break;
                case 5: pictureBox5.Visible = true; break;
                case 6: pictureBox6.Visible = true; break;
                case 7: pictureBox7.Visible = true; break;
            }

            currentIndex++;

            if (currentIndex > 8)
            {
                timer.Stop();
                ShowMainForm();
            }
        }

        private void ShowMainForm()
        {
            audioPlayer.Ctlcontrols.stop();
            Form1 mainForm = new Form1(this);
            mainForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
