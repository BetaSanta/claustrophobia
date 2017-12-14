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
    public partial class T_L4 : Form
    {
        public T_L4()
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
            LoadFonts.loadFontsForForm(label3, 72);


            Cursor.Hide();
        }

        int count = 1, index = 0;
        bool f = false, f2 = false;

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

            //диалог с пользователем
            if (e.KeyCode == Keys.Enter)
            {
                switch (count)
                {
                    case 1:
                        count++;
                        label1.Visible = false;
                        label2.Visible = true;
                        pictureBox7.Visible = true;
                        break;
                    case 2:
                        count++;
                        label2.Text = "Пройди этот простенький уровень";
                        pictureBox1.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox8.Visible = true;
                        pictureBox9.Visible = true;
                        pictureBox10.Visible = true;
                        timer1.Enabled = true;
                        break;
                    case 3:
                        if (f)
                        {
                            count++;
                            label3.Visible = false;
                            Cursor.Show();
                            panel1.Visible = true;
                        }
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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            T_L4 T_L4 = new T_L4();
            timer1.Stop();
            T_L4.ShowDialog();
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (f2 == false)
            {
                Cursor.Show();
                panel4.Width = panel4.Width + 40;
                if (panel4.Width == 600)
                {
                    timer2.Stop();
                    f2 = true;
                }
            }
            else
            {
                Cursor.Hide();
                panel4.Width = panel4.Width - 40;
                if (panel4.Width == 0)
                {
                    timer2.Stop();
                    f2 = false;
                }
            }
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

            block.methodRight2(pictureBox1, player);
            block.methodLeft2(pictureBox1, player);
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

            block.methodTop(pictureBox8, player);
            block.methodHead(pictureBox8, player);

            block.methodTop(pictureBox9, player);
            block.methodHead(pictureBox9, player);

            block.methodTop(pictureBox10, player);
            block.methodHead(pictureBox10, player);


            //проверка дошёл ли персонаж до двери
            if (player.Left < pictureBox7.Right && player.Right > pictureBox7.Left && player.Location.Y <= pictureBox7.Bottom)
            {
                label2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                player.Visible = false;
                player.Top = 700;
                label3.Visible = true;
                f = true;
            }
        }


    }
}
