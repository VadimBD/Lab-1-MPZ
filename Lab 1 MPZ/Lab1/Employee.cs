using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public DateTime BirthdayDate { get; set; }
        public List<Profession> Professions { get; set; } = [];
        public Employee(int id, string firstName, string lastName, string middleName, DateTime birthdayDate) 
        {
            Id = id; 
            FirstName = firstName;
            LastName = lastName; 
            MiddleName = middleName;
            BirthdayDate = birthdayDate; 
        }
        public void AssignProfession(Profession profession) => Professions.Add(profession);
        
    }
}
