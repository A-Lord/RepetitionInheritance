using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise1
{
    class IncrementModifier : ArrayModifier
    {
        public IncrementModifier(int[] inteArray) : base(inteArray)
        {

        }
        protected override int ModifyValue(int pluseet)
        {
            return pluseet + 1;
        }

    }
}
