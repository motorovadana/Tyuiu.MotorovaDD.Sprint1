using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MotorovaDD.Sprint1.Task1.V3.LIB
{
    public class DataService : ISprint1Task1V3
    {
        public double Calculate(double x, double y)
        {
            return (x - y) / (x + 3) + 3;
        }
    }
}
