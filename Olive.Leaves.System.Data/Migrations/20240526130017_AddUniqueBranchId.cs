using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olive.Leaves.System.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueBranchId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "LeaveStatuses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkingHoursInfo_BranchId",
                table: "WorkingHoursInfo",
                column: "BranchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypes_BranchId_Name",
                table: "LeaveTypes",
                columns: new[] { "BranchId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveStatuses_BranchId_Name",
                table: "LeaveStatuses",
                columns: new[] { "BranchId", "Name" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkingHoursInfo_BranchId",
                table: "WorkingHoursInfo");

            migrationBuilder.DropIndex(
                name: "IX_LeaveTypes_BranchId_Name",
                table: "LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_LeaveStatuses_BranchId_Name",
                table: "LeaveStatuses");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "LeaveStatuses");
        }
    }
}
