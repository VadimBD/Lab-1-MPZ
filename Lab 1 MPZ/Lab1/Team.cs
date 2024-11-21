using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class Team
    {
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;
        public Employee? TeamLead {get; set;}
        public List<TeamMember> TeamMembers { get; set; } = [];
    }
}
