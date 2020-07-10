using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PublicationSystem.Info
{
    public class CodedPersonalInfo
    {
        public string Info { get; private set; }

        public CodedPersonalInfo(string userInfo)
        {
            this.Info = userInfo;
        }
    }
}
