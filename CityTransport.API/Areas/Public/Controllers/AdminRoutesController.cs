using Microsoft.AspNetCore.Mvc;
using CityTransport.Data.Models;
using CityTransport.Data.Interfaces;

namespace CityTransport.API.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/api/routes")]
    [ApiController]
    public class AdminRoutesController : ControllerBase
    {
        private readonly IRouteRepository _repository;

        public AdminRoutesController(IRouteRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<BusRoute> AddRoute([FromBody] BusRoute route)
        {
            _repository.AddRoute(route);
            return CreatedAtAction(nameof(AddRoute), new { id = route.Id }, route);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRoute(int id)
        {
            var route = _repository.GetRouteById(id);
            if (route == null)
            {
                return NotFound();
            }
            _repository.DeleteRoute(id);
            return NoContent();
        }
    }
}