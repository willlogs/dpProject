using PublicationSystem.CommandProcessing;
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
            CommandProcessor.Instance.Subscribe(PublicationCommandExecuter.Instance);
            CommandProcessor.Instance.Subscribe(new PrintingCommandExecuter());
            StylishPrinter.AddStyle(new StarStyle());   
            StylishPrinter.AddStyle(new QuestionStyle());   
            StylishPrinter.AddStyle(new UpperCaseStyle());   

            while (true)
            {
                string command = Console.ReadLine();
                CommandProcessor.Instance.ParseCommand(command);
            }
        }
    }
}
