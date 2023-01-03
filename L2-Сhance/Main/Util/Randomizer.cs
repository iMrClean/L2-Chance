using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Util
{
    internal class Randomizer
    {
        private static readonly Random random = new Random();
        private const int MIN_VALUE = 0;
        private const int MAX_VALUE = 101;

        public static int GenerateRandomValue() 
        { 
            return random.Next(MIN_VALUE, MAX_VALUE);
        }
    }
}
