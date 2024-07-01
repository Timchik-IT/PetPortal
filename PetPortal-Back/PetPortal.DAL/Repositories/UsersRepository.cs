using Microsoft.EntityFrameworkCore;
using PetPortal.Core.Abstractions;
using PetPortal.Core.DTOs.Users;
using PetPortal.DAL.Entities;

namespace PetPortal.DAL.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly PetPortalDbContext _context;

    public UsersRepository(PetPortalDbContext context)
        => _context = context;

    public async Task Add(UserRegDto userPar)
    {
        var userEntity = new UserEntity
        {
            Id = userPar.Id,
            Name = userPar.Name,
            Email = userPar.Email,
            PasswordHash = userPar.PasswordHash
        };

        await _context.Users.AddAsync(userEntity);
        await _context.SaveChangesAsync();
    }

    public async Task<UserDto> GetByEmail(string email)
    {
        var userEntity = await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Email == email) ?? throw new Exception();

        return new UserDto(
            userEntity.Id,
            userEntity.Name
        );
    }
}