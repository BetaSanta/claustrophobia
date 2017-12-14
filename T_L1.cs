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
    public partial class T_L1 : Form
    {
        public T_L1()
        {
            InitializeComponent();
            Cursor.Hide();
            Select();

            LoadFonts.LoadFont();
            LoadFonts.loadFontsForForm(label1, 64);
            LoadFonts.loadFontsForForm(label2, 64);
            LoadFonts.loadFontsForForm(label3, 72);
            LoadFonts.loadFontsForForm(label4 , 72);
            LoadFonts.loadFontsForForm(label5, 72);
            LoadFonts.loadFontsForForm(label10, 72);
            LoadFonts.loadFontsForForm(label11, 48);
            LoadFonts.loadFontsForForm(label12, 48);
            LoadFonts.loadFontsForForm(label13, 48);
            button1.Font = new Font(LoadFonts.font.Families[0], 48);
            button2.Font = new Font(LoadFonts.font.Families[0], 48);
        }
        int index = 0;
        int count = 0;
        bool f = false, f2 = false;

        private void T_L1_KeyDown(object sender, KeyEventArgs e)
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
                        label2.Visible = true;
                        break;
                    case 3:
                        label1.Visible = false;
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

            if (PlayerClass.right == true)
            {
                player.Left += 5;
            }

            if (PlayerClass.left == true)
            {
                player.Left -= 5;
            }

            if (player.Location.X - this.Location.X >= 900)
            {
                label3.Text = "А теперь вернись обратно";
                pictureBox1.Image = Properties.Resources.LeftButton;
                f = true;
            }

            if (player.Location.X - this.Location.X == 130)
            {
                if (f)
                {
                    label3.Visible = false;
                    player.Visible = false;
                    panel1.Visible = true;
                    pictureBox1.Visible = false;
                    timer1.Enabled = false;
                    Cursor.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_L2 T_L2 = new T_L2();
            this.Hide();
            T_L2.ShowDialog();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 52);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 48);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            T_L1 T_L1 = new T_L1();
            timer1.Stop();
            T_L1.ShowDialog();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
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
    }
}
