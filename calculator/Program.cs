using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.Contracts;


namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            IStandartCalculator sc = new StandartCalculator();
            IDateCalculator dt = new DateCalculator();

            double inp1 = 50;
            string action = "-";
            double inp2 = 3;
            sc.InitialData(inp1);
            
            sc.substract(inp2);

            double result = sc.ReturnSum();




        }
    }
}
