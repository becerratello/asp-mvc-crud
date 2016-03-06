namespace EmpleadosCargos.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        CargoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Sueldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CargoID);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        CargoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoID)
                .ForeignKey("dbo.Cargos", t => t.CargoId, cascadeDelete: true)
                .Index(t => t.CargoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleados", "CargoId", "dbo.Cargos");
            DropIndex("dbo.Empleados", new[] { "CargoId" });
            DropTable("dbo.Empleados");
            DropTable("dbo.Cargos");
        }
    }
}
