using PetPortal.Core.DTOs.Projects;

namespace PetPortal.Core.Abstractions;

public interface IProjectsRepository
{
    Task<List<ProjectDto>> Get();
    Task<bool> Create(CreateProjectDto projectDto);
    Task<bool> Update(Guid id, UpdateProjectDto projectParams);
    Task<bool> Delete(Guid id);
}