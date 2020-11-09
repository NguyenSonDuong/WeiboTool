using ControllerWeibo;
using ModelWeibo.Recieve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiboTool
{
    public partial class Form1 : Form
    {
        private Weibo weibo;
        private String path = "";
        public Form1()
        {
            InitializeComponent();
            weibo = new Weibo();
            weibo.ProcessLoading += Weibo_ProcessLoading;
            weibo.SuccessLoading += Weibo_SuccessLoading;
            weibo.ErrorLoading += Weibo_ErrorLoading;
        }

        private void Weibo_ErrorLoading(object data)
        {
            WriteLog("Lỗi: " + data, Color.Red);
        }

        private void Weibo_SuccessLoading(object data)
        {
            WriteLog("TẢI THÀNH CÔNG TÀI NGUYÊN NGƯỜI DÙNG" , Color.Green);
        }
        private void ProcessDownloadData(Object data)
        {
            WriteLog("Đã tải thành công: " + data, Color.Teal);
        }
        private void Weibo_ProcessLoading(object data)
        {
            PostInfoRecieve.Card card = data as PostInfoRecieve.Card;
            if(card.mblog!=null)
            ActionWeiboAsync.ActionDownload(card, tbPath.Text + @"\", true, Weibo_ErrorLoading, ProcessDownloadData);
            
        }
        private async void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPath.Text))
                return;
            String source = tbID.Text;

            weibo.IdUser = ActionWeibo.GetIDFromText(source);
            ActionWeiboAsync.ActionLoadPostUser(weibo);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folder.SelectedPath;
            }
        }
        public void WriteLog(String mess, Color col)
        {
            ActionWeibo.InvokerFunction(rtbLog, () =>
            {
                rtbLog.SelectionColor = col;
                rtbLog.AppendText(mess + "\n");
            });
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            weibo.IsStop = true;
        }
    }
}
