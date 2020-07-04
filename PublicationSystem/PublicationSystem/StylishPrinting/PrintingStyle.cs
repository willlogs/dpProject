using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.StylishPrinting
{
    public abstract class PrintingStyle : IEquatable<PrintingStyle>
    {
        public abstract string Stylize(string message);
        public abstract string CommandSuffix { get; }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is PrintingStyle))
            {
                return false;
            }

            return this.Equals((PrintingStyle)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(PrintingStyle other)
        {
            if (other == null)
            {
                return false;
            }

            return CommandSuffix.Equals(other.CommandSuffix);
        }
    }
}
