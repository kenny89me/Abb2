namespace AbbTest2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Measure",
                c => new
                    {
                        MeasureId = c.Int(nullable: false, identity: true),
                        Timestamp = c.Time(nullable: false, precision: 7),
                        MotorId = c.Int(nullable: false),
                        MotorName = c.String(),
                        CurrentA = c.Decimal(precision: 18, scale: 2),
                        MaxTorque = c.Decimal(precision: 18, scale: 2),
                        MaxPressure = c.Decimal(precision: 18, scale: 2),
                        ActualCurrentA = c.Decimal(precision: 18, scale: 2),
                        ActualRevsRpm = c.Decimal(precision: 18, scale: 2),
                        ActualPressureBar = c.Decimal(precision: 18, scale: 2),
                        Difference = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MeasureId)
                .ForeignKey("dbo.Motor", t => t.MotorId, cascadeDelete: true)
                .Index(t => t.MotorId);
            
            CreateTable(
                "dbo.Motor",
                c => new
                    {
                        MotorId = c.Int(nullable: false, identity: true),
                        MotorName = c.String(nullable: false, maxLength: 60),
                        MotorType = c.Int(),
                        MaxPower = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VoltageV = c.Decimal(precision: 18, scale: 2),
                        CurrentA = c.Decimal(precision: 18, scale: 2),
                        FuelCons = c.Decimal(precision: 18, scale: 2),
                        MaxTorque = c.Decimal(precision: 18, scale: 2),
                        MaxPressure = c.Decimal(precision: 18, scale: 2),
                        Displacemnt = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MotorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Measure", "MotorId", "dbo.Motor");
            DropIndex("dbo.Measure", new[] { "MotorId" });
            DropTable("dbo.Motor");
            DropTable("dbo.Measure");
        }
    }
}
