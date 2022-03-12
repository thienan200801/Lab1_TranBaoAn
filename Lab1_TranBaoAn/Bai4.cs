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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int ConvertBoxType(string box)
        {
            if (box == "Binary") return 2;
            else if (box == "Hexadecimal") return 16;
            else if (box == "Decimal") return 10;
            return 0;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            int box1, box2;
            string stringInput;

            stringInput = textBox1.Text.Trim();
            box1 = ConvertBoxType(comboBox1.Text.Trim());
            box2 = ConvertBoxType(comboBox2.Text.Trim());

            if (box1 == 0) box2 = 0;

            try
            {
                if (box1 == 2)
                {
                    int Bin2Dec = Convert.ToInt32(stringInput, 2);
                    if (box2 == 10) textBox2.Text = Bin2Dec.ToString();
                    else if (box2 == 16) textBox2.Text = Convert.ToString(Bin2Dec, box2);
                    else textBox2.Text = stringInput;
                }
                else if (box1 == 16)
                {
                    int Hex2Dec = Convert.ToInt32(stringInput, 16);
                    if (box2 == 10) textBox2.Text = Convert.ToString(Hex2Dec, box2);
                    else if (box2 == 2) textBox2.Text = Convert.ToString(Hex2Dec, box2);
                    else textBox2.Text = stringInput;
                }
                else if (box1 == 10)
                {
                    textBox2.Text = Convert.ToString(int.Parse(stringInput), box2);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }
    }
}
