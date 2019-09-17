using System;
using System.Collections;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add('A');
            al.Add('B');
            al.Add('C');
            al.Add('D');
            foreach (char c in al) Console.WriteLine(c + "");
            Console.WriteLine($"Capacity:  {al.Capacity}");
        
        }
    }
}
