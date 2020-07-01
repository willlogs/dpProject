using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Info
{
    public static class UserManager
    {
        public static PersonalInformation GetUserById(int id)
        {
            return UserDataSender.Instance.GetInfoById(id);
        }

        public static PersonalInformation CreateUser(string name, string lastName, string gender, DateTime birthDate)
        {
            PersonalInformation pi = new PersonalInformation(name, lastName, gender, birthDate);
            return pi;
        }
    }
}
