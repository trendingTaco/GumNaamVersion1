using GumNaam.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GumNaam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeesController(EmployeeContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmployees()
        {
            return Ok(await _context.Employees.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployee(int id)
        {
            var Employee = await _context.Employees.FindAsync(id);
            if (Employee == null)
            {
                return NotFound();
            }
            return Ok(Employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee Employee)
        {
            /*
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            */
            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetEmployee",
                new { id = Employee.Id },
                Employee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutEmployee(int id, Employee Employee)
        {
            if (id != Employee.Id)
            {
                return BadRequest();
            }

            _context.Entry(Employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Employees.Any(p => p.Id == id))
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            var Employee = await _context.Employees.FindAsync(id);
            if (Employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(Employee);
            await _context.SaveChangesAsync();

            return Employee;
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> DeleteMultiple([FromQuery]int[] ids)
        {
            var Employees = new List<Employee>();
            foreach (var id in ids)
            {
                var Employee = await _context.Employees.FindAsync(id);

                if (Employee == null)
                {
                    return NotFound();
                }

                Employees.Add(Employee);
            }

            _context.Employees.RemoveRange(Employees);
            await _context.SaveChangesAsync();

            return Ok(Employees);
        }
    }
}
