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
            LoadLeng();
        }

        private void LoadLeng()
        {
            string appLang = Properties.Settings.Default.lang;
            switch (appLang)
            {
                case "en":
                    AppSettings_Language.Text = Properties.Resources.EN_AppSettings_Language;
                    File_OpenFile.Text = Properties.Resources.EN_File_OpenFile;
                    Language_EN.Text = Properties.Resources.EN_Language_EN;
                    Language_RU.Text = Properties.Resources.EN_Language_RU;
                    Menu_About.Text = Properties.Resources.EN_Menu_About;
                    Menu_AppSettings.Text = Properties.Resources.EN_Menu_AppSettings;
                    Menu_File.Text = Properties.Resources.EN_Menu_File;
                    Menu_Graph.Text = Properties.Resources.EN_Menu_Graph;
                    Menu_GraphSettings.Text = Properties.Resources.EN_Menu_GraphSettings;
                    Menu_GraphType.Text = Properties.Resources.EN_Menu_GraphType;
                    break;
                case "ru":
                    AppSettings_Language.Text = Properties.Resources.RU_AppSettings_Language;
                    File_OpenFile.Text = Properties.Resources.RU_File_OpenFile;
                    Language_EN.Text = Properties.Resources.RU_Language_EN;
                    Language_RU.Text = Properties.Resources.RU_Language_RU;
                    Menu_About.Text = Properties.Resources.RU_Menu_About;
                    Menu_AppSettings.Text = Properties.Resources.RU_Menu_AppSettings;
                    Menu_File.Text = Properties.Resources.RU_Menu_File;
                    Menu_Graph.Text = Properties.Resources.RU_Menu_Graph;
                    Menu_GraphSettings.Text = Properties.Resources.RU_Menu_GraphSettings;
                    Menu_GraphType.Text = Properties.Resources.RU_Menu_GraphType;
                    break;
                default:
                    AppSettings_Language.Text = Properties.Resources.EN_AppSettings_Language;
                    File_OpenFile.Text = Properties.Resources.EN_File_OpenFile;
                    Language_EN.Text = Properties.Resources.EN_Language_EN;
                    Language_RU.Text = Properties.Resources.EN_Language_RU;
                    Menu_About.Text = Properties.Resources.EN_Menu_About;
                    Menu_AppSettings.Text = Properties.Resources.EN_Menu_AppSettings;
                    Menu_File.Text = Properties.Resources.EN_Menu_File;
                    Menu_Graph.Text = Properties.Resources.EN_Menu_Graph;
                    Menu_GraphSettings.Text = Properties.Resources.EN_Menu_GraphSettings;
                    Menu_GraphType.Text = Properties.Resources.EN_Menu_GraphType;
                    break;
            }
        }

        private void Language_RU_Click(object sender, EventArgs e)
        {
            if (!Language_RU.Checked)
            {
                Language_RU.Checked = true;
                Language_EN.Checked = false;
                Properties.Settings.Default.lang = "ru";
                LoadLeng();
            }
        }

        private void Language_EN_Click(object sender, EventArgs e)
        {
            if (!Language_EN.Checked)
            {
                Language_EN.Checked = true;
                Language_RU.Checked = false;
                Properties.Settings.Default.lang = "en";
                LoadLeng();
            }
        }
    }
}