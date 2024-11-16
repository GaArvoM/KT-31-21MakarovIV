using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KT_31_21MakarovIV.Migrations
{
    /// <inheritdoc />
    public partial class someCH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idx_cd_student_fk_f_group_id",
                table: "cd_student");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "cd_student");

            migrationBuilder.RenameIndex(
                name: "IX_cd_student_f_group_id",
                table: "cd_student",
                newName: "idx_cd_student_fk_f_group_id");

            migrationBuilder.AlterColumn<int>(
                name: "f_group_id",
                table: "cd_student",
                type: "int",
                nullable: false,
                comment: "Идентификатор группы",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100,
                oldComment: "Номер группы");

            migrationBuilder.AddColumn<string>(
                name: "c_student_firstname",
                table: "cd_student",
                type: "nvarchar(200)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                comment: "Имя студента");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "c_student_firstname",
                table: "cd_student");

            migrationBuilder.RenameIndex(
                name: "idx_cd_student_fk_f_group_id",
                table: "cd_student",
                newName: "IX_cd_student_f_group_id");

            migrationBuilder.AlterColumn<int>(
                name: "f_group_id",
                table: "cd_student",
                type: "int",
                maxLength: 100,
                nullable: false,
                comment: "Номер группы",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Идентификатор группы");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "cd_student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "idx_cd_student_fk_f_group_id",
                table: "cd_student",
                column: "GroupId");
        }
    }
}
