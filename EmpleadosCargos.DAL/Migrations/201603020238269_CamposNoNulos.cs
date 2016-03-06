namespace EmpleadosCargos.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposNoNulos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleados", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Empleados", "Apellido", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleados", "Apellido", c => c.String());
            AlterColumn("dbo.Empleados", "Nombre", c => c.String());
        }
    }
}
