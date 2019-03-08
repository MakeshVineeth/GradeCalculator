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
using System.Windows.Shapes;

namespace GradeCalculator
{
    /// <summary>
    /// Interaction logic for ChangeSubjectsUI.xaml
    /// </summary>
    public partial class ChangeSubjectsUI : Window
    {
        public ChangeSubjectsUI()
        {
            InitializeComponent();
        }

        private void SubmitSubjects_Click(object sender, RoutedEventArgs e)
        {
            if (!(subTitle1.Text == ""))
            {
                Properties.Settings.Default.subText1 = subTitle1.Text;
            }
            else
            {
                Properties.Settings.Default.subText1 = "Subject 1";
            }

            if (!(subTitle2.Text == ""))
            {
                Properties.Settings.Default.subText2 = subTitle2.Text;
            }
            else
            {
                Properties.Settings.Default.subText2 = "Subject 2";
            }

            if (!(subTitle3.Text == ""))
            {
                Properties.Settings.Default.subText3 = subTitle3.Text;
            }
            else
            {
                Properties.Settings.Default.subText3 = "Subject 3";
            }

            if (!(subTitle4.Text == ""))
            {
                Properties.Settings.Default.subText4 = subTitle4.Text;
            }
            else
            {
                Properties.Settings.Default.subText4 = "Subject 4";
            }

            if (!(subTitle5.Text == ""))
            {
                Properties.Settings.Default.subText5 = subTitle5.Text;
            }
            else
            {
                Properties.Settings.Default.subText5 = "Subject 5";
            }

            if (!(subTitle6.Text == ""))
            {
                Properties.Settings.Default.subText6 = subTitle6.Text;
            }
            else
            {
                Properties.Settings.Default.subText6 = "Subject 6";
            }

            if (!(subTitle7.Text == ""))
            {
                Properties.Settings.Default.subText7 = subTitle7.Text;
            }
            else
            {
                Properties.Settings.Default.subText7 = "Subject 7";
            }

            Properties.Settings.Default.Save();
            ((MainWindow)Application.Current.MainWindow).ChangeSubsInWindows();
            MessageBox.Show("Done");
        }
    }
}
