using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicationSystem.Info
{
    class UserDataSender : IDataSender
    {
        CodedPersonalInfo codedInfo;

        public PersonalInformation DecryptInfo(CodedPersonalInfo info)
        {
            PersonalInformation pi;

            pi = JsonConvert.DeserializeObject<PersonalInformation>(info.info);

            return pi;
        }

        public CodedPersonalInfo EncryptInfo(PersonalInformation info)
        {
            CodedPersonalInfo ci = new CodedPersonalInfo();

            ci.info = JsonConvert.SerializeObject(info);

            return ci;
        }
    }
}
