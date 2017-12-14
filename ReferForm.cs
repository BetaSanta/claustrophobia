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
    public partial class ReferForm : Form
    {
        public ReferForm()
        {
            InitializeComponent();

            LoadFonts.LoadFont();
            LoadFonts.loadFontsForForm(label1, 80);
            LoadFonts.loadFontsForForm(label2, 36);
            LoadFonts.loadFontsForForm(label3, 22);
            LoadFonts.loadFontsForForm(label4, 36);
            LoadFonts.loadFontsForForm(label5, 24);
            LoadFonts.loadFontsForForm(label7, 24);
            LoadFonts.loadFontsForForm(label9, 24);
            LoadFonts.loadFontsForForm(label11, 24);
            LoadFonts.loadFontsForForm(label6, 18);
            LoadFonts.loadFontsForForm(label8, 18);
            LoadFonts.loadFontsForForm(label10, 18);
            LoadFonts.loadFontsForForm(label12, 18);
            LoadFonts.loadFontsForForm(label13, 36);
            LoadFonts.loadFontsForForm(label14, 72);
            LoadFonts.loadFontsForForm(label15, 12);
        }

        bool f1 = false, f2 = false, f3 = false;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.closeRedBackground;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.ButtonClose;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            panel2.Height = 0;
            panel3.Height = 0;
            f2 = false;
            f3 = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (f1 == false)
            {

                panel1.Height += 20;
                if (panel1.Height >= 300)
                {
                   

                    f1 = true;
                    timer1.Stop();
                }
            }
            else
            {
                panel1.Height -= 20;
                if (panel1.Height == 0)
                {
                    f1 = false;
                    timer1.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            panel1.Height = 0;
            panel3.Height = 0;
            f1 = false;
            f3 = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (f3 == false)
            {
                panel3.Height += 20;
                if (panel3.Height >= 300)
                {
                    f3 = true;
                    timer3.Stop();
                }
            }
            else
            {
                panel3.Height -= 20;
                if (panel3.Height == 0)
                {
                    f3 = false;
                    timer3.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 40);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 36);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            timer3.Start();

            panel1.Height = 0;
            panel2.Height = 0;
            f1 = false;
            f2 = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(f2 == false)
            {
                panel2.Height += 20;
                if (panel2.Height >= 300)
                {
                    f2 = true;
                    timer2.Stop();
                }
            }
            else
            {
                panel2.Height -= 20;
                if (panel2.Height == 0)
                {
                    f2 = false;
                    timer2.Stop();
                }
            }
        }
    }
}
