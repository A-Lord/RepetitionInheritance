using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise2
{
    class AdditionComputation : IComputation 
    {
        public bool CanCompute(string test)
        {
            if (test == "+" || test == "plus")
            {
                return true;
            }
            else
                return false;
        }
        public int Compute(int[] testArray)
        {
            int sendBack = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                sendBack += testArray[i];
                
                    }
            return sendBack;
        }
    }
}
