using System.Data;
using System.IO;
namespace Игра_на_внимательность_51
{
    public partial class Form1 : Form
    {
        DateTime date;
        public int number = 0;
        public int zakr = 0;
        string str = "";
        DateTime stopWatch = new DateTime();
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.Gainsboro;
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            number = 0;
            date = DateTime.Now;
            timer1.Tick += new EventHandler(timer1_Tick);
            but_play();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;

            stopWatch = stopWatch.AddTicks(tick);
            toolStripLabel5.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            toolStripLabel5.Text = "00:00:00:00";
            toolStripLabel6.Text = "";
            number = 0;
            but_stop();
            stop_zakr();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if(number + 1 == 1 & zakr == 1)
            {
                but1.BackColor = Color.Green;
                number = 1;
                toolStripLabel6.Text = "1";
                toolStripLabel7.Text = "";
            }
            else
            {
                if(number + 1 == 1)
                {
                    number = 1;
                    toolStripLabel6.Text = "1";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }
        private void but_play()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
            }
        }
        private void but_stop()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }
        }
        private void stop_zakr()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = SystemColors.Control;
                }
            }
        }

        private void закрашиваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(zakr == 1)
            {
                toolStripLabel9.Text = "Off";
                zakr = 0;
            }
            else
            {
                if (zakr == 0)
                {
                    toolStripLabel9.Text = "On";
                    zakr = 1;
                }
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (number + 1 == 2 & zakr == 1)
            {
                but2.BackColor = Color.Green;
                number = 2;
                toolStripLabel6.Text = "2";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 2)
                {
                    number = 2;
                    toolStripLabel6.Text = "2";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (number + 1 == 3 & zakr == 1)
            {
                but3.BackColor = Color.Green;
                number = 3;
                toolStripLabel6.Text = "3";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 3)
                {
                    number = 3;
                    toolStripLabel6.Text = "3";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (number + 1 == 4 & zakr == 1)
            {
                but4.BackColor = Color.Green;
                number = 4;
                toolStripLabel6.Text = "4";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 4)
                {
                    number = 4;
                    toolStripLabel6.Text = "4";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (number + 1 == 5 & zakr == 1)
            {
                but5.BackColor = Color.Green;
                number = 5;
                toolStripLabel6.Text = "5";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 5)
                {
                    number = 5;
                    toolStripLabel6.Text = "5";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (number + 1 == 6 & zakr == 1)
            {
                but6.BackColor = Color.Green;
                number = 6;
                toolStripLabel6.Text = "6";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 6)
                {
                    number = 6;
                    toolStripLabel6.Text = "6";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (number + 1 == 7 & zakr == 1)
            {
                but7.BackColor = Color.Green;
                number = 7;
                toolStripLabel6.Text = "7";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 7)
                {
                    number = 7;
                    toolStripLabel6.Text = "7";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (number + 1 == 8 & zakr == 1)
            {
                but8.BackColor = Color.Green;
                number = 8;
                toolStripLabel6.Text = "8";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 8)
                {
                    number = 8;
                    toolStripLabel6.Text = "8";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (number + 1 == 9 & zakr == 1)
            {
                but9.BackColor = Color.Green;
                number = 9;
                toolStripLabel6.Text = "9";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 9)
                {
                    number = 9;
                    toolStripLabel6.Text = "9";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but10_Click(object sender, EventArgs e)
        {
            if (number + 1 == 10 & zakr == 1)
            {
                but10.BackColor = Color.Green;
                number = 10;
                toolStripLabel6.Text = "10";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 10)
                {
                    number = 10;
                    toolStripLabel6.Text = "10";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but11_Click(object sender, EventArgs e)
        {
            if (number + 1 == 11 & zakr == 1)
            {
                but11.BackColor = Color.Green;
                number = 11;
                toolStripLabel6.Text = "11";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 11)
                {
                    number = 11;
                    toolStripLabel6.Text = "11";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but12_Click(object sender, EventArgs e)
        {
            if (number + 1 == 12 & zakr == 1)
            {
                but12.BackColor = Color.Green;
                number = 12;
                toolStripLabel6.Text = "12";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 12)
                {
                    number = 12;
                    toolStripLabel6.Text = "12";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but13_Click(object sender, EventArgs e)
        {
            if (number + 1 == 13 & zakr == 1)
            {
                but13.BackColor = Color.Green;
                number = 13;
                toolStripLabel6.Text = "13";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 13)
                {
                    number = 13;
                    toolStripLabel6.Text = "13";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but14_Click(object sender, EventArgs e)
        {
            if (number + 1 == 14 & zakr == 1)
            {
                but14.BackColor = Color.Green;
                number = 14;
                toolStripLabel6.Text = "14";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 14)
                {
                    number = 14;
                    toolStripLabel6.Text = "14";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but15_Click(object sender, EventArgs e)
        {
            if (number + 1 == 15 & zakr == 1)
            {
                but15.BackColor = Color.Green;
                number = 15;
                toolStripLabel6.Text = "15";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 15)
                {
                    number = 15;
                    toolStripLabel6.Text = "15";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but16_Click(object sender, EventArgs e)
        {
            if (number + 1 == 16 & zakr == 1)
            {
                but16.BackColor = Color.Green;
                number = 16;
                toolStripLabel6.Text = "16";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 16)
                {
                    number = 16;
                    toolStripLabel6.Text = "16";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but17_Click(object sender, EventArgs e)
        {
            if (number + 1 == 17 & zakr == 1)
            {
                but17.BackColor = Color.Green;
                number = 17;
                toolStripLabel6.Text = "17";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 17)
                {
                    number = 17;
                    toolStripLabel6.Text = "17";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but18_Click(object sender, EventArgs e)
        {
            if (number + 1 == 18 & zakr == 1)
            {
                but18.BackColor = Color.Green;
                number = 18;
                toolStripLabel6.Text = "18";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 18)
                {
                    number = 18;
                    toolStripLabel6.Text = "18";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but19_Click(object sender, EventArgs e)
        {
            if (number + 1 == 19 & zakr == 1)
            {
                but19.BackColor = Color.Green;
                number = 19;
                toolStripLabel6.Text = "19";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 19)
                {
                    number = 19;
                    toolStripLabel6.Text = "19";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but20_Click(object sender, EventArgs e)
        {
            if (number + 1 == 20 & zakr == 1)
            {
                but20.BackColor = Color.Green;
                number = 20;
                toolStripLabel6.Text = "20";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 20)
                {
                    number = 20;
                    toolStripLabel6.Text = "20";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but21_Click(object sender, EventArgs e)
        {
            if (number + 1 == 21 & zakr == 1)
            {
                but21.BackColor = Color.Green;
                number = 21;
                toolStripLabel6.Text = "21";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 21)
                {
                    number = 21;
                    toolStripLabel6.Text = "21";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but22_Click(object sender, EventArgs e)
        {
            if (number + 1 == 22 & zakr == 1)
            {
                but22.BackColor = Color.Green;
                number = 22;
                toolStripLabel6.Text = "22";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 22)
                {
                    number = 22;
                    toolStripLabel6.Text = "22";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but23_Click(object sender, EventArgs e)
        {
            if (number + 1 == 23 & zakr == 1)
            {
                but23.BackColor = Color.Green;
                number = 23;
                toolStripLabel6.Text = "23";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 23)
                {
                    number = 23;
                    toolStripLabel6.Text = "23";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but24_Click(object sender, EventArgs e)
        {
            if (number + 1 == 24 & zakr == 1)
            {
                but24.BackColor = Color.Green;
                number = 24;
                toolStripLabel6.Text = "24";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 24)
                {
                    number = 24;
                    toolStripLabel6.Text = "24";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but25_Click(object sender, EventArgs e)
        {
            if (number + 1 == 25 & zakr == 1)
            {
                but25.BackColor = Color.Green;
                number = 25;
                toolStripLabel6.Text = "25";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 25)
                {
                    number = 25;
                    toolStripLabel6.Text = "25";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but26_Click(object sender, EventArgs e)
        {
            if (number + 1 == 26 & zakr == 1)
            {
                but26.BackColor = Color.Green;
                number = 26;
                toolStripLabel6.Text = "26";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 26)
                {
                    number = 26;
                    toolStripLabel6.Text = "26";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but27_Click(object sender, EventArgs e)
        {
            if (number + 1 == 27 & zakr == 1)
            {
                but27.BackColor = Color.Green;
                number = 27;
                toolStripLabel6.Text = "27";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 27)
                {
                    number = 27;
                    toolStripLabel6.Text = "27";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but28_Click(object sender, EventArgs e)
        {
            if (number + 1 == 28 & zakr == 1)
            {
                but28.BackColor = Color.Green;
                number = 28;
                toolStripLabel6.Text = "28";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 28)
                {
                    number = 28;
                    toolStripLabel6.Text = "28";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but29_Click(object sender, EventArgs e)
        {
            if (number + 1 == 29 & zakr == 1)
            {
                but29.BackColor = Color.Green;
                number = 29;
                toolStripLabel6.Text = "29";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 29)
                {
                    number = 29;
                    toolStripLabel6.Text = "29";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but30_Click(object sender, EventArgs e)
        {
            if (number + 1 == 30 & zakr == 1)
            {
                but30.BackColor = Color.Green;
                number = 30;
                toolStripLabel6.Text = "30";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 30)
                {
                    number = 30;
                    toolStripLabel6.Text = "30";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but31_Click(object sender, EventArgs e)
        {
            if (number + 1 == 31 & zakr == 1)
            {
                but31.BackColor = Color.Green;
                number = 31;
                toolStripLabel6.Text = "31";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 31)
                {
                    number = 31;
                    toolStripLabel6.Text = "31";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but32_Click(object sender, EventArgs e)
        {
            if (number + 1 == 32 & zakr == 1)
            {
                but32.BackColor = Color.Green;
                number = 32;
                toolStripLabel6.Text = "32";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 32)
                {
                    number = 32;
                    toolStripLabel6.Text = "32";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but33_Click(object sender, EventArgs e)
        {
            if (number + 1 == 33 & zakr == 1)
            {
                but33.BackColor = Color.Green;
                number = 33;
                toolStripLabel6.Text = "33";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 33)
                {
                    number = 33;
                    toolStripLabel6.Text = "33";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but34_Click(object sender, EventArgs e)
        {
            if (number + 1 == 34 & zakr == 1)
            {
                but34.BackColor = Color.Green;
                number = 34;
                toolStripLabel6.Text = "34";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 34)
                {
                    number = 34;
                    toolStripLabel6.Text = "34";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but35_Click(object sender, EventArgs e)
        {
            if (number + 1 == 35 & zakr == 1)
            {
                but35.BackColor = Color.Green;
                number = 35;
                toolStripLabel6.Text = "35";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 35)
                {
                    number = 35;
                    toolStripLabel6.Text = "35";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but36_Click(object sender, EventArgs e)
        {
            if (number + 1 == 36 & zakr == 1)
            {
                but36.BackColor = Color.Green;
                number = 36;
                toolStripLabel6.Text = "36";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 36)
                {
                    number = 36;
                    toolStripLabel6.Text = "36";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but37_Click(object sender, EventArgs e)
        {
            if (number + 1 == 37 & zakr == 1)
            {
                but37.BackColor = Color.Green;
                number = 37;
                toolStripLabel6.Text = "37";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 37)
                {
                    number = 37;
                    toolStripLabel6.Text = "37";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but38_Click(object sender, EventArgs e)
        {
            if (number + 1 == 38 & zakr == 1)
            {
                but38.BackColor = Color.Green;
                number = 38;
                toolStripLabel6.Text = "38";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 38)
                {
                    number = 38;
                    toolStripLabel6.Text = "38";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but39_Click(object sender, EventArgs e)
        {
            if (number + 1 == 39 & zakr == 1)
            {
                but39.BackColor = Color.Green;
                number = 39;
                toolStripLabel6.Text = "39";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 39)
                {
                    number = 39;
                    toolStripLabel6.Text = "39";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but40_Click(object sender, EventArgs e)
        {
            if (number + 1 == 40 & zakr == 1)
            {
                but40.BackColor = Color.Green;
                number = 40;
                toolStripLabel6.Text = "40";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 40)
                {
                    number = 40;
                    toolStripLabel6.Text = "40";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but41_Click(object sender, EventArgs e)
        {
            if (number + 1 == 41 & zakr == 1)
            {
                but41.BackColor = Color.Green;
                number = 41;
                toolStripLabel6.Text = "41";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 41)
                {
                    number = 41;
                    toolStripLabel6.Text = "41";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but42_Click(object sender, EventArgs e)
        {
            if (number + 1 == 42 & zakr == 1)
            {
                but42.BackColor = Color.Green;
                number = 42;
                toolStripLabel6.Text = "42";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 42)
                {
                    number = 42;
                    toolStripLabel6.Text = "42";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but43_Click(object sender, EventArgs e)
        {
            if (number + 1 == 43 & zakr == 1)
            {
                but43.BackColor = Color.Green;
                number = 43;
                toolStripLabel6.Text = "43";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 43)
                {
                    number = 43;
                    toolStripLabel6.Text = "43";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but44_Click(object sender, EventArgs e)
        {
            if (number + 1 == 44 & zakr == 1)
            {
                but44.BackColor = Color.Green;
                number = 44;
                toolStripLabel6.Text = "44";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 44)
                {
                    number = 44;
                    toolStripLabel6.Text = "44";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but45_Click(object sender, EventArgs e)
        {
            if (number + 1 == 45 & zakr == 1)
            {
                but45.BackColor = Color.Green;
                number = 45;
                toolStripLabel6.Text = "45";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 45)
                {
                    number = 45;
                    toolStripLabel6.Text = "45";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but46_Click(object sender, EventArgs e)
        {
            if (number + 1 == 46 & zakr == 1)
            {
                but46.BackColor = Color.Green;
                number = 46;
                toolStripLabel6.Text = "46";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 46)
                {
                    number = 46;
                    toolStripLabel6.Text = "46";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but47_Click(object sender, EventArgs e)
        {
            if (number + 1 == 47 & zakr == 1)
            {
                but47.BackColor = Color.Green;
                number = 47;
                toolStripLabel6.Text = "47";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 47)
                {
                    number = 47;
                    toolStripLabel6.Text = "47";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but48_Click(object sender, EventArgs e)
        {
            if (number + 1 == 48 & zakr == 1)
            {
                but48.BackColor = Color.Green;
                number = 48;
                toolStripLabel6.Text = "48";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 48)
                {
                    number = 48;
                    toolStripLabel6.Text = "48";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but49_Click(object sender, EventArgs e)
        {
            if (number + 1 == 49 & zakr == 1)
            {
                but49.BackColor = Color.Green;
                number = 49;
                toolStripLabel6.Text = "49";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 49)
                {
                    number = 49;
                    toolStripLabel6.Text = "49";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but50_Click(object sender, EventArgs e)
        {
            if (number + 1 == 50 & zakr == 1)
            {
                but50.BackColor = Color.Green;
                number = 50;
                toolStripLabel6.Text = "50";
                toolStripLabel7.Text = "";
            }
            else
            {
                if (number + 1 == 50)
                {
                    number = 50;
                    toolStripLabel6.Text = "50";
                    toolStripLabel7.Text = "";
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        private void but51_Click(object sender, EventArgs e)
        {
            if (number + 1 == 51 & zakr == 1)
            {
                but51.BackColor = Color.Green;
                number = 51;
                toolStripLabel6.Text = "";
                toolStripLabel7.Text = "";
                str = String.Format("{0:HH:mm:ss:ff}", stopWatch);
                timer1.Stop();
                MessageBox.Show("Поздравляем, вы прошли игру за" + str + "минуты");
                toolStripLabel5.Text = "00:00:00:00";
                number = 0;
                but_stop();
                stop_zakr();

            }
            else
            {
                if (number + 1 == 51)
                {
                    number = 51;
                    toolStripLabel6.Text = "";
                    toolStripLabel7.Text = "";
                    timer1.Stop();
                    toolStripLabel5.Text = "00:00:00:00";
                    number = 0;
                    but_stop();
                    stop_zakr();
                }
                else
                {
                    toolStripLabel7.Text = "Неправильно! Продолжайте искать следующее число по возрастанию.";
                }
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader($"database/1.txt");

            DataSet ds = new DataSet();

            ds.Tables.Add("Leaderboard");

            string header = sr.ReadLine();  

            string [] col = System.Text.RegularExpressions.Regex.Split(header, ",");

            for(int i = 0; i < col.Length; i++)
            {
                ds.Tables[0].Columns.Add(col[i]);
            }

            string row = sr.ReadLine();

            while (row != null)
            {
                string[] rvalue = System.Text.RegularExpressions.Regex.Split(row, ",");
                ds.Tables[0].Rows.Add(rvalue);
                row = sr.ReadLine();
            }

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}