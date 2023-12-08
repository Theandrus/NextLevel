namespace BLL
{
    using System.Collections.Generic;
    using DAL;

    public class MainWindowLogic
    {
        public static List<Project> GetAllProjects()
        {
            return ProjectQueries.GetAllProjects();
        }

        public static void RemoveProject(string projectName)
        {
            ProjectQueries.DeleteProject(projectName);
        }

        public static void AddProject(string projectName)
        {
            Project project = new Project()
            {
                ProjectName = projectName,
            };
            ProjectQueries.AddProject(project);
        }
    }
}
