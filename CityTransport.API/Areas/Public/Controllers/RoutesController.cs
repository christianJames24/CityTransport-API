using Microsoft.AspNetCore.Mvc;
using CityTransport.Data.Models;
using CityTransport.Data.Interfaces;

namespace CityTransport.API.Areas.Public.Controllers
{
    [Area("Public")]
    [Route("public/api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly IRouteRepository _repository;

        public RoutesController(IRouteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BusRoute>> GetAllRoutes()
        {
            var routes = _repository.GetAllRoutes();
            return Ok(routes);
        }

        [HttpGet("{id}")]
        public ActionResult<BusRoute> GetRouteById(int id)
        {
            var route = _repository.GetRouteById(id);
            if (route == null)
            {
                return NotFound();
            }
            return Ok(route);
        }
    }
}
