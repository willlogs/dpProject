using PublicationSystem.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Delivery
{
    class Post : IDeliveryMethod
    {
        public static Post Instance { get; private set; } = new Post();

        public void SpecificMessage(int id)
        {
            DeliveryUtility.DeliveryPrint(id, "Post");
        }

        public void SpecificMessage(PersonalInformation info, int id)
        {
            DeliveryUtility.DeliveryPrint(info, id, "Post");
        }
    }
}
