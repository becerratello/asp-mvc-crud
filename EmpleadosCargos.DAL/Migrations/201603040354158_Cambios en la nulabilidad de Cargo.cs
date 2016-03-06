namespace EmpleadosCargos.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosenlanulabilidaddeCargo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cargos", "Nombre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cargos", "Nombre", c => c.String());
        }
    }
}
