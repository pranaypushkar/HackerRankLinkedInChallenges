using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRankLinkedInChallenges
{
    public class DictionariesAndMaps
    {
        static void Main5(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] pairs = Console.ReadLine().Split(' ');
                string key = Convert.ToString(pairs[0]);
                int value = Convert.ToInt32(pairs[1]);

                dictionary.Add(key, value);
            }


            List<string> input = new List<string>();

            string line;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                input.Add(line);
            }


            for (int i = 0; i < input.Count; i++)
            {
                int test = 0;

                if (dictionary.TryGetValue(Convert.ToString(input[i]), out test))
                {
                    Console.WriteLine(Convert.ToString(input[i]) + "=" + test);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadLine();

        }
    }
}
