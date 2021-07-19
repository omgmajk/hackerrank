using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int num = Int32.Parse(Console.ReadLine());
        double dub = Double.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        Console.WriteLine(i + num);
        Console.WriteLine("{0:0.0}",d + dub);
        Console.WriteLine(s + str);

    }
}
