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

namespace BMI_Calculator
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

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            First_Name_Box.Text = "";
            Last_Name_Box.Text = "";
            Phone_Box.Text = "";
            Height_Inches_box.Text = "";
            Weights_lbs_box.Text = "";

        }
    }
}
