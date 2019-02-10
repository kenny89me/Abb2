using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using AbbTest2.Models;


namespace AbbTest2.DAL
{
    public class DbUpdater
    {
        public List<Measure> DbUpdate()
        {
            AbbTest2Context db = new AbbTest2Context();


            var measures = db.Measures.Include(m => m.Motor);
            foreach (var mes in measures)
            {
                mes.CurrentA = mes.Motor.CurrentA;
                mes.MaxTorque = mes.Motor.MaxTorque;
                mes.MaxPressure = mes.Motor.MaxPressure;

                switch (mes.MotorId)
                {
                    case 1:
                        mes.Difference = mes.Motor.CurrentA - mes.ActualCurrentA;
                        break;

                    case 2:
                        mes.Difference = mes.MaxTorque - mes.ActualRevsRpm;
                        break;

                    case 3:
                        mes.Difference = mes.MaxPressure - mes.ActualPressureBar;
                        break;
                }

            }
            db.SaveChanges();


            return (measures.ToList());
        }
    }
}