namespace FootballRefereeManagementSystem.Data.Seeding
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;

    using Models;
    using SeedingDataConstants;

    internal class ApplicationUserSeeder
    {
        internal ICollection<ApplicationUser> GenerateApplicationUsers()
        {
            ICollection<ApplicationUser> users = new HashSet<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.RefereeId),
                    RefereeId = RefereeDataConstants.MainRefereeId,
                    UserName = "referee@bfs.com",
                    NormalizedUserName = "REFEREE@BFS.COM",
                    Email = "referee@bfs.com",
                    NormalizedEmail = "REFEREE@BFS.COM",
                    SecurityStamp = new Guid(ApplicationUserDataConstants.RefereeSecurityStamp).ToString("D")
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AssistantRefereeOneId),
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    UserName = "assitant_referee1@bfs.com",
                    NormalizedUserName = "ASSITANT_REFEREE1@BFS.COM",
                    Email = "assitant_referee1@bfs.com",
                    NormalizedEmail = "ASSITANT_REFEREE1@BFS.COM",
                    SecurityStamp = new Guid(ApplicationUserDataConstants.AssistantRefereeOneSecurityStamp).ToString("D")
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AssistantRefereeTwoId),
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    UserName = "assitant_referee2@bfs.com",
                    NormalizedUserName = "ASSITANT_REFEREE2@BFS.COM",
                    Email = "assitant_referee2@bfs.com",
                    NormalizedEmail = "ASSITANT_REFEREE2@BFS.COM",
                    SecurityStamp = new Guid(ApplicationUserDataConstants.AssistantRefereeTwoSecurityStamp).ToString("D")
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.DelegateId),
                    RefereeId = RefereeDataConstants.DelegateId,
                    UserName = "delegate@bfs.com",
                    NormalizedUserName = "DELEGATE@BFS.COM",
                    Email = "delegate@bfs.com",
                    NormalizedEmail = "DELEGATE@BFS.COM",
                    SecurityStamp = new Guid(ApplicationUserDataConstants.DelegateSecurityStamp).ToString("D")
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AdministratorId),
                    RefereeId = RefereeDataConstants.AdministratorId,
                    UserName = "admin@bfs.com",
                    NormalizedUserName = "ADMIN@BFS.COM",
                    Email = "admin@bfs.com",
                    NormalizedEmail = "ADMIN@BFS.COM",
                    SecurityStamp = new Guid(ApplicationUserDataConstants.AdministratorSecurityStamp).ToString("D")
                },
            };

            // Every user will have the same password for convenience
            var hasher = new PasswordHasher<ApplicationUser>();
            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, ApplicationUserDataConstants.Password);
            }

            return users;
        }
    }
}