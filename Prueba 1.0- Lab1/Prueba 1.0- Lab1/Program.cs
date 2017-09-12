using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prueba_1._0__Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DirectoryInfo f;
            string filePath = "", name = "";
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("c:/rle>rle.exe");
                Console.SetCursorPosition(15, Console.CursorTop - 1);
                filePath = Console.ReadLine();
                f = new DirectoryInfo(filePath);
                name = f.Name + f.Extension;

                readFile(filePath, "a");
                
                //Console.WriteLine(tool.RLE_compression(filePath) + "\n\n\n");
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
        static void readFile(string path, string type)
        {
            DeCompression tool = new DeCompression();
            using (var file = new FileStream(path, FileMode.Open)) //ruta del archivo
            {
                using (var currentFile = new BinaryReader(file))
                {
                    var bytes = currentFile.ReadBytes(1024); //aconsejable 1024, devuelve el ascci de las letras, no es necesario convertir
                    while (bytes.Length > 0)
                    {
                        using (var outputFile = new FileStream("C:\\Users\\jsala\\test2.txt", FileMode.Append))
                        {
                            using (var writer = new BinaryWriter(outputFile, Encoding.ASCII))
                            {
                                for (int i = 0; i < bytes.Length; i++)
                                {
                                    //writer.Write(i.ToString().ToCharArray()); //write numbers but there's another way
                                    var c = (char)i;
                                    writer.Write(c);
                                    writer.Write(bytes[i]);
                                }


                            }
                        }
                        bytes = currentFile.ReadBytes(1024);
                    }
                }
            }
        }
        
    }
}
