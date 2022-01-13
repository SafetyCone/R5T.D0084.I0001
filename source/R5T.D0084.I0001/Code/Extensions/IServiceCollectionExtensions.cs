using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0084.D001;
using R5T.D0101;
using R5T.T0063;


namespace R5T.D0084.I0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AllProjectDirectoryPathsProvider"/> implementation of <see cref="IAllProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAllProjectDirectoryPathsProvider(this IServiceCollection services,
            IServiceAction<IProjectRepository> projectRepositoryAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(projectRepositoryAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IAllProjectDirectoryPathsProvider, AllProjectDirectoryPathsProvider>();

            return services;
        }
    }
}
