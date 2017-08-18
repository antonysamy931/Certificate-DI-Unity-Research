using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Models
{
    public class CProperty<T>
    {
        public T Implementation { get; set; }
    }
}