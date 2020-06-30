using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.StylishPrinting
{
    public abstract class PrintingStyle
    {
        public abstract string Stylize(string message);
        public abstract string CommandSuffix { get; }
    }
}
