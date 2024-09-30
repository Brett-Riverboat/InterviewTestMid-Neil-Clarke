namespace InterviewTestMid.Data.Classes
{
    public class SampleData
    {
        public int PartId { get; set; }
        public string PartNbr { get; set; } = "";
        public string PartDesc { get; set; } = "";
        public Meta? Meta { get; set; } = null;
        public PartWeight? PartWeight { get; set; } = null;
        public bool ConversionsApplied { get; set; }
        public List<Materials> Materials { get; set; } = [];
    }

    public class Materials
    {
        public Material? Material { get; set; } = null;
        public double Percentage { get; set; }
    }

    public class Material
    {
        public int LookId { get; set; }
        public string LookNbr { get; set; } = "";
        public string LookDesc { get; set; } = "";
    }

    public class Meta
    {
        public PartClassification? PartClassification { get; set; } = null;
        public PartMasterType? PartMasterType { get; set; } = null;
        public PartColour? PartColour { get; set; } = null;
        public PartOpacity? PartOpacity { get; set; } = null;
    }

    public class PartClassification
    {
        public int LookId { get; set; }
        public string LookNbr { get; set; } = "";
        public string LookDesc { get; set; } = "";
        public string LookExtra { get; set; } = "";
    }

    public class PartColour
    {
        public int LookId { get; set; }
        public string LookNbr { get; set; } = "";
        public string LookDesc { get; set; } = "";
    }

    public class PartMasterType
    {
        public int LookId { get; set; }
        public string LookNbr { get; set; } = "";
        public string LookDesc { get; set; } = "";
    }

    public class PartOpacity
    {
        public int LookId { get; set; }
        public string LookNbr { get; set; } = "";
        public string LookDesc { get; set; } = "";
    }

    public class PartWeight
    {
        public int UoM { get; set; }
        public double Value { get; set; }
    }
}
