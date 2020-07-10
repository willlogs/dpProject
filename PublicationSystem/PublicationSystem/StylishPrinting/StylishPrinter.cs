using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem.StylishPrinting
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
                string[] lines = message.Split('\n');
                string[] newLines = new string[lines.Length];
                int j = 0;
                foreach(string s in lines)
                {
                    newLines[j++] = m_Styles[i].Stylize(s);
                    message = string.Join("\n", newLines);
                }
            }

            Console.Write(message);
        }

        public static void PrintLine(string message)
        {
            for (int i = 0; i < m_Styles.Count; i++)
            {
                string[] lines = message.Split('\n');
                string[] newLines = new string[lines.Length];
                int j = 0;
                foreach (string s in lines)
                {
                    newLines[j++] = m_Styles[i].Stylize(s);
                    message = string.Join("\n", newLines);
                }
            }

            Console.WriteLine(message);
        }
    }
}
