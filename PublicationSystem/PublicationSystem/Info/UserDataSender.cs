using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicationSystem.Info
{
    class UserDataSender : IDataSender
    {
        private static UserDataSender instance;
        public static UserDataSender Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserDataSender();
                }

                return instance;
            }
        }

        CodedPersonalInfo codedInfo;

        public PersonalInformation GetInfoById(int id)
        {
            return CodedPersonalInfo.ToPersonalInfo(CodedPersonalInfo.GetById(id));
        }

        public CodedPersonalInfo EncryptInfo(PersonalInformation info)
        {
            CodedPersonalInfo ci = new CodedPersonalInfo(info);

            return ci;
        }
    }
}
