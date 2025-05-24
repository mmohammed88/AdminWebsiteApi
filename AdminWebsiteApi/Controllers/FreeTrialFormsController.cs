using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdminWebsiteApi.Data;
using AdminWebsiteApi.Models;

namespace AdminWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreeTrialFormsController : ControllerBase
    {
        private readonly AdminWebsiteContext _context;

        public FreeTrialFormsController(AdminWebsiteContext context)
        {
            _context = context;
        }

        // GET: api/FreeTrialForms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FreeTrialForm>>> GetFreeTrialForms()
        {
            return await _context.FreeTrialForms.ToListAsync();
        }

        // GET: api/FreeTrialForms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FreeTrialForm>> GetFreeTrialForm(int id)
        {
            var freeTrialForm = await _context.FreeTrialForms.FindAsync(id);

            if (freeTrialForm == null)
            {
                return NotFound();
            }

            return freeTrialForm;
        }

        // PUT: api/FreeTrialForms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFreeTrialForm(int id, FreeTrialForm freeTrialForm)
        {
            if (id != freeTrialForm.Id)
            {
                return BadRequest();
            }

            _context.Entry(freeTrialForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FreeTrialFormExists(id))
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

        // POST: api/FreeTrialForms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FreeTrialForm>> PostFreeTrialForm(FreeTrialForm freeTrialForm)
        {
            _context.FreeTrialForms.Add(freeTrialForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFreeTrialForm", new { id = freeTrialForm.Id }, freeTrialForm);
        }

        // DELETE: api/FreeTrialForms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFreeTrialForm(int id)
        {
            var freeTrialForm = await _context.FreeTrialForms.FindAsync(id);
            if (freeTrialForm == null)
            {
                return NotFound();
            }

            _context.FreeTrialForms.Remove(freeTrialForm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FreeTrialFormExists(int id)
        {
            return _context.FreeTrialForms.Any(e => e.Id == id);
        }
    }
}
