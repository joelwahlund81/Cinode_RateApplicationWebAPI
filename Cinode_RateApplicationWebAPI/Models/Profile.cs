using System.Collections.Generic;

namespace Cinode_RateApplicationWebAPI.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string FullName => $"{FirstName} {LastName}";
        public bool IsAnonymous { get; set; }

        public ICollection<Skills> Skills { get; set; }
    }
}
