using System;

using Microsoft.Extensions.DependencyInjection;

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
        /// Adds the <see cref="O000_Main"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddO000_Main(this IServiceCollection services,
            IServiceAction<AddProjectReferencesToProject> addProjectReferencesToProjectAction)
        {
            services
                .Run(addProjectReferencesToProjectAction)
                .AddSingleton<O000_Main>();

            return services;
        }
    }
}
