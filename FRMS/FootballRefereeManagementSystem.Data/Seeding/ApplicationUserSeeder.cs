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
                    Id = new Guid(ApplicationUserDataConstants.RefereeGuid),
                    RefereeId = RefereeDataConstants.MainRefereeId,
                    UserName = "referee@bfs.com",
                    NormalizedUserName = "REFEREE@BFS.COM",
                    Email = "referee@bfs.com",
                    NormalizedEmail = "REFEREE@BFS.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AssistantRefereeOneGuid),
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    UserName = "assitant_referee1@bfs.com",
                    NormalizedUserName = "ASSITANT_REFEREE1@BFS.COM",
                    Email = "assitant_referee1@bfs.com",
                    NormalizedEmail = "ASSITANT_REFEREE1@BFS.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AssistantRefereeTwoGuid),
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    UserName = "assitant_referee2@bfs.com",
                    NormalizedUserName = "ASSITANT_REFEREE2@BFS.COM",
                    Email = "assitant_referee2@bfs.com",
                    NormalizedEmail = "ASSITANT_REFEREE2@BFS.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.DelegateGuid),
                    RefereeId = RefereeDataConstants.DelegateId,
                    UserName = "delegate@bfs.com",
                    NormalizedUserName = "DELEGATE@BFS.COM",
                    Email = "delegate@bfs.com",
                    NormalizedEmail = "DELEGATE@BFS.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AdministratorGuid),
                    RefereeId = RefereeDataConstants.AdministratorId,
                    UserName = "admin@bfs.com",
                    NormalizedUserName = "ADMIN@BFS.COM",
                    Email = "admin@bfs.com",
                    NormalizedEmail = "ADMIN@BFS.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = Guid.NewGuid(),
                    RefereeId = null,
                    UserName = "random_person@gmail.com",
                    NormalizedUserName = "RANDOM_PERSON@GMAIL.COM",
                    Email = "random_person@gmail.com",
                    NormalizedEmail = "RANDOM_PERSON@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    IsApprovedForReferee = false,
                }
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