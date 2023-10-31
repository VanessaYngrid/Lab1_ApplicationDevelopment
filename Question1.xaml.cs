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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Question1 : Window
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void calculation_Click(object sender, RoutedEventArgs e)
        {
            BankCharges bankCharges = new BankCharges(double.Parse(accountBalance.Text), int.Parse(checkBox.Text));
            //Creating an Object of class BankCharges
            //Taking the textBox of the accountBalance and check and converting to double and int respectively


            MessageBox.Show(bankCharges.ToString() , "Your account information is: ");

        }

        private void ReturnButton1_Click(object sender, RoutedEventArgs e)
        {
            Question4 question4 = new Question4();
            question4.Show();
            this.Close();
        }
    }
}
