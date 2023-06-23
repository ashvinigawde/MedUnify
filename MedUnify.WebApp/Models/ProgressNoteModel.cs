namespace MedUnify.WebApp.Models
{
    public class ProgressNoteModel : EntityModel
    {
        public long PatientVisitId { get; set; }
        public string SectionName { get; set; } = "";
        public string SectionText { get; set; } = "";

        public PatientVisitModel? PatientVisit { get; set; }
    }
}
