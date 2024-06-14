using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectService.Data;

namespace ProjectService.Controllers;

[ApiController]
[Route("api/organizations")]
public class OrganizationController : ControllerBase
{
    private readonly ProjectDbContext _context;
    private readonly IMapper _mapper;

    public OrganizationController(ProjectDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<OrganizationDto>> GetOrganizationById(Guid id)
    {
        Organization org = await _context.Organizations
            .FirstOrDefaultAsync(org => org.Id == id);
        
        OrganizationDto response = _mapper.Map<OrganizationDto>(org);

        return Ok(response);
    }
}
