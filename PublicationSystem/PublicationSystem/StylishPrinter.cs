using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public static class StylishPrinter
    {
        private static List<PrintingStyle> m_Styles = new List<PrintingStyle>();

        public static void AddStyle(PrintingStyle style)
        {
            m_Styles.Add(style);
        }

        public static void RemoveStyle(PrintingStyle style)
        {
            m_Styles.Remove(style);
        }

        public static void Print(string message)
        {
            for(int i = 0; i < m_Styles.Count; i++)
            {
                message = m_Styles[i].Stylize(message);
            }

            Console.Write(message);
        }

        public static void PrintLine(string message)
        {
            for (int i = 0; i < m_Styles.Count; i++)
            {
                message = m_Styles[i].Stylize(message);
            }

            Console.WriteLine(message);
        }
    }
}
