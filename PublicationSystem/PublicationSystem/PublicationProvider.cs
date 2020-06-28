using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class PublicationProvider 
    {
        private List<Publication> m_Publications;
        private static PublicationProvider m_Instance;

        public static PublicationProvider Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new PublicationProvider();
                    m_Instance.m_Publications = new List<Publication>();
                }

                return m_Instance;
            }
        }

        public Publication GetPublication(PublicationBuilder builder)
        {
            Publication publication = builder.GetPublication();

            bool publicationExists = m_Publications.Contains(publication);
            if (!publicationExists)
            {
                publication.EstablishDate = DateTime.Now;
                m_Publications.Add(publication);
            }

            return publication;
        }
    }
}
