namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_migration_profile2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.Reviews", new[] { "Student_StudentID" });
            RenameColumn(table: "dbo.Reviews", name: "Student_StudentID", newName: "StudentID");
            AlterColumn("dbo.Reviews", "StudentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "StudentID");
            AddForeignKey("dbo.Reviews", "StudentID", "dbo.Students", "StudentID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "StudentID", "dbo.Students");
            DropIndex("dbo.Reviews", new[] { "StudentID" });
            AlterColumn("dbo.Reviews", "StudentID", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "StudentID", newName: "Student_StudentID");
            CreateIndex("dbo.Reviews", "Student_StudentID");
            AddForeignKey("dbo.Reviews", "Student_StudentID", "dbo.Students", "StudentID");
        }
    }
}
