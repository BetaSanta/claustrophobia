using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claustrophobia
{
    public partial class L1_L8 : Form
    {
        public L1_L8()
        {
            InitializeComponent();
            LoadFonts.LoadFont();
            button1.Font = new Font(LoadFonts.font.Families[0], 48);
            button2.Font = new Font(LoadFonts.font.Families[0], 48);
            LoadFonts.loadFontsForForm(label1, 72);
            LoadFonts.loadFontsForForm(label14, 72);
            LoadFonts.loadFontsForForm(label15, 48);
            LoadFonts.loadFontsForForm(label16, 48);
            LoadFonts.loadFontsForForm(label17, 48);
            LoadFonts.loadFontsForForm(label18, 72);
            LoadFonts.loadFontsForForm(label19, 64);
            LoadFonts.loadFontsForForm(label2, 72);


            Cursor.Hide();
        }

        int count = 0, index = 0;
        bool f2 = false;
        DateTime date;

        private void T_L4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                PlayerClass.right = true;
                index = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                PlayerClass.left = true;
                index = 0;
            }

            if (PlayerClass.jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    PlayerClass.jump = true;
                    PlayerClass.Force = PlayerClass.G;
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (!f2)
                    timer1.Stop();
                else
                    timer1.Start();

                timer3.Start();
            }

            //диалог с пользователем
            if (e.KeyCode == Keys.Enter)
            {
                count++;
                switch (count)
                {
                    case 1:
                        label1.Visible = false;
                        label2.Visible = true;
                        pictureBox1.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                        EndLvl.Visible = true;
                        pictureBox15.Visible = true;
                        pictureBox19.Visible = true;
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void T_L4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                PlayerClass.right = false;
                player.Image = Properties.Resources.PlayerStop;
            }

            if (e.KeyCode == Keys.Left)
            {
                PlayerClass.left = false;
                player.Image = Properties.Resources.PlayerStop;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgressClass.progressMass[0, 7] = 1;
            ProgressClass.timeMass[0, 7] = date.ToString("m:ss");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgressClass.progressMass[0, 7] = 1;
            ProgressClass.timeMass[0, 7] = date.ToString("m:ss");

            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            label2.Text = date.ToString("m:ss");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            timer3.Start();
            timer1.Start();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            L1_L8 LF = new L1_L8();
            timer1.Stop();
            LF.ShowDialog();
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (f2 == false)
            {
                Cursor.Show();
                panel4.Width = panel4.Width + 40;
                if (panel4.Width == 600)
                {
                    timer3.Stop();
                    f2 = true;
                }
            }
            else
            {
                Cursor.Hide();
                panel4.Width = panel4.Width - 40;
                if (panel4.Width == 0)
                {
                    timer3.Stop();
                    f2 = false;
                }
            }
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 52);
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 48);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            if (PlayerClass.right == true && index % 5 == 0)
            {
                player.Image = Properties.Resources.PlayerRight;
            }
            if (PlayerClass.left == true && index % 5 == 0)
            {
                player.Image = Properties.Resources.PlayerLeft;
            }

            block.methodLeft(pictureBox15, player);
            block.methodRight(pictureBox15, player);
            block.methodLeft2(pictureBox2, player);
            block.methodRight2(pictureBox2, player);
            block.methodLeft2(pictureBox3, player);
            block.methodRight2(pictureBox3, player);

            if (PlayerClass.right == true)
            {
                player.Left += 5;
            }

            if (PlayerClass.left == true)
            {
                player.Left -= 5;
            }

            if (PlayerClass.jump == true)
            {
                player.Top -= PlayerClass.Force;
                PlayerClass.Force -= 1;
            }

            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;
                PlayerClass.jump = false;
            }
            else
            {
                player.Top += 5;
            }


            block.methodTop(pictureBox1, player);
            block.methodHead(pictureBox1, player);
            block.methodTop(pictureBox4, player);
            block.methodHead(pictureBox4, player);
            block.methodTop(pictureBox5, player);
            block.methodHead(pictureBox5, player);
            block.methodTop(pictureBox6, player);
            block.methodHead(pictureBox6, player);
            block.methodTop(pictureBox7, player);
            block.methodHead(pictureBox7, player);
            block.methodTop(pictureBox15, player);
            block.methodHead(pictureBox15, player);
            block.methodTop(pictureBox19, player);
            block.methodHead(pictureBox19, player);

            //проверка дошёл ли персонаж до двери
            if (player.Left < EndLvl.Right && player.Right > EndLvl.Left && player.Location.Y <= EndLvl.Bottom)
            {
                label2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                EndLvl.Visible = false;
                pictureBox15.Visible = false;
                pictureBox19.Visible = false;
                player.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                panel1.Visible = true;
                Cursor.Show();
            }
        }

    }
}