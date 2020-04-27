using System;
using System.Linq;

using FluentMigrator.Runner;

using Microsoft.Extensions.DependencyInjection;
using bballsim.simulation.DatabaseMigrations;

namespace bballsim.simulation
{
    public static class FluentMigrationRunner
    {
        /// <summary>
        /// Configure the dependency injection services
        /// </summary>
        public static IServiceProvider CreateServices()
        {
            return new ServiceCollection()
                // Add common FluentMigrator services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    // Add MySql support to FluentMigrator
                    .AddMySql5()
                    // Set the connection string
                    .WithGlobalConnectionString("Server=127.0.0.1;Port=3306;Database=simulation;Uid=simulationUser;Pwd=JabbatheSimulator1078;")
                    // Define the assembly containing the migrations
                    .ScanIn(
                         typeof(M_2020_04_18_01_AddLogTable).Assembly
                        ,typeof(M_2020_04_21_03_AddPlayer).Assembly
                        ,typeof(M_2020_04_24_01_AddTeam).Assembly
                        ,typeof(M_2020_04_24_02_AddGame).Assembly
                        ,typeof(M_2020_04_24_03_AddSimSchedule).Assembly).For.Migrations())                    
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                // Build the service provider
                .BuildServiceProvider(false);
        }

        /// <summary>
        /// Update the database
        /// </summary>
        public static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            // Instantiate the runner
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            // Execute the migrations
            runner.MigrateUp();
        }
    }
}