using PetPortal.Core.DTOs.Users;

namespace PetPortal.Core.Abstractions;

public interface IUsersRepository
{
    Task Add(UserRegDto userPar);
    Task<UserDto> GetByEmail(string email);
}