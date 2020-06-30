using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.CommandProcessing
{
    public interface ICommandExecuter
    {
        /// <summary>
        /// Executes the command. Return true if command and arguments are valid, return false otherwise.
        /// </summary>
        bool Execute(string command, string[] args);
    }
}
