using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedUnify.WebApi.Controllers
{
    public class PatientController : MedUnifyControllerBase
    {
        private readonly IPatientService _patientService;
        // GET: api/<PatientController>
        public PatientController(IPatientService ptService)
        {
            _patientService = ptService;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _patientService.GetAllAsync());
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _patientService.GetAsync(id));
        }

        // POST api/<PatientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Patient patient)
        {
            return Ok(await _patientService.CreateAsync(patient));
        }

        // PUT api/<PatientController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Patient patient)
        {
            return Ok(await _patientService.UpdateAsync(patient));
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _patientService.DeleteAsync(id));
        }
    }
}
