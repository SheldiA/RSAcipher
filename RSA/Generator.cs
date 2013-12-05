using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSA
{
    class Generator
    {
        public int GenerateBigPrimeInteger()
        {
            int result = 0;

            return result;
        }

        private int EuclideanAlgorithm(int a, int b)
        {
            int temp = 0;
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        public int GenerateCoprimeInteger(int primeInteger)
        {
            int result = 0;

            for (int i = 4; i < primeInteger; ++i)
            {
                if (EuclideanAlgorithm(primeInteger, i) == 1)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
