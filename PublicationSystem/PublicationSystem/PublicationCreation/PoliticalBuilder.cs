using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class PoliticalBuilder : PublicationBuilder
    {
        private const string PoliticalModel = "Political";
        public override Publication GetPublication()

        {
            Publication publication = PoliticalPublication.Instance;
            publication.Name = PoliticalModel;
            publication.HeadName = "Jafari";
            publication.RegisterationNumber = 6;
            return publication;
        }

        public override string PublicationCommandName => PoliticalModel.ToLower();
    }
}
