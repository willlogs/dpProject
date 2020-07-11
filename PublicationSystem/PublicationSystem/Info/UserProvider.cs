using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicationSystem.Info
{
    class UserProvider : IUserProvider
    {
        public PersonalInformation GetInfoById(int id)
        {
            CodedPersonalInfo codedUser = UserList.Instance.GetUser(id);
            if(codedUser != null)
            {
                PersonalInformation user = JsonConvert.DeserializeObject<PersonalInformation>(codedUser.Info);
                return user;
            }

            return null;
        }

        public int CreateUser(PersonalInformation info)
        {
            string jsonInfo = JsonConvert.SerializeObject(info);
            CodedPersonalInfo codedUser = new CodedPersonalInfo(jsonInfo);
            int userId = UserList.Instance.AddUser(codedUser);
            return userId;
        }
    }
}
