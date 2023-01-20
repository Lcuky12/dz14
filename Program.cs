using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            int time = 20;
            int temporaryAge;
            Console.WriteLine(age);
            Console.WriteLine(time);
            temporaryAge = age;
            age = time;
            time = temporaryAge;
            Console.WriteLine(age);
            Console.WriteLine(time);
        }
    }
}
