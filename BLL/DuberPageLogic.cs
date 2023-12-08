using DAL;

namespace BLL
{
    public class DuberPageLogic
    {
        public static List<Tuple<Actor, bool>> GetActorsToDisplay(int projectId)
        {
            var actors = ActorQueries.GetAllActors();
            var rolesByProjectId = RoleQueries.GetRolesByProjectId(projectId);

            var result = new List<Tuple<Actor, bool>>();
            foreach (var actor in actors)
            {
                bool isAdded = false;
                foreach (var role in rolesByProjectId)
                {
                    var cast = ProjectCastQueries.GetProjectCastByRoleIdAndActorId(role.Id, actor.Id);

                    if (cast != null)
                    {
                        result.Add(new Tuple<Actor, bool>(actor, true));
                        isAdded = true;
                        break;
                    }
                }

                if (!isAdded)
                {
                    result.Add(new Tuple<Actor, bool>(actor, false));
                }
            }

            return result;
        }

        public static void AddProjectCast(int actorId, int roleId)
        {
            ProjectCast projCast = new ProjectCast()
            {
                ActorId = actorId,
                RoleId = roleId,
            };
            ProjectCastQueries.AddProjectCast(projCast);
        }

        public static Actor GetActorByName(string actorName)
        {
            return ActorQueries.GetActorByName(actorName);
        }

        public static List<Actor> GetAllActors()
        {
            return ActorQueries.GetAllActors();
        }

        public static void AddActor(string actorName)
        {
            Actor actor = new Actor()
            {
                ActorName = actorName,
            };
            ActorQueries.AddActor(actor);
        }

        public static void RemoveActor(string actorName)
        {
            var actor = ActorQueries.GetActorByName(actorName);
            ActorQueries.DeleteActor(actor.Id);
        }
    }
}
