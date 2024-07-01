using System.Data;

namespace PetPortal.Core.Models;

public class Project
{
    public Guid Id;

    public string Name = string.Empty;

    public string Description = string.Empty;

    public Guid OwnerId; 
}