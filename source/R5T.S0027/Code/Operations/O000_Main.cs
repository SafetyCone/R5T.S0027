using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.O0002;

using LocalData;

using R5T.S0027.Lib;


namespace R5T.S0027
{
    public class O000_Main : T0020.IActionOperation
    {
        private AddProjectReferencesToProject AddProjectReferencesToProject { get; }


        public O000_Main(
            AddProjectReferencesToProject addProjectReferencesToProject)
        {
            this.AddProjectReferencesToProject = addProjectReferencesToProject;
        }

        public async Task Run()
        {
            // Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0031\source\R5T.S0031\R5T.S0031.csproj";
            var projectReferencesToAddIdentityStrings =
                //Instances.ProjectPath.GetVisualStudioRelatedProjectIdentityStrings()
                //.Concat(Instances.ProjectPath.GetProjectRepositoryRelatedProjectIdentityStrings())
                Instances.ProjectPath.GetProjectIdentityStringsRelatedTo_GetAllRepositoryDirectories()
                //EnumerableHelper.From(new[] {
                //    Instances.ProjectPath.R5T_D0084_A001(),
                //})
                .Now();

            // Run.
            await this.AddProjectReferencesToProject.Run(
                projectFilePath,
                projectReferencesToAddIdentityStrings);
        }
    }
}
