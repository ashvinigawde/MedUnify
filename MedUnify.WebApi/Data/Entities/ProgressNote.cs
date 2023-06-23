namespace MedUnify.WebApi.Data.Entities
{
    public class ProgressNote : BaseEntity
    {
        public long PatientVisitId { get; set; }
        public string SectionName { get; set; } = "";
        public string SectionText { get; set; } = "";

        public PatientVisit? PatientVisit { get; set; }
    }
}
