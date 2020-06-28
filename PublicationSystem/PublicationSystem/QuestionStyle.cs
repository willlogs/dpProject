﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class QuestionStyle : PrintingStyle
    {
        public override string CommandSuffix => "Q";

        public override string Stylize(string message)
        {
            return "?" + message;
        }
    }
}
