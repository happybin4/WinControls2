using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WinControls2
{
    public partial class Form2 : Form
    {
        bool bSetAlam = false;
        DateTime dDay;
        DateTime dTime;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        //C# 프로그램에서 mp3, mp4 => WindowsMediaPlayer 관련
        //dll 참조추가 > COM > 형식라이브러리

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            bSetAlam = true;
            dDay = DateTime.Parse(dtpDate.Text); 
            //보이는 날짜 문자열을 DateTime으로 변환
            dTime = dtpTime.Value;

            lblAlarm.Text = $"Alarm : {dDay.ToShortDateString()}" +
                $"{dTime.ToShortTimeString()}";
            tabControl1.SelectedTab = tabPage2;
            //tabControl1.SelectedIndex = 1; 같은코딩
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now; //년월일시분초
            lblDate.Text = curTime.ToShortDateString();
            lblTime.Text = curTime.ToShortTimeString();

            //알람설정을 한 경우라면 , 알람시간하고 현재시간이 일치하는지
            // 체크 => 일치한다면, 알람을 표시
            if (bSetAlam)
            {
                //일자가 같고, 시간,분이 같고
                if(dDay == DateTime.Today && dTime.Hour == curTime.Hour &&
                    dTime.Minute == curTime.Minute)
                {
                    bSetAlam = false;
                    MessageBox.Show("흐에~~~~~!");
                    player.URL = "media/preview.mp3";
                    player.controls.play();
                }
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            bSetAlam = false;
            lblAlarm.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = "media/videoplayback.mp4";
            }
           
        }
    }
}
