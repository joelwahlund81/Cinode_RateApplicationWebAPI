using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Cinode_RateApplicationWebAPI.Models
{
     public class ProfileDto
    {
        public int Id { get; }

        [JsonProperty("fname")]
        public string FirstName { get; }
        
        [JsonProperty("lname")]
        public string LastName { get; }
        
        [JsonProperty("fullname")]
        public string FullName => $"{FirstName} {LastName}";
        
        [JsonProperty("anon")]
        public bool IsAnonymous { get; }
        
        [JsonProperty("skills", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SkillsDto> Skills { get; set; }

        public ProfileDto(Profile profile)
        {
            Id = profile.Id;
            FirstName = profile.FirstName;
            LastName = profile.LastName;
            IsAnonymous = profile.IsAnonymous;
            if (profile.Skills != null && profile.Skills.Any())
            {
                Skills = profile.Skills.Select(s => new SkillsDto(s));
            }
        }

        public class SkillsDto
        {
            [JsonProperty("desc")]
            public string Skill { get; set; }
            [JsonProperty("rating")]
            public int Rating { get; set; }

            public SkillsDto(Skills skill)
            {
                Skill = skill.Skill;
                Rating = skill.Rating;
            }
        }
    }
}
