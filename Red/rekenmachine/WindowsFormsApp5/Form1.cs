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
        double result;
        string task;

        public Rekenmachine()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (text_box.Text == "0")
            {
                text_box.Clear();
            }
            Button button = (Button)sender;
            text_box.Text = text_box.Text + button.Text;
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            task = button.Text;
            result = Double.Parse(text_box.Text) / 100;
            text_box.Text = result.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            task = button.Text;
            result = Double.Parse(text_box.Text);
            text_box.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            task = button.Text;
            result = Double.Parse(text_box.Text);
            text_box.Text = "0";
        }

        private void buttonDiff_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            task = button.Text;
            result = Double.Parse(text_box.Text);
            text_box.Text = "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            task = button.Text;
            result = Double.Parse(text_box.Text);
            text_box.Text = "0";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (task == "+") // +
            {
                double finalResult = result + Convert.ToDouble(text_box.Text);
                text_box.Text = finalResult.ToString();
            }
            else if (task == "-") // -
            {
                double finalResult = result - Convert.ToDouble(text_box.Text);
                text_box.Text = finalResult.ToString();
            }
            else if (task == "*") // *
            {
                double finalResult = result * Convert.ToDouble(text_box.Text);
                text_box.Text = finalResult.ToString();
            }
            else if (task == "/") // /
            {
                double finalResult = result / Convert.ToDouble(text_box.Text);
                text_box.Text = finalResult.ToString();
            }
        }

        private void buttonResetNunber_Click(object sender, EventArgs e)
        {
            text_box.Text = "0";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            text_box.Text = "0";
            result = 0;
        }
    }
}
