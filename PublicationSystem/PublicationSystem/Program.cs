using PublicationSystem.CommandProcessing;
using PublicationSystem.Info;
using PublicationSystem.StylishPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            CommandProcessor cp = CommandProcessor.Instance;

            cp.Subscribe(UserManager.Instance);
            cp.Subscribe(PublicationCommandExecuter.Instance);
            cp.Subscribe(new PrintingCommandExecuter());

            StylishPrinter.AddStyle(new StarStyle());
            StylishPrinter.AddStyle(new QuestionStyle());
            StylishPrinter.AddStyle(new UpperCaseStyle());

            while (true)
            {
                string command = Console.ReadLine();
                cp.ParseCommand(command);
            }
        }
    }
}
