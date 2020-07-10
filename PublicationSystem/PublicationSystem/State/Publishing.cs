using PublicationSystem.Delivery;
using PublicationSystem.Info;
using PublicationSystem.StylishPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.State
{
    class Publishing : PublicationState
    {
        private const string DeliveryFullInfo = "fullInfo";
        private const string DeliveryIdInfo = "justId";
        private const string CourierDelivery = "courier";
        private const string OnlineDelivery = "online";
        private const string PostDelivery = "post";

        private bool isFullPrinting = false;

        public Publishing()
        {
            allowedCommands = new string[]
            {
                "publish", "setPublishingMethod", "setDeliveryPrintStatus"
            };
        }

        public override bool Execute(string comand, string[] args, Publication publication)
        {
            if (comand == allowedCommands[0])
            {
                Publish(publication);
            }
            else if (comand == allowedCommands[1])
            {
                if(args != null && args.Length > 0)
                {
                    switch (args[0])
                    {
                        case CourierDelivery:
                            publication.PubDeliveryMethod = Courier.Instance;
                            break;
                        case OnlineDelivery:
                            publication.PubDeliveryMethod = Online.Instance;
                            break;
                        case PostDelivery:
                            publication.PubDeliveryMethod = Post.Instance;
                            break;
                        default:
                            StylishPrinter.PrintLine("Delivery method is not valid!");
                            break;
                    }
                }
                else
                {
                    StylishPrinter.PrintLine("Delivery method argument not provided!");
                }
            }
            else if (comand == allowedCommands[2])
            {
                if (args != null && args.Length > 0)
                {
                    switch (args[0])
                    {
                        case DeliveryFullInfo:
                            isFullPrinting = true;
                            break;
                        case DeliveryIdInfo:
                            isFullPrinting = false;
                            break;
                        default:
                            StylishPrinter.PrintLine("Delivery print status is not valid!");
                            break;
                    }
                }
                else
                {
                    StylishPrinter.PrintLine("Delivery print status argument not provided!");
                }
            }
            else
            {
                CommandProcessing.CommandProcessor.Instance.WrongCommand();
            }

            return true;
        }

        public override PublicationState Next()
        {
            throw new Exception("No Next state after publish");
        }

        private void Publish(Publication pub)
        {
            foreach(int id in pub.SubsIDs)
            {
                if (isFullPrinting)
                {
                    PersonalInformation userInfo = UserManager.Instance.GetUserById(id);
                    pub.PubDeliveryMethod.SpecificMessage(userInfo, id);
                }
                else
                {
                    pub.PubDeliveryMethod.SpecificMessage(id);
                }
            }

            StylishPrinter.PrintLine("End of notifying");
        }
    }
}
