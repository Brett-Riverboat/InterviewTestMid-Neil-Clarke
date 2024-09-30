using InterviewTestMid.Services;

namespace InterviewTestMid.Tests.Services
{
    public class SampleDataFileIOTests
    {

        [Fact]
        public void WriteLogMessage_ValidMessage_WritesToDebug()
        {
            var sampleDataAbsolutePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\InterviewTestMid\Data\Json\SampleData.json"));

            if (!File.Exists(sampleDataAbsolutePath))
            {
                Assert.Fail("Could not get correct file for sample Json file.");
            }

            var sampleData = SampleDataFileIO.GetSampleDataFromJsonFile(sampleDataAbsolutePath);

            var part11170 = sampleData.FirstOrDefault(x => x.PartId == 11170);
            var part11171 = sampleData.FirstOrDefault(x => x.PartId == 11171);
            var part11172 = sampleData.FirstOrDefault(x => x.PartId == 11172);

            //There is no one to many relationship so I think this is correct
            Assert.NotNull(part11170?.Meta);
            Assert.NotNull(part11171?.Meta);
            Assert.NotNull(part11172?.Meta);
        }

    }
}
