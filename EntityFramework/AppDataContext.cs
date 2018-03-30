using DataModels;
using EntityFramework.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        { }

        public DbSet<Training> Trainings { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<MuscleCategory> MuscleCategories { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<Difficulty> DifficultyLevel { get; set; }
        public DbSet<ExerciseTemplate> ExerciseTemplates { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<MetricType> MetricTypes { get; set; }
        public DbSet<MetricValue> MetricValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrainingEntityConfig());
            modelBuilder.ApplyConfiguration(new ExerciseEntityConfig());
            modelBuilder.ApplyConfiguration(new SetEntityConfig());
            modelBuilder.ApplyConfiguration(new MuscleCategoryEntityConfig());
            modelBuilder.ApplyConfiguration(new MuscleGroupEntityConfig());
            modelBuilder.ApplyConfiguration(new ExerciseCoreMuscleGroupEntityConfig());
            modelBuilder.ApplyConfiguration(new ExerciseSuppMuscleGroupEntityConfig());
            modelBuilder.ApplyConfiguration(new TrainingCategoriesEntityConfig());
            modelBuilder.ApplyConfiguration(new ExerciseTemplateSuppMuscleGroupConfig());
            modelBuilder.ApplyConfiguration(new ExerciseTemplateCoreMuscleGroupConfig());
            modelBuilder.ApplyConfiguration(new ExerciseTemplateConfig());
            modelBuilder.ApplyConfiguration(new MetricValueConfig());
        }
    }
}
