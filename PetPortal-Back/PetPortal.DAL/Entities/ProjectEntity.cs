namespace PetPortal.DAL.Entities;

public class ProjectEntity
{
    public Guid Id;

    public string Name = string.Empty;

    public string Description = string.Empty;

    public Guid OwnerId;

    // List of users

    public UserEntity User;
}