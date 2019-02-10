using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AbbTest2.DAL;
using AbbTest2.Models;
using WcfService3;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    //[Serializable]
    //[DataContract(Name = "Measures{0}")]
    public class Service1 : IService1
    {
        public List<Measure> GetMeasures()
        {
            AbbTest2Context db = new AbbTest2Context();
            var measures = db.Measures.ToList();

            return (measures);
        }
    }
}


