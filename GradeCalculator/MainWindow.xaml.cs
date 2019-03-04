using System.Windows;
using System.Windows.Controls;

namespace GradeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int C1, C2, C3, C4, C5, C6, C7;
        int G1, G2, G3, G4, G5, G6, G7;

     

        #region Verify the Credits


        private void Credit5_TextChanged(object sender, TextChangedEventArgs e)
        {
            C5 = VerifyCredits(sender);
        }

        private void Credit6_TextChanged(object sender, TextChangedEventArgs e)
        {
            C6 = VerifyCredits(sender);
        }

        private void Credit2_TextChanged(object sender, TextChangedEventArgs e)
        {
            C2 = VerifyCredits(sender);
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
                    displayBox.Text = "";
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

        #region Verify the Grades
        private void Grade1_TextChanged(object sender, TextChangedEventArgs e)
        {
            G1 = VerifyGrade(sender);
            SumUp();
        }

        private void Grade2_TextChanged(object sender, TextChangedEventArgs e)
        {
            G2 = VerifyGrade(sender);
            SumUp();
        }

        private void Grade3_TextChanged(object sender, TextChangedEventArgs e)
        {
            G3 = VerifyGrade(sender);
            SumUp();
        }

        private void Grade4_TextChanged(object sender, TextChangedEventArgs e)
        {
            G4 = VerifyGrade(sender);
            SumUp();
        }

        private void Grade5_TextChanged(object sender, TextChangedEventArgs e)
        {
            G5 = VerifyGrade(sender);
            SumUp();
        }

        private void Grade6_TextChanged(object sender, TextChangedEventArgs e)
        {
            G6 = VerifyGrade(sender);
            SumUp();
        }

        private void Grade7_TextChanged(object sender, TextChangedEventArgs e)
        {
            G7 = VerifyGrade(sender);
            SumUp();
        }

        #endregion

        public int VerifyGrade(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int G))
            {
                if (G < 0)
                {
                    G = 0;
                }
            }
            else
            {
                switch (textBox.Text)
                {
                    case "": G = 0;break;
                    case "O": G = 10; break;
                    case "A+": G = 9; break;
                    case "A": G = 8; break;
                    case "B+": G = 7; break;
                    case "B": G = 6; break;
                    case "C": G = 5; break;
                    case "P": G = 4; break;
                    case "F": G = 0; break;
                    case "Ab": G = 0; break;
                    default:displayBox.Text="Invalid Input"; break;
                }

            }

            return G;
        }

        public void SumUp()
        {
            int C = C1 + C2 + C3 + C4 + C5 + C6 + C7;
            int V1 = C1 * G1;
            int V2 = C2 * G2;
            int V3 = C3 * G3;
            int V4 = C4 * G4;
            int V5 = C5 * G5;
            int V6 = C6 * G6;
            int V7 = C7 * G7;
            int V = V1 + V2 + V3 + V4 + V5 + V6 + V7;
            double SGPA = V / (double) C;
            displayBox.Text = SGPA.ToString();
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement gridItem in gridSGPA.Children)
            {
                if (gridItem.GetType() == typeof(TextBox))
                {
                    ((TextBox)gridItem).Text = string.Empty;
                }
            }
        }
    }
}
