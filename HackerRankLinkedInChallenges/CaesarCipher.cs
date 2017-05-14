using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankLinkedInChallenges
{
    public class CaesarCipher
    {
        static void Main3(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            if (!(n >= 1 && n <= 100))
            {
                Environment.Exit(0);
            }

            if (!(k >= 0 && k <= 100))
            {
                Environment.Exit(0);
            }

            if (n != s.Length)
            {
                Environment.Exit(0);
            }


            string enc = null;

            StringBuilder sb = new StringBuilder();

            char[] smallLetters = new char[26];

            for (int i = 97; i <= 122; i++)
            {
                smallLetters[i - 97] = (char)i;
            }

            char[] capitalLetters = new char[26];

            for (int i = 65; i <= 90; i++)
            {
                capitalLetters[i - 65] = (char)i;
            }

            int rem = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 97 && s[i] <= 122) || (s[i] >= 65 && s[i] <= 90))
                {
                    if ((s[i] >= 97 && s[i] <= 122))
                    {
                        if ((s[i] + k) > 122)
                        {

                            rem = (k - (122 - s[i])) % 26;
                            if (rem == 0)
                            {
                                sb.Append('z');
                            }
                            else
                            {
                                sb.Append(smallLetters[rem - 1]);
                            }
                        }
                        else
                        {
                            sb.Append((char)(s[i] + k));
                        }
                    }
                    else if ((s[i] >= 65 && s[i] <= 90))
                    {
                        if ((s[i] + k) > 90)
                        {
                            rem = (k - (90 - s[i])) % 26;
                            if (rem == 0)
                            {
                                sb.Append('Z');
                            }
                            else
                            {
                                sb.Append(capitalLetters[rem - 1]);
                            }
                        }
                        else
                        {
                            sb.Append((char)(s[i] + k));
                        }
                    }
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            enc = sb.ToString();
            Console.WriteLine(enc);

        }
    }
}
