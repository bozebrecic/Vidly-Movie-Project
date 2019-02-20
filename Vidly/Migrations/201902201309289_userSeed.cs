namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userSeed : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'45243276-03c9-4681-9dd5-b2c51030923b', N'guest@vidly.com', 0, N'AOWlWiPM/QLbp7EmBZmjKhXUga5nRXJT22PIEeCJ0zGBRACT8XeNR06VDvBc06RgrQ==', N'228ef189-db75-45a2-a68a-adaf81526a40', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b20a4d38-a58b-4bd0-bd5b-169a7c70639a', N'admin@vidly.com', 0, N'AK2snM7RKtDfO7puVo8vB/BSRSm86VWBvwxNVhgrQ7hGJ1ygkVb10re44IwYMNwHfg==', N'7f026ca8-a5c1-4a7a-afa4-d6ca70d6c4be', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'06268fe8-2d7d-484c-bdd2-4ae9af575840', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b20a4d38-a58b-4bd0-bd5b-169a7c70639a', N'06268fe8-2d7d-484c-bdd2-4ae9af575840')

");
        }
        
        public override void Down()
        {
        }
    }
}
