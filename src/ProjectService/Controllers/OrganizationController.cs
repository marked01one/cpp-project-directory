using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
}
