// <copyright file="UserQueries.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
// <summary>
// File: UserQueries.cs
// Provides methods for querying and manipulating user data.
// </summary>
// <author>Your Name</author>
//-----------------------------------------------------------------------
namespace DAL
{
    using System.Data;

    /// <summary>
    /// Provides methods for querying and manipulating user data.
    /// </summary>
    public static class ProjectCastQueries
    {
        private static readonly AppDBContext Context;

        /// <summary>
        /// Initializes static members of the <see cref="UserQueries"/> class.
        /// Initializes a new instance of the <see cref="UserQueries"/> class.
        /// </summary>
        static ProjectCastQueries()
        {
            Context = new AppDBContext();
        }

        public static ProjectCast GetProjectCastByRoleId(int roleId)
        {
            return (from cast in Context.ProjectCasts
                    where cast.RoleId == roleId
                    select cast).FirstOrDefault();
        }

        public static ProjectCast GetProjectCastByRoleIdAndActorId(int roleId, int actorId)
        {
            return (from cast in Context.ProjectCasts
                    where cast.RoleId == roleId && cast.ActorId == actorId
                    select cast).FirstOrDefault();
        }

        public static void AddProjectCast(ProjectCast projCast)
        {
            Context.ProjectCasts.Add(projCast);
            Context.SaveChanges();
        }
    }
}
