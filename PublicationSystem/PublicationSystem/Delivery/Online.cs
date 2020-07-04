using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Delivery
{
    class Online : IDeliveryMethod
    {
        private static Online instance;

        public static Online Instance
        {
            get;
            set;
        }

        public void SpecificMessage(int id)
        {
            StylishPrinting.StylishPrinter.PrintLine("Online: Character " + id);
        }
    }
}
