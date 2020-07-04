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
            while (true)
            {
                string command = Console.ReadLine();
                CommandProcessing.CommandProcessor.Instance.ParseCommand(command);
            }
        }
    }
}
