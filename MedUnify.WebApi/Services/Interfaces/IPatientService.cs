using MedUnify.WebApi.Data.Entities;

namespace MedUnify.WebApi.Services.Interfaces
{
    public interface IPatientService
    {
        Task<int> CreateAsync(Patient patient);
        Task<List<Patient>> GetAllAsync();
        Task<Patient?> GetAsync(int id);
        Task<int> UpdateAsync(Patient patient);
        Task<int> DeleteAsync(int id);
    }
}
