﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthcareMonitoring.Server.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthcareMonitoring.Server.Data;
using HealthcareMonitoring.Server.IRepository;
using HealthcareMonitoring.Shared.Domain;

namespace HealthcareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        //private readonly ApplicationDbContext _context;

        public DiagnosesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Doctors
        [HttpGet]
        public async Task<IActionResult> GetDiagnosis()
        {
            var diagnoses = await _unitOfWork.Doctors.GetAll();
            return Ok(diagnoses);
        }

        // GET: api/Doctors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Diagnosis>> GetDiagnosis(int id)
        {

            var diagnosis = await _unitOfWork.Doctors.Get(q => q.Id == id);

            if (diagnosis == null)
            {
                return NotFound();
            }

            return Ok(diagnosis);
        }
        // PUT: api/Doctors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiagnosis(int id, Diagnosis diagnosis)
        {
            if (id != diagnosis.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Diagnoses.Update(diagnosis);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DiagnosisExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Doctors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Diagnosis>> PostDiagnosis(Diagnosis diagnosis)
        {
            await _unitOfWork.Diagnoses.Insert(diagnosis);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetDiagnosis", new { id = diagnosis.Id }, diagnosis);
        }

        // DELETE: api/Doctors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiagnosis(int id)
        {
            var diagnosis = await _unitOfWork.Diagnoses.Get(q => q.Id == id);
            if (diagnosis == null)
            {
                return NotFound();
            }
            await _unitOfWork.Diagnoses.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();

        }

        private async Task<bool> DiagnosisExists(int id)
        {
            var diagnosis = await _unitOfWork.Diagnoses.Get(q => q.Id == id);
            return diagnosis != null;
        }
    }
}