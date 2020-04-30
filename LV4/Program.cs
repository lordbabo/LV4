using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)                                       //2. zadatak
        {
            Dataset csvDat = new Dataset(@"C:\Users\slave\Desktop\lv4.csv");
            Adapter adapter = new Adapter(new Analyzer3rdParty());
            double[][] matrix = adapter.ConvertData(csvDat);
            foreach(double d in adapter.CalculateAveragePerColumn(csvDat))
            {
                Console.WriteLine(d);
            }
            Adapter.ToString(matrix);

        }
    }
}
