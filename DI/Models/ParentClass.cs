using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Models
{
    public class ParentClass : CommonProperty<InterfaceParent>, InterfaceParent
    {

        public string ReturnString()
        {
            return Implimentation.ReturnString();
        }
    }
}