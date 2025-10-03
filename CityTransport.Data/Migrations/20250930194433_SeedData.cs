using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CityTransport.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusRoutes",
                columns: new[] { "Id", "EndPoint", "Name", "RouteNumber", "StartPoint" },
                values: new object[,]
                {
                    { 1, "Rachel / De Lorimier (North)", "De Lorimier", "10", "Terminus Papineau (South)" },
                    { 2, "Côte-des-Neiges / Ridgewood", "Parc-du-Mont-Royal / Ridgewood", "11", "Metro Mont-Royal" },
                    { 3, "Île-des-Soeurs", "Île-des-Soeurs", "12", "Metro De l’Église" },
                    { 4, "Atwater", "Sainte-Catherine", "15", "Terminus Papineau" },
                    { 5, "Metro Beaubien", "Beaubien", "18", "Rosemont / Beaubien" },
                    { 6, "Westmount / Vendôme", "Sherbrooke", "24", "Terminus Sherbrooke Est" },
                    { 7, "Henri-Bourassa / Lacordaire", "Lacordaire", "32", "Terminus Cadillac" },
                    { 8, "Henri-Bourassa Est", "Papineau", "45", "Metro Papineau" },
                    { 9, "Metro Snowdon", "Édouard-Montpetit", "51", "Metro Laurier" },
                    { 10, "Boulevard Saint-Laurent Nord", "Saint-Laurent", "55", "Terminus Berri-UQAM" },
                    { 11, "Pie-IX / Sauvé", "Saint-Michel", "67", "Metro Saint-Michel" },
                    { 12, "Henri-Bourassa / O'Brien", "Gouin", "69", "Gouin Est / Langelier" },
                    { 13, "Parc / Jean-Talon", "Du Parc", "80", "Metro Place-des-Arts" },
                    { 14, "Lachine", "Saint-Jacques", "90", "Metro Lionel-Groulx" },
                    { 15, "Pie-IX / Rosemont", "Mont-Royal", "97", "Metro Mont-Royal" },
                    { 16, "Concordia Loyola Campus", "Monkland", "103", "Metro Villa-Maria" },
                    { 17, "Concordia Loyola Campus", "Sherbrooke (NDG)", "105", "Metro Vendôme" },
                    { 18, "Terminus LaSalle", "Newman", "106", "Angrignon" },
                    { 19, "Metro Côte-Vertu", "Sauvé / Côte-Vertu", "121", "Metro Sauvé" },
                    { 20, "Metro Guy-Concordia", "Côte-des-Neiges", "165", "Metro Snowdon" },
                    { 21, "Henri-Bourassa Ouest / Bois-Franc", "Henri-Bourassa", "171", "Henri-Bourassa Est" },
                    { 22, "Sainte-Anne-de-Bellevue", "Bord-du-Lac", "211", "Metro Lionel-Groulx" },
                    { 23, "Henri-Bourassa Est", "Express Pie-IX", "439", "Metro Pie-IX" },
                    { 24, "Terminus Berri-UQAM", "Express Aéroport / Centre-Ville", "747", "YUL Montreal-Trudeau" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BusRoutes",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
