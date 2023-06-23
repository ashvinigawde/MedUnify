using MedUnify.WebApi.Data;
using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedUnify.WebApi.Services
{
    public class PatientService : ServiceBase, IPatientService
    {
        public PatientService(MedUnifyDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<int> CreateAsync(Patient patient)
        {
            patient.CreatedAt = DateTime.Now;
            patient.UpdatedAt = DateTime.Now;
            await _dbContext.Patients.AddAsync(patient);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var patient = await _dbContext.Patients.FirstOrDefaultAsync(x => x.Id == id);
            if (patient == null)
            {
                return 0;
            }
            patient.DeletedAt = DateTime.Now;
            _dbContext.Patients.Remove(patient);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await _dbContext.Patients.ToListAsync();
        }

        public async Task<Patient?> GetAsync(int id)
        {
           return await _dbContext.Patients.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<int> UpdateAsync(Patient patient)
        {
            
            var oldPtData = await _dbContext.Patients.FirstOrDefaultAsync(x => x.Id == patient.Id);
            if (oldPtData == null)
            {
                return 0;
            }
            oldPtData.FirstName=patient.FirstName;
            oldPtData.LastName=patient.LastName;
            oldPtData.City=patient.City;
            oldPtData.State=patient.State;
            oldPtData.Address=patient.Address;
            oldPtData.UpdatedAt = DateTime.Now;
            _dbContext.Patients.Update(oldPtData);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
