using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class TeamMember
    {
        public int Id { get; set; }
        public Employee? Employee { get; set; }
        public Position? Position { get; set; }
        public TeamMember(int id, Employee employee, Position position)
        {
            Id = id;
            Employee = employee;
            Position = position;
        }
    }
}
