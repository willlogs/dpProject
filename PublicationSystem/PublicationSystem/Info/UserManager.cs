using PublicationSystem.CommandProcessing;
using PublicationSystem.StylishPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Info
{
    public class UserManager : ICommandExecuter
    {
        public struct UserInfoId
        {
            public PersonalInformation info;
            public int id;

            public UserInfoId(PersonalInformation info, int id)
            {
                this.info = info;
                this.id = id;
            }
        }

        private string[] commands = new string[2] { "subscribe", "createCharacter"};
        private static UserManager instance;

        public IUserProvider UserProvider { get; set; }
        public static UserManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserManager();
                }

                return instance;
            }
        }

        public PersonalInformation GetUserById(int id)
        {
            PersonalInformation info = UserProvider.GetInfoById(id);

            if(info != null)
            {
                return info;
            }
            else
            {
                string message = string.Format("User with id {0} does not exits.", id);
                StylishPrinter.PrintLine(message);
                return null;
            }
        }

        public UserInfoId CreateUser(string name, string lastName, string gender, DateTime birthDate)
        {
            PersonalInformation personalInfo = new PersonalInformation(name, lastName, gender, birthDate);

            int userId = UserProvider.CreateUser(personalInfo);
            if(userId == -1)
            {
                StylishPrinter.PrintLine("User has not been created. User with this info already exists");
            }
            else
            {
                string message = string.Format("User with id {0} has been created.", userId);
                StylishPrinter.PrintLine(message);
            }

            return new UserInfoId(personalInfo, userId);
        }

        public bool Execute(string command, string[] args)
        {
            if(command == commands[0])
            {
                if(args != null && args.Length > 1)
                {
                    try
                    {
                        Publication publication = PublicationProvider.Instance.GetPublication(args[0]);
                        publication.Subscribe(Convert.ToInt32(args[1]));
                    }
                    catch (Exception exception)
                    {
                        StylishPrinter.PrintLine(exception.Message);
                    }
                }
                else
                {
                    StylishPrinter.PrintLine("Invalid arguments for subscribing user");
                }
            }
            else
            {
                if(command == commands[1])
                {
                    if (args != null && args.Length > 3)
                    {
                        try
                        {
                            CreateUser(args[0], args[1], args[2], Convert.ToDateTime(args[3]));
                        }
                        catch (FormatException)
                        {
                            StylishPrinter.PrintLine("Invalid birth date for creating user");
                        }
                    }
                    else
                    {
                        StylishPrinter.PrintLine("Invalid arguments for creating user");
                    }
                }
                else
                {
                    CommandProcessor.Instance.WrongCommand();
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
