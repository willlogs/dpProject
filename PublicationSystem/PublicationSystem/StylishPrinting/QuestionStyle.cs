using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.StylishPrinting
{
    public class QuestionStyle : PrintingStyle
    {
        public static QuestionStyle Instance { get; } = new QuestionStyle();
        public override string CommandSuffix => "Q";

        public override string Stylize(string message)
        {
            return "?" + message;
        }
    }
}
