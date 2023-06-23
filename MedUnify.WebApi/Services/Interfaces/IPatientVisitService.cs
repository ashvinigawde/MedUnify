using MedUnify.WebApi.Data.Entities;

namespace MedUnify.WebApi.Services.Interfaces
{
    public interface IPatientVisitService
    {
        Task<int> Create(PatientVisit patientVisit);
        Task<List<PatientVisit>> GetAll(int patientId);
    }
}
