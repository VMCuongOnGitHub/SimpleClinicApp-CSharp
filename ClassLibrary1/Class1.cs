using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient
{
    class Patient
    {
        private string name;
        private string dayOfBirth;
        private string age;
        private string gender;
        private string address;
        private string telephoneNumber;

        public Patient(string name, string dayOfBirth, string age, string gender, string address, string telephoneNumber)
        {
            Name = name;
            DayOfBirth = dayOfBirth;
            Age = age;
            Gender = gender;
            Address = address;
            TelephoneNumber = telephoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
    }
}
