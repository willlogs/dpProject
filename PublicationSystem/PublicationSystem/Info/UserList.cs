using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Info
{
    public class UserList
    {
        private List<CodedPersonalInfo> userList = new List<CodedPersonalInfo>();

        private static UserList instance;
        public static UserList Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserList();
                }

                return instance;
            }
        }

        /// <summary>
        /// Add user to the list if it does not exist there and returns it's unique id. Otherwise returns -1.
        /// </summary>
        public int AddUser(CodedPersonalInfo userInfo)
        {
            bool userExists = userList.Contains(userInfo);
            if (!userExists)
            {
                userList.Add(userInfo);
                return userList.Count - 1;
            }

            return -1;
        }

        public CodedPersonalInfo GetUser(int userId)
        {
            for(int i = 0; i < userList.Count; i++)
            {
                if(userId == i)
                {
                    return userList[i];
                }
            }

            return null;
        }
    }
}
