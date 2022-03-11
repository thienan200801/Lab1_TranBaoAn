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
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static String DecToBin(int n)
        {
            string result = "";
            int[] binaryNum = new int[32];

            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
                result += (binaryNum[j]);
            return result;
        }

        public static String BinToDec(int n)
        {
            string result = "";
            int num = n;
            int dec_value = 0;

            int base1 = 1;

            int temp = num;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            return dec_value.ToString();
        }

        public string HexToBin(string hexvalue)
        {
            return Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        }

        public static string BinToHex(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return binary;

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        public bool checkInput (string a)
        {
            int number1, count = 0;
            bool success1 = int.TryParse(a, out number1);

            if (comboBox1.Text == "Binary" || comboBox2.Text == "Binary")
            {
                foreach(var i in a)
                {
                    if (i != '0' || i != '1') return false;
                }
                return true;
            }

            if (comboBox1.Text == "Hexadecimal" || comboBox2.Text == "Hexadecimal")
            {
                for (var i = 0; i < a.Length; i++)
                {
                    if (success1 || i == 'A' || i == 'a' || i == 'B' || i == 'b' || i == 'C' || i == 'c'
                        || i == 'D' || i == 'd' || i == 'E' || i == 'e' || i == 'F' || i == 'f') count++;
                }
                if (count == a.Length) return true;
                return false;
            }

            if (comboBox1.Text == "Decimal" || comboBox2.Text == "Decimal")
            {
                if (success1) return true;
                return false;
            }
            return true;
        }
        private void Execute_Click(object sender, EventArgs e)
        {
            string input1;

            input1 = textBox1.Text;

            int number1;

            bool success1 = int.TryParse(input1, out number1);

            if (!checkInput(input1))
            {
                MessageBox.Show("Nhập dữ liệu sai định dạng");
                return;
            }

            if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Binary")
            {
                textBox2.Text = HexToBin(input1);
            }
            if (comboBox1.Text == "Binary" && comboBox2.Text == "Hexadecimal")
            {
                textBox2.Text = BinToHex(input1);
            }

            if (comboBox1.Text == "Hexadecimal" && comboBox2.Text == "Decimal")
            {
                string tmp = HexToBin(input1);
                textBox2.Text = BinToDec(Int32.Parse(tmp));
            }

            if (comboBox1.Text == "Decimal" && comboBox2.Text == "Hexadecimal")
            {
                if (success1)
                {
                    string tmp = DecToBin(number1);
                    textBox2.Text = BinToHex(tmp);
                }
            }
            if(comboBox1.Text == "Decimal" && comboBox2.Text == "Binary")
            {
                if (success1)
                {
                    textBox2.Text = DecToBin(number1);
                }
                else
                {
                    MessageBox.Show("Nhập dữ liệu sai định dạng");
                }
            }
            if (comboBox1.Text == "Binary" && comboBox2.Text == "Decimal")
            {
                if (success1)
                {
                    textBox2.Text = BinToDec(number1);
                }
            }
        }
    }
}
