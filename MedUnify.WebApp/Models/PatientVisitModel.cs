namespace MedUnify.WebApp.Models;

public class PatientVisitModel : EntityModel
{
    public int PatientId { get; set; }
    public DateTime VisitDate { get; set; }
    public List<ProgressNoteModel>? ProgressNotes { get; set; }
}
