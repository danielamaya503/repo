using ApiCRUD.Interfaces.Servicios;
using ApiCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosControllers : ControllerBase
    {
        public readonly IDepartament _departamentoService;

        public DepartamentosControllers(IDepartament departamentoService)
        {
            _departamentoService = departamentoService;
        }

        /// <summary>
        /// Genera un endpoint para obtener todos los departamentos
        /// </summary>
        /// <returns></returns>s
        [HttpGet]
        [Route("GetAllDepartaments")]
        public async Task<ActionResult<IEnumerable<Departament>>> GetALLDepartament() {

            // Manejo de errores básico con try-catch
            try
            {
                // Llamada al servicio para obtener los departamentos
                var deparmentList = await _departamentoService.GetALLDepartaments();

                // Verificación si la lista está vacía o es nula
                if (deparmentList == null || !deparmentList.Any())
                {
                    // Retornar un estado 404 si no se encuentran departamentos
                    return NotFound("No se encontraron departamentos.");
                }
                // Retornar la lista de departamentos con un estado 200 OK
                return Ok(deparmentList);

            }
            catch (Exception ex) 
            {
                // Retornar un estado 500 en caso de error interno del servidor
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
            
        }

    }
}
