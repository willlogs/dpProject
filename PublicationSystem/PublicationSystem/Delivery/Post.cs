using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Delivery
{
    class Post : IDeliveryMethod
    {
        private static Post instance;

        public static Post Instance
        {
            get;
            set;
        }

        public void SpecificMessage(int id)
        {
            StylishPrinting.StylishPrinter.PrintLine("Post: Character " + id);
        }
    }
}
