using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseExample
{
    public class BaseClass
    {
        private string _name;
        public BaseClass(string name)
        {
            this._name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("My Name is :{0}", _name);
        }
    }
}
