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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Tong_Click(object sender, EventArgs e)
        {
            string input1, input2;
            long sum = 0;

            input1 = Input1.Text;
            input2 = Input2.Text;

            long number1, number2;

            bool success1 = long.TryParse(input1, out number1);
            bool success2 = long.TryParse(input2, out number2);
            if (success1 && success2)
            {
                sum = number1 + number2;
            }
            else 
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
            textBox3.Text = sum.ToString();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
