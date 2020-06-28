using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class PoliticalBuilder : PublicationBuilder
    {
        public override Publication GetPublication()
        {
            Publication publication = PoliticalPublication.Instance;
            publication.Name = "Political";
            publication.HeadName = "Jafari";
            publication.RegisterationNumber = 6;
            return publication;
        }
    }
}
