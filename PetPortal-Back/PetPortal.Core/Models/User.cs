namespace PetPortal.Core.Models;

public class User
{
    public Guid Id;

    public string Name = string.Empty;

    public string Email = string.Empty;

    public string PasswordHash = string.Empty;
}