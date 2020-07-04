using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.StylishPrinting
{
    public class UpperCaseStyle : PrintingStyle
    {
        public static UpperCaseStyle Instance { get; } = new UpperCaseStyle();
        public override string CommandSuffix => "Upper";

        public override string Stylize(string message)
        {
            return message.ToUpper();
        }
    }
}
