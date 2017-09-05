using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_1._0__Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DeCompression tool = new DeCompression();
            Console.WriteLine("De/Compression program\nWrite a ");
            string s = Console.ReadLine();
            Console.WriteLine(tool.RLE_compression(s));
            Console.ReadLine();
            
        }
    }
}
