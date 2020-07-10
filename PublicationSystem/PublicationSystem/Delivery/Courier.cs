using PublicationSystem.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Delivery
{
    class Courier : IDeliveryMethod
    {
        public static Courier Instance { get; private set; } = new Courier();

        public void SpecificMessage(int id)
        {
            DeliveryUtility.DeliveryPrint(id, "Courier");
        }

        public void SpecificMessage(PersonalInformation info, int id)
        {
            DeliveryUtility.DeliveryPrint(info, id, "Courier");
        }
    }
}
