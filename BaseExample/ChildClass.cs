using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseExample
{
    public class ChildClass : BaseClass
    {
        private string _job;
        public ChildClass(string name, string job)
            : base(name) {
                this._job = job;
        }

        public override void Display()
        {
            Console.WriteLine("Overrided");
            base.Display();
        }

        public void Show()
        {
            Console.WriteLine("My professional is :{0}", _job);
        }
    }
}
