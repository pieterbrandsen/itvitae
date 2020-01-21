using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lettertype_Chaos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min,max);
            }
        }

        private void Button_randomize_Click(object sender, RoutedEventArgs e)
        {
            //string textBoxContent = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text;
            string newTextBox = "";

            /*for (int i = 0; i < textBoxContent.Length; i++)
            {
                int random = GetRandomNumber(0, 2);
                textBox1.Text = "";
                // Je moet een nieuwe textbox maken en de letter daar steeds overschrijven
                if (random == 0)
                {
                    textBox1.Text += textBoxContent[i];
                    textBox1.FontFamily = new FontFamily("Comic Sans MS");
                    newTextBox += textBox1.Text;
                }
                if (random == 1)
                {
                    newTextBox += textBoxContent[i];
                }
                newTextBox += random;

            }*/
            for (int i = 0; i < textBox.TextLength; i++)
            {
                textBox.Select(i, 1);
                textBox.SelectionFont = new Font(fontName, textBox.SelectionFont.Size, textBox.SelectionFont.Style);
            }

            //textBox.Document.Blocks.Clear();
            //textBox.Document.Blocks.Add(new Paragraph(new Run(newTextBox)));
            newTextBox = "";
        }
    }
}
