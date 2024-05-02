using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPFDataContext.NET.Migrations
{
    /// <inheritdoc />
    public partial class HotelReservationChangeToGuest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HotellKjede = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hotel__46023BDF13B164E0", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoom",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfBeds = table.Column<int>(type: "int", nullable: true),
                    SizeOfRoom = table.Column<int>(type: "int", nullable: true),
                    QualityOfRoom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Occupied = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HotelRoo__32863939F4289E21", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fornavn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Etternavn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Person__AA2FFBE597F6ADD6", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin__719FE488C3368116", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK__Admin__AdminId__68487DD7",
                        column: x => x.AdminId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Stilling = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__7AD04F11F18084B2", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK__Employee__Employ__656C112C",
                        column: x => x.EmployeeId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Guest__0C423C121AE80D67", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK__Guest__GuestId__628FA481",
                        column: x => x.GuestId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "HotelReservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HotelRes__B7EE5F245ED63343", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK__HotelRese__Guest__6EF57B66",
                        column: x => x.GuestId,
                        principalTable: "Guest",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__HotelRese__RoomI__6FE99F9F",
                        column: x => x.RoomId,
                        principalTable: "HotelRoom",
                        principalColumn: "RoomId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservation_GuestId",
                table: "HotelReservation",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReservation_RoomId",
                table: "HotelReservation",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "HotelReservation");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "HotelRoom");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
