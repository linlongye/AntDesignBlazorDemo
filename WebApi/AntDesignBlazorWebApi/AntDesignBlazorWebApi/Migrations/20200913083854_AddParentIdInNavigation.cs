using Microsoft.EntityFrameworkCore.Migrations;

namespace AntDesignBlazorWebApi.Migrations
{
    public partial class AddParentIdInNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "NavigationInfos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NavigationInfos_ParentId",
                table: "NavigationInfos",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_NavigationInfos_NavigationInfos_ParentId",
                table: "NavigationInfos",
                column: "ParentId",
                principalTable: "NavigationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NavigationInfos_NavigationInfos_ParentId",
                table: "NavigationInfos");

            migrationBuilder.DropIndex(
                name: "IX_NavigationInfos_ParentId",
                table: "NavigationInfos");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "NavigationInfos");
        }
    }
}
