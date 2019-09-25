using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySQLDAL.repositories
{
    public class ProfileRepository : IProfileRepository
    {
        public async Task<Profile> GetLastProfileByMachineName(string machineName)
        {
            await Task.Delay(10000);

            return new Profile { Name = "undefined" };
        }

        public async Task<Profile> GetProfileByName(string name)
        {
            throw new NotImplementedException();
        }

        

        public async Task<bool> SaveProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        
    }
}
