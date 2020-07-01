using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Info
{
    interface IDataSender
    {
        CodedPersonalInfo EncryptInfo(PersonalInformation info);
        PersonalInformation GetInfoById(int id);
    }
}
