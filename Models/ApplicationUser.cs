using Microsoft.AspNetCore.Identity;

namespace ThesisArchive.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name {get; set;} = string.Empty;
        public bool isVerified {get; set;}
    }
}