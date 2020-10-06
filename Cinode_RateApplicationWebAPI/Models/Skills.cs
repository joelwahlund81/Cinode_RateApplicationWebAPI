using System.ComponentModel.DataAnnotations;

namespace Cinode_RateApplicationWebAPI.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int Rating { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
