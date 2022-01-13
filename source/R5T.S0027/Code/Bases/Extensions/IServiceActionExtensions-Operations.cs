using System;

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
        /// Adds the <see cref="O000_Main"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<O000_Main> AddO000_Main(this IServiceAction _,
            IServiceAction<AddProjectReferencesToProject> addProjectReferencesToProjectAction)
        {
            var serviceAction = _.New<O000_Main>(services => services.AddO000_Main(
                addProjectReferencesToProjectAction));

            return serviceAction;
        }
    }
}
