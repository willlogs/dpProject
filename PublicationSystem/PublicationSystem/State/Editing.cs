using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Editing : IPublicationState
    {
        public bool Execute(string comand, string[] args, Publication publication)
        {
            throw new NotImplementedException();
        }

        public string PrintProgress()
        {
            return "print progress called";
        }

        public void SwitchToPrinting()
        {
            throw new NotImplementedException();
        }
    }
}
