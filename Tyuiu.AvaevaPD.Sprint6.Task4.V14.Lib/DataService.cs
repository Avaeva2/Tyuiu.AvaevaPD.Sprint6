using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AvaevaPD.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; //объявляем пустой массив
            int len = (stopValue - startValue) + 1; //вычисляем длину массива
            valueArray = new double[len]; // создаем массив с указанной длиной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x ++)

            {
                if ((Math.Sin(x) + 1) == 0)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
                y =  Math.Round(2 * x - 4 + ((2 * x -1)/ Math.Sin(x) + 1), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
