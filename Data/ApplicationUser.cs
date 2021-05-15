using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;
using WeightTracker.DomainModels;

namespace WeightTracker.Data
{
    public class ApplicationUser : IdentityUser
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public Profile Profile { get; set; }

        public Guid ProfileId { get; set; }

    }
}