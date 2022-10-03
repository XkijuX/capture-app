using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace capturescreen
{
    public partial class Form1 : Form
    {
        internal PictureBox Window;
        Rectangle VirtualScreen;

        bool DownRecieved;
        int X;
        int Y;
        int W;
        int H;

        Rectangle rect;
        Point lastTopLeft;
        int CordTop, CordBottom, CordLeft, CordRight;


        // Settings:
        bool Upload = false;
        bool CopyImage = true;
        bool CopyURL = false;
        bool OpenURL = false;
        bool SaveImage = true; 

        bool OpenImage = false;
        String location = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Capture\\";
        String Key;
        String Url;

        // HTTP client
        private static readonly HttpClient client = new HttpClient();

        readonly string UserDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public object JsonConvert { get; private set; }

        public Form1()
        {
            this.Window = new PictureBox();
            // Hide the windows
            //this.Window.Hide();
            this.Hide();

            // Get the virtual screen
            this.VirtualScreen = SystemInformation.VirtualScreen;

            // Read settings:
            try
            {
                string[] lines = File.ReadAllLines(UserDir + "\\Capture\\settings.txt");

                this.Url = lines[0];
                this.Key = lines[1];
                this.location = lines[2];
                this.Upload = bool.Parse(lines[3]);
                this.SaveImage = bool.Parse(lines[4]);
                this.OpenImage = bool.Parse(lines[5]);
                this.OpenURL = bool.Parse(lines[6]);
                this.CopyImage = bool.Parse(lines[7]);
                this.CopyURL = bool.Parse(lines[8]);
            } catch (FileNotFoundException e)
            {

            } catch (DirectoryNotFoundException e)
            {
                /* Create and save default data */
                // User Settings Folder
                Directory.CreateDirectory(UserDir + "\\Capture");

                // Save Images Folder
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Capture");

                String[] lines =
                {   
                    "",
                    "",
                    Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Capture\\",
                    "false",
                    "true",
                    "false",
                    "false",
                    "true",
                    "false"
                };

                File.WriteAllLines(UserDir + "\\Capture\\settings.txt", lines);
            }
          
            // Initalize the application
            Initialize();
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            this.DownRecieved = true;
            this.X = e.X;
            this.Y = e.Y;
            this.Window.Size = new Size(0, 0);
            this.Window.Show();
            this.Refresh();
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (!this.DownRecieved) return;
            int x = e.X;
            int y = e.Y;
            this.W = x - this.X;
            this.H = y - this.Y;

            this.CordTop = Math.Min(e.Y, this.Y);
            this.CordBottom = Math.Max(e.Y, this.Y);
            this.CordLeft = Math.Min(e.X, this.X);
            this.CordRight = Math.Max(e.X, this.X);
            this.rect = Rectangle.FromLTRB(CordLeft, CordTop, CordRight, CordBottom);

            if (this.rect.Location != lastTopLeft) {
                this.Window.Location = rect.Location;
            }
            this.Window.Size = rect.Size;
            this.Window.Refresh();
            this.lastTopLeft = this.rect.Location;
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            this.DownRecieved = false;
            CaptureScreen(X, Y, W, H);
        }

        private void settingsKey(object sender, KeyEventArgs e)
        {
            // Key if key is F1 and open settings
            if(e.KeyCode == Keys.F1)
            {
                Form settings = new settings();
                settings.TopMost = true;
                settings.Show();
                this.Size = new Size(0, 0);
            }
        }

        private void Initialize()
        {
            // initialie variables.
            this.DownRecieved = false;

            // Add event listeners
            this.MouseDown += new MouseEventHandler(this.mouseDown);
            this.MouseMove += new MouseEventHandler(this.mouseMove);
            this.MouseUp += new MouseEventHandler(this.mouseUp);

            // Set the correct screen dimensions & edit layout
            this.Size = VirtualScreen.Size;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.5;
            this.Top = VirtualScreen.Top;
            this.Left = VirtualScreen.Left;
            this.Width = VirtualScreen.Width;
            this.Height = VirtualScreen.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;

            // Configure window
            this.Window.BackColor = Color.FromArgb(128, 128, 128);
            this.Window.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(this.Window);
            this.Window.TabIndex = 8;
            this.Window.TabStop = false;
            this.Window.Tag = Color.Red;
            this.Window.Paint += new PaintEventHandler(WindowBorder);
            this.TransparencyKey = Color.FromArgb(128, 128, 128);
            this.ResumeLayout(false);

            // Watch key down
            this.KeyDown += new KeyEventHandler(this.settingsKey);

            // Show dialog
            this.ShowDialog();
        }

        private void WindowBorder(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.Window.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        async public void CaptureScreen(int X, int Y, int W, int H)
        {
            try
            {
                // Sleep for 5 ms so the screen can clear.
                this.Size = new Size(0, 0);
                System.Threading.Thread.Sleep(100);

                // Take a screenshot
                Bitmap captureBitmapTest = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(captureBitmapTest);
                graphics.CopyFromScreen(rect.X - Math.Abs(VirtualScreen.Left), rect.Y - Math.Abs(VirtualScreen.Top), 0, 0, captureBitmapTest.Size);

                // Copy Image to clipboard
                if (CopyImage) Clipboard.SetImage(captureBitmapTest); // Copy to clipboard

                // Save the locally
                if(SaveImage)
                {
                    String file = location +  DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                    captureBitmapTest.Save(@file, ImageFormat.Png);
                    if(OpenImage) Process.Start(@file);
                }
                // Upload image
                if (Upload)
                {
                    ImageConverter converter = new ImageConverter();
                    MemoryStream memoryStream = new MemoryStream();
                    captureBitmapTest.Save(memoryStream, ImageFormat.Png);
                    string base64String = Convert.ToBase64String(memoryStream.ToArray());

                     // Upload The Image
                    StringContent content = new StringContent("{ \"key\":\"" + Key + "\",\"uploadimg\": \" " + base64String + "\"}", Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(Url, content);
                    switch(response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            string str = (await response.Content.ReadAsStringAsync()).ToString();
                            if (CopyURL) Clipboard.SetText(str);
                            if (OpenURL) Process.Start(str);
                            break;
                        case System.Net.HttpStatusCode.MovedPermanently:
                            Clipboard.SetImage(captureBitmapTest);
                            MessageBox.Show("URL is incorrect, please go change it. Image copied to clipboard");
                            break;
                        case System.Net.HttpStatusCode.BadRequest:
                            Clipboard.SetImage(captureBitmapTest);
                            MessageBox.Show((await response.Content.ReadAsStringAsync()).ToString() + " Image copied to clipboard");
                            break;
                        case System.Net.HttpStatusCode.Forbidden:
                            Clipboard.SetImage(captureBitmapTest);
                            MessageBox.Show((await response.Content.ReadAsStringAsync()).ToString() + " Image copied to clipboard");
                            break;
                        default:
                            Clipboard.SetImage(captureBitmapTest);
                            MessageBox.Show("Something went wrong. Image copied to clipboard");
                            break;
                    }
                }
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
    }
}
