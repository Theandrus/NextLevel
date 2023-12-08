namespace DAL
{
    /// <summary>
    /// Provides methods for querying and manipulating user data.
    /// </summary>
    public static class ActorQueries
    {
        private static readonly AppDBContext Context;

        /// <summary>
        /// Initializes static members of the <see cref="UserQueries"/> class.
        /// Initializes a new instance of the <see cref="UserQueries"/> class.
        /// </summary>
        static ActorQueries()
        {
            Context = new AppDBContext();
        }

        public static List<Actor> GetAllActors()
        {
            return (from actor in Context.Actors
                    select actor).ToList();
        }

        public static Actor GetActorById(int actorId)
        {
            return (from actor in Context.Actors
                    where actor.Id == actorId
                    select actor).FirstOrDefault();
        }

        public static Actor GetActorByName(string actorName)
        {
            return (from actor in Context.Actors
                    where actor.ActorName == actorName
                    select actor).FirstOrDefault();
        }


        public static void AddActor(Actor actor)
        {
            Context.Actors.Add(actor);
            Context.SaveChanges();
        }

        public static void DeleteActor(int actorId)
        {
            var actorToDelete = Context.Actors.Find(actorId);

            if (actorToDelete != null)
            {
                Context.Actors.Remove(actorToDelete);
                Context.SaveChanges();
            }
        }
    }
}
