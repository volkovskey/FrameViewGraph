using System.Diagnostics;

namespace FrameViewGraph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            string appLang = Properties.Settings.Default.lang;
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(appLang);
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(appLang);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string versionOfProgram = typeof(MainForm).Assembly.GetName().Version.ToString();
            int lengthOfVersion = versionOfProgram.LastIndexOf('.');
            Properties.Settings.Default.AppVersion = versionOfProgram.Substring(0, lengthOfVersion);
            this.Text = "FVG v." + Properties.Settings.Default.AppVersion + " by volkovskey";

            LoadLeng();
        }

        private void LoadLeng()
        {
            string appLang = Properties.Settings.Default.lang;
            if (!string.IsNullOrEmpty(appLang))
            {
                Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(appLang);
                Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(appLang);  
            }

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

        private void Language_RU_Click(object sender, EventArgs e)
        {
            if (!Language_RU.Checked)
            {
                Language_RU.Checked = true;
                Language_EN.Checked = false;
                Properties.Settings.Default.lang = "ru";
                Properties.Settings.Default.Save();
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
            }
        }

        private void File_OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                StatusText.Text = Local.Status_Load;
                StatusMenu.Refresh();
                //добавить проверку правильности файла
                string[][] dataFromFile = File.ReadAllLines(OpenFile.FileName).Select(line => line.Split(',').ToArray()).ToArray();
                StatusText.Text = Local.Status_Work;
                StatusMenu.Refresh();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}