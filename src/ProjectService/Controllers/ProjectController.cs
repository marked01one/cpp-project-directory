using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectService.Data;
using ProjectService.Models.DTOs;
using ProjectService.Models.Entities;

namespace ProjectService.Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectController : ControllerBase
{
    private readonly ProjectDbContext _context;
    private readonly IMapper _mapper;

    public ProjectController(ProjectDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProjectDto>>> GetAllProjects()
    {
        // Get the query organized by organizations
        IQueryable<Project> query = _context.Projects.OrderBy(x => x.Organization).AsQueryable();
        // Return a list mapped to `ProjectDto`
        return await query.ProjectTo<ProjectDto>(_mapper.ConfigurationProvider).ToListAsync();
    }
}
