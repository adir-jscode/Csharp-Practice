using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Point<T,Q,R> where T : class
        where Q : struct
        where R : class, new()
    {
        public T X {  get; set; }
        public Q Y { get; set; }
        public R Z { get; set; }

        public void Convert<M>(M m)
            where M : class, new()
        {

        }
    }
}
