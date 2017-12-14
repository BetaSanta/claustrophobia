using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace claustrophobia
{
    public partial class loadForm : Form
    {

        bool checkButton = false;

        public string pathHelp = "ZLP.chm";

        public loadForm()
        {
            InitializeComponent();

            //Cursor.Show();
            LoadFonts.LoadFont();
            LoadFonts.loadFontsForForm(headLabel, 80);
            LoadFonts.loadFontsForForm(newGameLabel, 36);
            LoadFonts.loadFontsForForm(SettingsLabel, 36);
            LoadFonts.loadFontsForForm(referLabel, 36);
            LoadFonts.loadFontsForForm(ExitLabel, 36);
        }

        //----------увеличивает размер надписи и меняет курсор----------
        private void newGameLabel_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 40);
            SoundClass.PlayStart();
        }

        private void newGameLabel_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font(LoadFonts.font.Families[0], 36);
            //(sender as Label).Cursor = Cursors.Default;
        }

        //----------------------------------------------------------------

        //пасхалка 
        private void switchImage_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, pathHelp);

            if (!checkButton)
            {
                headLabel.ForeColor = Color.Red;
                checkButton = true;
            }
            else
            {
                headLabel.ForeColor = Color.White;
                checkButton = false;
            }
        }

        //кнопка выхода
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            string SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Native Games\\Claustrophobia\\";//путь к папке Мои Документы + название папки сохранений

            if (!Directory.Exists(SaveFolder)) //если папки не существует
            {
                Directory.CreateDirectory(SaveFolder); //создаем ее
            }
            if (File.Exists(SaveFolder + "ProgressFile" + ".cps"))
                File.Delete(SaveFolder + "ProgressFile" + ".cps");
            File.WriteAllText(SaveFolder + "ProgressFile" + ".cps", saveFile(ProgressClass.progressMass, ProgressClass.timeMass));

            this.Close();
        }

        private void newGameLabel_Click(object sender, EventArgs e)
        {
            LevelForm levelF = new LevelForm();
            levelF.ShowDialog();
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            settings_form.ShowDialog();
        }

        private void referLabel_Click(object sender, EventArgs e)
        {
            ReferForm refer_form = new ReferForm();
            refer_form.ShowDialog();
        }

        private void loadForm_Load(object sender, EventArgs e)
        {
            StartLoadedGame();
        }

        /// <summary>
        /// сохранение прогресса
        /// </summary>
        private string saveFile(int[,] progressMass, string[,] timeMass)
        {
            string pM = "";
            string tM = "";
            for (int i = 0; i < 2; i++)
            {
                
                for (int j = 0; j < 8; j++)
                {
                    pM += progressMass[i, j] + " ";
                    tM += timeMass[i, j] + " ";
                }
                pM += "\r\n";
                tM += "\r\n";
            }
            return pM + tM;
        }

        /// <summary>
        /// загрузка прогресса
        /// </summary>
        private void StartLoadedGame()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Native Games\\Claustrophobia\\ProgressFile";
            if (File.Exists(path + ".cps"))
            {

                StreamReader reader = new StreamReader(path + ".cps");
                string[] file = (reader.ReadToEnd()).Split('\n');
                reader.Close();

                string[] row = file;

                for (int i = 0; i < 2; i++)
                {
                    row = file[i].Split(' ');
                    for (int j = 0; j < 8; j++)
                        ProgressClass.progressMass[i, j] = Convert.ToInt32(row[j]);
                }
                for (int i = 0; i < 2; i++)
                {
                    row = file[i + 2].Split(' ');
                    for (int j = 0; j < 8; j++)
                        ProgressClass.timeMass[i, j] = row[j];
                }
            }
            else
            {
                return;
            }
        }
    }
}
