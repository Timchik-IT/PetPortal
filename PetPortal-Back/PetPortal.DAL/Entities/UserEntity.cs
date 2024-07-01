namespace PetPortal.DAL.Entities;

public class UserEntity
{
    public Guid Id;

    public string Name = string.Empty;
    
    public string Email = string.Empty;

    public string PasswordHash = string.Empty;
}