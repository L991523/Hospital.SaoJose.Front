namespace Hospital.SaoJose.Negocios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfissionalSaude2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recurso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DataInclusao = c.DateTime(nullable: false),
                        Custo = c.Double(nullable: false),
                        InformacoesGerais = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recurso");
        }
    }
}
