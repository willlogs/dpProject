using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Info
{
    public interface IUserProvider
    {
        int CreateUser(PersonalInformation info);
        PersonalInformation GetInfoById(int id);
    }
}
