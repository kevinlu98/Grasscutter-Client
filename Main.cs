using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Jint;
using Helper;
using System.Diagnostics;
using Fiddler;
using Microsoft.JScript;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Diagnostics;


namespace Grasscutter_Client
{

    public partial class Main : Form
    {

        public static Boolean SERVER_AUTH = true;

        public static string GAME_PATH = "";
        public static string GAME_IP = "";
        public static string GAME_PORT = "";

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        [DllImport("kernel32")]// 读配置文件方法的6个参数：所在的分区（section）、 键值、     初始缺省值、   StringBuilder、  参数长度上限 、配置文件路径
        public static extern long GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]//写入配置文件方法的4个参数：  所在的分区（section）、  键值、     参数值、       配置文件路径
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);


        //private static List<string> imgList = new List<string>();

        private static List<Label> labels = new List<Label>();

        public Main()
        {
            InitializeComponent();

        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            if (!panel1.Visible)
            {
                SetValue("config", "path", GAME_PATH);
                SetValue("config", "ip", this.IpInput.Text);
                GAME_IP = this.IpInput.Text;
                SetValue("config", "port", this.PortInput.Text);
                GAME_PORT = this.PortInput.Text;
            }
        }

        private void ServerAuth_Click(object sender, EventArgs e)
        {
            serverAuth(true);
        }

        private void serverAuth(bool auth)
        {

            SERVER_AUTH = auth;
            if (SERVER_AUTH)
            {
                this.ServerAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                this.ServerAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
                this.ServerAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.ServerPrivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
                this.ServerPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                this.ServerPrivate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            }
            else
            {
                this.ServerPrivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                this.ServerPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
                this.ServerPrivate.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.ServerAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
                this.ServerAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                this.ServerAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
           
            SetValue("config", "auth", SERVER_AUTH + "");
        }

        private void ServerPrivate_Click(object sender, EventArgs e)
        {
            serverAuth(false);
        }

        private  void Main_Load(object sender, EventArgs e)
        {
            FiddlerHelper.stop();
            FiddlerHelper.installcert();
            
            loadNotice();
            GAME_PATH = GetValue("config", "path");
            
            SERVER_AUTH = GetValue("config", "auth") == "True";
            serverAuth(SERVER_AUTH);
            GAME_IP = GetValue("config", "ip");
            GAME_PORT = GetValue("config", "port");
            this.GamePathInput.Text = GAME_PATH;
            this.IpInput.Text = GAME_IP;
            this.PortInput.Text = GAME_PORT;
        }
        /// <summary>
        /// 加载官方公告
        /// </summary>
        private  void loadNotice()
        {
            var result = GetData("https://ys.mihoyo.com/main/news");
            var regex = new Regex("__NUXT__=(.*);");
            var codes = regex.Matches(result);

            try
            {
                var jscode = codes[0].Value;
                Console.WriteLine(jscode);
                Engine engine = new Engine();
                engine.Execute(jscode);
                var recList = engine.GetValue("__NUXT__").AsObject().Get("data").AsArray().Get("0").AsObject().Get("recList").AsArray();

                labels.Add(NoticeList1);
                labels.Add(NoticeList2);
                labels.Add(NoticeList3);
                for (var i = 0; i < recList.GetLength(); i++)
                {
                    if (i > 2) break;
                    var item = recList.Get(i + "").AsObject();
                    var date = item.Get("date").AsString();
                    var title = item.Get("title").AsString();
                    title = title.Substring(0, title.Length > 22 ? 22 : title.Length);
                    labels[i].Text = date + "  " + title;
                }
                if (recList.GetLength() > 0)
                {
                    this.NoticeImage.BackgroundImage = Image.FromStream(getImageStream(recList.Get((recList.GetLength() - 1) + "").AsObject().Get("cover").AsString()));
                }
            }catch (Exception ex)
            {

            }
        }

        public static string GetValue(string section, string key)
        {
            // ▼ 获取当前程序启动目录
            string strPath = Application.StartupPath + @"/config.ini"; //这里是绝对路径
            if (File.Exists(strPath))  //检查是否有配置文件，并且配置文件内是否有相关数据。
            {
                StringBuilder sb = new StringBuilder(255);
                GetPrivateProfileString(section, key, "", sb, 255, strPath);

                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public static void SetValue(string section, string key, string value)
        {
            // ▼ 获取当前程序启动目录
            string strPath = Application.StartupPath + @"/config.ini";  //这里是绝对路径
          
            WritePrivateProfileString(section, key, value, strPath);
        }


        private Stream getImageStream(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 20000;  //超时时间
            request.Method = "GET";  //请求方式
            request.KeepAlive = true; //解决GetResponse操作超时问题

            //通过HttpWebRequest的GetResponse()方法建立HttpWebResponse,强制类型转换
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return response.GetResponseStream();
        }

        private string GetData(string url)
        {
            string result = string.Empty;
            string error = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 20000;  //超时时间
                request.Method = "GET";  //请求方式
                request.KeepAlive = true; //解决GetResponse操作超时问题

                //通过HttpWebRequest的GetResponse()方法建立HttpWebResponse,强制类型转换
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                //获取响应内容，返回的数据格式: {"status":"success","msg":"成功","data":{"info": "example"}}
                result = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            if (error != string.Empty)
                MessageBox.Show(error);

            return result;
        }

        private void BtnGamePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件

            dialog.Title = "请选择文件";
            dialog.Filter = "所有文件(*.exe)|*.exe";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.GamePathInput.Text = dialog.FileName;
                GAME_PATH = dialog.FileName;
               
            }

        }



        private void GameStart_Click(object sender, EventArgs e)
        {
            if(GAME_PATH == string.Empty)
            {
                MessageBox.Show("请设置游戏路径");
                return;
            }
            if (System.Diagnostics.Process.GetProcessesByName("YuanShen.exe").ToList().Count>0)
            {
                MessageBox.Show("游戏正在运行");
                return;
            }

            string gameParent = ExtractFolderFromPath(GAME_PATH,@"\",false);
            if (!SERVER_AUTH)
            {
                if (GAME_IP == string.Empty || GAME_PORT == string.Empty)
                {
                    MessageBox.Show("请设置私服的IP和端口");
                    return;
                }
                FiddlerHelper.start();
                if (!File.Exists(gameParent + @"\mhypbase.dll.bak"))
                {
                    File.Move(gameParent + @"\mhypbase.dll", gameParent + @"\mhypbase.dll.bak");
                    File.WriteAllBytes(gameParent + @"\mhypbase.dll", Properties.Resources.RSAPatch);
                }
                File.WriteAllText(gameParent + @"\Publickey.txt", Properties.Resources.key);
                Console.WriteLine("启动私服...");
            }
            else
            {
                if (File.Exists(gameParent + @"\Publickey.txt"))
                {
                    File.Delete(gameParent + @"\Publickey.txt");
                }
                
                if (File.Exists(gameParent + @"\mhypbase.dll.bak"))
                {
                    File.Delete(gameParent + @"\mhypbase.dll");
                    File.Move(gameParent + @"\mhypbase.dll.bak", gameParent + @"\mhypbase.dll");
                }
                Console.WriteLine("启动官服...");
            }
            Process.Start(GAME_PATH);
        }

        public static string ExtractFolderFromPath(string fileName, string pathSeparator, bool includeSeparatorAtEnd)
        {
            int pos = fileName.LastIndexOf(pathSeparator);
            return fileName.Substring(0, (includeSeparatorAtEnd ? pos + 1 : pos));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            FiddlerHelper.stop();
        }

        private void Recover_Click(object sender, EventArgs e)
        {
            string gameParent = ExtractFolderFromPath(GAME_PATH, @"\", false);
            if (GAME_PATH == string.Empty)
            {
                MessageBox.Show("请设置游戏路径");
                return;
            }
            if (File.Exists(gameParent + @"\mhypbase.dll.bak"))
            {
                File.Delete(gameParent + @"\mhypbase.dll");
                File.Move(gameParent + @"\mhypbase.dll.bak", gameParent + @"\mhypbase.dll");
            }
            else
            {
                File.WriteAllBytes(gameParent + @"\mhypbase.dll", Properties.Resources.mhypbase);
            }
            MessageBox.Show("恢复成功，请重启游戏客户端");
        }
    }
}
