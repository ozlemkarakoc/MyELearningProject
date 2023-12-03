namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_Review : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StrudentID = c.Int(nullable: false),
                        ReviewScore = c.Int(nullable: false),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.CourseID)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Reviews", "CourseID", "dbo.Courses");
            DropIndex("dbo.Reviews", new[] { "Student_StudentID" });
            DropIndex("dbo.Reviews", new[] { "CourseID" });
            DropTable("dbo.Reviews");
        }
    }
}
