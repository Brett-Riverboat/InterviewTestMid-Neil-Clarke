using InterviewTestMid.Data.Classes;

namespace InterviewTestMid.Services
{
    public static class SampleDataReadEdit
    {
        public static List<string?> GetLookDescriptionsForPartDescription(List<SampleData> sampleData, string PartDescription)
        {
            return sampleData
                .Where(x => x.PartDesc == PartDescription)
                .SelectMany(x => new[] { x.Meta.PartClassification?.LookDesc, x.Meta.PartMasterType?.LookDesc, x.Meta.PartOpacity?.LookDesc }
                .Concat(x.Materials.Select(m => m.Material?.LookDesc)))
                .Where(desc => !string.IsNullOrEmpty(desc))
                .ToList();
        }

        public static void EditFirstPartWeightValue(List<SampleData> sampleData, double value)
        {
            var firstPartWeight = sampleData.FirstOrDefault();
            if (firstPartWeight != null) firstPartWeight.PartWeight.Value = value;
        }
    }
}
