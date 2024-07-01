using PetPortal.Core.DTOs.Projects;

namespace PetPortal.Core.Abstractions;

public interface IProjectService
{
    Task<List<ProjectDto>> GetProjects();
    Task<bool> Create(CreateProjectDto projectDto);
    Task<bool> Update(Guid id, UpdateProjectDto projectParams);
    Task<bool> Delete(Guid id);
}