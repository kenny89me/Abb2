using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
using AbbTest2.DAL;
using AbbTest2.Models;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public List<Measure> GetMeasures()
	{
        using (AbbTest2Context db = new AbbTest2Context())
        {
            List<Measure> measures = db.Measures.Include(m => m.Motor).ToList();
            return (measures);
        }
            
	}

	
}
