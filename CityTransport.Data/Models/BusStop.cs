using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransport.Data.Models
{
    public class BusStop
    {
        public int Id { get; set; }
        public string StopNumber { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
