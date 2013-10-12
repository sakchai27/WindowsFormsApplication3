using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "แบบประเมินประสิทธิภาพการจัดทำโพลด์ของศูนย์วิจัยมหาลีย :" + Environment.NewLine;


            str = str + "1.เพศ ===";
            if (apt1.Checked == true)
            {
                str = str + "ชาย" + Environment.NewLine;
           

            }
            if (radioButton2.Checked == true)
            {
                str = str + "หญิง" + Environment.NewLine;
           
            }

            str = str + "2.อายุ ===";
            if (bpt1.Checked == true)
            {
                str = str + "18-25 ปี" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "26-35 ปี" + Environment.NewLine;
            }
            if (radioButton1.Checked == true)
            {
                str = str + "36-45 ปี" + Environment.NewLine;

            }
            if (radioButton3.Checked == true)
            {
                str = str + "46 ปีขึ้นไป" + Environment.NewLine;

            }
            str = str + "3.การศึกษา ===";
            if (cpt1.Checked == true)
            {
                str = str + "ต่ำกว่าปริญญาตรี" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "ปริญญาตรี" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "สูงกว่าปริญญาตรี" + Environment.NewLine;

            }
            str = str + "4.สถานภาพ ===";
            if (dpt1.Checked == true)
            {
                str = str + "อาจารย์/เจ้าหน้าที่" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "นักศักษา" + Environment.NewLine;
            }
            if (dpt3.Checked == true)
            {
                str = str + "บุคคลภายนอก" + Environment.NewLine;





            }
            MessageBox.Show(str, "รายงานผล");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

