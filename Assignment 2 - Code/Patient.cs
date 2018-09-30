using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___Code
{
    class Patient
    {
        private int id;
        private string avatarImage;
        private string name;
        private string dayOfBirth;
        private string gender;
        private string address;
        private string telephoneNumber;

        public Patient(int id, string avatarImage, string name, string dayOfBirth, string gender, string address, string telephoneNumber)
        {
            AvatarImage = avatarImage;
            Id = id;
            Name = name;
            DayOfBirth = dayOfBirth;
            Gender = gender;
            Address = address;
            TelephoneNumber = telephoneNumber;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string AvatarImage { get => avatarImage; set => avatarImage = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
