using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Publishing : PublicationState
    {
        public override bool Execute(string comand, string[] args, Publication publication)
        {
            throw new NotImplementedException();
        }

        public override PublicationState Next()
        {
            throw new Exception("No Next state after publish");
        }
    }
}
