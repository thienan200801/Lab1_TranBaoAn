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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        public long MinFunc(long a, long b)
        {
            return a < b ? a : b;
        }

        public long MaxFunc(long a, long b)
        {
            return (a > b) ? a : b;
        }
        private void Find_Click(object sender, EventArgs e)
        {
            //find min
            string num1, num2, num3;

            num1 = textBox1.Text;
            num2 = textBox2.Text;
            num3 = textBox3.Text;

            long number1, number2, number3;

            bool success1 = long.TryParse(num1, out number1);
            bool success2 = long.TryParse(num2, out number2);
            bool success3 = long.TryParse(num3, out number3);

            if (success1 && success2 && success3)
            {
                //find min
                textBox4.Text = MinFunc(MinFunc(number1, number2), number3).ToString();

                //find max           
                textBox5.Text = MaxFunc(MaxFunc(number1, number2), number3).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }

        }
    }
}
