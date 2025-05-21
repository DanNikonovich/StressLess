using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace StressLess
{public partial class Form3 : Form
    {   private Timer timer;
        private int imageIndex = 0;
        private string[] imagePaths;
        private Timer breathingTimer;
        private int breathingIndex = 0;
        private string[] breathingCycle;
        private Timer customCycleTimer;
        private int customCycleStep = 0;
        private int elapsedTime = 0;
        Form mainForm;
        public Form3(Form mainForm)
        {   InitializeComponent(); this.mainForm = mainForm;
            // Загружаем пути изображений (убираем двойной слеш)
            imagePaths = new string[]
            {   Path.Combine("Breath", "Inhale.png"), Path.Combine("Breath", "Outhale.png"),};      
            // Инициализируем и настраиваем таймер
            timer = new Timer(); timer.Interval = 7000; // 7 секунд
            timer.Tick += Timer_Tick;}
        private void button1_Click(object sender, EventArgs e)
        {   // Останавливаем таймер дыхания, если он запущен
            if (breathingTimer != null && breathingTimer.Enabled) {   breathingTimer.Stop();}
            // Очищаем панель и запускаем основной таймер
            panel1.Controls.Clear();timer.Start();}
        private void pictureBox1_Click(object sender, EventArgs e)
        {   mainForm.Show();      // Показать Form3
            this.Close();}
        private void button2_Click(object sender, EventArgs e)
        {   if (timer != null && timer.Enabled) timer.Stop();
            if (breathingTimer != null && breathingTimer.Enabled) breathingTimer.Stop();
            if (customCycleTimer != null && customCycleTimer.Enabled) customCycleTimer.Stop();
            panel1.Controls.Clear(); panel1.BackgroundImage = null; label1.Text = ""; string filePath = @"Rules\\1.txt";
            if (File.Exists(filePath)) {   string content = File.ReadAllText(filePath);
                Label textLabel = new Label {   Text = content, AutoSize = true, MaximumSize = new Size(panel1.Width - 10, 0), Location = new Point(5, 5) };
                panel1.Controls.Add(textLabel);}
            else { MessageBox.Show("Файл не найден.");}}
        private void button4_Click(object sender, EventArgs e)
        {   if (timer != null && timer.Enabled) timer.Stop();
            if (breathingTimer != null && breathingTimer.Enabled) breathingTimer.Stop();
            if (customCycleTimer != null && customCycleTimer.Enabled) customCycleTimer.Stop();
            panel1.Controls.Clear(); panel1.BackgroundImage = null; label1.Text = ""; string filePath = @"Rules\\2.txt";
            if (File.Exists(filePath)) {   string content = File.ReadAllText(filePath);
                Label textLabel = new Label {    Text = content, AutoSize = true, MaximumSize = new Size(panel1.Width - 10, 0), Location = new Point(5, 5)};
                panel1.Controls.Add(textLabel); }
            else {MessageBox.Show("Файл не найден.");}}
        private void button6_Click(object sender, EventArgs e)
        {   if (timer != null && timer.Enabled) timer.Stop();
            if (breathingTimer != null && breathingTimer.Enabled) breathingTimer.Stop();
            if (customCycleTimer != null && customCycleTimer.Enabled) customCycleTimer.Stop();
            panel1.Controls.Clear(); panel1.BackgroundImage = null; label1.Text = ""; string filePath = @"Rules\\3.txt";
            if (File.Exists(filePath)) {   string content = File.ReadAllText(filePath);  Label textLabel = new Label {   Text = content, AutoSize = true, MaximumSize = new Size(panel1.Width - 10, 0), Location = new Point(5, 5)}; panel1.Controls.Add(textLabel);}
            else { MessageBox.Show("Файл не найден.");}}
        private void Timer_Tick(object sender, EventArgs e)
        {   if (imagePaths.Length == 0) return; try {string imagePath = imagePaths[imageIndex];
                if (File.Exists(imagePath)) {  panel1.BackgroundImage = Image.FromFile(imagePath); SetBreathingText(imagePath); panel1.BackgroundImageLayout = ImageLayout.Stretch; imageIndex = (imageIndex + 1) % imagePaths.Length;}
                else{ MessageBox.Show($"Файл не найден: {imagePath}"); timer.Stop();}}
            catch (Exception ex) { MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);timer.Stop();}}
        private void button3_Click(object sender, EventArgs e)
        {   // Останавливаем основной таймер, если он активен
            if (timer != null && timer.Enabled) { timer.Stop(); }
            // Очищаем панель
            panel1.Controls.Clear(); breathingIndex = 0;
            // Инициализируем массив, если ещё не инициализирован
            if (breathingCycle == null || breathingCycle.Length == 0) { breathingCycle = new string[]{ Path.Combine("Breath", "Inhale.png"), Path.Combine("Breath", "Vector.png"), Path.Combine("Breath", "Outhale.png"), Path.Combine("Breath", "Vector.png")};}
            // Создаем таймер, если он ещё не создан
            if (breathingTimer == null) {    breathingTimer = new Timer(); breathingTimer.Interval = 4000; breathingTimer.Tick += BreathingTimer_Tick;} breathingTimer.Start();}
        private void BreathingTimer_Tick(object sender, EventArgs e)
        { try {  if (breathingCycle.Length == 0) return; string imagePath = breathingCycle[breathingIndex];
                if (File.Exists(imagePath)) { panel1.BackgroundImage = Image.FromFile(imagePath); SetBreathingText(imagePath); panel1.BackgroundImageLayout = ImageLayout.Stretch; breathingIndex = (breathingIndex + 1) % breathingCycle.Length;}
                else {   MessageBox.Show($"Файл не найден: {imagePath}"); breathingTimer.Stop();}}
            catch (Exception ex) {   MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message); breathingTimer.Stop();}}
        private void button5_Click(object sender, EventArgs e)
        {   // Останавливаем все предыдущие таймеры
            if (timer != null && timer.Enabled) timer.Stop();
            if (breathingTimer != null && breathingTimer.Enabled) breathingTimer.Stop();
            // Сброс переменных
            panel1.Controls.Clear(); elapsedTime = 0; customCycleStep = 0;
            if (customCycleTimer == null) {   customCycleTimer = new Timer(); customCycleTimer.Tick += CustomCycleTimer_Tick;}
            // Старт с 1-секундного интервала
            customCycleTimer.Interval = 1000; customCycleTimer.Start();}
        private void CustomCycleTimer_Tick(object sender, EventArgs e)
        {   string inhale = Path.Combine("Breath", "Inhale.png");
            string outhale = Path.Combine("Breath", "Outhale.png");
            string vector = Path.Combine("Breath", "Vector.png");
            try {   // Первая фаза — 30 секунд, переключение каждые 1 сек
                if (elapsedTime < 30) {   string imagePath = (elapsedTime % 2 == 0) ? inhale : outhale;
                    if (File.Exists(imagePath)) {   panel1.BackgroundImage = Image.FromFile(imagePath); SetBreathingText(imagePath); panel1.BackgroundImageLayout = ImageLayout.Stretch;} elapsedTime++;}
                else {   // Вторая фаза — 5 + 10 + 5 + 10 сек
                    string imagePath = ""; int interval = 1000;
                    switch (customCycleStep)
                    {   case 0: imagePath = inhale; interval = 5000; break;
                        case 1: imagePath = vector; interval = 10000; break;
                        case 2: imagePath = outhale; interval = 5000; break;
                        case 3: imagePath = vector; interval = 10000; break;}
                    if (File.Exists(imagePath)) {panel1.BackgroundImage = Image.FromFile(imagePath); panel1.BackgroundImageLayout = ImageLayout.Stretch;} customCycleStep++;
                    // После 4 шагов возвращаемся к началу
                    if (customCycleStep >= 4) {   customCycleStep = 0; elapsedTime = 0; interval = 1000; // Снова 1 секунда
                    } customCycleTimer.Interval = interval;}}
            catch (Exception ex) {MessageBox.Show("Ошибка при показе изображения: " + ex.Message); customCycleTimer.Stop();}}
        private void SetBreathingText(string imagePath) {   if (imagePath.EndsWith("Inhale.png")) {label1.Text = "Вдох";} else if (imagePath.EndsWith("Outhale.png")) {label1.Text = "Выдох";} else if (imagePath.EndsWith("Vector.png")) {label1.Text = "Задержите дыхание";} else {label1.Text = "";}}}}