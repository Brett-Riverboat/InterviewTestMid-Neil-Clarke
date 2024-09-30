using InterviewTestMid.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InterviewTestMid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ILogger, Logger>();
                })
                .Build();

            var logger = host.Services.GetRequiredService<ILogger>();

            DoWork(logger);
        }

        private static void DoWork(ILogger Logger)
        {
            try
            {
                Logger.WriteLogMessage("Doing some JSON tasks...");

                var sampleData = SampleDataFileIO.GetSampleDataFromJsonFile();

                var foilMaterialsDescriptions = SampleDataReadEdit.GetLookDescriptionsForPartDescription(sampleData, "FOIL");

                Logger.WriteStringsasCsv(foilMaterialsDescriptions);

                SampleDataReadEdit.EditFirstPartWeightValue(sampleData, 100.0);

                SampleDataFileIO.SaveSampleDatatoFile(sampleData, "SampleDataEdited.json");

                Logger.WriteLogMessage("Finished doing some JSON tasks.");
            }
            catch (Exception Ex)
            {
                Logger.WriteErrorMessage(Ex);
                Environment.Exit(1);
            }

        }

    }
}