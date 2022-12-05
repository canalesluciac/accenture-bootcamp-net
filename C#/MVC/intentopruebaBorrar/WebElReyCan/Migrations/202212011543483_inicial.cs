namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.String(maxLength: 10, unicode: false),
                        Hora = c.String(maxLength: 10, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 30, unicode: false),
                        Raza = c.String(maxLength: 40, unicode: false),
                        Edad = c.Int(nullable: false),
                        NombreDuenio = c.String(nullable: false, maxLength: 50, unicode: false),
                        Celular = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turno");
        }
    }
}
