using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Printing : PublicationState
    {
        public Printing()
        {
            allowedCommands = new string[] {
                "getPrintingProgress",
                "startPublishing"
            };
        }

        public override bool Execute(string comand, string[] args, Publication publication)
        {
            if (comand == allowedCommands[0])
            {
                Random rnd = new Random();
                StylishPrinting.StylishPrinter.PrintLine("" + rnd.Next(0, 101));
            }
            else
            {
                if (comand == allowedCommands[1])
                {
                    publication.SetState(Next());
                }
                else
                {
                    CommandProcessing.CommandProcessor.Instance.WrongCommand();
                }
            }
            return true;
        }

        public override PublicationState Next()
        {
            return new Publishing();
        }

        public string PrintProgress()
        {
            return "print progress called";
        }
    }
}
