using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LedgerController : ControllerBase
    {
        private readonly LedgerDbContext _context;

        public LedgerController(LedgerDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("api/NewLedger")]
        public IActionResult NewLedger([FromBody] Ledger ledgerInput)
        {
            try
            {
                // Save the entity to the database
                _context.Ledgers.Add(ledgerInput);
                _context.SaveChanges();

                return Ok("Success");
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, ex.Message);
            }
        }
    }
}
