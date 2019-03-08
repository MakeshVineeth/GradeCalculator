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
            Properties.Settings.Default.subText1 = subTitle1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Done");
        }
    }
}
