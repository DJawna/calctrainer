using CalctrainerContracts.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalctrainerContracts.repositories
{
    public interface IProfileRepository
    {
        /// <summary>
        /// creates Profile by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<Profile> GetProfileByName(string name);

        void SaveProfile(Profile profile);
    }
}
