using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class EditRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1",
                columns: new[] { "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "ADMINCRM", "SOME_FIXED_GUID_STRING_1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aaaaaaa2-aaaa-aaaa-aaaa-aaaaaaaaaaa2", 0, "12cd6c9a-ee34-4b78-a000-919d741f2854", "salesrep@crm.com", true, false, null, "Sales Rep User", "SALESREP@CRM.COM", "SALESREPCRM", "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==", null, false, 0, "SOME_FIXED_GUID_STRING_2", false, "salesRepCRM" },
                    { "aaaaaaa3-aaaa-aaaa-aaaa-aaaaaaaaaaa3", 0, "22cd6c9a-ee34-4b78-a000-919d741f2854", "salesmanager@crm.com", true, false, null, "Sales Manager User", "SALESMANAGER@CRM.COM", "SALESMANAGERCRM", "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==", null, false, 1, "SOME_FIXED_GUID_STRING_3", false, "salesManagerCRM" },
                    { "aaaaaaa4-aaaa-aaaa-aaaa-aaaaaaaaaaa4", 0, "32cd6c9a-ee34-4b78-a000-919d741f2854", "support@crm.com", true, false, null, "Support Agent User", "SUPPORT@CRM.COM", "SUPPORTAGENTCRM", "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==", null, false, 2, "SOME_FIXED_GUID_STRING_4", false, "supportAgentCRM" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaaaaaa2-aaaa-aaaa-aaaa-aaaaaaaaaaa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaaaaaa3-aaaa-aaaa-aaaa-aaaaaaaaaaa3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaaaaaa4-aaaa-aaaa-aaaa-aaaaaaaaaaa4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1",
                columns: new[] { "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "ADMIN@CRM.COM", "SOME_FIXED_GUID_STRING" });
        }
    }
}
