using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.CommandProcessing
{
    public class CommandProcessor
    {
        private static CommandProcessor instance;

        public static CommandProcessor Instance
        {
            get;
            set;
        }

        public delegate void commandProcessorEventHandler(string command, string[] args);
        public event commandProcessorEventHandler OnSubscribeCommand, OnCreatePublicationCommand;

        public void ParseCommand(string c)
        {
            char[] characters = c.ToCharArray();
            if (characters[0] != '/') 
            {
                WrongCommand();
            }
        }

        public void WrongCommand()
        {
            Console.WriteLine("Wrong Command");
            throw new Exception("Wrong Command");
        }
    }
}
