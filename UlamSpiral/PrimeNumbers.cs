using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamSpiral
{
    public class PrimeNumbers
    {
        public bool[] MakeSieve(int max)
        {
            // Make an array indicating whether numbers are prime.
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            // Cross out multiples.
            for (int i = 2; i <= max; i++)
            {
                // See if i is prime.
                if (is_prime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
        public Tuple<int,int> CalculatePointByIndex(int index)
        {
            int m = Convert.ToInt32(Math.Floor((Math.Sqrt(index) + 1) / 2));
            int k = index - (4 * m*(m - 1));

            if ((k>1) && (k < (2*m)))
            {
                return new Tuple<int, int>(m, k - m);
            }
            else if ((k >= (2*m) ) && (k<(4*m)))
            {
                return new Tuple<int, int>(3 * m - k, m);
            }
            else if ((k >= (4*m)) && (k<(6*m)))
            {
                return new Tuple<int, int>(-1 * m, 5 * m - k);
            }
            else if ((k >= (6*m)) &&  (k<(8*m)))
            {
                return new Tuple<int, int>(k - (7 * m), -1 * m);
            }
            // This function will calculate the cartesian point given an index
            return new Tuple<int, int>(0, 0);
        }
    }
}
