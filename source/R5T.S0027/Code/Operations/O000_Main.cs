using System;
using System.Threading.Tasks;

using R5T.O0002;

using LocalData;


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
            var projectToModifyFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0026\source\R5T.S0026\R5T.S0026.csproj";
            var projectReferencesToAddIdentityStrings = new[]
            {
                Instances.ProjectPath.R5T_D0077_A002(),
                Instances.ProjectPath.R5T_D0078_A002(),
                Instances.ProjectPath.R5T_D0079_A002(),
                Instances.ProjectPath.R5T_D0083_I001(),
            };

            // Run.
            await this.AddProjectReferencesToProject.Run(
                projectToModifyFilePath,
                projectReferencesToAddIdentityStrings);
        }
    }
}
