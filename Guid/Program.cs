using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Guid
{
    class Program
    {
        static void Main(string[] args)
        {
            MD5 c = MD5.Create();
            var computeHash = c.ComputeHash(System.Text.Encoding.UTF8.GetBytes("Antony"));
            var customGuid = new System.Guid(computeHash);
            Console.Write(System.Guid.NewGuid());
            Console.Read();
        }
    }
}
