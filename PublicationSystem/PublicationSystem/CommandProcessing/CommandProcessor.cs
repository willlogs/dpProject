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
            get 
            {
                if(instance == null)
                {
                    instance = new CommandProcessor();
                }
                return instance;
            }
        }

        public Dictionary<string, ICommandExecuter> commandSubscribers;

        public void Subscribe(string command, ICommandExecuter commandExecuter)
        {
            if (commandSubscribers.ContainsKey(command))
            {
                commandSubscribers[command] = commandExecuter;
            }
            else
            {
                commandSubscribers.Add(command, commandExecuter);
            }
        }

        public void ParseCommand(string c)
        {
            char[] characters = c.ToCharArray();
            if (characters[0] != '/') 
            {
                WrongCommand();
            }

            string[] args = c.Split(' ');
            string command = args[0].Remove(0, 1);

            if (commandSubscribers.ContainsKey(command))
            {

            }
            else
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
