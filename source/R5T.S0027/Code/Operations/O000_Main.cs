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
            var projectToModifyFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E1000.Private\source\TestProject\TestProject.csproj";
            var projectReferencesToAddIdentityStrings = new[]
            {
                Instances.ProjectPath.R5T_A0003(), // 130 recursive project reference dependencies!
            };

            // Run.
            await this.AddProjectReferencesToProject.Run(
                projectToModifyFilePath,
                projectReferencesToAddIdentityStrings);
        }
    }
}
