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
    public partial class T_L2 : Form
    {
        public T_L2()
        {
            InitializeComponent();
            Cursor.Hide();

            LoadFonts.LoadFont();
            button1.Font = new Font(LoadFonts.font.Families[0], 48);
            button2.Font = new Font(LoadFonts.font.Families[0], 48);
            LoadFonts.loadFontsForForm(label1, 64);
            LoadFonts.loadFontsForForm(label10, 64);
            LoadFonts.loadFontsForForm(label11, 48);
            LoadFonts.loadFontsForForm(label12, 48);
            LoadFonts.loadFontsForForm(label13, 48);
            LoadFonts.loadFontsForForm(label14, 72);
            LoadFonts.loadFontsForForm(label15, 64);
            LoadFonts.loadFontsForForm(label2, 64);
            LoadFonts.loadFontsForForm(label3, 64);
            LoadFonts.loadFontsForForm(label4, 72);
            LoadFonts.loadFontsForForm(label5, 70);



            Select();
        }
        int count = 0, count2 = 0;
        bool f2 = false;

        private void T_L1_KeyDown(object sender, KeyEventArgs e)
        {
            if (PlayerClass.jump != true)    
            {
                if (e.KeyCode == Keys.Space)
                {
                    PlayerClass.jump = true;
                    PlayerClass.Force = PlayerClass.G;

                    if (count >= 3)  
                    {
                        label10.Visible = true;
                        count2++;
                        label10.Text = "Прыгни ещё " + (6 - count2) + " раз";
                        if (count2 == 6)
                        {
                            label3.Visible = false;
                            player.Visible = false;
                            pictureBox1.Visible = false;
                            panel1.Visible = true;
                            label10.Visible = false;
                            timer1.Enabled = false;
                            Cursor.Show();
                        }
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
                count++;
                switch (count)
                {
                    case 1:
                        label4.Visible = false;
                        label1.Visible = true;
                        break;
                    case 2:
                        label1.Visible = false;
                        label2.Visible = true;
                        break;
                    case 3:
                        label2.Visible = false;
                        label3.Visible = true;
                        pictureBox1.Visible = true;
                        timer1.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PlayerClass.jump == true)
            {
                player.Top -= PlayerClass.Force;
                PlayerClass. Force -= 1;
            }

            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;
                PlayerClass.jump = false;
            }
            else
            {
                //proverka(pictureBox1);
                if (block.f == false) 
                    player.Top += 5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_L3 T_L3 = new T_L3();
            this.Hide();
            T_L3.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            T_L2 T_L2 = new T_L2();
            timer1.Stop();
            T_L2.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 52);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 48);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Show();
            this.Close();
        }
    }
}