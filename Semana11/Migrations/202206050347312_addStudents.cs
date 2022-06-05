namespace Semana11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "IsActive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "IsActive");
        }
    }
}
