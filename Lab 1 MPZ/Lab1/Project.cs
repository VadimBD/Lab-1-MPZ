using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Team? Team { get; set; }
        public ProjectOwner? ProjectOwner { get; set; }
        public Employee? ProjectManager { get; set; }
        public Project(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AssignTeam(Team team) => Team = team;
        public void AssignProjectManager(Employee projectManager) => ProjectManager = projectManager;

    }
}
