using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicationSystem.Info
{
    [Serializable]
    public class PersonalInformation
    {
        public string fName, lName, gender;
        public int id = -1;
        public DateTime birthDate;

        public PersonalInformation(string name, string lastName, string gender, DateTime birth, bool addToList = true)
        {
            fName = name;
            lName = lastName;
            this.gender = gender;
            birthDate = birth;

            if (addToList)
            {
                CodedPersonalInfo codedInfo = new CodedPersonalInfo(this);
            }
        }

        public string ToString()
        {
            return String.Format(
                "name: " + fName + " " + lName + "\n" +
                "gender: " + gender + "\n" +
                "id: " + id
            );
        }
    }
}
