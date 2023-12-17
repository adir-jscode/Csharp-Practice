using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    public class Teacher : Person
    {
        private const string _idPrefix = "T-";
        private readonly string _id;
        public Teacher(string id) : base(0)
        {
            _id = id;
        }

        public string GeneratedId()
        {
            return  _idPrefix +_id ;
        }

        public override string GetId()
        {
            return GeneratedId();
        }
    }
}
