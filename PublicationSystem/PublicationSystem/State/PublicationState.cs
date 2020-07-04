using PublicationSystem.CommandProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    public abstract class PublicationState
    {
        protected string[] allowedCommands;

        public abstract bool Execute(string command, string[] args, Publication publication);

        public string[] GetCommandsList()
        {
            return allowedCommands;
        }

        public abstract PublicationState Next();
    }
}
