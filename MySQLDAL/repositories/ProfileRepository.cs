using Calctrainer.models;
using Calctrainer.repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySQLDAL.repositories
{
    public class ProfileRepository : IProfileRepository
    {
        public Task<Profile> GetProfileByName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveProfile(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
