using Cinode_RateApplicationWebAPI.Models;
using System.Collections.Generic;

namespace Cinode_RateApplicationWebAPI.Repositories
{
    public interface ISkillsRepository
    {
        IEnumerable<Skills> GetAllSkills();
    }
}
