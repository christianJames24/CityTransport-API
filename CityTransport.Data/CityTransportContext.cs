using CityTransport.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTransport.Data
{
    public class CityTransportContext : DbContext
    {
        public CityTransportContext(DbContextOptions<CityTransportContext> options)
            : base(options)
        {
        }

        public DbSet<BusRoute> BusRoutes { get; set; }
        public DbSet<BusStop> BusStops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusRoute>().HasData(
                new BusRoute { Id = 1, RouteNumber = "10", Name = "De Lorimier", StartPoint = "Terminus Papineau (South)", EndPoint = "Rachel / De Lorimier (North)" },
new BusRoute { Id = 2, RouteNumber = "11", Name = "Parc-du-Mont-Royal / Ridgewood", StartPoint = "Metro Mont-Royal", EndPoint = "Côte-des-Neiges / Ridgewood" },
new BusRoute { Id = 3, RouteNumber = "12", Name = "Île-des-Soeurs", StartPoint = "Metro De l’Église", EndPoint = "Île-des-Soeurs" },
new BusRoute { Id = 4, RouteNumber = "15", Name = "Sainte-Catherine", StartPoint = "Terminus Papineau", EndPoint = "Atwater" },
new BusRoute { Id = 5, RouteNumber = "18", Name = "Beaubien", StartPoint = "Rosemont / Beaubien", EndPoint = "Metro Beaubien" },
new BusRoute { Id = 6, RouteNumber = "24", Name = "Sherbrooke", StartPoint = "Terminus Sherbrooke Est", EndPoint = "Westmount / Vendôme" },
new BusRoute { Id = 7, RouteNumber = "32", Name = "Lacordaire", StartPoint = "Terminus Cadillac", EndPoint = "Henri-Bourassa / Lacordaire" },
new BusRoute { Id = 8, RouteNumber = "45", Name = "Papineau", StartPoint = "Metro Papineau", EndPoint = "Henri-Bourassa Est" },
new BusRoute { Id = 9, RouteNumber = "51", Name = "Édouard-Montpetit", StartPoint = "Metro Laurier", EndPoint = "Metro Snowdon" },
new BusRoute { Id = 10, RouteNumber = "55", Name = "Saint-Laurent", StartPoint = "Terminus Berri-UQAM", EndPoint = "Boulevard Saint-Laurent Nord" },
new BusRoute { Id = 11, RouteNumber = "67", Name = "Saint-Michel", StartPoint = "Metro Saint-Michel", EndPoint = "Pie-IX / Sauvé" },
new BusRoute { Id = 12, RouteNumber = "69", Name = "Gouin", StartPoint = "Gouin Est / Langelier", EndPoint = "Henri-Bourassa / O'Brien" },
new BusRoute { Id = 13, RouteNumber = "80", Name = "Du Parc", StartPoint = "Metro Place-des-Arts", EndPoint = "Parc / Jean-Talon" },
new BusRoute { Id = 14, RouteNumber = "90", Name = "Saint-Jacques", StartPoint = "Metro Lionel-Groulx", EndPoint = "Lachine" },
new BusRoute { Id = 15, RouteNumber = "97", Name = "Mont-Royal", StartPoint = "Metro Mont-Royal", EndPoint = "Pie-IX / Rosemont" },
new BusRoute { Id = 16, RouteNumber = "103", Name = "Monkland", StartPoint = "Metro Villa-Maria", EndPoint = "Concordia Loyola Campus" },
new BusRoute { Id = 17, RouteNumber = "105", Name = "Sherbrooke (NDG)", StartPoint = "Metro Vendôme", EndPoint = "Concordia Loyola Campus" },
new BusRoute { Id = 18, RouteNumber = "106", Name = "Newman", StartPoint = "Angrignon", EndPoint = "Terminus LaSalle" },
new BusRoute { Id = 19, RouteNumber = "121", Name = "Sauvé / Côte-Vertu", StartPoint = "Metro Sauvé", EndPoint = "Metro Côte-Vertu" },
new BusRoute { Id = 20, RouteNumber = "165", Name = "Côte-des-Neiges", StartPoint = "Metro Snowdon", EndPoint = "Metro Guy-Concordia" },
new BusRoute { Id = 21, RouteNumber = "171", Name = "Henri-Bourassa", StartPoint = "Henri-Bourassa Est", EndPoint = "Henri-Bourassa Ouest / Bois-Franc" },
new BusRoute { Id = 22, RouteNumber = "211", Name = "Bord-du-Lac", StartPoint = "Metro Lionel-Groulx", EndPoint = "Sainte-Anne-de-Bellevue" },
new BusRoute { Id = 23, RouteNumber = "439", Name = "Express Pie-IX", StartPoint = "Metro Pie-IX", EndPoint = "Henri-Bourassa Est" },
new BusRoute { Id = 24, RouteNumber = "747", Name = "Express Aéroport / Centre-Ville", StartPoint = "YUL Montreal-Trudeau", EndPoint = "Terminus Berri-UQAM" }
            );
        }
    }
}