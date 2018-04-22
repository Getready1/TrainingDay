using DataModels;
using EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingDayWeb
{
    public static class SeedDatabase
    {
        static AppDataContext context;
        public static void Initialize(IServiceProvider services)
        {
            context = services.GetRequiredService<AppDataContext>();
            if (!context.DifficultyLevel.Any())
            {
                context.DifficultyLevel.AddRange(new List<Difficulty>
                {
                    new Difficulty{Name = "Easy"},
                    new Difficulty{Name = "EasMedium"},
                    new Difficulty{Name = "Hard"},
                    new Difficulty{Name = "Insane"}
                });
                context.SaveChanges();
            }
            if (!context.MuscleCategories.Any())
            {
                context.MuscleCategories.AddRange(GetMuscleCategories());
                context.SaveChanges();
            }
            if (!context.MuscleGroups.Any())
            {
                context.MuscleGroups.AddRange(GetMuscleGroups());
                context.SaveChanges();
            }
            if (!context.Trainings.Any())
            {
                context.Trainings.AddRange(GetTrainings());
                context.SaveChanges();
            }
            if (!context.TrainingMuscleCategories.Any())
            {
                context.TrainingMuscleCategories.AddRange(GetTrainingMuscleCategories());
                context.SaveChanges();
            }
            if (!context.MetricTypes.Any())
            {
                context.MetricTypes.AddRange(GetMetricTypes());
                context.SaveChanges();
            }
            if (!context.ExerciseTemplates.Any())
            {
                context.ExerciseTemplates.AddRange(GetExerciseTemplates());
                context.SaveChanges();
            }
            if (!context.ExerciseTemplateCoreMuscleGroups.Any())
            {
                context.ExerciseTemplateCoreMuscleGroups.AddRange(GetExerciseTemplateCoreMuscleGroups());
                context.SaveChanges();
            }
            if (!context.ExerciseTemplateSuppMuscleGroups.Any())
            {
                context.ExerciseTemplateSuppMuscleGroups.AddRange(GetExerciseTemplateSupMuscleGroups());
                context.SaveChanges();
            }
            if (!context.ExerciseTemplateMetricTypes.Any())
            {
                context.ExerciseTemplateMetricTypes.AddRange(GetExerciseTemplateMetricTypes());
                context.SaveChanges();
            }
            if (!context.Exercises.Any())
            {
                context.Exercises.AddRange(GetExercises());
                context.SaveChanges();
            }
            if (!context.Sets.Any())
            {
                context.Sets.AddRange(GetSets());
                context.SaveChanges();
            }
            if (!context.Metrics.Any())
            {
                context.Metrics.AddRange(GetMetrics());
                context.SaveChanges();
            }
        }

        static List<MetricType> GetMetricTypes()
        {
            return new List<MetricType>
            {
                new MetricType
                {
                    Name = "Weight"
                },
                new MetricType
                {
                    Name = "Quantity"
                },
                new MetricType
                {
                    Name = "Height"
                }
            };
        }

        static List<MuscleCategory> GetMuscleCategories()
        {
            return new List<MuscleCategory>
            {
                new MuscleCategory
                {
                    Name = "Back"
                },
                new MuscleCategory
                {
                    Name = "Chest"
                },
                new MuscleCategory
                {
                    Name = "Shoulders"
                },
                new MuscleCategory
                {
                    Name = "Biceps"
                },
                new MuscleCategory
                {
                    Name = "Legs"
                },
                new MuscleCategory
                {
                    Name = "Triceps"
                }
            };
        }

        static List<MuscleGroup> GetMuscleGroups()
        {
            var categories = context.MuscleCategories.Select(x => x.MuscleCategoryId);

            return new List<MuscleGroup>
            {
                new MuscleGroup
                {
                    Name = "Quadriceps",
                    MuscleCategoryId =  categories.Where(x => x == 5).First()
                },
                new MuscleGroup
                {
                    Name = "Biceps",
                    MuscleCategoryId =  categories.Where(x => x == 4).First()
                },
                new MuscleGroup
                {
                    Name = "Triceps",
                    MuscleCategoryId =  categories.Where(x => x == 6).First()
                },
                new MuscleGroup
                {
                    Name = "Upper Chest",
                    MuscleCategoryId =  categories.Where(x => x == 2).First()
                },
                new MuscleGroup
                {
                    Name = "Lower Chest",
                    MuscleCategoryId =  categories.Where(x => x == 2).First()
                }
            };
        }

        static List<ExerciseTemplate> GetExerciseTemplates()
        {
            return new List<ExerciseTemplate>
            {
                new ExerciseTemplate
                {
                    Name = "The Bench Press",
                    Description = "Very Good Exercise"
                },
                new ExerciseTemplate
                {
                    Name = "Squats",
                    Description = "Very Good Exercise"
                }
            };
        }

        static List<ExerciseTemplateCoreMuscleGroups> GetExerciseTemplateCoreMuscleGroups()
        {
            var templates = context.ExerciseTemplates.Select(x => x.ExerciseTemplateId);
            var muscleGroups = context.MuscleCategories.Select(x => x.MuscleCategoryId);

            return new List<ExerciseTemplateCoreMuscleGroups>
            {
                new ExerciseTemplateCoreMuscleGroups
                {
                    ExerciseTemplateId = templates.Where(id => id == 1).First(),
                    MuscleGroupId = muscleGroups.Where(id => id == 3).First()
                },
                new ExerciseTemplateCoreMuscleGroups
                {
                    ExerciseTemplateId = templates.Where(id => id == 2).First(),
                    MuscleGroupId = muscleGroups.Where(id => id == 1).First()
                }
            };
        }

        static List<ExerciseTemplateSuppMuscleGroups> GetExerciseTemplateSupMuscleGroups()
        {
            var templates = context.ExerciseTemplates.Select(x => x.ExerciseTemplateId);
            var muscleGroups = context.MuscleCategories.Select(x => x.MuscleCategoryId);

            return new List<ExerciseTemplateSuppMuscleGroups>
            {
                new ExerciseTemplateSuppMuscleGroups
                {
                    ExerciseTemplateId = templates.Where(id => id == 1).First(),
                    MuscleGroupId = muscleGroups.Where(id => id == 5).First()
                },
                new ExerciseTemplateSuppMuscleGroups
                {
                    ExerciseTemplateId = templates.Where(id => id == 2).First(),
                    MuscleGroupId = muscleGroups.Where(id => id == 1).First()
                },
            };
        }

        static List<ExerciseTemplateMetricType> GetExerciseTemplateMetricTypes()
        {
            var exerciseTemplateIds = context.ExerciseTemplates.Select(x => x.ExerciseTemplateId);
            var metricTypeIds = context.MetricTypes.Select(x => x.MetricTypeId);

            return new List<ExerciseTemplateMetricType>
            {
                new ExerciseTemplateMetricType
                {
                    ExerciseTemplateId = exerciseTemplateIds.Where(id => id == 1).First(),
                    MetricTypeId = metricTypeIds.Where(id => id == 1).First()
                },
                new ExerciseTemplateMetricType
                {
                    ExerciseTemplateId = exerciseTemplateIds.Where(id => id == 1).First(),
                    MetricTypeId = metricTypeIds.Where(id => id == 2).First()
                },
                new ExerciseTemplateMetricType
                {
                    ExerciseTemplateId = exerciseTemplateIds.Where(id => id == 2).First(),
                    MetricTypeId = metricTypeIds.Where(id => id == 1).First()
                },
                new ExerciseTemplateMetricType
                {
                    ExerciseTemplateId = exerciseTemplateIds.Where(id => id == 2).First(),
                    MetricTypeId = metricTypeIds.Where(id => id == 2).First()
                }
            };
        }

        static List<Exercise> GetExercises()
        {
            var exerciseTemplates = context.ExerciseTemplates.Select(x => x.ExerciseTemplateId);
            var trainings = context.Trainings.Select(x => x.TrainingId);

            return new List<Exercise>
                {
                    new Exercise
                    {
                        Name = "Monday Bench Press",
                        ExerciseTemplateId = exerciseTemplates.Where(id => id == 1).First(),
                        TrainingId = trainings.Where(id => id == 1).First()
                    },
                    new Exercise
                    {
                        Name = "Wednesday Squats",
                        ExerciseTemplateId = exerciseTemplates.Where(id => id == 2).First(),
                        TrainingId = trainings.Where(id => id == 2).First(),
                        
                    }
                };
            }

        static List<Training> GetTrainings()
        {
            var muscleCategories = context.MuscleCategories.Select(x => x.MuscleCategoryId);

            return new List<Training>
                {
                    new Training
                    {
                        Name = "Monday Training 1",
                        Comment = "Just started. First training of the year.",
                        ModifiedDate = DateTime.Now,
                        CreationDate = DateTime.Now
                    },
                    new Training
                    {
                        Name = "Wednesday Training 1",
                        Comment = "Planning to train hard.",
                        ModifiedDate = DateTime.Now,
                        CreationDate = DateTime.Now
                    }
                };
        }

        static List<TrainingMuscleCategories> GetTrainingMuscleCategories()
        {
            var muscleCategories = context.MuscleCategories.Select(x => x.MuscleCategoryId);
            var trainings = context.Trainings.Select(x => x.TrainingId);

            return new List<TrainingMuscleCategories>
            {
                new TrainingMuscleCategories
                {
                    TrainingId = trainings.Where(id => id == 1).First(),
                    MuscleCategoryId = muscleCategories.Where(id => id == 2).First()
                },
                new TrainingMuscleCategories
                {
                    TrainingId = trainings.Where(id => id == 1).First(),
                    MuscleCategoryId = muscleCategories.Where(id => id == 4).First()
                },
                new TrainingMuscleCategories
                {
                    TrainingId = trainings.Where(id => id == 2).First(),
                    MuscleCategoryId = muscleCategories.Where(id => id == 5).First()
                },
                new TrainingMuscleCategories
                {
                    TrainingId = trainings.Where(id => id == 2).First(),
                    MuscleCategoryId = muscleCategories.Where(id => id == 3).First()
                }
            };
        }

        static List<Set> GetSets()
        {
            var difficulties = context.DifficultyLevel.ToList();
            var exercises = context.Exercises.Select(x => x.ExerciseId);

            return new List<Set>
            {
                new Set
                {
                    Difficulty = difficulties.Where(x => x.DifficultyId == 2).First(),
                    ExerciseId = exercises.Where(id => id == 1).First()
                },
                new Set
                {
                    Difficulty = difficulties.Where(x => x.DifficultyId == 2).First(),
                    ExerciseId = exercises.Where(id => id == 1).First()
                },
                new Set
                {
                    Difficulty = difficulties.Where(x => x.DifficultyId == 2).First(),
                    ExerciseId = exercises.Where(id => id == 1).First()
                },
                new Set
                {
                    Difficulty = difficulties.Where(x => x.DifficultyId == 3).First(),
                    ExerciseId = exercises.Where(id => id == 2).First()
                },
                new Set
                {
                    Difficulty = difficulties.Where(x => x.DifficultyId == 3).First(),
                    ExerciseId = exercises.Where(id => id == 2).First()
                },
                new Set
                {
                    Difficulty = difficulties.Where(x => x.DifficultyId == 4).First(),
                    ExerciseId = exercises.Where(id => id == 2).First()
                }
            };
        }

        static List<Metric> GetMetrics()
        {
            var sets = context.Sets.Select(x => x.SetId);
            var metricTypes = context.MetricTypes.Select(x => x.MetricTypeId);

            return new List<Metric>
            {
                new Metric
                {
                    SetId = sets.Where(id => id == 1).First(),
                    MetricTypeId = metricTypes.Where(id => id == 1).First(),
                    MetricValue = 75,
                    Name = "Bench Weight"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 1).First(),
                    MetricTypeId = metricTypes.Where(id => id == 2).First(),
                    MetricValue = 6,
                    Name = "Quantity"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 2).First(),
                    MetricTypeId = metricTypes.Where(id => id == 1).First(),
                    MetricValue = 75,
                    Name = "Bench Weight"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 2).First(),
                    MetricTypeId = metricTypes.Where(id => id == 2).First(),
                    MetricValue = 5,
                    Name = "Quantity"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 3).First(),
                    MetricTypeId = metricTypes.Where(id => id == 1).First(),
                    MetricValue = 75,
                    Name = "Bench Weight"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 3).First(),
                    MetricTypeId = metricTypes.Where(id => id == 2).First(),
                    MetricValue = 4,
                    Name = "Quantity"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 4).First(),
                    MetricTypeId = metricTypes.Where(id => id == 1).First(),
                    MetricValue = 90,
                    Name = "Squats Weight"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 4).First(),
                    MetricTypeId = metricTypes.Where(id => id == 2).First(),
                    MetricValue = 7,
                    Name = "Quantity"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 5).First(),
                    MetricTypeId = metricTypes.Where(id => id == 1).First(),
                    MetricValue = 90,
                    Name = "Squats Weight"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 5).First(),
                    MetricTypeId = metricTypes.Where(id => id == 2).First(),
                    MetricValue = 6,
                    Name = "Quantity"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 6).First(),
                    MetricTypeId = metricTypes.Where(id => id == 1).First(),
                    MetricValue = 90,
                    Name = "Squats Weight"
                },
                new Metric
                {
                    SetId = sets.Where(id => id == 6).First(),
                    MetricTypeId = metricTypes.Where(id => id == 2).First(),
                    MetricValue = 4,
                    Name = "Quantity"
                }
            };
        } 
    }
}
