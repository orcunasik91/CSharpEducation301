using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEducation301.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsStatusPropForCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "Customers");
        }
    }
}
