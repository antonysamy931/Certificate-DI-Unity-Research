using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using DI.Models;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //[Dependency]
        //public InterfaceParent Parent { get; set; }

        //[Dependency]
        //public ISample SampleObj { get; set; }

        public ActionResult Index()
        {
            //var obj = Parent.ReturnString();
            //var second = ObjectFactory.Resolve<InterfaceParent>().ReturnString();

            var SampleObj = ObjectFactory.Resolve<ISample>();
            var obj = SampleObj.GetName("DI");

            return View();
        }

        public ActionResult FileResult()
        {            
            //System.IO.FileStream stream = new System.IO.FileStream(@"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            //return File(stream, "video/x-ms-wmv");

            System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(fs);
            long byteLength = new System.IO.FileInfo(@"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv").Length;
            byte[] Mybytes = binaryReader.ReadBytes((Int32)byteLength);
            fs.Close();
            fs.Dispose();

            return File(Mybytes, "video/x-ms-wmv");
        }

    }
}
