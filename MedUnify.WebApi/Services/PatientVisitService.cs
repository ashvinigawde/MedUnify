using MedUnify.WebApi.Data;
using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedUnify.WebApi.Services
{
    public class PatientVisitService : ServiceBase, IPatientVisitService
    {
        public PatientVisitService(MedUnifyDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<int> Create(PatientVisit patientVisit)
        {
            var visit = new PatientVisit()
            {
                PatientId = patientVisit.PatientId,
                VisitDate = DateTime.Now,
            };

            await _dbContext.PatientVisits.AddAsync(visit);
            var resp = await _dbContext.SaveChangesAsync();
            if (patientVisit.ProgressNotes == null || resp == 0)
            {
                return 0;
            }

            var notes = patientVisit.ProgressNotes;
            notes.ForEach(x => x.PatientVisitId = visit.Id);
            await _dbContext.ProgressNotes.AddRangeAsync(notes);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<PatientVisit>> GetAll(int patientId)
        {
            return await _dbContext.PatientVisits.Where(x => x.PatientId == patientId).Include(x => x.ProgressNotes).ToListAsync();
        }
    }
}
