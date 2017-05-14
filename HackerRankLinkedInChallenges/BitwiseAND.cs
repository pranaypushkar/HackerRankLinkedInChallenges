using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankLinkedInChallenges
{
    public class BitwiseAND
    {
        static void Main1(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            int[,] A = new int[T, 2];

            var numbers = new int[T, 2];

            int check = 1;
            int count = 0;
            int bitValue = 0;

            if (T >= 1 && T <= 1000)
            {
                for (var i = 0; i < T; i++)
                {
                    var numList = new string[2];
                    numList = Console.ReadLine().Split();
                    for (var j = 0; j < 2; j++)
                    {
                        numbers[i, j] = Convert.ToInt32(numList[j]);
                    }
                    for (var j = 0; j < 2; j++)
                    {
                        if (numbers[i, 0] >= 2 && numbers[i, 0] <= 1000)
                        {
                            if (numbers[i, 1] >= 2 && numbers[i, 1] <= numbers[i, 0])
                            {
                                check = 0;
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Environment.Exit(0);
                        }

                    }

                }

                if (check == 0)
                {

                }
            }
            else
            {
                Environment.Exit(0);
            }

            if (check == 0)
            {
                for (int i = 0; i < T; i++)
                {

                    int size = numbers[i, 0];

                    int[] s = new int[size];

                    for (int l = 0; l < s.Length; l++)
                    {
                        s[l] = l + 1;
                    }

                    for (int k = 0; k < s.Length; k++)
                    {
                        for (int m = 0; m < s.Length; m++)
                        {
                            if (s[k] < s[m])
                            {
                                bitValue = s[k] & s[m];
                                if (bitValue > count && bitValue < numbers[i, 1])
                                {
                                    count = bitValue;
                                }
                            }
                        }
                    }
                    Console.WriteLine(count);
                    count = 0;
                }
            }

        }
    }
}
