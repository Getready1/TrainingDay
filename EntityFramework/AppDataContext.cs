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
        public DbSet<MuscleCategory> MuscleCategory { get; set; }
        public DbSet<MuscleGroup> MuscleGroup { get; set; }
        public DbSet<Difficulty> Difficulty { get; set; }

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
        }
    }
}
