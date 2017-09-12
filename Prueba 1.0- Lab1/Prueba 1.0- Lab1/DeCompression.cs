using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Prueba_1._0__Lab1
{
    class DeCompression
    {
        
    
        public string RLE_compression(string data) 
        {
            StringBuilder rle = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                int pivot = 1; //minimo es 1
                while (i+1 < data.Length && data[i] == data[i+1])
                {
                    pivot++;
                    i++;
                }
                rle.Append(pivot);
                rle.Append(data[i]);
            }
            return rle.ToString();
        }
        
        public int compressionRatio(int sizeAfter, int sizeBefore)
        {
            return sizeAfter / sizeBefore;
        }
        public int compressionFactor(int sizeBefore, int sizeAfter)
        {
            return sizeBefore / sizeAfter;
        }
        public double savingPercentage(int sizeBefore, int sizeAfter)
        {
            return (sizeBefore - sizeAfter) / sizeBefore;
        }

        public void RLE_decompression(string filepath)
        {
            using (var file = new FileStream(filepath, FileMode.Open)) 
            {
                using (var currentFile = new BinaryReader(file))
                {
                    var bytes = currentFile.ReadBytes((int)file.Length); //aconsejable 1024, devuelve el ascci de las letras, no es necesario convertir
                    int count = 0;
                    using (var outputFile = new FileStream("C:\\Users\\jsala\\test2.txt", FileMode.Append))
                    {
                        using (var writer = new BinaryWriter(outputFile, Encoding.ASCII))
                        {
                            for (int i = 0; i < bytes.Length; i++)//fijo ya se que el primero es un número 
                            {
                                count = bytes[i];
                                while (count > 0)
                                {
                                    var c = (char)i;
                                    writer.Write(c);
                                    writer.Write(bytes[i]);
                                    count--;
                                }
                                i++;

                            }
                            
                        }
                    }
                   
                                        
                }
            }
        }



    }
}
