using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace WeightTracker.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}