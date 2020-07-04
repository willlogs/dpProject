using PublicationSystem.StylishPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Editing : PublicationState
    {
        public Editing()
        {
            allowedCommands = new string[] { 
                "getEditingProgress",
                "startPrinting"
            };
        }

        public override bool Execute(string comand, string[] args, Publication publication)
        {
            if(comand == allowedCommands[0])
            {
                Random rnd = new Random();
                StylishPrinter.PrintLine("" + rnd.Next(0, 101));
            }
            else
            {
                if(comand == allowedCommands[1])
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
            return new Printing();
        }

        public string PrintProgress()
        {
            return "print progress called";
        }
    }
}
