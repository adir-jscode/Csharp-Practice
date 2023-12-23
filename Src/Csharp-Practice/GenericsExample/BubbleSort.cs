using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class BubbleSort <T> where T : INumber<T>
    {
        public T[] SortArray(T[] NumArray)
        {
            var n = NumArray.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (NumArray[j] > NumArray[j + 1])
                    {
                        T tempVar = NumArray[j];
                        NumArray[j] = NumArray[j + 1];
                        NumArray[j + 1] = tempVar;
                    }

            return NumArray;
        }
    }
}
