using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class SystemManager
    {
        private List<Employee> employees = new List<Employee>();
        private List<Profession> professions = new List<Profession>();
        private List<Project> projects = new List<Project>();
        private List<ProjectOwner> projectOwners = new List<ProjectOwner>();
        private List<Team> teams = new List<Team>();

       
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void EditEmployee(int id, string firstName, string lastName, string middleName, DateTime birthdayDate)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.MiddleName = middleName;
                employee.BirthdayDate = birthdayDate;
            }
        }

        public void DeleteEmployee(int id)
        {
            employees.RemoveAll(e => e.Id == id);
        }

        public void AssignProfessionToEmployee(int employeeId, Profession profession)
        {
            var employee = employees.Find(e => e.Id == employeeId);
            if (employee != null && profession != null)
            {
                employee.Professions.Add(profession);
            }
        }

      
        public void CreateProject(Project project)
        {
            projects.Add(project);
        }

        public void EditProject(int id, string name)
        {
            var project = projects.Find(p => p.Id == id);
            if (project != null)
            {
                project.Name = name;
            }
        }

        public void DeleteProject(int id)
        {
            projects.RemoveAll(p => p.Id == id);
        }

        public void AssignTeamAndManagerToProject(int projectId, Team team, Employee projectManager)
        {
            var project = projects.Find(p => p.Id == projectId);
            if (project != null)
            {
                project.Team = team;
                project.ProjectManager = projectManager;
            }
        }

       
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void EditTeam(int id, string name)
        {
            var team = teams.Find(t => t.Id == id);
            if (team != null)
            {
                team.Name = name;
            }
        }

        public void DeleteTeam(int id)
        {
            teams.RemoveAll(t => t.Id == id);
        }

        public void AddTeamMember(int teamId, TeamMember teamMember)
        {
            var team = teams.Find(t => t.Id == teamId);
            if (team != null)
            {
                team.TeamMembers.Add(teamMember);
            }
        }

        public void DeleteTeamMember(int teamId, int teamMemberId)
        {
            var team = teams.Find(t => t.Id == teamId);
            if (team != null)
            {
                team.TeamMembers.RemoveAll(tm => tm.Id == teamMemberId);
            }
        }

    }
}
