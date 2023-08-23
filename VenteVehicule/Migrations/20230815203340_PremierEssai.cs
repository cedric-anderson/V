using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VenteVehicule.Migrations
{
    /// <inheritdoc />
    public partial class PremierEssai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_vehicule",
                table: "VehiculeDoccasions",
                newName: "id_vehicule");

            migrationBuilder.RenameColumn(
                name: "Id_annance",
                table: "Annonces",
                newName: "id_annance");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Annonces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "VehiculeDoccasions",
                columns: new[] { "id_vehicule", "AnneFab", "Carburant", "Couleur", "DateMiseEnVente", "Description", "Kilometrage", "Marque", "Modele", "Prix", "Transmission" },
                values: new object[,]
                {
                    { 1, 2020, "Essence", "Bleu", new DateTime(2023, 7, 16, 22, 33, 40, 166, DateTimeKind.Local).AddTicks(982), "Bonne condition, faible kilométrage.", 15000, "Toyota", "Corolla", 15000.00m, "Automatique" },
                    { 2, 2018, "Essence", "Rouge", new DateTime(2023, 7, 31, 22, 33, 40, 166, DateTimeKind.Local).AddTicks(1031), "Économique et fiable.", 20000, "Honda", "Civic", 18000.00m, "Manuelle" },
                    { 3, 2022, "Essence", "Noir", new DateTime(2023, 7, 1, 22, 33, 40, 166, DateTimeKind.Local).AddTicks(1034), "Voiture de sport puissante.", 1000, "Ford", "Mustang", 40000.00m, "Automatique" }
                });

            migrationBuilder.InsertData(
                table: "Annonces",
                columns: new[] { "id_annance", "DateMiseEnLigne", "Description", "Email", "ImageURL", "NumeroTelephone", "Prix", "Vendeur", "id_Vehicule" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 5, 22, 33, 40, 166, DateTimeKind.Local).AddTicks(1132), "Belle voiture d'occasion à vendre.", "jean.dupont@example.com", "https://example.com/images/car1.jpg", "123-456-7890", 15000.00m, "Jean Dupont", 1 },
                    { 2, new DateTime(2023, 7, 31, 22, 33, 40, 166, DateTimeKind.Local).AddTicks(1137), "Voiture familiale spacieuse en bon état.", "alice.martin@example.com", "https://example.com/images/car2.jpg", "987-654-3210", 18000.00m, "Alice Martin", 2 },
                    { 3, new DateTime(2023, 8, 10, 22, 33, 40, 166, DateTimeKind.Local).AddTicks(1141), "Véhicule économique idéal pour la ville.", "cedric.anderson@example.com", "https://example.com/images/car3.jpg", "555-123-4567", 40000.00m, "Cedric Anderson", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Annonces",
                keyColumn: "id_annance",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Annonces",
                keyColumn: "id_annance",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Annonces",
                keyColumn: "id_annance",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehiculeDoccasions",
                keyColumn: "id_vehicule",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehiculeDoccasions",
                keyColumn: "id_vehicule",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehiculeDoccasions",
                keyColumn: "id_vehicule",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Annonces");

            migrationBuilder.RenameColumn(
                name: "id_vehicule",
                table: "VehiculeDoccasions",
                newName: "Id_vehicule");

            migrationBuilder.RenameColumn(
                name: "id_annance",
                table: "Annonces",
                newName: "Id_annance");
        }
    }
}
