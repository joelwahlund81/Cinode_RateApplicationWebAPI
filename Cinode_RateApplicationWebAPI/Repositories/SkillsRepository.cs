using Cinode_RateApplicationWebAPI.Models;
using System.Collections.Generic;

namespace Cinode_RateApplicationWebAPI.Repositories
{
    public class SkillsRepository : ISkillsRepository
    {
        private readonly RatingAppContext _context;

        public SkillsRepository(RatingAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Skills> GetAllSkills()
        {
            return _context.Skills;
        }
    }
}
