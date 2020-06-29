using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    class CommandProcessor
    {
        private static CommandProcessor instance;

        public static CommandProcessor Instance
        {
            get;
            set;
        }

        public delegate void commandProcessorEventHandler(string command, string[] args);
        public event commandProcessorEventHandler OnSubscribeCommand, OnCreatePublicationCommand;

        public void AddExecuter(ICommandExecuter executer)
        {

        }

        public void RemoveExecuter(ICommandExecuter executer)
        {

        }

        public void ParseCommand(string c)
        {

        }
    }
}
