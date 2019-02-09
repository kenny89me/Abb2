using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;
using AbbTest2.Models;
using AbbTest2.DAL;

namespace WcfService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService1 : System.Web.Services.WebService
    {
        private AbbTest2Context db = new AbbTest2Context();
        [WebMethod]
        public List<Measure> GetMeasures()
        {
            var measures = db.Measures.Include(m => m.Motor);


            return measures.ToList();
        }
    }
}
