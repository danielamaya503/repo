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

        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllUsers")]
        // GET: api/UsuarioControllers/GetAllUsers
        //ActionResult es una clase que representa el resultado de una acción de un controlador en ASP.NET Core.
        //para devolver diferentes tipos de respuestas HTTP.
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAllUsers()
        {
            try {
                //Obtiene todos los usuarios llamando al servicio   
                var users = await _usuarioService.GetAllUsuarios();

                //si es nulodevuelve no encontrado
                if (users == null || !users.Any())
                {
                    //si no hay usuarios devuelve no encontrado
                    return NotFound("No se encontraron usuarios.");
                }
                //devuelve la lista de usuarios
                return Ok(users);

            }
            catch (Exception ex) 
            {
                //si hay un error devuelve error interno del servidor
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor: " + ex.Message);
            }
            
        }
    }
}
