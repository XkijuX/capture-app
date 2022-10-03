using System;
using System.Windows.Forms;
using System.IO;

namespace capturescreen
{
    public partial class settings : Form
    {
        /* TextInput */
        String urlText;
        String keyText;
        String locationText;

        /* Radio */
        bool CopyImage;
        bool CopyURL;
        
        /* Checkbox */
        bool openImage;
        bool openUrl;

        /* Save path */
        private readonly string UserDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public settings()
        {
            InitializeComponent();
            try
            {
                string[] lines = File.ReadAllLines(UserDir + "\\Capture\\settings.txt");

                url.Text = lines[0];
                key.Text = lines[1];
                localLocation.Text = lines[2];
                openPNG.Checked = bool.Parse(lines[5]);
                openURL.Checked = bool.Parse(lines[6]);
                copyImage.Checked = bool.Parse(lines[7]);
                copyURL.Checked = bool.Parse(lines[8]);
            }
            catch (FileNotFoundException e)
            {

            }
        }

        private void save_click(object sender, EventArgs e)
        {
            this.urlText = url.Text;
            this.keyText = key.Text;
            this.locationText = localLocation.Text;

            this.openImage = openPNG.Checked;
            this.openUrl = openURL.Checked;

            this.CopyImage = copyImage.Checked;
            this.CopyURL = copyURL.Checked;

            String[] lines =
            {
                urlText, 
                keyText, 
                locationText, 
                (!urlText.Equals("")).ToString(),
                (!locationText.Equals("")).ToString(), 
                openImage.ToString(), 
                openUrl.ToString(), 
                CopyImage.ToString(), 
                CopyURL.ToString()
            };

            File.WriteAllLines(UserDir + "\\Capture\\settings.txt", lines);
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
