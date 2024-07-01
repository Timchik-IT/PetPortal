namespace PetPortal.Core.DTOs.Users;

public record UserRegDto(
    Guid Id,
    string Name,
    string Email,
    string PasswordHash
);