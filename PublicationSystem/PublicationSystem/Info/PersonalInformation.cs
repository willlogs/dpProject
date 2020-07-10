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
        public DateTime birthDate;

        public PersonalInformation(string name, string lastName, string gender, DateTime birth)
        {
            fName = name;
            lName = lastName;
            this.gender = gender;
            birthDate = birth;
        }

        public override string ToString()
        {
            return String.Format(
                "name: " + fName + " " + lName + "\n" +
                "gender: " + gender + "\n" +
                "birth date: " + birthDate
            );
        }
    }
}
