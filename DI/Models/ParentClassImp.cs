using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Models
{
    public class ParentClassImp : InterfaceParent
    {
        public string ReturnString()
        {
            return "Success";
        }
    }
}