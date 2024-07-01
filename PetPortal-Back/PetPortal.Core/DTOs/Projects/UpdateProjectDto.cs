namespace PetPortal.Core.DTOs.Projects;

public record UpdateProjectDto(
    Guid Id,
    string Name,
    string Description
);