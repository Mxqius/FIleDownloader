using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIleDownloader
{
    public partial class Main : Form
    {
        HttpDownloader httpDownloader;
        private string AddressFileSaveAs = "";
        public Main()
        {
            InitializeComponent();
        }
        bool CheckUrl()
        {
            if (txt_url.Text == String.Empty)
            {
                return false;
            }
            return true;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            txt_url.Text = Clipboard.GetText();
        }
        bool CheckSaveAddress()
        {
            if (AddressFileSaveAs == String.Empty)
            {
                return false;
            }
            return true;
        }
        bool StartDownload()
        {
            if (!CheckUrl())
            {
                MessageBox.Show("Please Enter a Url !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (CheckSaveAddress())
                {
                    if (!CheckConnection())
                    {
                        MessageBox.Show("Lost Connection Internet :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    httpDownloader = new HttpDownloader(txt_url.Text, AddressFileSaveAs);
                    httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                    httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                    httpDownloader.Start();
                    return true;
                }
                MessageBox.Show("Please Select Save Path !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool CheckConnection()
        {
            try
            {
                Ping ping = new Ping();
                PingReply pr = ping.Send("www.google.com");
                if (pr.Status == IPStatus.Success)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            pg_status.Value = (int)e.Progress;
            lbl_percent.Text = e.Progress.ToString("0.00") + "%";
            lbl_speed.Text = String.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lbl_downloaded.Text = String.Format("{0} MB", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            lbl_status.Text = "Downloading...";
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                lbl_downloaded.Text = "Finish !"; lbl_percent.Text = "100%";
            }));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartDownload();
        }

        private void pb_SaveAs_Click(object sender, EventArgs e)
        {
            sfd_SaveDownload.FileName = Path.GetFileName(txt_url.Text);
            if (sfd_SaveDownload.ShowDialog() == DialogResult.OK)
            {
                AddressFileSaveAs = sfd_SaveDownload.FileName;
            }
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Pause();
        }

        private void txt_url_MouseEnter(object sender, EventArgs e)
        {
            txt_url.Text = Clipboard.GetText();
        }

        private void lbl_dev_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/mxqius");
        }
    }
}
