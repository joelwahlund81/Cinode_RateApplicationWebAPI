using Cinode_RateApplicationWebAPI.Models;
using Cinode_RateApplicationWebAPI.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Cinode_RateApplicationWebAPI.Services
{
    public class SkillsService : ISkillsService
    {
        private readonly ISkillsRepository _skillsRepo;

        public SkillsService(ISkillsRepository skillsRepo)
        {
            _skillsRepo = skillsRepo;
        }

        public IEnumerable<MostUsedSkill> GetMostUsedSkill()
        {
            var skills = _skillsRepo.GetAllSkills().ToList();

            int index = 0;

            return skills
                .GroupBy(s => s.Skill.ToLower())
                .Select(s => new MostUsedSkill
                { 
                    Id = index++,
                    Name = s.Key,
                    AverageRating = s.Average(a => a.Rating),
                    Count = s.Count() 
                })
                .OrderByDescending(s => s.Count);
        }
    }   
}
