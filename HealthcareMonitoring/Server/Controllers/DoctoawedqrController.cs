using HealthcareMonitoring.Server.Data;
using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthcareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoawedqrController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DoctoawedqrController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] Doctor doctor)
        {
            var entity = await _applicationDbContext.Doctors.FirstOrDefaultAsync(x=>x.Id == doctor.Id);

            entity.DoctorName = doctor.DoctorName;
            entity.DoctorPhoneNumber = doctor.DoctorPhoneNumber;
            entity.DoctorNationality = doctor.DoctorNationality;
            entity.DoctorIntroduction = doctor.DoctorIntroduction;
            entity.DoctorSpecialization= doctor.DoctorSpecialization;
            entity.DoctorExperience = doctor.DoctorExperience;
            entity.DoctorAvailavleTime = doctor.DoctorAvailavleTime;

            _applicationDbContext.Doctors.Update(entity);

            _applicationDbContext.SaveChanges();

            return Ok();
        }
    }
}
