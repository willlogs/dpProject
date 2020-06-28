using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class SportPublication : Publication
    {
        private static SportPublication m_Instance;

        public static SportPublication Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new SportPublication();
                }

                return m_Instance;
            }
        }
    }
}
