using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Person
    {
        private string name;
        private Genders gender;
        private DateTime birthDate;

        public Person()
        {

        }

        public Person(string Name, DateTime birthDate)
        {
            this.Name = Name;
            this.birthDate = birthDate;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Genders Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.Name, this.birthDate));
        }
    }
}