﻿using System;
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
                "/getEditingProgress",
                "/startPrinting"
            };
        }

        public override bool Execute(string comand, string[] args, Publication publication)
        {
            throw new NotImplementedException();
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
