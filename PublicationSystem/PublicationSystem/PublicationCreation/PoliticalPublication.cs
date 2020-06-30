using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class PoliticalPublication : Publication
    {
        private static PoliticalPublication m_Instance;

        public static PoliticalPublication Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new PoliticalPublication();
                }

                return m_Instance;
            }
        }
    }
}
