using Cinode_RateApplicationWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinode_RateApplicationWebAPI.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly RatingAppContext _context;

        public ProfileRepository(RatingAppContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Profile profile)
        {
            await _context.Profiles.AddAsync(profile);

            await _context.SaveChangesAsync();

            return profile.Id;
        }

        public async Task<ProfileDto> Get(int id)
        {
            var profile = await _context.Profiles
           .Include(x => x.Skills)
           .SingleOrDefaultAsync(p => p.Id == id);

            return new ProfileDto(profile);
        }

        public async Task<ProfileDto> GetWithSkills(int id)
        {
            var profile = await _context.Profiles
           .SingleOrDefaultAsync(p => p.Id == id);

            return new ProfileDto(profile);
        }

        public async Task<IEnumerable<ProfileDto>> GetProfiles()
        {
            return await _context.Profiles
                .Include(x => x.Skills)
                .Select(p => new ProfileDto(p))
                .ToListAsync();
        }
    }
}
