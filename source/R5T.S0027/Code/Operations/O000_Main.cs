using System;
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
            var projectToModifyFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0046\source\R5T.E0046\R5T.E0046.csproj";
            var projectReferencesToAddIdentityStrings =
                Instances.ProjectPath.GetProjectRepositoryRelatedProjectIdentityStrings();
            //new[]
            //{
            //    Instances.ProjectPath.R5T_X0002(),
            //};

            // Run.
            await this.AddProjectReferencesToProject.Run(
                projectToModifyFilePath,
                projectReferencesToAddIdentityStrings);
        }
    }
}
