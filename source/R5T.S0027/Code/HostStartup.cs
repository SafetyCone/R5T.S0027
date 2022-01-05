using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Magyar;
using R5T.Ostrogothia.Rivet;

using R5T.A0003;
using R5T.D0048.Default;
using R5T.D0077.A002;
using R5T.D0078.A002;
using R5T.D0079.A002;
using R5T.D0081.I001;
using R5T.D0083.I001;
using R5T.D0088.I0002;
using R5T.D0101.I0001;
using R5T.D0101.I001;
using R5T.O0002;
using R5T.T0063;

using IProvidedServiceActionAggregation = R5T.D0088.I0002.IProvidedServiceActionAggregation;
using IRequiredServiceActionAggregation = R5T.D0088.I0002.IRequiredServiceActionAggregation;
using ServicesPlatformRequiredServiceActionAggregation = R5T.A0003.RequiredServiceActionAggregation;


namespace R5T.S0027
{
    public class HostStartup : HostStartupBase
    {
        public override Task ConfigureConfiguration(IConfigurationBuilder configurationBuilder)
        {
            // Do nothing.

            return Task.CompletedTask;
        }

        protected override Task ConfigureServices(IServiceCollection services, IProvidedServiceActionAggregation providedServicesAggregation)
        {
            // Inputs.
            var executionSynchronicityProviderAction = Instances.ServiceAction.AddConstructorBasedExecutionSynchronicityProviderAction(Synchronicity.Synchronous);
            var organizationProviderAction = Instances.ServiceAction.AddOrganizationProviderAction(); // Rivet organization.
            var rootOutputDirectoryPathProviderAction = Instances.ServiceAction.AddConstructorBasedRootOutputDirectoryPathProviderAction(@"C:\Temp\Output");

            // Services platform.
            var servicesPlatformRequiredServiceActionAggregation = new ServicesPlatformRequiredServiceActionAggregation
            {
                ConfigurationAction = providedServicesAggregation.ConfigurationAction,
                ExecutionSynchronicityProviderAction = executionSynchronicityProviderAction,
                LoggerAction = providedServicesAggregation.LoggerAction,
                LoggerFactoryAction = providedServicesAggregation.LoggerFactoryAction,
                MachineMessageOutputSinkProviderActions = EnumerableHelper.Empty<IServiceAction<D0099.D002.IMachineMessageOutputSinkProvider>>(),
                MachineMessageTypeJsonSerializationHandlerActions = EnumerableHelper.Empty<IServiceAction<D0098.IMachineMessageTypeJsonSerializationHandler>>(),
                OrganizationProviderAction = organizationProviderAction,
                RootOutputDirectoryPathProviderAction = rootOutputDirectoryPathProviderAction,
            };

            var servicesPlatform = Instances.ServiceAction.AddProvidedServiceActionAggregation(
                servicesPlatformRequiredServiceActionAggregation);

            // Core competencies.
            // Project repository.
            var projectRepositoryFilePathsProviderAction = Instances.ServiceAction.AddHardCodedProjectRepositoryFilePathsProviderAction();

            var fileBasedProjectRepositoryAction = Instances.ServiceAction.AddFileBasedProjectRepositoryAction(
                projectRepositoryFilePathsProviderAction);

            var projectRepositoryAction = Instances.ServiceAction.ForwardFileBasedProjectRepositoryToProjectRepositoryAction(
                fileBasedProjectRepositoryAction);

            // Visual studio.
            var dotnetOperatorActions = Instances.ServiceAction.AddDotnetOperatorActions(
                servicesPlatform.CommandLineOperatorAction,
                servicesPlatform.SecretsDirectoryFilePathProviderAction);
            var visualStudioProjectFileOperatorActions = Instances.ServiceAction.AddVisualStudioProjectFileOperatorActions(
                dotnetOperatorActions.DotnetOperatorAction,
                servicesPlatform.FileNameOperatorAction,
                servicesPlatform.StringlyTypedPathOperatorAction);
            var visualStudioProjectFileReferencesProviderAction = Instances.ServiceAction.AddVisualStudioProjectFileReferencesProviderAction(
                servicesPlatform.StringlyTypedPathOperatorAction);
            var visualStudioSolutionFileOperatorActions = Instances.ServiceAction.AddVisualStudioSolutionFileOperatorActions(
                dotnetOperatorActions.DotnetOperatorAction,
                servicesPlatform.FileNameOperatorAction,
                servicesPlatform.StringlyTypedPathOperatorAction);

            // Operations.
            var addProjectReferencesToProjectAction = Instances.ServiceAction.AddAddProjectReferencesToProjectAction(
                projectRepositoryAction,
                servicesPlatform.StringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorActions.VisualStudioProjectFileOperatorAction,
                visualStudioProjectFileReferencesProviderAction,
                visualStudioSolutionFileOperatorActions.VisualStudioSolutionFileOperatorAction);
            var getRecursiveDependenciesCountAction = Instances.ServiceAction.AddGetRecursiveDependenciesCountAction(
                visualStudioProjectFileReferencesProviderAction);

            // Local.
            var o001_AddProjectReferencesToProjectAction = Instances.ServiceAction.AddO001_AddProjectReferencesToProjectAction(
                addProjectReferencesToProjectAction);
            var o002_GetRecursiveDependenciesCountAction = Instances.ServiceAction.AddO002_GetRecursiveDependenciesCountAction(
                getRecursiveDependenciesCountAction);

            // Run.
            services
                .Run(servicesPlatform.ConfigurationAuditSerializerAction)
                .Run(servicesPlatform.ServiceCollectionAuditSerializerAction)
                // Operations.
                .Run(o001_AddProjectReferencesToProjectAction)
                .Run(o002_GetRecursiveDependenciesCountAction)
                ;

            return Task.CompletedTask;
        }

        protected override Task FillRequiredServiceActions(IRequiredServiceActionAggregation requiredServiceActions)
        {
            // Do nothing.

            return Task.CompletedTask;
        }
    }
}
