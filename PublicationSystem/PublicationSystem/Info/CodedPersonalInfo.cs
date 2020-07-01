using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PublicationSystem.Info
{
    public class CodedPersonalInfo
    {
        // statics:
        public static List<CodedPersonalInfo> infoList = new List<CodedPersonalInfo>();

        public static CodedPersonalInfo GetById(int id)
        {
            foreach(CodedPersonalInfo _info in infoList)
            {
                if(_info.id == id)
                {
                    return _info;
                }
            }

            throw new Exception("No info with this id");
        }

        public static PersonalInformation ToPersonalInfo(CodedPersonalInfo info)
        {
            return JsonConvert.DeserializeObject<PersonalInformation>(info.info);
        }

        // none statics:
        public CodedPersonalInfo(PersonalInformation inputInfo)
        {
            try
            {
                GetById(inputInfo.id);
            }
            catch
            {
                this.info = JsonConvert.SerializeObject(inputInfo);
                int index = infoList.Count;
                infoList.Add(this);
                this.id = index;
                inputInfo.id = index;
            }
        }

        public int id;
        public string info;
    }
}
