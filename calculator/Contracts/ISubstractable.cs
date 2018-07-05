using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Contracts
{
    interface ISubstractable<inpT,outT>
    {

        outT substract(inpT t);


    }

   

   
}
