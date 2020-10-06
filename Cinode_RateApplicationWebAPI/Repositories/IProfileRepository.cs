using Cinode_RateApplicationWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinode_RateApplicationWebAPI.Repositories
{
    public interface IProfileRepository
    {
        public Task<int> Create(Profile profile);
        public Task<ProfileDto> Get(int id);
        public Task<ProfileDto> GetWithSkills(int id);
        public Task<IEnumerable<ProfileDto>> GetProfiles();
    }
}
