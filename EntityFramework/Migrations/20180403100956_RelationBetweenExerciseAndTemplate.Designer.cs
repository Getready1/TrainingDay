﻿// <auto-generated />
using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EntityFramework.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20180403100956_RelationBetweenExerciseAndTemplate")]
    partial class RelationBetweenExerciseAndTemplate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataModels.Difficulty", b =>
                {
                    b.Property<int>("DifficultyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DifficultyId");

                    b.ToTable("DifficultyLevel");
                });

            modelBuilder.Entity("DataModels.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExerciseTemplateId");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("TrainingId");

                    b.HasKey("ExerciseId");

                    b.HasIndex("ExerciseTemplateId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("DataModels.ExerciseCoreMuscleGroup", b =>
                {
                    b.Property<int>("ExcersiceId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("ExcersiceId", "MuscleGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseCoreMuscleGroup");
                });

            modelBuilder.Entity("DataModels.ExerciseSuppMuscleGroup", b =>
                {
                    b.Property<int>("ExcersiceId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("ExcersiceId", "MuscleGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseSuppMuscleGroup");
                });

            modelBuilder.Entity("DataModels.ExerciseTemplate", b =>
                {
                    b.Property<int>("ExerciseTemplateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ExerciseTemplateId");

                    b.ToTable("ExerciseTemplates");
                });

            modelBuilder.Entity("DataModels.ExerciseTemplateCoreMuscleGroups", b =>
                {
                    b.Property<int>("ExerciseTemplateId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("ExerciseTemplateId", "MuscleGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseTemplateCoreMuscleGroups");
                });

            modelBuilder.Entity("DataModels.ExerciseTemplateSuppMuscleGroups", b =>
                {
                    b.Property<int>("ExerciseTemplateId");

                    b.Property<int>("MuscleGroupId");

                    b.HasKey("ExerciseTemplateId", "MuscleGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("ExerciseTemplateSuppMuscleGroups");
                });

            modelBuilder.Entity("DataModels.Metric", b =>
                {
                    b.Property<int>("MetricId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MetricTypeId");

                    b.Property<int?>("MetricValueId");

                    b.Property<string>("Name");

                    b.HasKey("MetricId");

                    b.HasIndex("MetricTypeId");

                    b.ToTable("Metrics");
                });

            modelBuilder.Entity("DataModels.MetricExerciseTemplates", b =>
                {
                    b.Property<int>("ExerciseTemplateId");

                    b.Property<int>("MetricId");

                    b.HasKey("ExerciseTemplateId", "MetricId");

                    b.HasIndex("MetricId");

                    b.ToTable("MetricExerciseTemplates");
                });

            modelBuilder.Entity("DataModels.MetricMetricValues", b =>
                {
                    b.Property<int>("MetricId");

                    b.Property<int>("MetricValueId");

                    b.HasKey("MetricId", "MetricValueId");

                    b.HasIndex("MetricValueId");

                    b.ToTable("MetricMetricValues");
                });

            modelBuilder.Entity("DataModels.MetricType", b =>
                {
                    b.Property<int>("MetricTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("MetricTypeId");

                    b.ToTable("MetricTypes");
                });

            modelBuilder.Entity("DataModels.MetricValue", b =>
                {
                    b.Property<int>("MetricValueId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MetricId");

                    b.Property<int?>("SetId");

                    b.Property<double>("Value");

                    b.HasKey("MetricValueId");

                    b.HasIndex("SetId");

                    b.ToTable("MetricValues");
                });

            modelBuilder.Entity("DataModels.MuscleCategory", b =>
                {
                    b.Property<int>("MuscleCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("MuscleCategoryId");

                    b.ToTable("MuscleCategories");
                });

            modelBuilder.Entity("DataModels.MuscleGroup", b =>
                {
                    b.Property<int>("MuscleGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MuscleCategoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("MuscleGroupId");

                    b.HasIndex("MuscleCategoryId");

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("DataModels.Set", b =>
                {
                    b.Property<int>("SetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DifficultyId");

                    b.Property<int?>("ExerciseId");

                    b.Property<int>("ExericeId");

                    b.HasKey("SetId");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("DataModels.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("TrainingId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("DataModels.TrainingMuscleCategories", b =>
                {
                    b.Property<int>("MuscleCategoryId");

                    b.Property<int>("TrainingId");

                    b.HasKey("MuscleCategoryId", "TrainingId");

                    b.HasIndex("TrainingId");

                    b.ToTable("TrainingMuscleCategories");
                });

            modelBuilder.Entity("DataModels.Exercise", b =>
                {
                    b.HasOne("DataModels.ExerciseTemplate", "ExerciseTemplate")
                        .WithMany("Exercises")
                        .HasForeignKey("ExerciseTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.Training", "Training")
                        .WithMany("Exercises")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.ExerciseCoreMuscleGroup", b =>
                {
                    b.HasOne("DataModels.Exercise", "Exercise")
                        .WithMany("CoreMuscleGroups")
                        .HasForeignKey("ExcersiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.MuscleGroup", "MuscleGroup")
                        .WithMany("CoreExcercises")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.ExerciseSuppMuscleGroup", b =>
                {
                    b.HasOne("DataModels.Exercise", "Exercise")
                        .WithMany("SupplimentaryMuscleGroups")
                        .HasForeignKey("ExcersiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.MuscleGroup", "MuscleGroup")
                        .WithMany("SupExcercises")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.ExerciseTemplateCoreMuscleGroups", b =>
                {
                    b.HasOne("DataModels.ExerciseTemplate", "ExerciseTemplate")
                        .WithMany("CoreMuscleGroups")
                        .HasForeignKey("ExerciseTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.MuscleGroup", "MuscleGroup")
                        .WithMany("CoreExcerciseTemplates")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.ExerciseTemplateSuppMuscleGroups", b =>
                {
                    b.HasOne("DataModels.ExerciseTemplate", "ExerciseTemplate")
                        .WithMany("SupplimentaryMuscleGroups")
                        .HasForeignKey("ExerciseTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.MuscleGroup", "MuscleGroup")
                        .WithMany("SupExcercisesTemplates")
                        .HasForeignKey("MuscleGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.Metric", b =>
                {
                    b.HasOne("DataModels.MetricType", "MetricType")
                        .WithMany("Metrics")
                        .HasForeignKey("MetricTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.MetricExerciseTemplates", b =>
                {
                    b.HasOne("DataModels.ExerciseTemplate", "ExerciseTemplate")
                        .WithMany("Metrics")
                        .HasForeignKey("ExerciseTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.Metric", "Metric")
                        .WithMany("ExerciseTemplates")
                        .HasForeignKey("MetricId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.MetricMetricValues", b =>
                {
                    b.HasOne("DataModels.Metric", "Metric")
                        .WithMany("MetricValue")
                        .HasForeignKey("MetricId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.MetricValue", "MetricValue")
                        .WithMany("Metrics")
                        .HasForeignKey("MetricValueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.MetricValue", b =>
                {
                    b.HasOne("DataModels.Set")
                        .WithMany("MetricValues")
                        .HasForeignKey("SetId");
                });

            modelBuilder.Entity("DataModels.MuscleGroup", b =>
                {
                    b.HasOne("DataModels.MuscleCategory", "MuscleCategory")
                        .WithMany("MuscleGroups")
                        .HasForeignKey("MuscleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataModels.Set", b =>
                {
                    b.HasOne("DataModels.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId");

                    b.HasOne("DataModels.Exercise", "Exercise")
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseId");

                    b.OwnsOne("DataModels.ComplexModels.Metrics", "Metrics", b1 =>
                        {
                            b1.Property<int>("SetId");

                            b1.Property<double>("Distance");

                            b1.Property<double>("Duration");

                            b1.Property<int>("Repetitions");

                            b1.Property<double>("Weight");

                            b1.ToTable("Sets");

                            b1.HasOne("DataModels.Set")
                                .WithOne("Metrics")
                                .HasForeignKey("DataModels.ComplexModels.Metrics", "SetId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("DataModels.TrainingMuscleCategories", b =>
                {
                    b.HasOne("DataModels.MuscleCategory", "MuscleCategory")
                        .WithMany("Trainings")
                        .HasForeignKey("MuscleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataModels.Training", "Training")
                        .WithMany("MuscleCategories")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}