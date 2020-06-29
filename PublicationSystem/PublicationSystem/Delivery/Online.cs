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

        public string SpecificMessage(string characterName)
        {
            throw new NotImplementedException();
        }
    }
}
