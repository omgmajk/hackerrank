using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int test = Int32.Parse(Console.ReadLine());
        var texts = new List<string>();

        while (test > 0)
        {
            texts.Add(Console.ReadLine());
            test--;
        }

        foreach (var text in texts)
        {
            string evens = string.Empty;
            string odds = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if(i % 2 == 0)
                {
                    evens += text[i];
                }
                else
                {
                    odds += text[i];
                }
            }
            Console.WriteLine($"{evens} {odds}");
        }

    }
}
