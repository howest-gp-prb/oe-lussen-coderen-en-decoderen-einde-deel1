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

namespace Prb.LussenCoderen.WPF
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

        private void btnEncodeSimple_Click(object sender, RoutedEventArgs e)
        {
            txtLower.Text = EncodeSimple(txtUpper.Text);
        }

        private void btnDecodeSimple_Click(object sender, RoutedEventArgs e)
        {
            txtUpper.Text = DecodSimple(txtLower.Text);
        }
        string EncodeSimple(string source)
        {
            string target = "";
            int length = source.Length;
            char character;
            byte number;

            for (int r = 0; r < length; r++)
            {
                character = char.Parse(source.Substring(r, 1));
                number = (byte)character;
                number += 128;
                target += (char)number;

            }
            return target;
        }
        string DecodSimple(string source)
        {
            string target = "";
            int length = source.Length;
            char character;
            byte number;

            for (int r = 0; r < length; r++)
            {
                character = char.Parse(source.Substring(r, 1));
                number = (byte)character;
                number -= 128;
                target += (char)number;

            }
            return target;
        }
        private void btnEncodeComplex_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDecodeComplex_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
