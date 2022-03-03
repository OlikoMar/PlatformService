using System;
using System.Collections.Generic;
using System.Linq;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _dbContext;

        public PlatformRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool SaveChanges()
        {
            return _dbContext.SaveChanges() >= 0;
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _dbContext.Platforms;
        }

        public Platform GetPlatformById(int id)
        {
            return _dbContext.Platforms.FirstOrDefault(s => s.Id == id);
        }

        public void CreatePlatform(Platform platform)
        {
            if (platform is null) throw new ArgumentNullException(nameof(platform));

            _dbContext.Platforms.Add(platform);
        }
    }
}
