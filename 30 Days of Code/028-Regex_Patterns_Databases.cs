using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*
    This is meant to be made into a regex exercise but string.Contains works out in our favor here.
    Could be simplified even more by not using a method but it was easier this way.
*/

class Solution
{
    public static bool getName(string name, string email)
    {
        if(email.Contains("@gmail.com"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        var names = new List<string>();
        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];

            if(getName(firstName, emailID) == true)
            {
                names.Add(firstName);
            }

        }
        names.Sort();
        foreach(var x in names)
        {
            Console.WriteLine(x);
        }
    }
}
