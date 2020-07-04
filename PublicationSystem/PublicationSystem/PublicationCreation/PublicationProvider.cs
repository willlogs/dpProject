using PublicationSystem.CommandProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class PublicationProvider
    {
        private Dictionary<string, Publication> m_Publications;
        private static PublicationProvider m_Instance;

        public static PublicationProvider Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new PublicationProvider();
                }

                return m_Instance;
            }
        }

        private PublicationProvider()
        {
            m_Instance = this;
            m_Instance.m_Publications = new Dictionary<string, Publication>();
        }

        public Publication CreatePublication(PublicationBuilder builder)
        {
            Publication publication = builder.GetPublication();

            bool publicationExists = m_Publications.ContainsKey(builder.PublicationCommandName);
            if (!publicationExists)
            {
                publication.EstablishDate = DateTime.Now;
                m_Publications.Add(builder.PublicationCommandName, publication);
            }
            else
            {
                Console.WriteLine("The publication model " + builder.PublicationCommandName + " already exists! No more creation");
            }

            return publication;
        }

        public Publication GetPublication(string publicationName)
        {
            bool publicationExists = m_Publications.ContainsKey(publicationName);
            if (!publicationExists)
            {
                throw new ArgumentException("The publication " + publicationName + " does not exist.");
            }
            else
            {
                return m_Publications[publicationName];
            }
        }

        public void PrintInfo()
        {
            foreach(var publicationPair in m_Publications)
            {
                publicationPair.Value.PrintInfo();
            }
        }
    }
}
