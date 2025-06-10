using System.Security;
using Dsw2025Ej14.Api.Data;
using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductsController : ControllerBase
    {
        private readonly IPersistencia _persistencia;

        public ProductsController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }
        [HttpGet("products")]

        public IActionResult GetProducts()
        {
            return Ok(_persistencia.GetProducts());
        }

    }
}
