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
    }
}
