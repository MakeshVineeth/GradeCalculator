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
        int c1, c2, c3, c4, c5, c6, c7, c8;
        double g1, g2, g3, g4, g5, g6, g7, g8;

     

        #region Verify the Credits


        private void Credit5_TextChanged(object sender, TextChangedEventArgs e)
        {
            C5 = VerifyCredits(sender);
            SumUp();
        }

        private void Credit6_TextChanged(object sender, TextChangedEventArgs e)
        {
            C6 = VerifyCredits(sender);
            SumUp();
        }

        private void Credit2_TextChanged(object sender, TextChangedEventArgs e)
        {
            C2 = VerifyCredits(sender);
            SumUp();
        }



        private void Credit7_TextChanged(object sender, TextChangedEventArgs e)
        {
            C7 = VerifyCredits(sender);
            SumUp();
        }

        private void Credit4_TextChanged(object sender, TextChangedEventArgs e)
        {
            C4 = VerifyCredits(sender);
            SumUp();
        }

        private void Credit3_TextChanged(object sender, TextChangedEventArgs e)
        {
            C3 = VerifyCredits(sender);
            SumUp();
        }

   

        private void Credit1_TextChanged(object sender, TextChangedEventArgs e)
        {
            C1 = VerifyCredits(sender);
            SumUp();
        }
        #endregion


        #region Verify the Credits in CGPA
        private void Cre1_TextChanged(object sender, TextChangedEventArgs e)
        {
            c1 = VerifyCreditsCGPA(sender);
            SumUpCGPA();
        }

        private void Cre2_TextChanged(object sender, TextChangedEventArgs e)
        {
            c2 = VerifyCreditsCGPA(sender); SumUpCGPA();
        }

        private void Cre3_TextChanged(object sender, TextChangedEventArgs e)
        {
            c3 = VerifyCreditsCGPA(sender); SumUpCGPA();
        }

        private void Cre4_TextChanged(object sender, TextChangedEventArgs e)
        {
            c4 = VerifyCreditsCGPA(sender); SumUpCGPA();
        }

        private void Cre5_TextChanged(object sender, TextChangedEventArgs e)
        {
            c5 = VerifyCreditsCGPA(sender); SumUpCGPA();
        }

        private void Cre6_TextChanged(object sender, TextChangedEventArgs e)
        {
            c6 = VerifyCreditsCGPA(sender); SumUpCGPA();
        }

        private void Cre7_TextChanged(object sender, TextChangedEventArgs e)
        {
            c7 = VerifyCreditsCGPA(sender); SumUpCGPA();
        }

        private void Cre8_TextChanged(object sender, TextChangedEventArgs e)
        {
            c8 = VerifyCreditsCGPA(sender); SumUpCGPA();
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
                    C = 0; // Error Detection
                    displayBox.Text = "Invalid Input";
                }
                else
                {
                    displayBox.Text = "";
                }

            }
            else
            {
                if (!(textBox.Text == ""))
                {
                    C = 0; // Error Detection
                    displayBox.Text = "Invalid Input";
                }
                else
                {
                    displayBox.Text = "";
                }
                
            }

            return C;
        }

        public int VerifyCreditsCGPA(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int C))
            {
                if (C < 0)
                {
                    C = 0; // Error Detection
                    resultCGPA.Text = "Invalid Input";
                }
                else
                {
                    resultCGPA.Text = "";
                }

            }
            else
            {
                if (!(textBox.Text == ""))
                {
                    C = 0; // Error Detection
                    resultCGPA.Text = "Invalid Input";
                }
                else
                {
                    resultCGPA.Text = "";
                }

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

        #region Check SGPA

        private void SgpaGrade1_TextChanged(object sender, TextChangedEventArgs e)
        {
            g1 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade2_TextChanged(object sender, TextChangedEventArgs e)
        {
            g2 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade3_TextChanged(object sender, TextChangedEventArgs e)
        {
            g3 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade4_TextChanged(object sender, TextChangedEventArgs e)
        {
            g4 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade5_TextChanged(object sender, TextChangedEventArgs e)
        {
            g5 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade6_TextChanged(object sender, TextChangedEventArgs e)
        {
            g6 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade7_TextChanged(object sender, TextChangedEventArgs e)
        {
            g7 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }

        private void SgpaGrade8_TextChanged(object sender, TextChangedEventArgs e)
        {
            g8 = VerifyGradeCGPA(sender);
            SumUpCGPA();
        }
        #endregion

        public int VerifyGrade(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int G))
            {
                if (G < 0)
                {
                    G = 0; // Error Detection
                    displayBox.Text = "Incorrect Input";
                }
                else
                {
                    displayBox.Text = ""; // If Input is > 0 then clear invalid text
                }
            }
            else
            {
                switch (textBox.Text)
                {
                    case "": G = 0; displayBox.Text = ""; break;
                    case "O": G = 10; displayBox.Text = ""; break;
                    case "A+": G = 9; displayBox.Text = ""; break;
                    case "A": G = 8; displayBox.Text = ""; break;
                    case "B+": G = 7; displayBox.Text = ""; break;
                    case "B": G = 6; displayBox.Text = ""; break;
                    case "C": G = 5; displayBox.Text = ""; break;
                    case "P": G = 4; displayBox.Text = ""; break;
                    case "F": G = 0; displayBox.Text = ""; break;
                    case "Ab": G = 0; displayBox.Text = ""; break;
                    default:displayBox.Text="Invalid Input"; break;
                }

            }

            return G;
        }

        public double VerifyGradeCGPA(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (double.TryParse(textBox.Text, out double G))
            {
                if (G < 0)
                {
                    G = 0; // Error Detection
                    resultCGPA.Text = "Incorrect Input";
                }
                else
                {
                    resultCGPA.Text = ""; // If Input is > 0 then clear invalid text
                }
            }

            return G;
        }

        public void SumUp()
        {
            if (!(displayBox.Text == "Invalid Input"))
            {
                int C = C1 + C2 + C3 + C4 + C5 + C6 + C7;
                if (!(C == 0))
                {
                    int V1 = C1 * G1;
                    int V2 = C2 * G2;
                    int V3 = C3 * G3;
                    int V4 = C4 * G4;
                    int V5 = C5 * G5;
                    int V6 = C6 * G6;
                    int V7 = C7 * G7;
                    int V = V1 + V2 + V3 + V4 + V5 + V6 + V7;
                    double SGPA = V / (double)C;
                    displayBox.Text = SGPA.ToString("0.##");
                }
                
            }

        }

        public void SumUpCGPA()
        {
            if (!(displayBox.Text == "Invalid Input"))
            {

                int C = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8;
                if (!(C == 0))
                {
                    double V1 = c1 * g1;
                    double V2 = c2 * g2;
                    double V3 = c3 * g3;
                    double V4 = c4 * g4;
                    double V5 = c5 * g5;
                    double V6 = c6 * g6;
                    double V7 = c7 * g7;
                    double V8 = c8 * g8;
                    double V = V1 + V2 + V3 + V4 + V5 + V6 + V7 + V8;
                    double CGPA = V / (double)C;
                    resultCGPA.Text = CGPA.ToString("0.##");
                }                

            }

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

        private void ResetBtnCGPA_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement gridItem in gridCGPA.Children)
            {
                if (gridItem.GetType() == typeof(TextBox))
                {
                    ((TextBox)gridItem).Text = string.Empty;
                }
            }
        }
    }
}
