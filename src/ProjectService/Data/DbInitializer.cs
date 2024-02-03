using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectService.Models.Entities;

namespace ProjectService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using IServiceScope scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<ProjectDbContext>());
    }

    private static void SeedData(ProjectDbContext context)
    {
        context.Database.Migrate();

        if (context.Projects.Any())
        {
            Console.WriteLine("--> Data already seeded! Proceeding...");
            return;
        }

        List<Project> items = new List<Project>()
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Ground Control System - Database Team",
                Organization = "Northrop Grumman Collaboration Project",
                Compensation = CompensationEnum.Volunteer,
                Description = "We welcome all aspiring software engineers to join us to build a database for handling messages between vehicles",
                ContactEmail = "gcs@example.com"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Chrome Extension for BroncoDirect!",
                Organization = "Bronco Direct Me",
                Compensation = CompensationEnum.Volunteer,
                Description = "We welcome all aspiring software engineers to join us to build a tool for improving the registration process",
                ContactEmail = "bdm@example.com"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "SCALES",
                Organization = "Bronco Space",
                Compensation = CompensationEnum.HourlyPay,
                Description = "The Bronco Space ICON lab is currently searching for up to five students to participate in a paid part time internship in collaboration with the Small Scale Flight Software team at NASA JPL ",
                ContactEmail = "broncospace@example.com"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "NLP for Drone Guidance w/ Dr. Mohamed El-Hadedy",
                Organization = "Research for Inclusive Opportunites",
                Compensation = CompensationEnum.SemesterPay,
                Description = "Description goes here!",
                ContactEmail = "broncospace@example.com"
            },

        };
        // Add all items to repository
        context.AddRange(items);
        context.SaveChanges();
    }
}
