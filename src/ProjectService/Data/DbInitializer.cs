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

        List<Project> items = new()
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Ground Controls System Software",
                Organization = "Northrop Grumman Collaboration Project",
                Compensation = CompensationEnum.Volunteer,
                Description = "We welcome all aspiring software engineers to join us to build a database for handling messages between vehicles",
                ContactsEmail = "sample.gcs@ngcp.test.com",
                ContactsDiscord = "TesterUser",
                ContactsPhone = "909-869-0000"
                ,
                Majors = new List<MajorEnum>() {
                    MajorEnum.CS,
                    MajorEnum.CpE
                }
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Chrome Extension for BroncoDirect!",
                Organization = "Bronco Direct Me",
                Compensation = CompensationEnum.Volunteer,
                Description = "We welcome all aspiring software engineers to join us to build a tool for improving the registration process",
                ContactsEmail = "bdm-test@example.com",
                ContactsDiscord = "BroncoD1r3ctM3"
                ,
                Majors = new List<MajorEnum>() {
                    MajorEnum.CS
                }
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "SCALES",
                Organization = "Bronco Space",
                Compensation = CompensationEnum.Hourly,
                Description = "The Bronco Space ICON lab is currently searching for up to five students to participate in a paid part time internship in collaboration with the Small Scale Flight Software team at NASA JPL ",
                ContactsEmail = "broncospace@example.com",
                Majors = new List<MajorEnum>() {
                    MajorEnum.CS,
                    MajorEnum.CpE,
                    MajorEnum.EE,
                    MajorEnum.ARO
                }
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "NLP for Drone Guidance w/ Dr. Mohamed El-Hadedy",
                Organization = "Research for Inclusive Opportunites",
                Compensation = CompensationEnum.Semesterly,
                Description = "Description goes here!",
                ContactsEmail = "sample.nlp@test.com",
                ContactsDiscord = "TesterUser",
                ContactsPhone = "909-869-0000"
                ,
                Majors = new List<MajorEnum>() {
                    MajorEnum.CpE,
                    MajorEnum.EE,
                    MajorEnum.ARO
                }
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Multi Role Aircraft UAV",
                Organization = "Northrop Grumman Collaboration Project",
                Compensation = CompensationEnum.Volunteer,
                Description = "We welcome all aspiring software engineers to join us to build a database for handling messages between vehicles",
                ContactsEmail = "sample.uav@ngcp.test.com",
                ContactsDiscord = "TesterUser",
                ContactsPhone = "909-869-0000",
                Majors = new List<MajorEnum>() {
                    MajorEnum.CS,
                    MajorEnum.CpE,
                    MajorEnum.EE,
                    MajorEnum.ME,
                    MajorEnum.ARO
                }
            },

        };
        // Add all items to repository
        context.AddRange(items);
        context.SaveChanges();
    }
}
