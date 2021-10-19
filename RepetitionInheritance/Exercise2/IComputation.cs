using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise2
{
    interface IComputation
    {
        public bool CanCompute(string test);
        public int Compute(int[] testArray);

    }
}
