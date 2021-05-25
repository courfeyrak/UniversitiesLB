using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestionsSchool.Migrations
{
    public partial class ChangeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelQuestSchool_Question_QuestionId",
                table: "RelQuestSchool");

            migrationBuilder.DropForeignKey(
                name: "FK_RelQuestSchool_School_SchoolId",
                table: "RelQuestSchool");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "RelQuestSchool",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "RelQuestSchool",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RelQuestSchool_Question_QuestionId",
                table: "RelQuestSchool",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelQuestSchool_School_SchoolId",
                table: "RelQuestSchool",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelQuestSchool_Question_QuestionId",
                table: "RelQuestSchool");

            migrationBuilder.DropForeignKey(
                name: "FK_RelQuestSchool_School_SchoolId",
                table: "RelQuestSchool");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "RelQuestSchool",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "RelQuestSchool",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_RelQuestSchool_Question_QuestionId",
                table: "RelQuestSchool",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelQuestSchool_School_SchoolId",
                table: "RelQuestSchool",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
