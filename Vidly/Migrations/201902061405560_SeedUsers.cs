namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'17f7e572-2f72-4368-9dde-17c33d3602c0', N'admin-vidly@vidly.com', 0, N'AAXdujw+rPc+WYUpUE7dqaLk3mofBaOjbYbyJePgSjTOnmbC6iFqZOlZ9y5Jze5wdQ==', N'602724cd-33c2-460e-946f-f073b357c09d', NULL, 0, 0, NULL, 1, 0, N'admin-vidly@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'77129bb1-86fd-4f4e-abbb-b259c63f8f91', N'guest@vidly.com', 0, N'AGhMbNUNbAhO2FXghHPD6stgZeSxrJOdRX0LPdtmR5g+6aGG8nq0JC2NKsPyO7i4uQ==', N'866ba85e-379b-4d86-9cbb-3849f0fcc6ae', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'06268fe8-2d7d-484c-bdd2-4ae9af575840', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'17f7e572-2f72-4368-9dde-17c33d3602c0', N'06268fe8-2d7d-484c-bdd2-4ae9af575840')
");
        }
        
        public override void Down()
        {
        }
    }
}
