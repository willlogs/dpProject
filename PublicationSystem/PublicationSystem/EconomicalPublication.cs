using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class EconomicalPublication : Publication
    {
        private static EconomicalPublication m_Instance;

        public static EconomicalPublication Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new EconomicalPublication();
                }

                return m_Instance;
            }
        }
    }
}
