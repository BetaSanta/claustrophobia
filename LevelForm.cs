using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace claustrophobia
{
    public partial class LevelForm : Form
    {
        int locationVeribal = -1;

        public LevelForm()
        {
            InitializeComponent();

            //Cursor.Show();
            LoadFonts.LoadFont();
            //применение шрифтов к первой локации
            LoadFonts.loadFontsForForm(headLabelOne, 80);
            LoadFonts.loadFontsForForm(label1, 36);
            LoadFonts.loadFontsForForm(label2, 36);
            LoadFonts.loadFontsForForm(label3, 36);
            LoadFonts.loadFontsForForm(label4, 36);
            LoadFonts.loadFontsForForm(label5, 36);
            LoadFonts.loadFontsForForm(label6, 36);
            LoadFonts.loadFontsForForm(label7, 36);
            LoadFonts.loadFontsForForm(label8, 36);

            //применение шрифтов ко второй локации
            LoadFonts.loadFontsForForm(headLabelTwo, 80);
            LoadFonts.loadFontsForForm(label11, 36);
            LoadFonts.loadFontsForForm(label12, 36);
            LoadFonts.loadFontsForForm(label13, 36);
            LoadFonts.loadFontsForForm(label14, 36);
            LoadFonts.loadFontsForForm(label15, 36);
            LoadFonts.loadFontsForForm(label16, 36);
            LoadFonts.loadFontsForForm(label17, 36);
            LoadFonts.loadFontsForForm(label18, 36);

            //применение шрифтов к третьей локации
            LoadFonts.loadFontsForForm(headLabelThree, 80);
            LoadFonts.loadFontsForForm(label20, 36);
            LoadFonts.loadFontsForForm(label21, 36);
            LoadFonts.loadFontsForForm(label22, 36);
            LoadFonts.loadFontsForForm(label23, 36);
            LoadFonts.loadFontsForForm(label24, 36);
            LoadFonts.loadFontsForForm(label25, 36);
            LoadFonts.loadFontsForForm(label26, 36);
            LoadFonts.loadFontsForForm(label27, 36);

            //применение шрифтов к обучающей локации
            LoadFonts.loadFontsForForm(headLabelTraning, 80);
            LoadFonts.loadFontsForForm(label53, 36);
            LoadFonts.loadFontsForForm(label54, 36);
            LoadFonts.loadFontsForForm(label55, 36);
            LoadFonts.loadFontsForForm(label56, 36);
        }

        //----------------стрелки перелистывания локаций-------------
        private void arrowRight0_Click(object sender, EventArgs e)
        {
            locationVeribal = 01;
            timer1.Start();
        }

        private void arrowRight_Click(object sender, EventArgs e)
        {
            locationVeribal = 10;
            timer1.Start();
        }

        private void arrowLeft1_Click(object sender, EventArgs e)
        {
            locationVeribal = 11;
            timer1.Start();
        }

        private void arrowRight2_Click(object sender, EventArgs e)
        {
            locationVeribal = 20;
            timer1.Start();
        }

        private void arrowLeft2_Click(object sender, EventArgs e)
        {
            locationVeribal = 21;
            timer1.Start();
        }

        private void arrowLeft3_Click(object sender, EventArgs e)
        {
            locationVeribal = 31;
            timer1.Start();
        }
        //------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (locationVeribal)
            {
                case 01:
                    locationOne.Width += 40;
                    if (locationOne.Width >= ClientSize.Width)
                        timer1.Stop();
                    break;

                case 10:
                    locationTwo.Width += 40;
                    if (locationTwo.Width >= ClientSize.Width)
                        timer1.Stop();
                    break;
                case 11:
                    locationOne.Width -= 40;
                    if (locationOne.Width == 0)
                        timer1.Stop();
                    break;

                case 20:
                    locationThree.Width += 40;
                    if (locationThree.Width >= ClientSize.Width)
                        timer1.Stop();
                    break;

                case 21:
                    locationTwo.Width -= 40;
                    if (locationTwo.Width == 0)
                        timer1.Stop();
                    break;

                case 31:
                    locationThree.Width -= 40;
                    if (locationThree.Width == 0)
                        timer1.Stop();
                    break;
                default:
                    break;
            }
        }


        //----------------------------кнопка закрытия----------------------
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.closeRedBackground;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.ButtonClose;
        }
        //------------------------------------------------------------------


        //-----------------------Стрелки выбора уровня---------------------
        private void arrowRight1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Left += 10;
        }

        private void arrowRight1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Left -= 10;
        }

        private void arrowLeft1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Left -= 10;
        }

        private void arrowLeft1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Left += 10;
        }
        //-----------------------------------------------------------------


        //---------------------подсветка уровня-----------------------
        private void label56_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 40);
            SoundClass.PlayStart();
        }

        private void label56_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 36);
        }
        //------------------------------------------------------------

        //-------------------------выбор уровня-----------------------
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            T_L1 T_L1 = new T_L1();
            SoundClass.PlayBackground();
            T_L1.ShowDialog();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            T_L2 T_L2 = new T_L2();
            SoundClass.PlayBackground();
            T_L2.ShowDialog();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            T_L3 T_L3 = new T_L3();
            SoundClass.PlayBackground();
            T_L3.ShowDialog();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            T_L4 T_L4 = new T_L4();
            SoundClass.PlayBackground();
            T_L4.ShowDialog();
        }

        private void levelOne1_Click(object sender, EventArgs e)
        {
            L1_L1 L1_L1 = new L1_L1();
            SoundClass.PlayBackground();
            L1_L1.ShowDialog();
        }

        private void levelTwo1_Click(object sender, EventArgs e)
        {
            L1_L2 L1_L2 = new L1_L2();
            SoundClass.PlayBackground();
            L1_L2.ShowDialog();
        }

        private void levelThree1_Click(object sender, EventArgs e)
        {
            L1_L3 L1_L3 = new L1_L3();
            SoundClass.PlayBackground();
            L1_L3.ShowDialog();
        }

        private void levelFour1_Click(object sender, EventArgs e)
        {
            L1_L4 L1_L4 = new L1_L4();
            SoundClass.PlayBackground();
            L1_L4.ShowDialog();
        }

        private void levelFive1_Click(object sender, EventArgs e)
        {
            L1_L5 L1_L5 = new L1_L5();
            SoundClass.PlayBackground();
            L1_L5.ShowDialog();
        }

        private void levelSix1_Click(object sender, EventArgs e)
        {
            L1_L6 L1_L6 = new L1_L6();
            SoundClass.PlayBackground();
            L1_L6.ShowDialog();
        }

        private void levelSeven1_Click(object sender, EventArgs e)
        {
            L1_L7 L1_L7 = new L1_L7();
            SoundClass.PlayBackground();
            L1_L7.ShowDialog();
        }

        private void levelEight1_Click(object sender, EventArgs e)
        {
            L1_L8 L1_L8 = new L1_L8();
            SoundClass.PlayBackground();
            L1_L8.ShowDialog();
        }

        //отображение прогресса
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ProgressClass.progressMass[0, 0] == 1)
            {
                levelOne1.Visible = false;
                label9.Visible = true;
                label9.Text = ProgressClass.timeMass[0, 0];
            }
            else
            {
                levelOne1.Visible = true;
                label9.Visible = false;
            }
            if (ProgressClass.progressMass[0, 1] == 1)
            {
                levelTwo1.Visible = false;
                label10.Visible = true;
                label10.Text = ProgressClass.timeMass[0, 1];
            } 
            else
            {
                levelTwo1.Visible = true;
                label10.Visible = false;
            }
            if (ProgressClass.progressMass[0, 2] == 1)
            {
                levelThree1.Visible = false;
                label19.Visible = true;
                label19.Text = ProgressClass.timeMass[0, 2];
            }   
            else
            {
                levelThree1.Visible = true;
                label19.Visible = false;
            }
            if (ProgressClass.progressMass[0, 3] == 1)
            {
                levelFour1.Visible = false;
                label28.Visible = true;
                label28.Text = ProgressClass.timeMass[0, 3];
            }  
            else
            {
                levelFour1.Visible = true;
                label28.Visible = false;
            }
            if (ProgressClass.progressMass[0, 4] == 1)
            {
                levelFive1.Visible = false;
                label29.Visible = true;
                label29.Text = ProgressClass.timeMass[0, 4];
            }   
            else
            {
                levelFive1.Visible = true;
                label29.Visible = false;
            }
            if (ProgressClass.progressMass[0, 5] == 1)
            {
                levelSix1.Visible = false;
                label30.Visible = true;
                label30.Text = ProgressClass.timeMass[0, 5];
            }  
            else
            {
                levelSix1.Visible = true;
                label30.Visible = false;
            }
            if (ProgressClass.progressMass[0, 6] == 1)
            {
                levelSeven1.Visible = false;
                label31.Visible = true;
                label31.Text = ProgressClass.timeMass[0, 6];
            }   
            else
            {
                levelSeven1.Visible = true;
                label31.Visible = false;
            }
            if (ProgressClass.progressMass[0, 7] == 1)
            {
                levelEight1.Visible = false;
                label32.Visible = true;
                label32.Text = ProgressClass.timeMass[0, 7];
            }
            else
            {
                levelEight1.Visible = true;
                label32.Visible = false;
            }
        }
        //------------------------------------------------------------
    }
}
