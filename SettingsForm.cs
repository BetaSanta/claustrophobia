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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadFonts.LoadFont();
            LoadFonts.loadFontsForForm(label1, 80);
            LoadFonts.loadFontsForForm(label2, 48);
            LoadFonts.loadFontsForForm(label3, 48);
            LoadFonts.loadFontsForForm(label4, 22);
            LoadFonts.loadFontsForForm(label5, 22);
            LoadFonts.loadFontsForForm(label6, 22);
            checkBox1.Font = new Font(LoadFonts.font.Families[0], 48);
            checkBox1.UseCompatibleTextRendering = true;
            button1.Font = new Font(LoadFonts.font.Families[0], 24);
            button1.UseCompatibleTextRendering = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarningForm warning_form = new WarningForm();
            warning_form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SoundClass.sound_on();
                checkBox1.Text = "звук есть";
            }
            else
            {
                SoundClass.sound_off();
                checkBox1.Text = "звука нет";
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.closeRedBackground;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.ButtonClose;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (SoundClass.sound_enabled)

                checkBox1.Checked = true;

            else
                checkBox1.Checked = false;

        }
    }
}
