using FLOCKAPI.Classes;
using FLOCKAPI.Interfaces;
using FLOCKAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FLOCKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : Controller
    {
        private readonly IServicioAPI _servicioapi;
        private readonly ILogger _logger;
        public ProvinciasController(IServicioAPI servicioAPI, ILogger<ProvinciasController> logger)
        {
            _servicioapi = servicioAPI;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetLongYLatDeProvincia(string nombre)
        {
            RootObject root = _servicioapi.GetProvincias();
            _logger.LogInformation("Se estan obteniendo las provincias");
            var provincia = root.provincias.FirstOrDefault(x => x.nombre == nombre);
            if (provincia != null)
                return Ok(Json(provincia.centroide.lat.ToString() + provincia.centroide.lon.ToString()));
            _logger.LogError($"La provincia {nombre} no se encontró");
            return BadRequest();
        }
    }
}
