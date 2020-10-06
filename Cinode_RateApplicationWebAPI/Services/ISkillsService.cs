using Cinode_RateApplicationWebAPI.Models;
using System.Collections.Generic;

namespace Cinode_RateApplicationWebAPI.Services
{
    public interface ISkillsService
    {
        IEnumerable<MostUsedSkill> GetMostUsedSkill();
    }
}
