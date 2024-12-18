using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Employee? TeamLead { get; set; }
        public List<TeamMember> TeamMembers { get; set; } = [];
        public Team(int id, string name)
        {
            Id = id; 
            Name = name;
        }
        public void AddTeamMember(TeamMember teamMember) => TeamMembers.Add(teamMember);
        public void RemoveTeamMember(int teamMemberId) => TeamMembers.RemoveAll(tm => tm.Id == teamMemberId);
    }
}
