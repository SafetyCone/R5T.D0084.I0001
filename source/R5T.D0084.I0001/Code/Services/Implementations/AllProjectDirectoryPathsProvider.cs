using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0084.D001;
using R5T.D0101;using R5T.T0064;


namespace R5T.D0084.I0001
{[ServiceImplementationMarker]
    public class AllProjectDirectoryPathsProvider : IAllProjectDirectoryPathsProvider,IServiceImplementation
    {
        private IProjectRepository ProjectRepository { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public AllProjectDirectoryPathsProvider(
            IProjectRepository projectRepository,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.ProjectRepository = projectRepository;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string[]> GetAllProjectDirectoryPaths()
        {
            var allProjectFilePaths = await this.ProjectRepository.GetAllProjectFilePaths();

            var output = allProjectFilePaths
                .Select(xFilePath => this.StringlyTypedPathOperator.GetDirectoryPathForFilePath(xFilePath))
                .Distinct()
                .Now_OLD();

            return output;
        }
    }
}
