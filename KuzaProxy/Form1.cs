using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using Vanara;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using ReaperTheme;
using SaturnProxy;
using System.Diagnostics;

namespace KuzaProxy
{
    public partial class Form1 : ReaperForm
    {
        public Form1()
        {
            InitializeComponent();
            updateIPDisplay();
            captivePortalTest();
        }
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        static bool settingsReturn, refreshReturn;

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void updateIPDisplay()
        {
            string publicIPv4 = new WebClient().DownloadString("http://icanhazip.com");
            viewPublicIP.Text = publicIPv4;
        }
        public void captivePortalTest()
        {
            string captiveCheck = new WebClient().DownloadString("http://captive.apple.com");

            if (captiveCheck.Contains("Success") == false)
            {
                //MessageBox.Show("A captive portal was detected - please authenticate into your network before connecting.", "SimpleConnect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void reaperButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Malediven01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "202.1.197.227:80");

                    Thread.Sleep(40);
                    
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Honduras01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "65.182.5.212:8080");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Germany01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "136.243.47.220:3128");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Germany02")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "139.162.166.141:3128");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Germany03")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "95.216.230.235:8080");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Singapore01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "139.162.18.88:8080");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Poland01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "80.211.244.192:80");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Thailand01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "118.174.211.220:11");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Thailand02")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "49.49.31.27:8080");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "US01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "167.99.168.90:3128");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "US02")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "165.22.36.75:8888");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }

            if (comboBox1.Text == "France01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "163.172.154.72:8811");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "France02")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "51.79.73.82:3128");

                    Thread.Sleep(40);

                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");

                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Mexiko01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "148.217.94.54:3128");

                    Thread.Sleep(40);
                    
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");
                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Brazil01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "200.255.122.170:8080");

                    Thread.Sleep(40);
                    
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");
                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Russia01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "109.167.207.72:8080");

                    Thread.Sleep(40);



                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");
                    updateIPDisplay();
                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "Iran01")
            {
                try
                {
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 1);
                    registry.SetValue("ProxyServer", "5.160.90.91:3128");

                    Thread.Sleep(40);
                    
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                    MessageBox.Show("Proxy Connected");
                    updateIPDisplay();
                }
                catch
                {
                    MessageBox.Show("Error: Please try another proxy");
                    RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                    registry.SetValue("ProxyEnable", 0);
                    settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                    refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    updateIPDisplay();
                }
            }
            if (comboBox1.Text == "ProxySwitch")
            {
                
            }
        }

        private void Switch()
        {
            Thread.Sleep(60000);

        }

     

        

        

        private void reaperButton2_Click(object sender, EventArgs e)
        {
            updateIPDisplay();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//Disconnect proxy when closing app,
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            registry.SetValue("ProxyServer", "0.0.0.0:0");
            registry.SetValue("ProxyEnable", 0);
            Thread.Sleep(40);

            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            System.Diagnostics.Process.Start("https://github.com/libkuza"); //I'll add an update checker soon.
        }
        

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }

        private void Form1_onColorBarColorChanged(object sender, ReaperEvents.OnColorBarColorChanged e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reaperButton3_Click(object sender, EventArgs e)//disconnect button
        {
            try
            {
                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                
                registry.SetValue("ProxyServer", "0.0.0.0:0");
                registry.SetValue("ProxyEnable", 0);
                Thread.Sleep(40);

                settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                updateIPDisplay();
                MessageBox.Show("Proxy Disconnected");

            }
            catch
            {
                MessageBox.Show("Error: Something went wrong");
                
            }
        }

        private void label2_Click(object sender, EventArgs e)//Information Button
        {
            MessageBox.Show("SaturnProxy Version 1.1");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 0);
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        
    }
}
