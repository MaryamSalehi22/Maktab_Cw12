using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Maktab_Cw12
{
    public class Student : IStudent
    {
        static string _pattern = @"\w{3,}";
        Regex regex = new Regex(_pattern);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Id { get; set; }

        public Student(string firstName , string lastName)
        {
            ValidateFirstName(firstName);
            ValidateLastName(lastName);

        }

        private void ValidateLastName(string lastName)
        {
            if (regex.IsMatch(lastName))
            {
                LastName = lastName;
            }
            else
            {
                throw new ArgumentException("Invalid lastname");
            }
        }

        private void ValidateFirstName(string firstName)
        {
            if (regex.IsMatch(firstName))
            {
                FirstName = firstName;
            }
            else
            {
                throw new ArgumentException("Invalid firstname");
            }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
