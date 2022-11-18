using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays
{
    public  class Program2
    {
        private static void Main(string[] args)
        {
         //syntax of array in C#
         int[] numbers = { 10, 20, 30, 40, 50 };
         string[] names = { "Anmol", "Kishor", "Rajesh" };

        for (int i = names.Length - 1; i >= 0; i--) 
        {
          names[0] = "Test";
          Console.WriteLine(names[i]);
        }
        //foreach Loop
        foreach(int n in numbers)
        {
            if (n>0)
           Console.WriteLine(n);   
        }
         foreach(string nm in names)
        {
           Console.WriteLine(nm);  
        }
        }
    }
}
