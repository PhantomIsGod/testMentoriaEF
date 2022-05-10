using Microsoft.AspNetCore.Mvc;
using testMentoriaEF.Model;
using testMentoriaEF.Infrastructure;

namespace testMentoriaEF.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DatabaseController : Controller
    {
        private readonly DatabaseDataContext _context;
        public DatabaseController(DatabaseDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var estudiantes = _context.Estudiantes;
            return Ok(estudiantes);
        }
        [HttpPut]
        public IActionResult PosteoMensaje()
        {
            return Ok();
        }
        
        [HttpPost]
        public IActionResult AgregarEstudiante()
        {
            var estudiantes = _context.Estudiantes;
            var nuevoEstudiante = new Estudiante();
            nuevoEstudiante.Nombre = "Juan Finol";
            nuevoEstudiante.FechaNacimiento = new DateTime(1997, 12, 15);
            _context.Add(nuevoEstudiante);
            _context.SaveChanges();
            return Ok(estudiantes);
        }
    }
}
