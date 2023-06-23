using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedUnify.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientVisitController : MedUnifyControllerBase
    {
        private readonly IPatientVisitService _patientVisitService;
        public PatientVisitController(IPatientVisitService visitService)
        {
            _patientVisitService = visitService;
        }
        // GET: api/<PatientVisitController>
        [HttpGet]
        public async Task<IActionResult> Index(int patientId)
        {
            return Ok(await _patientVisitService.GetAll(patientId));
        }


        // POST api/<PatientVisitController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PatientVisit patientVisit)
        {
            return Ok(await _patientVisitService.Create(patientVisit));
        }
    }
}
