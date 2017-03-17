using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class DiagonalDifference
    {
        static void Main(String[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[][] matrix = new int[n][n];
            
            for(int i = 0;i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matrix[i][j] = Int32.Parse(Console.ReadLine());
                }
            }

        }
    }
}
