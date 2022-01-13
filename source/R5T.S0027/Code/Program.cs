using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.D0088;
using R5T.D0090;


namespace R5T.S0027
{
    class Program : ProgramAsAServiceBase
    {
        #region Static

        static async Task Main()
        {
            //OverridableProcessStartTimeProvider.Override("20211214-163052");
            //OverridableProcessStartTimeProvider.DoNotOverride();

            await Instances.Host.NewBuilder()
                .UseProgramAsAService<Program, T0075.IHostBuilder>()
                .UseHostStartup<HostStartup, T0075.IHostBuilder>(Instances.ServiceAction.AddStartupAction())
                .Build()
                .SerializeConfigurationAudit()
                .SerializeServiceCollectionAudit()
                .RunAsync();
        }

        #endregion


        public Program(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        protected override async Task ServiceMain(CancellationToken stoppingToken)
        {
            await this.ServiceProvider.Run<O000_Main>();

            //await this.ServiceProvider.Run<O002_GetRecursiveDependenciesCount>();
        }

        //private async Task RunOperation()
        //{
        
        //}
        
        //private async Task RunMethod()
        //{
        
        //}
    }
}