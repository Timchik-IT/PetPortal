namespace PetPortal.Core.DTOs.Projects;

public record ProjectDto(
    Guid Id,
    string Name,
    string Description
);