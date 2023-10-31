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
    /// Interaction logic for Question3.xaml
    /// </summary>
    public partial class Question3 : Window
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void DailyPopulation_Click(object sender, RoutedEventArgs e)
        {
            OrganismsPopulation dailyPopulation = new OrganismsPopulation(int.Parse(PopulationSize.Text), double.Parse(AveDailyIncrease.Text), int.Parse(MultiplyDay.Text));

            try
            {
                if (dailyPopulation.getPopulationStartSize() < 2)
                {
                    throw new Exception("Invalid input! The population starting size can not be less than 2");
                }

                if (dailyPopulation.getAverageDailyIncrease() < 0)
                {
                    throw new Exception("Invalid input! The average daily increase can not be negative");
                }

                if (dailyPopulation.getMultiplyDays() < 1)
                {
                    throw new Exception("Invalid input! The number of multiply days can not be less than 1");
                }

                for(int i = 0; i < int.Parse(MultiplyDay.Text); i++)
                {
                    MessageBox.Show("the daily population is: " + dailyPopulation.PopulationSizePerDay(i));
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void ReturnButton3_Click(object sender, RoutedEventArgs e)
        {
            Question4 question4 = new Question4();
            question4.Show();
            this.Close();
        }
    }
}
