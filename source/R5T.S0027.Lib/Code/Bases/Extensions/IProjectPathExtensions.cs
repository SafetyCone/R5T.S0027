using System;
using System.Linq;

using R5T.T0040;

using LocalData;


namespace R5T.S0027.Lib
{
    public static class IProjectPathExtensions
    {
        public static string[] GetProjectIdentityStringsRelatedTo_ExtensionMethodBaseExtensionsRepository(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0101_I001(),
                _.R5T_D0101_I0001(),
                _.R5T_D0108_I001(),
                _.R5T_D0108_I0001(),
                _.R5T_D0109_I001(),
                _.R5T_D0109_I0001(),
            };

            return identityStrings;
        }

        public static string[] GetProjectIdentityStringsRelatedTo_GitAndGitHubOperators(this IProjectPath _)
        {
            var output = _.GetProjectIdentityStringsRelatedTo_GitHubOperator()
                .Append(_.GetProjectIdentityStringsRelatedTo_GitOperator())
                .Now()
                ;

            return output;    
        }

        public static string[] GetProjectIdentityStringsRelatedTo_GitHubOperator(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0082_A001(),
                // Dependencies will be added by Olympia functionality.
            };

            return identityStrings;
        }

        public static string[] GetProjectIdentityStringsRelatedTo_GitOperator(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0037_A002(),
                // Dependencies will be added by Olympia functionality.
            };

            return identityStrings;
        }

        public static string[] GetProjectIdentityStringsRelatedTo_ProjectRepository(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0101_I0001(),
                _.R5T_D0101_I001(),
            };

            return identityStrings;
        }

        public static string[] GetProjectIdentityStringsRelatedTo_GetAllRepositoryDirectories(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0084_D001_I002(),
                _.R5T_D0084_D002_I001(),
            };

            return identityStrings;
        }

        public static string[] GetProjectIdentityStringsRelatedTo_VisualStudio(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0077_A002(),
                _.R5T_D0078_A002(),
                _.R5T_D0079_A002(),
                _.R5T_D0083_I001(),
            };

            return identityStrings;
        }
    }
}
