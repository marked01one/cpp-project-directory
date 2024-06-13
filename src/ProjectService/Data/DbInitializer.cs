using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;

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

        Guid ngcpId = Guid.NewGuid();
        Guid spaceId = Guid.NewGuid();
        Guid calsysId = Guid.NewGuid();
        Guid fsaeId = Guid.NewGuid();

        List<Organization> organizations = [
            new() {Id = ngcpId, Name = "Northrop Grumman Collaboration Project"},
            new() {Id = spaceId, Name = "Bronco Space"},
            new() {Id = calsysId, Name = "CALSys Lab"},
            new() {Id = fsaeId, Name = "Cal Poly Pomona Formula SAE"}
        ];

        context.AddRange(organizations);

        Major ME = new() {Id = Guid.NewGuid(), Name = "Mechanical Engineering", Acronym = "ME"};
        Major ARO = new() {Id = Guid.NewGuid(), Name = "Aerospace Engineering", Acronym = "ARO"};
        Major EE = new() {Id = Guid.NewGuid(), Name = "Electrical Engineering", Acronym = "EE"};
        Major CpE = new() {Id = Guid.NewGuid(), Name = "Computer Engineering", Acronym = "CpE"};
        Major CS = new() {Id = Guid.NewGuid(), Name = "Computer Science",Acronym = "CS"};
        Major CIS = new() {Id = Guid.NewGuid(), Name = "Computer Information System", Acronym = "CIS"};

        context.AddRange([ME, ARO, EE, CpE, CS, CIS]);

        Guid gcsId = Guid.NewGuid();
        Guid uavId = Guid.NewGuid();
        Guid ugvId = Guid.NewGuid();

        List<Project> projects = [
            new() {
                Id = gcsId,
                Name = "Ground Control Station",
                Description = "A desktop software platform and electronics system, designed to provide mission operators with up-to-date & intuitive data monitoring of all vehicles (such as vehicle health and mission status), as well as software functionalities for executing mission commands.",
                OrganizationId = ngcpId,
                ContactsPhone = null,
                ContactsDiscord = "ngcp.gcs",
                ContactsEmail = "ngcp@example.com",

            },
            new() {
                Id = uavId,
                Name = "Multi Role Aircraft UAV",
                Description = "An autonomous plane vehicle designated to locate the survivor via radio frequency search, relay the position back to the GCS, and deploy a relief package nearby.",
                OrganizationId = ngcpId,
                ContactsPhone = "000-000-0000",
                ContactsDiscord = "ngcp.uav",
                ContactsEmail = "ngcp@example.com",
            },
            new() {
                Id = ugvId,
                Name = "Emergency Response Unit UGV",
                Description = "An autonomous ground vehicle designated to navigate to the survivor via waypoint navigation. The location of the survivor is then sent back to GCS.",
                OrganizationId = ngcpId,
                ContactsPhone = "000-000-0000",
                ContactsDiscord = "ngcp.eru",
                ContactsEmail = "ngcp@example.com",
            }
        ];

        context.AddRange(projects);

        List<ProjectMajor> projectMajors = [
            new() {ProjectId = gcsId, MajorId = CS.Id},
            new() {ProjectId = gcsId, MajorId = CIS.Id},
            new() {ProjectId = gcsId, MajorId = CpE.Id},
            new() {ProjectId = uavId, MajorId = ARO.Id},
            new() {ProjectId = uavId, MajorId = EE.Id},
            new() {ProjectId = uavId, MajorId = CS.Id},
            new() {ProjectId = ugvId, MajorId = ME.Id},
            new() {ProjectId = ugvId, MajorId = EE.Id},
            new() {ProjectId = ugvId, MajorId = CpE.Id},
            new() {ProjectId = ugvId, MajorId = CS.Id}
        ];

        context.AddRange(projectMajors);

        context.SaveChanges();
    }
}
