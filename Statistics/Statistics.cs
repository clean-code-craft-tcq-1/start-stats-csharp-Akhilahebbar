using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;

        public StatsComputer CalculateStatistics(List<double> numbers)
        {
            if (numbers.Any(predicate: doubleValue => Double.IsNaN(doubleValue)))
            {
                return null;
            }
            else
            {
                //Implement statistics 
                this.min = numbers.Min();
                this.max = numbers.Max();
                this.average = numbers.Average();
            }
            return this;
        }
    }

}

