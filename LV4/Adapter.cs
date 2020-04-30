using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        public double[][] ConvertData(Dataset dataset)           //1. zadatak
        {
            IList<List<double>> MatrixList = dataset.GetData();
            double[][] matrix = new double[MatrixList.Count][];
            for(int i = 0; i < MatrixList.Count; i++)
            {
                matrix[i] = new double[MatrixList[i].Count];
            }
            for(int i = 0; i < MatrixList.Count; i++)
            {
                for(int j=0;j<MatrixList[i].Count; j++)
                {
                    matrix[i][j] = MatrixList[i][j];
                }
            }
            return matrix;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
        public static void ToString(double[][] matrix)                //2. zadatak
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

