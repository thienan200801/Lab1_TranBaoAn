using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_TranBaoAn
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        //public bool checkInput(string[] subs)
        //{
        //    foreach(var i in subs)
        //    {
        //        if (i > "10" && i < "0") return false;
        //        if (Convert.ToDouble(subs) > 10 && Convert.ToDouble(subs) < 0) return false;
        //    }

        //}
        public float AvgScore(string[]? subs)
        {
            float sum = 0;
            foreach(var i in subs)
            {
                float tmp = float.Parse(i);
                sum += tmp;
            }
            return sum / subs.Length;
        }

        public float MaxScore(string[]? subs)
        {
            List<float> max = new List<float>();
            float maxx = 0;
            foreach (var i in subs)
            {
                max.Add(float.Parse(i));
            }
            foreach (var i in max)
            {
                if(i > maxx) maxx = i;
            }
            return maxx;
        }

        public float MinScore(string[] subs)
        {
            List<float> min = new List<float>();
            float minn = 2147483647;
            foreach (var i in subs)
            {
                min.Add(float.Parse(i));
            }
            foreach (var i in min)
            {
                if(i < minn) minn = i;
            }
            return minn;
        }

        public float PassedScore(string[] subs)
        {
            int count = 0;
            foreach (var i in subs)
            {
                float tmp = float.Parse(i);
                if (tmp >= 5) count++;
            }
            return count;
        }

        public bool checkGioi(string[] subs)
        {
            foreach (var i in subs)
            {
                float tmp = float.Parse(i);
                if (tmp < 6.5) return false;
            }
            return true;
        }

        public bool checkKha(string[] subs)
        {
            foreach (var i in subs)
            {
                float tmp = float.Parse(i);
                if (tmp < 5) return false;
            }
            return true;
        }

        public bool checkTB(string[] subs)
        {
            foreach (var i in subs)
            {
                float tmp = float.Parse(i);
                if (tmp < 3.5) return false;
            }
            return true;
        }

        public bool checkYeu(string[] subs)
        {
            foreach (var i in subs)
            {
                float tmp = float.Parse(i);
                if (tmp < 2) return false;
            }
            return true;
        }

        public String RankFunc(float a, string[] subs)
        {
            string res = "";
            if (a >= 8 && a<=10)
            {
                if (checkGioi(subs))
                {
                    res = "Giỏi";
                }
                //MessageBox.Show(checkGioi(subs).ToString());
            }

            if ((a >= 6.5 && a<8) || (a>=8 && checkGioi(subs) == false))
            {
                if (checkKha(subs)) res = "Khá";
            }

            if ((a >= 5 && a<6.5) || (a >= 6.5 && checkKha(subs) == false))
            {
                if (checkTB(subs)) res = "TB";
            }

            if (a >= 3.5 && a < 5 || (a >= 5 && checkTB(subs) == false))
            {
                if (checkTB(subs)) res = "Yếu";
            }

            if (a >= 0 && a < 3.5 || (a >= 5 && checkTB(subs) == false))
            {
                if (checkYeu(subs)) res = "Yếu";
            }
            return res;
        }

        private void Out_Click(object sender, EventArgs e)
        {
            try
            {


            string s = textBox1.Text;

            string[] subs = s.Split(' ');
            float[] fsubs;
            for (var sub = 0; sub < subs.Length; sub++)
            {
                Label label = new Label();
                label.Text = ($"Môn {sub}: {sub}đ");
                ScoreList.Controls.Add(label);
            }

            label6.Text = Math.Round(AvgScore(subs), 2).ToString();

            label8.Text = MaxScore(subs).ToString();

            label10.Text = MinScore(subs).ToString();

            label7.Text = PassedScore(subs).ToString();

            label9.Text = (subs.Length - PassedScore(subs)).ToString();

            label11.Text = RankFunc(AvgScore(subs), subs);
            }

            catch
            {
                MessageBox.Show("Error Input!");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ScoreList.ResetText();
        }
    }
}
