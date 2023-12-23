using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    public class Example
    {
        public string Append(params string[] text) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in text) 
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        public void Test1(ref int x) 
        {
            x = 5;
        }

        public void Test2(in int x) 
        {
            //x=4; Can't Change
        }

        public void Test3(out int x) 
        {
            x = 0; // Must be change the value
        }
    }
}
