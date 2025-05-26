using LAB11_WilliansMalque.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LAB11_WilliansMalque.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestConnectionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestConnectionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("tickets")]
        public async Task<IActionResult> GetTickets()
        {
            try
            {
                // Intenta obtener los primeros 5 registros para probar conexión
                var tickets = await _context.tickets.Take(5).ToListAsync();

                return Ok(new
                {
                    Message = "Conexión exitosa a la base de datos",
                    Data = tickets
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Error al conectar con la base de datos",
                    Details = ex.Message
                });
            }
        }
    }
}