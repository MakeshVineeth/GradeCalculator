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
            toggleBtnSGPA.IsChecked = true;
            ToggleBtnCGPA.IsChecked = true;
            ChangeSubsInWindows();
            
        }

        public void ChangeSubsInWindows()
        {
            subCheckBox1.Content = Properties.Settings.Default.subText1;
            subCheckBox2.Content = Properties.Settings.Default.subText2;
            subCheckBox3.Content = Properties.Settings.Default.subText3;
            subCheckBox4.Content = Properties.Settings.Default.subText4;
            subCheckBox5.Content = Properties.Settings.Default.subText5;
            subCheckBox6.Content = Properties.Settings.Default.subText6;
            subCheckBox7.Content = Properties.Settings.Default.subText7;
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

        private void ChangeSubs_Click(object sender, RoutedEventArgs e)
        {
            ChangeSubjectsUI changeSubjectsUI = new ChangeSubjectsUI();
            changeSubjectsUI.Show();
        }

        #region Subject Checkboxes SGPA

        private void SubCheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            Credit1.IsEnabled = true;
            Grade1.IsEnabled = true;
        }

        private void SubCheckBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit1.IsEnabled = false;
            Grade1.IsEnabled = false;
        }

        private void SubCheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            Credit2.IsEnabled = true;
            Grade2.IsEnabled = true;
        }

        private void SubCheckBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit2.IsEnabled = false;
            Grade2.IsEnabled = false;
        }

        private void SubCheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            Credit3.IsEnabled = true;
            Grade3.IsEnabled = true;
        }

        private void SubCheckBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit3.IsEnabled = false;
            Grade3.IsEnabled = false;
        }

        private void SubCheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            Credit4.IsEnabled = true;
            Grade4.IsEnabled = true;
        }

        private void SubCheckBox4_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit4.IsEnabled = false;
            Grade4.IsEnabled = false;
        }

        private void SubCheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            Credit5.IsEnabled = true;
            Grade5.IsEnabled = true;
        }

        private void SubCheckBox5_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit5.IsEnabled = false;
            Grade5.IsEnabled = false;
        }

        private void SubCheckBox6_Checked(object sender, RoutedEventArgs e)
        {
            Credit6.IsEnabled = true;
            Grade6.IsEnabled = true;
        }

        private void SubCheckBox6_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit6.IsEnabled = false;
            Grade6.IsEnabled = false;
        }

        private void SubCheckBox7_Checked(object sender, RoutedEventArgs e)
        {
            Credit7.IsEnabled = true;
            Grade7.IsEnabled = true;
        }

        private void SubCheckBox7_Unchecked(object sender, RoutedEventArgs e)
        {
            Credit7.IsEnabled = false;
            Grade7.IsEnabled = false;
        }
        #endregion

        #region Sem Checkboxes

        private void SemChechBox1_Checked(object sender, RoutedEventArgs e)
        {
            Cre1.IsEnabled = true;
            sgpaGrade1.IsEnabled = true;
        }

        private void SemChechBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre1.IsEnabled = false;
            sgpaGrade1.IsEnabled = false;
        }

        private void SemChechBox2_Checked(object sender, RoutedEventArgs e)
        {
            Cre2.IsEnabled = true;
            sgpaGrade2.IsEnabled = true;
        }

        private void SemChechBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre2.IsEnabled = false;
            sgpaGrade2.IsEnabled = false;
        }

        private void SemChechBox3_Checked(object sender, RoutedEventArgs e)
        {
            Cre3.IsEnabled = true;
            sgpaGrade3.IsEnabled = true;
        }

        private void SemChechBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre3.IsEnabled = false;
            sgpaGrade3.IsEnabled = false;
        }

        private void SemChechBox4_Checked(object sender, RoutedEventArgs e)
        {
            Cre4.IsEnabled = true;
            sgpaGrade4.IsEnabled = true;
        }

        private void SemChechBox4_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre4.IsEnabled = false;
            sgpaGrade4.IsEnabled = false;
        }

        private void SemChechBox5_Checked(object sender, RoutedEventArgs e)
        {
            Cre5.IsEnabled = true;
            sgpaGrade5.IsEnabled = true;
        }

        private void SemChechBox5_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre5.IsEnabled = false;
            sgpaGrade5.IsEnabled = false;
        }

        private void SemChechBox6_Checked(object sender, RoutedEventArgs e)
        {
            Cre6.IsEnabled = true;
            sgpaGrade6.IsEnabled = true;
        }

        private void SemChechBox6_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre6.IsEnabled = false;
            sgpaGrade6.IsEnabled = false;
        }

        private void SemChechBox8_Checked(object sender, RoutedEventArgs e)
        {
            Cre8.IsEnabled =true;
            sgpaGrade8.IsEnabled = true;
        }

        private void SemChechBox8_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre8.IsEnabled = false;
            sgpaGrade8.IsEnabled = false;
        }

        private void SemChechBox7_Checked(object sender, RoutedEventArgs e)
        {
            Cre7.IsEnabled = true;
            sgpaGrade7.IsEnabled = true;
        }

        private void SemChechBox7_Unchecked(object sender, RoutedEventArgs e)
        {
            Cre7.IsEnabled = false;
            sgpaGrade7.IsEnabled = false;
        }

        #endregion

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
                    case "AB": G = 0; displayBox.Text = ""; break;
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
            else
            {
                if (!(textBox.Text == ""))
                {
                    resultCGPA.Text = "Invalid Input";
                }
                else
                {
                    G = 0;
                    resultCGPA.Text = "";
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
                    /*double SGPA = V / (double)C;*/
                    double SGPA = V;
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

        private void ToggleBtn_IsChecked(object sender, RoutedEventArgs e)
        {
                foreach (UIElement gridItem in gridSGPA.Children)
                {
                    if (gridItem.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)gridItem).IsChecked = true;
                    }
                }
        }

        private void ToggleBtn_IsUnchecked(object sender, RoutedEventArgs e)
        {
            foreach (UIElement gridItem in gridSGPA.Children)
            {
                if (gridItem.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)gridItem).IsChecked = false;
                }
            }
        }

        private void ToggleBtnCGPA_IsChecked(object sender, RoutedEventArgs e)
        {
            foreach (UIElement gridItem in gridCGPA.Children)
            {
                if (gridItem.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)gridItem).IsChecked = true;
                }
            }
        }

        private void ToggleBtnCGPA_IsUnchecked(object sender, RoutedEventArgs e)
        {
            foreach (UIElement gridItem in gridCGPA.Children)
            {
                if (gridItem.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)gridItem).IsChecked = false;
                }
            }
        }
    }
}
