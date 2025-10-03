using CityTransport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransport.Data.Interfaces
{
    public interface IRouteRepository
    {
        IEnumerable<BusRoute> GetAllRoutes();
        BusRoute GetRouteById(int id);
        void AddRoute(BusRoute route);
        void DeleteRoute(int id);

    }
}
