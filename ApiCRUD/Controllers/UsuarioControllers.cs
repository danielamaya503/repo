using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiCRUD.Models.Models;
using ApiCRUD.Interfaces.Servicios;

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
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _usuarioService.GetAllUsuarios();
            return Ok(users);
        }
    }
}
