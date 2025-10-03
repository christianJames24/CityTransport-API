using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransport.Data.Models
{
    public class BusRoute
    {
        public int Id { get; set; }
        public string RouteNumber { get; set; }
        public string Name { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
    }
}
