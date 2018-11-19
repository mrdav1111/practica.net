namespace XML_JSON_parser.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        personaId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        noTelefonico = c.String(),
                    })
                .PrimaryKey(t => t.personaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
