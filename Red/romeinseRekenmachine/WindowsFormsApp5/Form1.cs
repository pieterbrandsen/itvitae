using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Rekenmachine : Form
    {
        string result;
        int numberResult = 0;

        string result2;
        int numberResult2 = 0;

        string task; 

        public Rekenmachine()
        {
            InitializeComponent();
        }
    private void button_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Clear();
            }
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }
        private void buttonAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            task = button.Text;
            result = textBox.Text;
            textBox.Text = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            result = result.ToUpper();
            result2 = textBox.Text;

 

            result2 = result2.ToUpper();
            for (int i = 0; i < result2.Length; i++)
            {
                if (i != result2.Length - 1 && getLetterValue(result2[i]) < getLetterValue(result2[i + 1]))
                {
                    numberResult2 += getLetterValue(result2[i + 1]) - getLetterValue(result2[i]);
                    i++;
                    continue;
                }
                else
                {
                    numberResult2 += getLetterValue(result2[i]);
                }
            }

            

            static string ToLetter(int number)
            {
                if (number < 1) return string.Empty;
                if (number >= 1000) 
                    return "M" + ToLetter(number - 1000);
                if (number >= 900) 
                    return "CM" + ToLetter(number - 900);
                if (number >= 500) 
                    return "D" + ToLetter(number - 500);
                if (number >= 400) 
                    return "CD" + ToLetter(number - 400);
                if (number >= 100) 
                    return "C" + ToLetter(number - 100);
                if (number >= 90) 
                    return "XC" + ToLetter(number - 90);
                if (number >= 50) 
                    return "L" + ToLetter(number - 50);
                if (number >= 40) 
                    return "XL" + ToLetter(number - 40);
                if (number >= 10)
                    return "X" + ToLetter(number - 10);
                if (number >= 9) 
                    return "IX" + ToLetter(number - 9);
                if (number >= 5) 
                    return "V" + ToLetter(number - 5);
                if (number >= 4) 
                    return "IV" + ToLetter(number - 4);
                if (number >= 1) 
                    return "I" + ToLetter(number - 1);
                throw new ArgumentOutOfRangeException("There went something wrong");
            }


            static int getLetterValue(char letter)
            {
                switch (letter)
                {
                    case 'I':
                        return 1;
                    case 'V':
                        return 5;
                    case 'X':
                        return 10;
                    case 'L':
                        return 50;
                    case 'C':
                        return 100;
                    case 'D':
                        return 500;
                    case 'M':
                        return 1000;
                    default:
                        return 0;
                }
            };



            if (task == "+")
            {
                int finalResult2 = numberResult + numberResult2;
                textBox.Text = ToLetter(finalResult2);
            }
            else if (task == "-")
            {
                int finalResult2 = numberResult - numberResult2;
                textBox.Text = ToLetter(finalResult2);
            }
            else if (task == "*")
            {
                int finalResult2 = numberResult * numberResult2;
                textBox.Text = ToLetter(finalResult2);
            }
            else if (task == "/")
            {
                int finalResult2 = numberResult / numberResult2;
                textBox.Text = ToLetter(finalResult2);
            }
        }


        private void buttonResetNumber_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            result = "";
            result2 = "";
            numberResult = 0;
            numberResult2 = 0;
        }
    }
}
