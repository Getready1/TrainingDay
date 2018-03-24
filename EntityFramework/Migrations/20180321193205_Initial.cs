using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Difficulty",
                columns: table => new
                {
                    DifficultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulty", x => x.DifficultyId);
                });

            migrationBuilder.CreateTable(
                name: "MuscleCategory",
                columns: table => new
                {
                    MuscleCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleCategory", x => x.MuscleCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    TrainingId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.TrainingId);
                });

            migrationBuilder.CreateTable(
                name: "MuscleGroup",
                columns: table => new
                {
                    MuscleGroupId = table.Column<Guid>(nullable: false),
                    MuscleCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroup", x => x.MuscleGroupId);
                    table.ForeignKey(
                        name: "FK_MuscleGroup_MuscleCategory_MuscleCategoryId",
                        column: x => x.MuscleCategoryId,
                        principalTable: "MuscleCategory",
                        principalColumn: "MuscleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<Guid>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    TrainingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "TrainingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingMuscleCategories",
                columns: table => new
                {
                    MuscleCategoryId = table.Column<Guid>(nullable: false),
                    TrainingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingMuscleCategories", x => new { x.MuscleCategoryId, x.TrainingId });
                    table.ForeignKey(
                        name: "FK_TrainingMuscleCategories_MuscleCategory_MuscleCategoryId",
                        column: x => x.MuscleCategoryId,
                        principalTable: "MuscleCategory",
                        principalColumn: "MuscleCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingMuscleCategories_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "TrainingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseCoreMuscleGroup",
                columns: table => new
                {
                    ExcersiceId = table.Column<Guid>(nullable: false),
                    MuscleGroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCoreMuscleGroup", x => new { x.ExcersiceId, x.MuscleGroupId });
                    table.ForeignKey(
                        name: "FK_ExerciseCoreMuscleGroup_Exercises_ExcersiceId",
                        column: x => x.ExcersiceId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseCoreMuscleGroup_MuscleGroup_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroup",
                        principalColumn: "MuscleGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSuppMuscleGroup",
                columns: table => new
                {
                    ExcersiceId = table.Column<Guid>(nullable: false),
                    MuscleGroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSuppMuscleGroup", x => new { x.ExcersiceId, x.MuscleGroupId });
                    table.ForeignKey(
                        name: "FK_ExerciseSuppMuscleGroup_Exercises_ExcersiceId",
                        column: x => x.ExcersiceId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseSuppMuscleGroup_MuscleGroup_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroup",
                        principalColumn: "MuscleGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    SetId = table.Column<Guid>(nullable: false),
                    DifficultyId = table.Column<int>(nullable: true),
                    ExerciseId = table.Column<Guid>(nullable: true),
                    ExericeId = table.Column<Guid>(nullable: false),
                    Metrics_Distance = table.Column<double>(nullable: false),
                    Metrics_Duration = table.Column<double>(nullable: false),
                    Metrics_Repetitions = table.Column<int>(nullable: false),
                    Metrics_Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.SetId);
                    table.ForeignKey(
                        name: "FK_Sets_Difficulty_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulty",
                        principalColumn: "DifficultyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sets_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseCoreMuscleGroup_MuscleGroupId",
                table: "ExerciseCoreMuscleGroup",
                column: "MuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TrainingId",
                table: "Exercises",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSuppMuscleGroup_MuscleGroupId",
                table: "ExerciseSuppMuscleGroup",
                column: "MuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MuscleGroup_MuscleCategoryId",
                table: "MuscleGroup",
                column: "MuscleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_DifficultyId",
                table: "Sets",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_ExerciseId",
                table: "Sets",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingMuscleCategories_TrainingId",
                table: "TrainingMuscleCategories",
                column: "TrainingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseCoreMuscleGroup");

            migrationBuilder.DropTable(
                name: "ExerciseSuppMuscleGroup");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "TrainingMuscleCategories");

            migrationBuilder.DropTable(
                name: "MuscleGroup");

            migrationBuilder.DropTable(
                name: "Difficulty");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "MuscleCategory");

            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
