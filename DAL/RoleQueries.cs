namespace DAL
{
    public static class RoleQueries
    {
        private static readonly AppDBContext _context;

        static RoleQueries()
        {
            _context = new AppDBContext();
        }

        public static List<Role> GetRolesByProjectId(int projectId)
        {
            return (from role in _context.Roles
                    where role.ProjectId == projectId
                    select role).ToList();
        }

        public static Role GetRoleByRoleNameAndProjId(string roleName, int projecId)
        {
            return (from role in _context.Roles
                    where role.RoleName == roleName && role.ProjectId == projecId
                    select role).FirstOrDefault();
        }

        public static void AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public static void DeleteRole(string roleName, int projectId)
        {
            var roleToDelete = (from role in _context.Roles
                                 where role.RoleName == roleName && role.ProjectId == projectId
                                 select role).FirstOrDefault();

            if (roleToDelete != null)
            {
                _context.Roles.Remove(roleToDelete);
                _context.SaveChanges();
            }
        }
    }
}
