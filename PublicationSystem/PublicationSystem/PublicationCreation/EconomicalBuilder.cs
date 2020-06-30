using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class EconomicalBuilder : PublicationBuilder
    {
        private const string EconomicalModel = "Economical";

        public override Publication GetPublication()
        {
            Publication publication = EconomicalPublication.Instance;
            publication.Name = EconomicalModel;
            publication.HeadName = "Masoumi";
            publication.RegisterationNumber = 7;
            return publication;
        }

        public override string PublicationCommandName => EconomicalModel.ToLower();
    }
}
