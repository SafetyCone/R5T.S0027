using System;
using System.Threading.Tasks;

using R5T.O0002;
using R5T.T0020;


namespace R5T.S0027
{
    public class O002_GetRecursiveDependenciesCount : IActionOperation
    {
        private GetRecursiveDependenciesCount GetRecursiveDependenciesCount { get; }


        public O002_GetRecursiveDependenciesCount(
            GetRecursiveDependenciesCount getRecursiveDependenciesCount)
        {
            this.GetRecursiveDependenciesCount = getRecursiveDependenciesCount;
        }

        public async Task Run()
        {
            // Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0113\source\R5T.T0113.X000\R5T.T0113.X000.csproj";

            // Run.
            var recursiveProjectReferencesCount = await this.GetRecursiveDependenciesCount.Run(projectFilePath);

            Console.WriteLine($"{recursiveProjectReferencesCount}: Recursive project reference count for project file:\n\n{projectFilePath}");
        }
    }
}
