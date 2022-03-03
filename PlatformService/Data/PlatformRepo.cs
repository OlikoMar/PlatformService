using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new System.NotImplementedException();
        }

        public Platform GetPlatformById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreatePlatform(Platform platform)
        {
            throw new System.NotImplementedException();
        }
    }
}
