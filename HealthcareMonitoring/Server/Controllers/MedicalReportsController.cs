﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthcareMonitoring.Server.Data;
using HealthcareMonitoring.Shared.Domain;

namespace HealthcareMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MedicalReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MedicalReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicalReport>>> GetMedicalReports()
        {
          if (_context.MedicalReports == null)
          {
              return NotFound();
          }
            return await _context.MedicalReports.ToListAsync();
        }

        // GET: api/MedicalReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicalReport>> GetMedicalReport(int id)
        {
          if (_context.MedicalReports == null)
          {
              return NotFound();
          }
            var medicalReport = await _context.MedicalReports.FindAsync(id);

            if (medicalReport == null)
            {
                return NotFound();
            }

            return medicalReport;
        }

        // PUT: api/MedicalReports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalReport(int id, MedicalReport medicalReport)
        {
            if (id != medicalReport.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicalReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalReportExists(id))
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

        // POST: api/MedicalReports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MedicalReport>> PostMedicalReport(MedicalReport medicalReport)
        {
          if (_context.MedicalReports == null)
          {
              return Problem("Entity set 'ApplicationDbContext.MedicalReports'  is null.");
          }
            _context.MedicalReports.Add(medicalReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicalReport", new { id = medicalReport.Id }, medicalReport);
        }

        // DELETE: api/MedicalReports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicalReport(int id)
        {
            if (_context.MedicalReports == null)
            {
                return NotFound();
            }
            var medicalReport = await _context.MedicalReports.FindAsync(id);
            if (medicalReport == null)
            {
                return NotFound();
            }

            _context.MedicalReports.Remove(medicalReport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicalReportExists(int id)
        {
            return (_context.MedicalReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
