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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string NumberToText(int inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn ", "triệu", "tỷ" };
            bool isNegative = false;

            string sNumber = inputNumber.ToString();
            int number = Int32.Parse(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }

            string result = " ";

            if (inputNumber == 0) result = "không";

            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;  

           


            if (positionDigit == 0)
                result += unitNumbers[0];
            else
            {
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result += " ";
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? "" : "");
        }


        private void Read_Click(object sender, EventArgs e)
        {
            string input1;

            input1 = textBox1.Text;

            int number1;

            bool success1 = int.TryParse(input1, out number1);

            // Read number
            if (success1)
            {
                if (number1 >= 0 && number1 <= 9)
                {
                    textBox3.Text = NumberToText(number1);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên trong khoảng từ 0 đến 9");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên trong khoảng từ 0 đến 9");
            }
        }
        private void ReadAdvanced_Click(object sender, EventArgs e)
        {
            string input2;

            input2 = textBox2.Text;

            int number2;

            bool success2 = int.TryParse(input2, out number2);

            // Read number advanced
            if (success2)
            {
                textBox4.Text =  NumberToText(number2);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }
    }
}
