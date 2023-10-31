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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for Question2.xaml
    /// </summary>
    public partial class Question2 : Window
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void ShippingCharges_Click(object sender, RoutedEventArgs e)
        {
            FFShipping ffShipping = new FFShipping (int.Parse(weightBox.Text), int.Parse(milesBox.Text));

            MessageBox.Show(ffShipping.ToString(), "The shipping charges is: ");

               
        }

        private void ReturnButton2_Click(object sender, RoutedEventArgs e)
        {
            Question4 question4 = new Question4();
            question4.Show();
            this.Close();
        }
    }
}
