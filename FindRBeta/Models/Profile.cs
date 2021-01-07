using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindRBeta.Models
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Profile
    {
        public int Id { get; set; }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private Gender sex;

        public Gender Sex
        {
            get { return sex; }
            set { sex = value; }
        }


        private Location address;

        public Location Address
        {
            get { return address; }
            set { address = value; }
        }

        private string details;

        public string Details
        {
            get { return details; }
            set { details = value; }
        }




    }
}