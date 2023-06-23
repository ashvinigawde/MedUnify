namespace MedUnify.WebApi.Data.Entities
{
    public class PatientVisit : BaseEntity
    {
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public List<ProgressNote>? ProgressNotes { get; set; }
    }
}
