namespace Brain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIDtoallclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.Hours",
                c => new
                    {
                        HoursId = c.Int(nullable: false, identity: true),
                        SleepHours = c.Int(nullable: false),
                        Nap = c.Int(nullable: false),
                        WorkHours = c.Int(nullable: false),
                        TrainHours = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HoursId);
            
            CreateTable(
                "dbo.PersonalInfo",
                c => new
                    {
                        PersonalInfoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonalInfoId);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subject");
            DropTable("dbo.PersonalInfo");
            DropTable("dbo.Hours");
            DropTable("dbo.Book");
        }
    }
}
