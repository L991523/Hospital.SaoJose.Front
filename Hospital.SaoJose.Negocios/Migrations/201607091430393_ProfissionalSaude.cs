namespace Hospital.SaoJose.Negocios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfissionalSaude : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProfissionalSaude",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Formacao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProfissionalSaude");
        }
    }
}
