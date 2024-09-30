using InterviewTestMid.Data.Classes;
using Newtonsoft.Json;

namespace InterviewTestMid.Services
{
    public static class SampleDataFileIO
    {
        public static List<SampleData> GetSampleDataFromJsonFile(string? sampleDataAbsolutePath = null)
        {
            sampleDataAbsolutePath ??= Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Data\Json\SampleData.json"));

            if (!File.Exists(sampleDataAbsolutePath))
            {
                Environment.Exit(1);
            }

            var jsonData = File.ReadAllText(sampleDataAbsolutePath);
            var sampleData = JsonConvert.DeserializeObject<List<SampleData>>(jsonData) ?? [];

            return sampleData;
        }

        public static void SaveSampleDatatoFile(List<SampleData> sampleData, string filename)
        {
            var editedJsonData = JsonConvert.SerializeObject(sampleData, Formatting.Indented);
            var editedSampleDataAbsolutePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Data\Json\" + filename));
            File.WriteAllText(editedSampleDataAbsolutePath, editedJsonData);
        }
    }
}
