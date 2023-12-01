using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AvaevaPD.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            double res = 2 * Math.Pow(x,3) + 0.5 * Math.Pow(x,2) - 3.5 * x + 2;
            return res;
        }
    }
}
