using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Models
{
    public class Sample : CProperty<ISample>, ISample
    {
        public string GetName(string name)
        {
            return Implementation.GetName(name);
        }
    }
}