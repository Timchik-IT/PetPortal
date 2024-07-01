using PetPortal.Core.DTOs.Users;

namespace PetPortal.Core.Abstractions;

public interface IUserService
{
    Task Add(UserRegDto userPar);
    Task<UserDto> GetByEmail(string email);
}