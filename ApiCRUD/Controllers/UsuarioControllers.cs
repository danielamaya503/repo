using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using ApiCRUD.Models.Models;
using ApiCRUD.Interfaces.Servicios;
using ApiCRUD.Models;

namespace ApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioControllers : ControllerBase
    {
        public readonly IUsuarios _usuarioService;

        public UsuarioControllers(IUsuarios usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        // GET: api/UsuarioControllers/GetAllUsers
        //ActionResult es una clase que representa el resultado de una acción de un controlador en ASP.NET Core.
        //para devolver diferentes tipos de respuestas HTTP.
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAllUsers()
        {
            var users = await _usuarioService.GetAllUsuarios();

            //si es nulodevuelve no encontrado
            if (users == null || !users.Any())
            {
                return NotFound("No se encontraron usuarios.");
            }

            return Ok(users);
        }
    }
}
