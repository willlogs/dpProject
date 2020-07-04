using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.Delivery
{
    public interface IDeliveryMethod
    {
        void SpecificMessage(int id);
    }
}
