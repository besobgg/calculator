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


            StandartCalculator sc = new StandartCalculator();
            DateCalculator dt = new DateCalculator();
            BaseCalculator bc = new BaseCalculator();
            ISubstractable sub = new ISubstractable();
             var inp1 = Console.ReadLine();

             
            var action = Console.ReadLine();
            var inp2 = Console.ReadLine();



        }
    }
}
