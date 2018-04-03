using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EntityFramework.Migrations
{
    public partial class RelationBetweenExerciseAndTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseTemplateId",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseTemplateId",
                table: "Exercises",
                column: "ExerciseTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseTemplates_ExerciseTemplateId",
                table: "Exercises",
                column: "ExerciseTemplateId",
                principalTable: "ExerciseTemplates",
                principalColumn: "ExerciseTemplateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseTemplates_ExerciseTemplateId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_ExerciseTemplateId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseTemplateId",
                table: "Exercises");
        }
    }
}
