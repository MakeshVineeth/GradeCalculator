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
using System.Windows.Threading;

namespace GradeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Verify the Credits
        int C1, C2, C3, C4, C5, C6, C7;

        private void Credit5_TextChanged(object sender, TextChangedEventArgs e)
        {
            C5 = VerifyCredits(sender);
        }

        private void Credit6_TextChanged(object sender, TextChangedEventArgs e)
        {
            C6 = VerifyCredits(sender);
        }

        private void Credit7_TextChanged(object sender, TextChangedEventArgs e)
        {
            C7 = VerifyCredits(sender);
        }

        private void Credit4_TextChanged(object sender, TextChangedEventArgs e)
        {
            C4 = VerifyCredits(sender);
        }

        private void Credit3_TextChanged(object sender, TextChangedEventArgs e)
        {
            C3 = VerifyCredits(sender);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            C2 = VerifyCredits(sender);
        }


        private void Credit1_TextChanged(object sender, TextChangedEventArgs e)
        {
            C1 = VerifyCredits(sender);
        }
#endregion

        public MainWindow()
        {
            InitializeComponent();
         
        }

        public int VerifyCredits(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int C))
            {
                if (C < 0)
                {
                    C = 0;
                }
            }
            else
            {
                if (!(textBox.Text == ""))
                {
                    displayBox.Text = "Not Valid";
                }

                C = 0;
            }

            return C;
        }

    }
}
