namespace DAL
{
    public class Actor
    {
        public int Id { get; set; }
        public string ActorName { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public int ProjectId { get; set; }
    }

    public class ProjectCast
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int RoleId { get; set; }
    }

    public class Models
    {

    }
}