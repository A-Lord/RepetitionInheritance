using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise1
{
    public abstract class ArrayModifier
    {
        private int[] _privateIntArray;
        public ArrayModifier(int[] inputIntArray)
        {
            _privateIntArray = inputIntArray;
        }
        protected abstract int ModifyValue(int inten);
        public void Modify()
        {
            for (int i = 0; i < _privateIntArray.Length; i++)
            {
                _privateIntArray[i] = ModifyValue(_privateIntArray[i]);
            }
        }
        public void PrintIt()
        {
            foreach (var item in _privateIntArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
