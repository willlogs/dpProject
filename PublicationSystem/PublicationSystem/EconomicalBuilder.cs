using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class EconomicalBuilder : PublicationBuilder
    {
        public override Publication GetPublication()
        {
            Publication publication = EconomicalPublication.Instance;
            publication.Name = "Economical";
            publication.HeadName = "Masoumi";
            publication.RegisterationNumber = 7;
            return publication;
        }
    }
}
