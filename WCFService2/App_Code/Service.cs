using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AbbTest2.DAL;
using AbbTest2.Models;
using System.Data.Entity;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[Serializable]
[DataContract(Name = "Measures{0}")]
public class Service : IService
{
    
    public List<Measure> GetMeasures()
    {
        AbbTest2Context db = new AbbTest2Context();
        var measures = db.Measures.ToList();

        return (measures);
    }
}