using CityTransport.Data.Interfaces;
using CityTransport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransport.Data.Repositories
{
    public class DatabaseRouteRepository : IRouteRepository
    {
        private readonly CityTransportContext _context;

        public DatabaseRouteRepository(CityTransportContext context)
        {
            _context = context;
        }

        public IEnumerable<BusRoute> GetAllRoutes()
        {
            return _context.BusRoutes.ToList();
        }

        public BusRoute GetRouteById(int id)
        {
            return _context.BusRoutes.FirstOrDefault(r => r.Id == id);
        }

        public void AddRoute(BusRoute route)
        {
            _context.BusRoutes.Add(route);
            _context.SaveChanges();
        }

        public void DeleteRoute(int id)
        {
            var route = _context.BusRoutes.FirstOrDefault(r => r.Id == id);
            if (route != null)
            {
                _context.BusRoutes.Remove(route);
                _context.SaveChanges();
            }
        }
    }
}
