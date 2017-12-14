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
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
            LoadFonts.LoadFont();
            LoadFonts.loadFontsForForm(label5, 26);
            button1.Font = new Font(LoadFonts.font.Families[0], 16);
            button1.UseCompatibleTextRendering = true;
            button2.Font = new Font(LoadFonts.font.Families[0], 16);
            button2.UseCompatibleTextRendering = true;
            Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningForm_Shown(object sender, EventArgs e)
        {
            cursor_start();
        }

        /// <summary>
        /// курсор мышки сразу на кнопку ОТМЕНА
        /// </summary>
        private void cursor_start()
        {
            Point point;
            point = button2.Location;
            point.Offset(button2.Width / 2, button2.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Native Games\\Claustrophobia\\";//путь к папке Мои Документы + название папки сохранений
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 8; j++)
                {
                    ProgressClass.progressMass[i, j] = 0;
                    ProgressClass.timeMass[i, j] = "0";
                }

            if (File.Exists(SaveFolder + "ProgressFile" + ".cps"))
                File.Delete(SaveFolder + "ProgressFile" + ".cps");
            this.Close();
        }
    }
}
