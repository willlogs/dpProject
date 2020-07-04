using PublicationSystem.CommandProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Info
{
    public class UserManager : ICommandExecuter
    {
        private string[] commands = new string[2] { "subscribe", "createCharacter"};

        public static PersonalInformation GetUserById(int id)
        {
            return UserDataSender.Instance.GetInfoById(id);
        }

        public static PersonalInformation CreateUser(string name, string lastName, string gender, DateTime birthDate)
        {
            PersonalInformation pi = new PersonalInformation(name, lastName, gender, birthDate);
            return pi;
        }

        public bool Execute(string command, string[] args)
        {
            if(command == commands[0])
            {
                PublicationProvider.Instance.GetPublication(args[0]).Subscribe(Convert.ToInt32(args[1]));
            }
            else
            {
                if(command == commands[1])
                {
                    CreateUser(args[0], args[1], args[2], Convert.ToDateTime(args[3]));
                }
                else
                {
                    CommandProcessing.CommandProcessor.Instance.WrongCommand();
                    return false;
                }
            }

            return false;
        }

        public List<string> GetCommandList()
        {
            return new List<string>(commands);
        }
    }
}
