
using Lab_1_MPZ.Lab1;

Profession developer = new Profession
{
    Id = 1,
    Name = "Software Developer",
    Description = "Develops software applications.",
    Level = Level.Middle
};

Profession tester = new Profession
{
    Id = 2,
    Name = "QA Tester",
    Description = "Tests software applications.",
    Level = Level.Junior
};

Employee john = new Employee
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    MiddleName = "M.",
    BirthdayDate = new DateTime(1990, 5, 15),
    Professions = new List<Profession> { developer, tester }
};

Employee jane = new Employee
{
    Id = 2,
    FirstName = "Jane",
    LastName = "Smith",
    MiddleName = "A.",
    BirthdayDate = new DateTime(1988, 11, 23),
    Professions = new List<Profession> { developer }
};


Position teamLeadPosition = new Position
{
    Id = 1,
    Name = "Team Lead",
    Description = "Leads a team of developers."
};

// Создание членов команды
TeamMember johnTeamMember = new TeamMember
{
    Id = 1,
    Employee = john,
    Position = teamLeadPosition
};

TeamMember janeTeamMember = new TeamMember
{
    Id = 2,
    Employee = jane,
    Position = null // Не указана позиция
};


Team team = new Team
{
    Id = 1,
    Name = "Development Team",
    TeamLead = john,
    TeamMembers = new List<TeamMember> { johnTeamMember, janeTeamMember }
};


ProjectOwner owner = new ProjectOwner
{
    Id = 1,
    FirstName = "Alice",
    LastName = "Brown",
    MiddleName = "L.",
    BirthdayDate = new DateTime(1985, 3, 10)
};


Project project = new Project
{
    Id = 1,
    Name = "Next-Gen Application",
    Team = team,
    ProjectOwner = owner,
    ProjectManager = jane
};


Console.WriteLine($"Project: {project.Name}");
Console.WriteLine($"Owner: {project.ProjectOwner?.FirstName} {project.ProjectOwner?.LastName}");
Console.WriteLine($"Manager: {project.ProjectManager?.FirstName} {project.ProjectManager?.LastName}");
Console.WriteLine($"Team: {project.Team?.Name}");
Console.WriteLine("Team Members:");

foreach (var member in project.Team.TeamMembers)
{
    Console.WriteLine($"- {member.Employee?.FirstName} {member.Employee?.LastName} ({member.Position?.Name ?? "No Position"})");
}