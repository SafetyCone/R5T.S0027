using System;

using R5T.T0040;

using LocalData;


namespace R5T.S0027.Lib
{
    public static class IProjectPathExtensions
    {
        public static string[] GetExtensionMethodBaseExtensionsRepositoryRelatedProjectIdentityStrings(this IProjectPath _)
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

        public static string[] GetProjectRepositoryRelatedProjectIdentityStrings(this IProjectPath _)
        {
            var identityStrings = new[]
            {
                _.R5T_D0101_I0001(),
                _.R5T_D0101_I001(),
            };

            return identityStrings;
        }

        public static string[] GetVisualStudioRelatedProjectIdentityStrings(this IProjectPath _)
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
