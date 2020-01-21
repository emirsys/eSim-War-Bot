using System;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
namespace eSim_War_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
        }
        private DateTime _kalanZaman;
        private int _saat, _dakika, _saniye;

        private void button1_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://duna.e-sim.org/");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (_saat > 0 && _dakika == 0 && _saniye == 0)
            {
                _saat--;
                _dakika = 60;
                _saniye = 60;
            }

            if (_dakika > 0 && _saniye == 0)
            {
                _dakika--;
                _saniye = 60;
            }

            if (_saniye > 0)
            {
                _saniye--;
            }

            if (_saat == 0 && _dakika == 0 && _saniye == 0)
            {
                TopMost = false;

                if (WindowState == FormWindowState.Minimized)
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                }

                Timer1.Stop();
                LBLSure.Text = @"00:00:00";
                timer2.Start();

                BtnBasla.Text = @"Başlat";
                MtbSaat.Text = "";
            }
            LBLSure.Text = _saat.ToString("00") + @":" + _dakika.ToString("00") + @":" + _saniye.ToString("00");
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            if (BtnBasla.Text == @"Başlat")
            {
                try
                {
                    _kalanZaman = Convert.ToDateTime(MtbSaat.Text);
                }
                catch
                {
                    MessageBox.Show(@"Oyundaki limitlerin yenileneceği zamanı giriniz. (Örn.: 00:10:00)", @"Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                BtnBasla.Text = @"Durdur";
                BtnSifirla.Enabled = false;

                _saat = _kalanZaman.Hour;
                _dakika = _kalanZaman.Minute;
                _saniye = _kalanZaman.Second;

                LBLSure.Text = _saat.ToString("00") + @":" + _dakika.ToString("00") + @":" + _saniye.ToString("00");

                Timer1.Enabled = true;
                Timer1.Start();
            }
            else
            {
                BtnBasla.Text = @"Başlat";
                BtnSifirla.Enabled = Enabled;
                _kalanZaman = Convert.ToDateTime(LBLSure.Text);

                MtbSaat.Text = _saat.ToString("00") + @":" + _dakika.ToString("00") + @":" + _saniye.ToString("00");
                Timer1.Stop();
            }
        }

        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
            Timer1.Dispose();
            LBLSure.Text = @"00:00:00";
            MtbSaat.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(url.Text);
            for(int i = 0; i < 2; i++)
            {
                button4_Click(button4, new EventArgs());
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
                progressBar1.Value++;
            else
            {
                timer2.Stop();
                button3.PerformClick();
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void white_rad_CheckedChanged(object sender, EventArgs e)
        {
            changeside.Text = "fightButtonBerserk2";
        }

        private void black_rad_CheckedChanged(object sender, EventArgs e)
        {
            changeside.Text = "fightButtonBerserk1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gecko.GeckoHtmlElement button4 = (Gecko.GeckoHtmlElement)geckoWebBrowser1.DomDocument.GetElementById(changeside.Text);
            button4.Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeckoInputElement Username = new GeckoInputElement(geckoWebBrowser1.Document.GetElementsByName("login")[0].DomObject);
            Username.Value = textBox1.Text;
            GeckoInputElement Password = new GeckoInputElement(geckoWebBrowser1.Document.GetElementsByName("password")[0].DomObject);
            Password.Value = textBox2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            black_rad.AutoCheck = true;
            white_rad.AutoCheck = true;
        }
    }
}
