using System;

using R5T.Lombardy;

using R5T.D0078;
using R5T.D0079;
using R5T.D0083;
using R5T.D0101;
using R5T.O0002;
using R5T.T0062;
using R5T.T0063;


namespace R5T.S0027
{
    public static partial class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="O002_GetRecursiveDependenciesCount"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<O002_GetRecursiveDependenciesCount> AddO002_GetRecursiveDependenciesCountAction(this IServiceAction _,
            IServiceAction<GetRecursiveDependenciesCount> getRecursiveDependenciesCountAction)
        {
            var serviceAction = _.New<O002_GetRecursiveDependenciesCount>(services => services.AddO002_GetRecursiveDependenciesCount(
                getRecursiveDependenciesCountAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="O001_AddProjectReferencesToProject"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<O001_AddProjectReferencesToProject> AddO001_AddProjectReferencesToProjectAction(this IServiceAction _,
            IServiceAction<AddProjectReferencesToProject> addProjectReferencesToProjectAction)
        {
            var serviceAction = _.New<O001_AddProjectReferencesToProject>(services => services.AddO001_AddProjectReferencesToProject(
                addProjectReferencesToProjectAction));

            return serviceAction;
        }
    }
}
