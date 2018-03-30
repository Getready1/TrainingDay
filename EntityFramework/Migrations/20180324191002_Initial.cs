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
                name: "DifficultyLevel",
                columns: table => new
                {
                    DifficultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevel", x => x.DifficultyId);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTemplates",
                columns: table => new
                {
                    ExerciseTemplateId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Metrics_Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTemplates", x => x.ExerciseTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "MetricTypes",
                columns: table => new
                {
                    MetricTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetricTypes", x => x.MetricTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MuscleCategories",
                columns: table => new
                {
                    MuscleCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleCategories", x => x.MuscleCategoryId);
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
                name: "MuscleGroups",
                columns: table => new
                {
                    MuscleGroupId = table.Column<Guid>(nullable: false),
                    MuscleCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.MuscleGroupId);
                    table.ForeignKey(
                        name: "FK_MuscleGroups_MuscleCategories_MuscleCategoryId",
                        column: x => x.MuscleCategoryId,
                        principalTable: "MuscleCategories",
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
                        name: "FK_TrainingMuscleCategories_MuscleCategories_MuscleCategoryId",
                        column: x => x.MuscleCategoryId,
                        principalTable: "MuscleCategories",
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
                name: "ExerciseTemplateCoreMuscleGroups",
                columns: table => new
                {
                    ExerciseTemplateId = table.Column<Guid>(nullable: false),
                    MuscleGroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTemplateCoreMuscleGroups", x => new { x.ExerciseTemplateId, x.MuscleGroupId });
                    table.ForeignKey(
                        name: "FK_ExerciseTemplateCoreMuscleGroups_ExerciseTemplates_ExerciseTemplateId",
                        column: x => x.ExerciseTemplateId,
                        principalTable: "ExerciseTemplates",
                        principalColumn: "ExerciseTemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTemplateCoreMuscleGroups_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
                        principalColumn: "MuscleGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTemplateSuppMuscleGroups",
                columns: table => new
                {
                    ExerciseTemplateId = table.Column<Guid>(nullable: false),
                    MuscleGroupId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTemplateSuppMuscleGroups", x => new { x.ExerciseTemplateId, x.MuscleGroupId });
                    table.ForeignKey(
                        name: "FK_ExerciseTemplateSuppMuscleGroups_ExerciseTemplates_ExerciseTemplateId",
                        column: x => x.ExerciseTemplateId,
                        principalTable: "ExerciseTemplates",
                        principalColumn: "ExerciseTemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTemplateSuppMuscleGroups_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
                        principalColumn: "MuscleGroupId",
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
                        name: "FK_ExerciseCoreMuscleGroup_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
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
                        name: "FK_ExerciseSuppMuscleGroup_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
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
                        name: "FK_Sets_DifficultyLevel_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "DifficultyLevel",
                        principalColumn: "DifficultyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sets_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MetricValues",
                columns: table => new
                {
                    MetricValueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetricId = table.Column<int>(nullable: false),
                    SetId = table.Column<Guid>(nullable: true),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetricValues", x => x.MetricValueId);
                    table.ForeignKey(
                        name: "FK_MetricValues_Sets_SetId",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "SetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Metrics",
                columns: table => new
                {
                    MetricId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExerciseTemplateId = table.Column<Guid>(nullable: false),
                    MetricTypeId = table.Column<int>(nullable: false),
                    MetricValueId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metrics", x => x.MetricId);
                    table.ForeignKey(
                        name: "FK_Metrics_ExerciseTemplates_ExerciseTemplateId",
                        column: x => x.ExerciseTemplateId,
                        principalTable: "ExerciseTemplates",
                        principalColumn: "ExerciseTemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Metrics_MetricTypes_MetricTypeId",
                        column: x => x.MetricTypeId,
                        principalTable: "MetricTypes",
                        principalColumn: "MetricTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Metrics_MetricValues_MetricValueId",
                        column: x => x.MetricValueId,
                        principalTable: "MetricValues",
                        principalColumn: "MetricValueId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_ExerciseTemplateCoreMuscleGroups_MuscleGroupId",
                table: "ExerciseTemplateCoreMuscleGroups",
                column: "MuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTemplateSuppMuscleGroups_MuscleGroupId",
                table: "ExerciseTemplateSuppMuscleGroups",
                column: "MuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_ExerciseTemplateId",
                table: "Metrics",
                column: "ExerciseTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_MetricTypeId",
                table: "Metrics",
                column: "MetricTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_MetricValueId",
                table: "Metrics",
                column: "MetricValueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MetricValues_SetId",
                table: "MetricValues",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_MuscleGroups_MuscleCategoryId",
                table: "MuscleGroups",
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
                name: "ExerciseTemplateCoreMuscleGroups");

            migrationBuilder.DropTable(
                name: "ExerciseTemplateSuppMuscleGroups");

            migrationBuilder.DropTable(
                name: "Metrics");

            migrationBuilder.DropTable(
                name: "TrainingMuscleCategories");

            migrationBuilder.DropTable(
                name: "MuscleGroups");

            migrationBuilder.DropTable(
                name: "ExerciseTemplates");

            migrationBuilder.DropTable(
                name: "MetricTypes");

            migrationBuilder.DropTable(
                name: "MetricValues");

            migrationBuilder.DropTable(
                name: "MuscleCategories");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "DifficultyLevel");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
