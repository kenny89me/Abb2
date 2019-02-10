

namespace AbbTest2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using AbbTest2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AbbTest2.DAL.AbbTest2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AbbTest2.DAL.AbbTest2Context";
        }

        protected override void Seed(AbbTest2.DAL.AbbTest2Context context)
        {

            var motors = new List<Motor>
            {
                new Motor{ MotorName = "Motor1", MotorType = MotorType.Electric, MaxPower = 2.0m, VoltageV = 230m, CurrentA = 8.7m, FuelCons = null, MaxTorque = null, MaxPressure = null, Displacemnt = null},
                new Motor{ MotorName = "Motor2", MotorType = MotorType.Electric, MaxPower = 50.0m, VoltageV = null, CurrentA = null, FuelCons = 4, MaxTorque = 3000, MaxPressure = null, Displacemnt = null},
                new Motor{ MotorName = "Motor3", MotorType = MotorType.Electric, MaxPower = 1.0m, VoltageV = null, CurrentA = null, FuelCons = null, MaxTorque = null, MaxPressure = 160, Displacemnt = 16}
            };

            motors.ForEach(s => context.Motors.Add(s));
            context.SaveChanges();

            var measures = new List<Measure>
            {
            new Measure{ Timestamp = new TimeSpan(10,00,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null ,ActualCurrentA = 7.0m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,00,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null ,ActualCurrentA = null , ActualRevsRpm = 2890m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,00,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 155m},
            new Measure{ Timestamp = new TimeSpan(10,10,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = 7.9m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,10,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = 3100m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,10,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 158m},
            new Measure{ Timestamp = new TimeSpan(10,20,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = 6.5m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,20,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = 2800m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,20,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 140m},
            new Measure{ Timestamp = new TimeSpan(10,30,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = 7.3m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,30,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = 2860m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,30,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 145m},
            new Measure{ Timestamp = new TimeSpan(10,40,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = 7.8m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,40,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = 2875m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,40,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 159m},
            new Measure{ Timestamp = new TimeSpan(10,50,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = 6.9m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,50,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = 2790m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(10,50,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 160m},
            new Measure{ Timestamp = new TimeSpan(11,00,00), MotorId = 1, MotorName  = "Motor1", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = 7.0m , ActualRevsRpm = null, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(11,00,00), MotorId = 2, MotorName  = "Motor2", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = 2900m, ActualPressureBar = null},
            new Measure{ Timestamp = new TimeSpan(11,00,00), MotorId = 3, MotorName  = "Motor3", CurrentA = null, MaxTorque = null, MaxPressure = null,ActualCurrentA = null , ActualRevsRpm = null, ActualPressureBar = 139m}
            };
            measures.ForEach(s => context.Measures.Add(s));
            context.SaveChanges();
        }
    }

}
