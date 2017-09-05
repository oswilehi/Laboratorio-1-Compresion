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
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("c:/rle>rle.exe");
                Console.SetCursorPosition(15, Console.CursorTop - 1);
                string s = Console.ReadLine();
                Console.WriteLine(tool.RLE_compression(s) + "\n\n\n");
                exit = true ;
            }
            Console.ReadLine();
            
            
        }
        static bool validation(string command)
        {
            if (command.Length < 7) //min value
                return false;
            for (int i = 0; i < command.Length; i++)
            {
                if (i == 0 && command[0] != '-' || command[i + 1] != 'c' || command[i + 1] != 'd')
                    return false;
                if (i == 3 && command[0] != '-' || command[i + 1] != 'f' || command[i + 2] != '"')
                    return false;
                if (command[command.Length - 1] != '"')
                    return false;
               
            }
            return true;
        }
        
    }
}
