using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Publishing : IPublicationState
    {
        public bool Execute(string comand, string[] args, Publication publication)
        {
            throw new NotImplementedException();
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }
    }
}
