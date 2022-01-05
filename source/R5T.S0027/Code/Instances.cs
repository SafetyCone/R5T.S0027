using System;

using R5T.T0040;
using R5T.T0044;
using R5T.T0062;
using R5T.T0070;
using R5T.T0113;


namespace R5T.S0027
{
    public static class Instances
    {
        public static IFileSystemOperator FileSystemOperator { get; } = T0044.FileSystemOperator.Instance;
        public static IHost Host { get; } = T0070.Host.Instance;
        public static IProjectOperator ProjectOperator { get; } = T0113.ProjectOperator.Instance;
        public static IProjectPath ProjectPath { get; } = T0040.ProjectPath.Instance;
        public static IServiceAction ServiceAction { get; } = T0062.ServiceAction.Instance;
        public static ISolutionOperator SolutionOperator { get; } = T0113.SolutionOperator.Instance;
    }
}
