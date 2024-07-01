using PetPortal.Core.Abstractions;
using PetPortal.Core.DTOs.Users;

namespace PetPortal.Application.Services;

public class UserService : IUserService
{
    private readonly IUsersRepository _usersRepository;

    public UserService(IUsersRepository usersRepository)
        => _usersRepository = usersRepository;

    public async Task Add(UserRegDto userPar)
    {
        await _usersRepository.Add(userPar);
    }

    public async Task<UserDto> GetByEmail(string email)
    {
        return await _usersRepository.GetByEmail(email);
    }
}