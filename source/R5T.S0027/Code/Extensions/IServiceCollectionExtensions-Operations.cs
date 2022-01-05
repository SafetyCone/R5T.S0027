using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0078;
using R5T.D0079;
using R5T.D0083;
using R5T.D0101;
using R5T.O0002;
using R5T.T0063;


namespace R5T.S0027
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="O002_GetRecursiveDependenciesCount"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddO002_GetRecursiveDependenciesCount(this IServiceCollection services,
            IServiceAction<GetRecursiveDependenciesCount> getRecursiveDependenciesCountAction)
        {
            services
                .Run(getRecursiveDependenciesCountAction)
                .AddSingleton<O002_GetRecursiveDependenciesCount>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="O001_AddProjectReferencesToProject"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddO001_AddProjectReferencesToProject(this IServiceCollection services,
            IServiceAction<AddProjectReferencesToProject> addProjectReferencesToProjectAction)
        {
            services
                .Run(addProjectReferencesToProjectAction)
                .AddSingleton<O001_AddProjectReferencesToProject>();

            return services;
        }
    }
}
