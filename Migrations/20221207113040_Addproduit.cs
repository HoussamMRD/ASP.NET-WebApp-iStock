using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iStock.Migrations
{
    /// <inheritdoc />
    public partial class Addproduit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QTT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseName = table.Column<string>(name: "Warehouse_Name", type: "nvarchar(max)", nullable: false),
                    FournisseurName = table.Column<string>(name: "Fournisseur_Name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
