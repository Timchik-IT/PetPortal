using Microsoft.EntityFrameworkCore;
using PetPortal.Core.Abstractions;
using PetPortal.Core.DTOs.Projects;
using PetPortal.DAL.Entities;

namespace PetPortal.DAL.Repositories;

public class ProjectsRepository : IProjectsRepository
{
    private readonly PetPortalDbContext _context;

    public ProjectsRepository(PetPortalDbContext context)
        => _context = context;

    public async Task<List<ProjectDto>> Get()
    {
        var projectEntities = await _context.Projects
            .AsNoTracking()
            .ToListAsync();

        var projects = projectEntities
            .Select(p => new ProjectDto(
                p.Id,
                p.Name,
                p.Description))
            .ToList();

        return projects;
    }

    public async Task<bool> Create(CreateProjectDto projectDto)
    {
        var projectEntity = new ProjectEntity
        {
            Id = projectDto.Id,
            Name = projectDto.Name,
            Description = projectDto.Description,
            OwnerId = projectDto.OwnerId
        };
            
        await _context.Projects.AddAsync(projectEntity);
        await _context.SaveChangesAsync();
        
        return true;
    }

    public async Task<bool> Update(Guid id, UpdateProjectDto projectParams)
    {
        await _context.Projects
            .Where(n => n.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Name, projectParams.Name)
                .SetProperty(p => p.Description, projectParams.Description)
            );
        
        return true;
    }

    public async Task<bool> Delete(Guid id)
    {
        await _context.Projects
            .Where(n => n.Id == id)
            .ExecuteDeleteAsync();

        return true;
    }
}