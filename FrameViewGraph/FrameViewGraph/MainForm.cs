using System.Diagnostics;

namespace FrameViewGraph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeLeng();
            string appLang = Properties.Settings.Default.lang;
            switch (appLang)
            {
                case "en":
                    Language_EN.Checked = true;
                    break;
                case "ru":
                    Language_RU.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void LoadLeng()
        {
            AppSettings_Language.Text = Properties.Settings.Default.AppSettings_Language;
            File_OpenFile.Text = Properties.Settings.Default.File_OpenFile;
            Language_EN.Text = Properties.Settings.Default.Language_EN;
            Language_RU.Text = Properties.Settings.Default.Language_RU;
            Menu_About.Text = Properties.Settings.Default.Menu_About;
            Menu_AppSettings.Text = Properties.Settings.Default.Menu_AppSettings;
            Menu_File.Text = Properties.Settings.Default.Menu_File;
            Menu_Graph.Text = Properties.Settings.Default.Menu_Graph;
            Menu_GraphSettings.Text = Properties.Settings.Default.Menu_GraphSettings;
            Menu_GraphType.Text = Properties.Settings.Default.Menu_GraphType;
        }

        private void ChangeLeng()
        {
            string appLang = Properties.Settings.Default.lang;
            switch (appLang)
            {
                case "en":
                    Properties.Settings.Default.AppSettings_Language = Properties.Resources.EN_AppSettings_Language;
                    Properties.Settings.Default.File_OpenFile = Properties.Resources.EN_File_OpenFile;
                    Properties.Settings.Default.Language_EN = Properties.Resources.EN_Language_EN;
                    Properties.Settings.Default.Language_RU = Properties.Resources.EN_Language_RU;
                    Properties.Settings.Default.Menu_About = Properties.Resources.EN_Menu_About;
                    Properties.Settings.Default.Menu_AppSettings = Properties.Resources.EN_Menu_AppSettings;
                    Properties.Settings.Default.Menu_File = Properties.Resources.EN_Menu_File;
                    Properties.Settings.Default.Menu_Graph = Properties.Resources.EN_Menu_Graph;
                    Properties.Settings.Default.Menu_GraphSettings = Properties.Resources.EN_Menu_GraphSettings;
                    Properties.Settings.Default.Menu_GraphType = Properties.Resources.EN_Menu_GraphType;
                    Properties.Settings.Default.Status_End = Properties.Resources.EN_Status_End;
                    Properties.Settings.Default.Status_Load = Properties.Resources.EN_Status_Load;
                    Properties.Settings.Default.Status_Work = Properties.Resources.EN_Status_Work;
                    Properties.Settings.Default.Save();
                    break;
                case "ru":
                    Properties.Settings.Default.AppSettings_Language = Properties.Resources.RU_AppSettings_Language;
                    Properties.Settings.Default.File_OpenFile = Properties.Resources.RU_File_OpenFile;
                    Properties.Settings.Default.Language_EN = Properties.Resources.RU_Language_EN;
                    Properties.Settings.Default.Language_RU = Properties.Resources.RU_Language_RU;
                    Properties.Settings.Default.Menu_About = Properties.Resources.RU_Menu_About;
                    Properties.Settings.Default.Menu_AppSettings = Properties.Resources.RU_Menu_AppSettings;
                    Properties.Settings.Default.Menu_File = Properties.Resources.RU_Menu_File;
                    Properties.Settings.Default.Menu_Graph = Properties.Resources.RU_Menu_Graph;
                    Properties.Settings.Default.Menu_GraphSettings = Properties.Resources.RU_Menu_GraphSettings;
                    Properties.Settings.Default.Menu_GraphType = Properties.Resources.RU_Menu_GraphType;
                    Properties.Settings.Default.Status_End = Properties.Resources.RU_Status_End;
                    Properties.Settings.Default.Status_Load = Properties.Resources.RU_Status_Load;
                    Properties.Settings.Default.Status_Work = Properties.Resources.RU_Status_Work;
                    Properties.Settings.Default.Save();
                    break;
                default:
                    Properties.Settings.Default.AppSettings_Language = Properties.Resources.EN_AppSettings_Language;
                    Properties.Settings.Default.File_OpenFile = Properties.Resources.EN_File_OpenFile;
                    Properties.Settings.Default.Language_EN = Properties.Resources.EN_Language_EN;
                    Properties.Settings.Default.Language_RU = Properties.Resources.EN_Language_RU;
                    Properties.Settings.Default.Menu_About = Properties.Resources.EN_Menu_About;
                    Properties.Settings.Default.Menu_AppSettings = Properties.Resources.EN_Menu_AppSettings;
                    Properties.Settings.Default.Menu_File = Properties.Resources.EN_Menu_File;
                    Properties.Settings.Default.Menu_Graph = Properties.Resources.EN_Menu_Graph;
                    Properties.Settings.Default.Menu_GraphSettings = Properties.Resources.EN_Menu_GraphSettings;
                    Properties.Settings.Default.Menu_GraphType = Properties.Resources.EN_Menu_GraphType;
                    Properties.Settings.Default.Status_End = Properties.Resources.EN_Status_End;
                    Properties.Settings.Default.Status_Load = Properties.Resources.EN_Status_Load;
                    Properties.Settings.Default.Status_Work = Properties.Resources.EN_Status_Work;
                    Properties.Settings.Default.Save();
                    break;
            }
            LoadLeng();
        }

        private void Language_RU_Click(object sender, EventArgs e)
        {
            if (!Language_RU.Checked)
            {
                Language_RU.Checked = true;
                Language_EN.Checked = false;
                Properties.Settings.Default.lang = "ru";
                Properties.Settings.Default.Save();
                ChangeLeng();
            }
        }

        private void Language_EN_Click(object sender, EventArgs e)
        {
            if (!Language_EN.Checked)
            {
                Language_EN.Checked = true;
                Language_RU.Checked = false;
                Properties.Settings.Default.lang = "en";
                Properties.Settings.Default.Save();
                ChangeLeng();
            }
        }

        private void File_OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                StatusMenu.Text = Properties.Settings.Default.Status_Load;
                StatusMenu.Refresh();
                //добавить проверку правильности файла
                string[][] dataFromFile = File.ReadAllLines(OpenFile.FileName).Select(line => line.Split(',').ToArray()).ToArray();
                StatusMenu.Text = Properties.Settings.Default.Status_Work;
                StatusMenu.Refresh();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}