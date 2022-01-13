using System;

using R5T.Lombardy;

using R5T.D0084.D001;
using R5T.D0101;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0084.I0001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AllProjectDirectoryPathsProvider"/> implementation of <see cref="IAllProjectDirectoryPathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAllProjectDirectoryPathsProvider> AddAllProjectDirectoryPathsProviderAction(this IServiceAction _,
            IServiceAction<IProjectRepository> projectRepositoryAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IAllProjectDirectoryPathsProvider>(services => services.AddAllProjectDirectoryPathsProvider(
                projectRepositoryAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
