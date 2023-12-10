using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.AvaevaPD.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length /rows;
            int[,] mtrx = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j ++)
                {
                    
                    if (matrix [i,j] >= 5 && matrix[i,j] <=10)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
