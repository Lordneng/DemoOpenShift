using DemoOpenShift.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenShift.Services.Contracts
{
    public class CalculatorService : ICalculatorService
    {
        public int Plus(int A, int B) => A + B;        
    }
}
