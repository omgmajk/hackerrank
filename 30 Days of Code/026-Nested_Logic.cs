using System;

namespace HackerRankLibraryFees
{
    class Solution
    {
        static void Main(string[] args)
        {
            var returned = Console.ReadLine().Split(' ');
            var due = Console.ReadLine().Split(' ');
            int hackos = 0;

            if (int.Parse(returned[2]) > int.Parse(due[2]))
                hackos += 10000;
            else if(int.Parse(returned[2]) == int.Parse(due[2]) &&
                    int.Parse(returned[1]) > int.Parse(due[1]))
            {
                hackos = 500 * (int.Parse(returned[1]) - int.Parse(due[1]));
            }
            else if (int.Parse(returned[2]) == int.Parse(due[2]) &&
                    int.Parse(returned[1]) == int.Parse(due[1]) &&
                    int.Parse(returned[0]) > int.Parse(due[0]))
            {
                hackos = 15 * (int.Parse(returned[0]) - int.Parse(due[0]));
            }

            Console.WriteLine(hackos);
        }
    }
}
