using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControls2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "이미지 파일(.jpg)|*.jpg|모든 파일(*.*)|*.*";
            //dlg.Title = "이미지 열기";
            //if(dlg.ShowDialog() == DialogResult.OK)
            //{
            //    //Image.FromFile() 해당경로 문자열로부터 이미지를 생성해서 반환
            //    pictureBox1.Image = Image.FromFile(dlg.FileName);

            //    // 1.BLOB 타입으로 지정 => 용량이 좀 커진다
            //    // 2.path 만 DB에 저장 => 문자열로 경로
            //}
            pictureBox1.Image = Image.FromFile("ProductImage/gd.jpg");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            else if (radioButton2.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else if (radioButton3.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
