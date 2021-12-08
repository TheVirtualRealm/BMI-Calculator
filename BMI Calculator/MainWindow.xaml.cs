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

        #region Part 1 of the Lab. ClearBtn & ExitBtn
        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            First_Name_Box.Text = "";
            Last_Name_Box.Text = "";
            Phone_Box.Text = "";
            Height_Inches_box.Text = "";
            Weights_lbs_box.Text = "";

        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        public class Customer
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string phoneNumbers { get; set; }
            public int heightInches { get; set; }
            public int weightLbs { get; set; }
            public int customBMI { get; set; }
            public string statusTitle { get; set; }
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            

            Customer customer1 = new Customer();

            customer1.lastName = Last_Name_Box.Text;

            customer1.firstName = First_Name_Box.Text;

            customer1.phoneNumbers = Phone_Box.Text;

            int currentWeight = 0;
            int currentHeight = 0;
            Int32.TryParse(Weights_lbs_box.Text, out currentWeight);
            Int32.TryParse(Height_Inches_box.Text, out currentHeight);
            customer1.weightLbs = currentWeight;
            customer1.heightInches = currentHeight;

            int bmi;
            bmi = 703 * customer1.weightLbs / (customer1.heightInches * customer1.heightInches);
            customer1.customBMI = bmi;


            string yourBMISataus = "NA";
            customer1.statusTitle = yourBMISataus;

            BMI_Results.Text = bmi.ToString();


            if (bmi < 18.5)
            {
                Message_Box.Text = "According to CDC.gov BMI Calculator you are underweight.";
                customer1.statusTitle = "Underweight";
            }
            if (bmi < 24.9)
            {
                Message_Box.Text = "According to CDC.gov BMI Calculator you have a normal body weight.";
                customer1.statusTitle = "Normal";
            }
            if (bmi < 29.9)
            {
                Message_Box.Text = "According to CDC.gov BMI Calculator you are overweight.";
                customer1.statusTitle = "Overweight";
            }
            else
            {
                Message_Box.Text = "According to CDC.gov BMI Calculator you are obese.";
                customer1.statusTitle = "Obese";
            }
            
            //MessageBox.Show($"The customers name is {First_Name_Box.Text} {Last_Name_Box.Text} and they can be reached at {Phone_Box.Text}. They are {Height_Inches_box.Text} inches tall. Their weight is {Weights_lbs_box.Text} pounds.");
        }


    }
}
