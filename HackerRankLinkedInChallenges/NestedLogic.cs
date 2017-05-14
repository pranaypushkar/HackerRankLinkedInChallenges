using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRankLinkedInChallenges
{
    public class NestedLogic
    {
        static void Main4(String[] args)
        {
            int fine = 0;

            string[] actualDate = Console.ReadLine().Split(' ');
            int actualDay = Convert.ToInt32(actualDate[0]);
            int actualMonth = Convert.ToInt32(actualDate[1]);
            int actualYear = Convert.ToInt32(actualDate[2]);

            string[] expectedDate = Console.ReadLine().Split(' ');
            int expectedDay = Convert.ToInt32(expectedDate[0]);
            int expectedMonth = Convert.ToInt32(expectedDate[1]);
            int expectedYear = Convert.ToInt32(expectedDate[2]);

            Validate(actualDay, actualMonth, actualYear, expectedDay, expectedMonth, expectedYear);

            if (actualYear < expectedYear)
            {
                //Environment.Exit(0);
                fine = 0;
            }
            else
            {
                if (actualYear > expectedYear)
                {
                    fine = 10000;
                }
                else if (actualYear == expectedYear)
                {
                    if (actualMonth < expectedMonth)
                    {
                        fine = 0;
                    }
                    else if (actualMonth > expectedMonth)
                    {
                        fine = 500 * (actualMonth - expectedMonth);
                    }
                    else if (actualMonth == expectedMonth)
                    {
                        if (actualDay == expectedDay)
                        {
                            fine = 0;
                        }
                        else if (actualDay > expectedDay)
                        {
                            fine = 15 * (actualDay - expectedDay);
                        }

                    }
                }
            }
            Console.WriteLine(fine);
            Console.ReadLine();
        }

        private static void Validate(int actualDay, int actualMonth, int actualYear, int expectedDay, int expectedMonth, int expectedYear)
        {
            if (!(actualDay >= 1 && actualDay <= 31))
            {
                Environment.Exit(0);
            }

            if (!(actualMonth >= 1 && actualMonth <= 12))
            {
                Environment.Exit(0);
            }

            if (!(actualYear >= 1 && actualYear <= 3000))
            {
                Environment.Exit(0);
            }
            if (!(expectedDay >= 1 && actualDay <= 31))
            {
                Environment.Exit(0);
            }

            if (!(expectedMonth >= 1 && actualMonth <= 12))
            {
                Environment.Exit(0);
            }

            if (!(expectedYear >= 1 && actualYear <= 3000))
            {
                Environment.Exit(0);
            }

        }
    }
}
