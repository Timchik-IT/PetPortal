namespace PetPortal.Core.DTOs.Projects;

public record CreateProjectDto(
    Guid Id,
    string Name,
    string Description,
    Guid OwnerId
);