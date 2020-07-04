using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Publishing : PublicationState
    {
        public Publishing()
        {
            allowedCommands = new string[]
            {
                "publish"
            };
        }

        public override bool Execute(string comand, string[] args, Publication publication)
        {
            if (comand == allowedCommands[0])
            {
                Publish();
            }
            else
            {
                CommandProcessing.CommandProcessor.Instance.WrongCommand();
            }

            return true;
        }

        public override PublicationState Next()
        {
            throw new Exception("No Next state after publish");
        }

        private void Publish()
        {

        }
    }
}
