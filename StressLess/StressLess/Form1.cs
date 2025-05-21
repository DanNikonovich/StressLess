using System;
using System.Drawing;
using System.Windows.Forms;

namespace StressLess
{
    public partial class Form1 : Form
    {
        Form mainForm;

        public Form1(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Video\\aquarium.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();      // Показать Form3
            this.Hide();       // Скрыть текущую форму (если нужно)
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form2 Load = new Form2();
            Load.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();      // Показать Form4
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                string helpFilePath = @"Help.chm"; // путь к файлу справки

                if (System.IO.File.Exists(helpFilePath))
                {
                    Help.ShowHelp(this, System.IO.Path.GetFullPath(helpFilePath));
                }
                else
                {
                    MessageBox.Show("Файл справки не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии справки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 