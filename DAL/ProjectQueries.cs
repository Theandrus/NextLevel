namespace DAL
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ProjectQueries
    {

        private static readonly AppDBContext _context;

        static ProjectQueries()
        {
            _context = new AppDBContext();
        }

        public static Project GetProjectByProjectName(string projectName)
        {
            return (from project in _context.Projects
                   where project.ProjectName == projectName
                   select project).First();
        }

        public static List<Project> GetAllProjects()
        {
            return (from project in _context.Projects
                    select project).ToList();
        }

        public static void DeleteProject(string projectName)
        {

            var projectToDelete = GetProjectByProjectName(projectName);

            if (projectToDelete != null)
            {
                _context.Projects.Remove(projectToDelete);
                _context.SaveChanges();
            }
        }

        public static void AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }
    }
}
