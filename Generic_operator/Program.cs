using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int 형의 Div = {0}", MyMyGenericOperation<int>.Div(4, 3));
            Console.WriteLine("double 형의 Div = {0}", MyMyGenericOperation<double>.Div(4.0, 3.0));
        }
    }
    public class MyMyGenericOperation<T>
    {
        public static double? Div(T a, T b)
        {
            if (a is int)
                return ((a as int?) / (b as int?));
            else
                return ((a as double?) / (b as double?));
        }
    }
}
