namespace BLL
{
    using DAL;

    public static class SessionManager
    {
        public static Project CurrentProject { get; set; }

        public static void ChangeProject(string projectName)
        {
            CurrentProject = ProjectQueries.GetProjectByProjectName(projectName);
        }
    }
}
