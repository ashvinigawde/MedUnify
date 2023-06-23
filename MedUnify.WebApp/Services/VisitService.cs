using MedUnify.WebApp.Models;

namespace MedUnify.WebApp.Services
{
    public class VisitService
    {
        private List<PatientVisitModel> visits = new();

        public List<PatientVisitModel> GetVisitsByPatientId(int patientId)
        {
            return visits.Where(v => v.PatientId == patientId).ToList();
        }

        public void AddProgressNoteToVisit(int visitId, ProgressNoteModel progressNote)
        {
            var visit = visits.FirstOrDefault(v => v.Id == visitId);
            if (visit != null)
            {
                visit.ProgressNotes ??= new List<ProgressNoteModel>{ progressNote };
            }
        }
    }
}
