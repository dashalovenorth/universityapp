using Microsoft.AspNetCore.Identity;

namespace UniversityApp.Models
{
    public class PortalUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}