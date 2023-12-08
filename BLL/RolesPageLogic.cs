namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;
    using DAL;

    public interface IRolePageLogic
    {
        List<Role> GetRolesByProjectName(string projectName);
        List<Role> GetRolesByProjectId(int projectId);
        void AddRole(string roleName, int projectId);
        void RemoveRole(string roleName, int projectId);
    }

    public class RolesPageLogic
    {
        private readonly IRolePageLogic _rolePageLogic;
        public RolesPageLogic(IRolePageLogic rolePageLogic)
        {
            _rolePageLogic = rolePageLogic;
        } 


        public static List<Role> GetRolesByProjectName(string projectName)
        {
            var project = ProjectQueries.GetProjectByProjectName(projectName);
            return RoleQueries.GetRolesByProjectId(project.Id);
        }

        public static List<Role> GetRolesByProjectId(int projectId)
        {
            return RoleQueries.GetRolesByProjectId(projectId);
        }

        public static Role GetRoleByRoleNameAndProjId(string roleName, int projectId)
        {
            return DAL.RoleQueries.GetRoleByRoleNameAndProjId(roleName, projectId);
        }

        public static void AddRole(string roleName, int projectId)
        {
            Role role = new Role()
            {
                RoleName = roleName,
                ProjectId = projectId,
            };
            RoleQueries.AddRole(role);
        }

        public static List<Tuple<Role, Actor>> GetRolesActorsPair(List<Role> roles)
        {
            var actorRolePairs = new List<Tuple<Role, Actor>>();
            foreach (Role role in roles)
            {
                var projectCast = ProjectCastQueries.GetProjectCastByRoleId(role.Id);
                if (projectCast != null)
                {
                    var actor = ActorQueries.GetActorById(projectCast.ActorId);
                    actorRolePairs.Add(new Tuple<Role, Actor>(role, actor));
                }
                else
                {
                    actorRolePairs.Add(new Tuple<Role, Actor>(role, new Actor()));
                }
            }

            return actorRolePairs;
        }

        public static void RemoveRole(string roleName, int projectId)
        {
            RoleQueries.DeleteRole(roleName, projectId);
        }
    }
}
