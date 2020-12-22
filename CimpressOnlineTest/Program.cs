using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressOnlineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //Console.WriteLine(Cimpress.CalculateLikeAndDislike(s1, s2));

            //Console.WriteLine("Like and Dislike Count : " + output.ToString());
            //Console.ReadLine();

            //string s =
            //int[] p = s.Split().Select(str => int.Parse(str)).ToArray();
            //Console.WriteLine(Cimpress.SolveVillageProblem(p));

            string line;
            line = "6";
            int n = Convert.ToInt32(line);
            line = "1 2 3 4 9 8";
            int[] p = new int[n];
            p = line.Split().Select(str => int.Parse(str)).ToArray();

            int out_ = solve1(p);
            Console.Out.WriteLine(out_);
        }

        static int solve(int[] p)
        {
            int listLength = 0;
            List<int> lstNumbers1 = new List<int>();
            List<int> lstExcluded = new List<int>();
            lstNumbers1.Add(p[0]);

            for (int x = 1; x < p.Length; x++)
            {
                listLength = lstNumbers1.Count - 1;

                if ((p[x] > lstNumbers1[listLength]) && (p[x] % lstNumbers1[listLength] == 0))
                {
                    lstNumbers1.Add(p[x]);
                }
                else
                {
                    lstExcluded.Add(p[x]);
                }
            }

            listLength = 0;
            List<int> lstNumbers = new List<int>();
            lstNumbers.Add(p[0]);

            for (int x = 1; x < p.Length; x++)
            {
                listLength = lstNumbers.Count - 1;

                if ((p[x] > lstNumbers[listLength]) && (p[x] % lstNumbers[listLength] == 0))
                {
                    lstNumbers.Add(p[x]);
                }

            }

            if (lstNumbers.Sum() > lstNumbers1.Sum())
            {
                return lstNumbers.Sum();
            }
            else
            {
                return lstNumbers1.Sum();
            }
        }

        static int solve1(int[] p)
        {
            int prevVillageIndex = 0;
            int previousProfit = 0;

            List<int> profitSum = new List<int>();

            for (int j = 0; j < p.Length; j++)
            {
                List<int> profit = new List<int>();
                prevVillageIndex = 0;
                previousProfit = 0;

                for (int i = 0 + j; i < p.Length; i++)
                {
                    if (i == j)
                    {
                        profit.Add(Convert.ToInt32(p[i]));
                        previousProfit = Convert.ToInt32(p[i]);                       
                    }
                    else
                    {
                        if (Convert.ToInt32(p[i]) % previousProfit == 0)
                        {
                            previousProfit = Convert.ToInt32(p[i]);
                            profit.Add(previousProfit);
                            
                            prevVillageIndex++;
                        }
                    }

                }

                profitSum.Add(profit.Sum(x => x));
                
            }

            return profitSum.Max();
        }
    }

    public static class Cimpress
    {
        public static int CalculateLikeAndDislike(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return 0;
            }

            char[] s1Arr = s1.ToCharArray();
            char[] s2Arr = s2.ToCharArray();

            int count = 0;

            for (int x = 0; x < s1Arr.Length; x++)
            {
                if (s1Arr[x] == s2Arr[x])
                {
                    count = count + 1;
                }
            }

            return count;
        }

       
    }
}
