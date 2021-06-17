using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Int32[] _arr = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 7, 9, 10, 14, 13 };
        var found = new Test.Found<Int32>();
        Int32? _ans = found.FoundMax2nd(_arr);
        if (_ans != null)
            Console.WriteLine($"Your _ans is a {_ans}");
        else
            Console.WriteLine($"Error! Array is empty!");
        Console.ReadLine();
    }
}

