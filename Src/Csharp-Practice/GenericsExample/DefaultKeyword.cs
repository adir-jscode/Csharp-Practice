using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class DefaultKeyword <T> where T : struct //Constrains
    {
        public T CreateInstance()
        {
            return default(T);
        }
    }
}
