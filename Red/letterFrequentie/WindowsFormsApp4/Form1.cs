using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string textBoxContent = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_ReadText_Click(object sender, EventArgs e)
        {
            textBoxContent = textBox.Text.ToUpper();

            textBox_A.Text = "0";
            textBox_B.Text = "0";
            textBox_C.Text = "0";
            textBox_D.Text = "0";
            textBox_E.Text = "0";
            textBox_F.Text = "0";
            textBox_G.Text = "0";
            textBox_I.Text = "0";
            textBox_J.Text = "0";
            textBox_K.Text = "0";
            textBox_L.Text = "0";
            textBox_M.Text = "0";
            textBox_N.Text = "0";
            textBox_O.Text = "0";
            textBox_P.Text = "0";
            textBox_Q.Text = "0";
            textBox_R.Text = "0";
            textBox_S.Text = "0";
            textBox_T.Text = "0";
            textBox_U.Text = "0";
            textBox_V.Text = "0";
            textBox_W.Text = "0";
            textBox_X.Text = "0";
            textBox_Y.Text = "0";
            textBox_Z.Text = "0";


            for (int i = 0; i < textBoxContent.Length; i++)
            {
                if (textBoxContent[i] == 'A')
                    textBox_A.Text = (Convert.ToInt32(textBox_A.Text) + 1).ToString();
                if (textBoxContent[i] == 'B')
                    textBox_B.Text = (Convert.ToInt32(textBox_B.Text) + 1).ToString();
                if (textBoxContent[i] == 'C')
                    textBox_C.Text = (Convert.ToInt32(textBox_C.Text) + 1).ToString();
                if (textBoxContent[i] == 'D')
                    textBox_D.Text = (Convert.ToInt32(textBox_D.Text) + 1).ToString();
                if (textBoxContent[i] == 'E')
                    textBox_E.Text = (Convert.ToInt32(textBox_E.Text) + 1).ToString();
                if (textBoxContent[i] == 'F')
                    textBox_F.Text = (Convert.ToInt32(textBox_F.Text) + 1).ToString();
                if (textBoxContent[i] == 'G')
                    textBox_G.Text = (Convert.ToInt32(textBox_G.Text) + 1).ToString();
                if (textBoxContent[i] == 'H')
                    textBox_H.Text = (Convert.ToInt32(textBox_H.Text) + 1).ToString();
                if (textBoxContent[i] == 'I')
                    textBox_I.Text = (Convert.ToInt32(textBox_I.Text) + 1).ToString();
                if (textBoxContent[i] == 'J')
                    textBox_J.Text = (Convert.ToInt32(textBox_J.Text) + 1).ToString();
                if (textBoxContent[i] == 'K')
                    textBox_K.Text = (Convert.ToInt32(textBox_K.Text) + 1).ToString();
                if (textBoxContent[i] == 'L')
                    textBox_L.Text = (Convert.ToInt32(textBox_L.Text) + 1).ToString();
                if (textBoxContent[i] == 'M')
                    textBox_M.Text = (Convert.ToInt32(textBox_M.Text) + 1).ToString();
                if (textBoxContent[i] == 'N')
                    textBox_N.Text = (Convert.ToInt32(textBox_N.Text) + 1).ToString();
                if (textBoxContent[i] == 'O')
                    textBox_O.Text = (Convert.ToInt32(textBox_O.Text) + 1).ToString();
                if (textBoxContent[i] == 'P')
                    textBox_P.Text = (Convert.ToInt32(textBox_P.Text) + 1).ToString();
                if (textBoxContent[i] == 'Q')
                    textBox_Q.Text = (Convert.ToInt32(textBox_Q.Text) + 1).ToString();
                if (textBoxContent[i] == 'R')
                    textBox_R.Text = (Convert.ToInt32(textBox_R.Text) + 1).ToString();
                if (textBoxContent[i] == 'S')
                    textBox_S.Text = (Convert.ToInt32(textBox_S.Text) + 1).ToString();
                if (textBoxContent[i] == 'T')
                    textBox_T.Text = (Convert.ToInt32(textBox_T.Text) + 1).ToString();
                if (textBoxContent[i] == 'U')
                    textBox_U.Text = (Convert.ToInt32(textBox_U.Text) + 1).ToString();
                if (textBoxContent[i] == 'V')
                    textBox_V.Text = (Convert.ToInt32(textBox_V.Text) + 1).ToString();
                if (textBoxContent[i] == 'W')
                    textBox_W.Text = (Convert.ToInt32(textBox_W.Text) + 1).ToString();
                if (textBoxContent[i] == 'X')
                    textBox_X.Text = (Convert.ToInt32(textBox_X.Text) + 1).ToString();
                if (textBoxContent[i] == 'Y')
                    textBox_Y.Text = (Convert.ToInt32(textBox_Y.Text) + 1).ToString();
                if (textBoxContent[i] == 'Z')
                    textBox_Z.Text = (Convert.ToInt32(textBox_Z.Text) + 1).ToString();
            }
        }
    }
}
