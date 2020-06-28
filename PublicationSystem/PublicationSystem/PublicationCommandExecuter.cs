using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class PublicationCommandExecuter : ICommandExecuter
    {
        private const string SportModel = "Sport";
        private const string PoliticalModel = "Political";
        private const string EconomicalModel = "Economical";

        public bool Execute(string command, string[] args)
        {
            string publicationName = GetPublicationName(command, args);

            Publication publication = null;
            switch (publicationName)
            {
                case SportModel:
                    publication = PublicationProvider.Instance.GetPublication(new SportBuilder());
                    break;
                case PoliticalModel:
                    publication = PublicationProvider.Instance.GetPublication(new PoliticalBuilder());
                    break;
                case EconomicalModel:
                    publication = PublicationProvider.Instance.GetPublication(new EconomicalBuilder());
                    break;
            }

            if(publication != null)
            {
                //do what command wants...
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetPublicationName(string command, string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
