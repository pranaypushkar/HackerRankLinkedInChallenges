using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankLinkedInChallenges
{
    public class ConsecutiveOnesInBinary
    {
        static void Main2(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string b = null;
            int count = 0;
            int count_MAX = 0;
            if (n >= 1 && n <= 1000000)
            {
                b = Convert.ToString(n, 2);
                foreach (char c in b)
                {
                    if (c == '1')
                    {
                        count++;
                        if (count > count_MAX)
                        {
                            count_MAX = count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                Console.WriteLine(count_MAX);
                Console.ReadLine();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
