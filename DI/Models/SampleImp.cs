using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Models
{
    public class SampleImp : ISample
    {
        public string GetName(string name)
        {
            return string.Format("Welcome {0}", name);
        }
    }
}