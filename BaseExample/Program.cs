using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var implementation = new ChildClass("Mark Antony", "IT Developer");
            implementation.Display();
            implementation.Show();
            Console.Read();
        }
    }
}
