using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || percent <= 0 || currentPopulation <= 0)
                throw new ArgumentException();
            if (initialPopulation == Int32.MaxValue || percent == Int32.MaxValue || currentPopulation == Int32.MaxValue)
                throw new OverflowException(); 
            int god = 0;
            for (; currentPopulation > initialPopulation; god++) 
            {
                initialPopulation = Convert.ToInt32(initialPopulation * (percent / 100) + initialPopulation+ visitors);
            }
            return god;
        }
    }
}