
using Lab_1_MPZ.Lab1;


        SystemManager systemManager = new SystemManager();
        Profession developer = new Profession { Id = 1, Name = "Software Developer", Description = "Develops software applications.", Level = Level.Middle };
        Profession tester = new Profession { Id = 2, Name = "QA Tester", Description = "Tests software applications.", Level = Level.Junior };
        Employee john = new Employee(1, "John", "Doe", "M.", new DateTime(1990, 5, 15));
        john.AssignProfession(developer);
        john.AssignProfession(tester);
        Employee jane = new Employee(2, "Jane", "Smith", "A.", new DateTime(1988, 11, 23));
        jane.AssignProfession(developer);
        Position teamLeadPosition = new Position { Id = 1, Name = "Team Lead", Description = "Leads a team of developers." };
        TeamMember johnTeamMember = new TeamMember(1, john, teamLeadPosition);
        TeamMember janeTeamMember = new TeamMember(2, jane, null);
        Team team = new Team(1, "Development Team");
        team.AddTeamMember(johnTeamMember);
        team.AddTeamMember(janeTeamMember);
        ProjectOwner owner = new ProjectOwner(1, "Alice", "Brown", "L.", new DateTime(1985, 3, 10)); Project project = new Project(1, "Next-Gen Application");
        project.AssignTeam(team);
        project.AssignProjectManager(jane); project.ProjectOwner = owner; systemManager.CreateProject(project);
        systemManager.AddEmployee(john); systemManager.AddEmployee(jane);
        Console.WriteLine($"Project: {project.Name}"); Console.WriteLine($"Owner: {project.ProjectOwner?.FirstName} {project.ProjectOwner?.LastName}");
        Console.WriteLine($"Manager: {project.ProjectManager?.FirstName} {project.ProjectManager?.LastName}");
