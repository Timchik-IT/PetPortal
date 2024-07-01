using PetPortal.Core.Abstractions;
using PetPortal.Core.DTOs.Projects;

namespace PetPortal.Application.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectsRepository _projectRepository;

    public ProjectService(IProjectsRepository projectsRepository)
        => _projectRepository = projectsRepository;

    public async Task<List<ProjectDto>> GetProjects()
    {
        return await _projectRepository.Get();
    }

    public async Task<bool> Create(CreateProjectDto projectDto)
    {
        return await _projectRepository.Create(projectDto);
    }

    public async Task<bool> Update(Guid id, UpdateProjectDto projectParams)
    {
        return await _projectRepository.Update(id, projectParams);
    }

    public async Task<bool> Delete(Guid id)
    {
        return await _projectRepository.Delete(id);
    }
}