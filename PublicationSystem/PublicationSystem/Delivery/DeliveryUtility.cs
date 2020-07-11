using PublicationSystem.Info;
using PublicationSystem.StylishPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Delivery
{
    public static class DeliveryUtility
    {
        public static void DeliveryPrint(PersonalInformation info, int userId, string deliveryMethod)
        {
            string message = string.Format("{0} delivered to user {1}\nUser Info:\n{2}",deliveryMethod , userId, info.ToString());
            StylishPrinter.PrintLine(message);
        }

        public static void DeliveryPrint(int userId, string deliveryMethod)
        {
            string message = string.Format("{0} delivered to user {1}", deliveryMethod, userId);
            StylishPrinter.PrintLine(message);
        }
    }
}
