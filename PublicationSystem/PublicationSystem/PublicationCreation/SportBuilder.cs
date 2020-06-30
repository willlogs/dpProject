using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class SportBuilder : PublicationBuilder
    {
        private const string SportModel = "Sport";

        public override Publication GetPublication()
        {
            Publication publication = SportPublication.Instance;
            publication.Name = SportModel;
            publication.HeadName = "Asadi";
            publication.RegisterationNumber = 3;
            return publication;
        }

        public override string PublicationCommandName => SportModel.ToLower();
    }
}
