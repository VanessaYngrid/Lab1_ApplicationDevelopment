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
    /// Interaction logic for Question4.xaml
    /// </summary>
    public partial class Question4 : Window
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            if (program1.IsChecked == true)
            {
                Question1 program1 = new Question1();
                program1.Show();
                this.Close();
            }

            if (program2.IsChecked == true)
            {
                Question2 program2 = new Question2();
                program2.Show();
                this.Close();
            }

            if (program3.IsChecked == true) 
            { 
                Question3 program3 = new Question3();
                program3.Show();
                this.Close();
            }
        }
    }
}
