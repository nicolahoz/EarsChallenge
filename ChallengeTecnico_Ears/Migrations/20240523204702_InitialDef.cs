using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChallengeTecnico_Ears.Migrations
{
    /// <inheritdoc />
    public partial class InitialDef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Person",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    EmployeeFile = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Offices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUIT = table.Column<int>(type: "int", nullable: false),
                    IdPerson = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Offices_T_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "T_Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "T_Person",
                columns: new[] { "Id", "Active", "Dni", "EmployeeFile", "Name" },
                values: new object[,]
                {
                    { 1L, true, 429052984, 1001, "John Doe" },
                    { 2L, true, 973347851, 1002, "Alice Smith" },
                    { 3L, false, 327813549, 1003, "Bob Johnson" },
                    { 4L, true, 360802010, 1004, "Emily Brown" },
                    { 5L, false, 157652163, 1005, "Michael Wilson" },
                    { 6L, true, 990772592, 1006, "Emma Davis" },
                    { 7L, false, 517109719, 1007, "James Taylor" },
                    { 8L, true, 22460317, 1008, "Olivia Martinez" },
                    { 9L, false, 453810075, 1009, "William Jones" },
                    { 10L, true, 379323607, 1010, "Sophia Anderson" }
                });

            migrationBuilder.InsertData(
                table: "T_Offices",
                columns: new[] { "Id", "Active", "CUIT", "CompanyName", "IdPerson" },
                values: new object[,]
                {
                    { 1L, true, 123456789, "Company1", 1L },
                    { 2L, false, 987654321, "Company2", 2L },
                    { 3L, true, 246810121, "Company3", 3L },
                    { 4L, false, 135791113, "Company4", 4L },
                    { 5L, true, 112233445, "Company5", 5L },
                    { 6L, false, 998877665, "Company6", 6L },
                    { 7L, true, 334455667, "Company7", 7L },
                    { 8L, false, 556677889, "Company8", 8L },
                    { 9L, true, 778899001, "Company9", 9L },
                    { 10L, false, 102030405, "Company10", 10L },
                    { 11L, true, 405060708, "Company11", 1L },
                    { 12L, false, 203040506, "Company12", 2L },
                    { 13L, true, 607080901, "Company13", 3L },
                    { 14L, false, 102030405, "Company14", 4L },
                    { 15L, true, 506070809, "Company15", 5L },
                    { 16L, false, 102938475, "Company16", 6L },
                    { 17L, true, 576869798, "Company17", 7L },
                    { 18L, false, 384756392, "Company18", 8L },
                    { 19L, true, 948573829, "Company19", 9L },
                    { 20L, false, 201938475, "Company20", 10L },
                    { 21L, true, 102938475, "Company21", 1L },
                    { 22L, false, 938475920, "Company22", 2L },
                    { 23L, true, 192837465, "Company23", 3L },
                    { 24L, false, 920384756, "Company24", 4L },
                    { 25L, true, 182736495, "Company25", 5L },
                    { 26L, false, 204060708, "Company26", 6L },
                    { 27L, true, 829384756, "Company27", 7L },
                    { 28L, false, 102938475, "Company28", 8L },
                    { 29L, true, 475829384, "Company29", 9L },
                    { 30L, false, 394857294, "Company30", 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Offices_IdPerson",
                table: "T_Offices",
                column: "IdPerson");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Offices");

            migrationBuilder.DropTable(
                name: "T_Person");
        }
    }
}
