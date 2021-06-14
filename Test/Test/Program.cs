using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Int32[] arr = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 7, 9, 10, 14, 13 };
        var found = new Test.Found();
        var ans = found.FoundMax2nd(arr);
        if (ans != null)
            Console.WriteLine($"Your ans is a {ans}");
        else
            Console.WriteLine($"Error! Array is empty!");
        Console.ReadLine();
    }
}

