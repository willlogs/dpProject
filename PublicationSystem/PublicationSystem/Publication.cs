using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public class Publication
    {
        public string Name { get; set; }
        public DateTime EstablishDate { get; set; }
        public int RegisterationNumber { get; set; }
        public string HeadName { get; set; }

        public override string ToString()
        {
            string message = "Name: " + Name + "\n";
            message += "Date: " + EstablishDate.ToString() + "\n";
            message += "Hashcode: " + GetHashCode().ToString() + "\n";
            message += "Head: " + HeadName + "\n";
            return message;
        }
    }
}
