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
                    UserName = "Main Referee",
                    NormalizedUserName = "MAIN REFEREE",
                    Email = "referee@bfs.com",
                    NormalizedEmail = "REFEREE@BFS.COM",
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AssistantRefereeOneGuid),
                    RefereeId = RefereeDataConstants.AssistantRefereeOneId,
                    UserName = "First AR",
                    NormalizedUserName = "FIRST AR",
                    Email = "assitant_referee1@bfs.com",
                    NormalizedEmail = "ASSITANT_REFEREE1@BFS.COM",
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AssistantRefereeTwoGuid),
                    RefereeId = RefereeDataConstants.AssistantRefereeTwoId,
                    UserName = "Second AR",
                    NormalizedUserName = "SECOND AR",
                    Email = "assitant_referee2@bfs.com",
                    NormalizedEmail = "ASSITANT_REFEREE2@BFS.COM",
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.DelegateGuid),
                    RefereeId = RefereeDataConstants.DelegateId,
                    UserName = "Delegate",
                    NormalizedUserName = "DELEGATE",
                    Email = "delegate@bfs.com",
                    NormalizedEmail = "DELEGATE@BFS.COM",
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = new Guid(ApplicationUserDataConstants.AdministratorGuid),
                    RefereeId = RefereeDataConstants.AdministratorId,
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@bfs.com",
                    NormalizedEmail = "ADMIN@BFS.COM",
                    IsApprovedForReferee = true,
                },
                new ApplicationUser()
                {
                    Id = Guid.NewGuid(),
                    RefereeId = null,
                    UserName = "Regular User",
                    NormalizedUserName = "REGULAR USER",
                    Email = "random_person@gmail.com",
                    NormalizedEmail = "RANDOM_PERSON@GMAIL.COM",
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