using jornada.Data;
using jornada.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace jornadaControllers 
{

    [ApiController]
    [Route("api/[controller]")]
    public class JornadaController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public JornadaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jornada>>> GetJornadas()
        {
            return await _dataContext.Jornadas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Jornada>> GetJornadaById(int id)
        {
            var jornada = await _dataContext.Jornadas.FindAsync(id);

            if (jornada == null)
            {
                return NotFound();
            }

            return jornada;
        }


        
    }

}