using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab1
{
    internal class OrganismsPopulation
    {

        private int populationStartSize;
        private double aveDailyIncrease;
        private int multiplyDays;

        public OrganismsPopulation(int populationStartSize, double aveDailyIncrease, int multiplyDays) 
        { 
            this.populationStartSize = populationStartSize;
            this.aveDailyIncrease = aveDailyIncrease;
            this.multiplyDays = multiplyDays;
        }

        public int getPopulationStartSize() 
        {
            return populationStartSize; 
        }

        public double getAverageDailyIncrease() 
        {
            return aveDailyIncrease;
        }

        public int getMultiplyDays() 
        {
            return multiplyDays; 
        }

        public int PopulationSizePerDay(int index)
        {
            int[] population = new int[multiplyDays];
            int popSize = populationStartSize;

            for(int i = 0; i < multiplyDays; i++)

            {
                popSize += (int)(popSize * (aveDailyIncrease/100));
                population[i] = popSize;
            }

            return population[index];
         }

        
    }
}
