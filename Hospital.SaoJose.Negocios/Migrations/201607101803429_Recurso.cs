namespace Hospital.SaoJose.Negocios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recurso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Paciente", "Cpf", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Paciente", "Cpf");
        }
    }
}
