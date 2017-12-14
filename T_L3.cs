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
    public partial class T_L3 : Form
    {
        public T_L3()
        {
            InitializeComponent();
            LoadFonts.LoadFont();
            button1.Font = new Font(LoadFonts.font.Families[0], 48);
            button2.Font = new Font(LoadFonts.font.Families[0], 48);
            LoadFonts.loadFontsForForm(label14, 72);
            LoadFonts.loadFontsForForm(label15, 48);
            LoadFonts.loadFontsForForm(label16, 48);
            LoadFonts.loadFontsForForm(label17, 48);
            LoadFonts.loadFontsForForm(label18, 72);
            LoadFonts.loadFontsForForm(label19, 64);
            LoadFonts.loadFontsForForm(label2, 64);
            LoadFonts.loadFontsForForm(label3, 64);
            LoadFonts.loadFontsForForm(label4, 64);
            LoadFonts.loadFontsForForm(label5, 64);
            LoadFonts.loadFontsForForm(label6, 64);
            LoadFonts.loadFontsForForm(label7, 64);
            LoadFonts.loadFontsForForm(label8, 64);
            LoadFonts.loadFontsForForm(label9, 72);


            Cursor.Hide();
            Select();
        }

        int index = 0;
        int count = 1;
        bool f = false, f2 = false;

        private void T_L1_KeyDown(object sender, KeyEventArgs e)
        {
            if (count == 3)
            {
                if (e.KeyCode == Keys.Right)
                {
                    PlayerClass.right = true;
                    index = 0;
                }

            }

            if (count == 4)  
            {
                if (PlayerClass.jump != true)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        PlayerClass.jump = true;
                        PlayerClass.Force = PlayerClass.G;
                    }
                }

            }


            if (e.KeyCode == Keys.Escape)
            {
                if (!f2)
                    timer1.Stop();
                else
                    timer1.Start();

                timer2.Start();
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
                        break;
                    case 2:
                        count++;
                        label2.Visible = false;
                        label3.Visible = true;
                        pictureBox1.Visible = true;
                        timer1.Enabled = true;
                        break;
                    case 3:
                        if (f)
                        {
                            count++;
                            label3.Visible = false;
                            label4.Visible = true;
                        }
                        break;
                    case 4:
                        count++;
                        label4.Visible = false;
                        label5.Visible = true;
                        break;
                    case 5:
                        count++;
                        label5.Visible = false;
                        label6.Visible = true;
                        break;
                    case 6:
                        count++;
                        label6.Visible = false;
                        label7.Visible = true;
                        label8.Visible = true;
                        break;
                    case 7:
                        count++;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = true;
                        break;
                    case 8:
                        count++;
                        label9.Visible = false;
                        player.Visible = false;
                        pictureBox1.Visible = false;
                        panel1.Visible = true;
                        timer1.Enabled = false;
                        Cursor.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void T_L1_KeyUp(object sender, KeyEventArgs e)
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

            block.methodLeft2(pictureBox2, player);
            block.methodRight2(pictureBox2, player);
            block.methodLeft2(pictureBox3, player);
            block.methodRight2(pictureBox3, player);
            block.methodRight2(pictureBox1, player);
            block.methodLeft2(pictureBox1, player);
            

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

            if (player.Left < pictureBox4.Right && player.Right > pictureBox4.Left && player.Location.Y <= pictureBox4.Bottom)
            {
                f = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_L4 T_L4 = new T_L4();
            this.Hide();
            T_L4.ShowDialog();
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

        private void label16_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            T_L3 T_L3 = new T_L3();
            timer1.Stop();
            T_L3.ShowDialog();
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 52);
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 48);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
