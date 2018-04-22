using AutoMapper;
using DataModels;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace TrainingDayWeb.Extensions
{
    public static class Extensions
    {
        public static void ConfigureMappings(this IApplicationBuilder app)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Difficulty, DifficultyViewModel>();

                cfg.CreateMap<Training, TrainingViewModel>()
                .ForMember(x => x.MuscleCategories, y => y.MapFrom(z => z.MuscleCategories.Select(w => w.MuscleCategory)))
                .ForMember(v => v.Id, o => o.MapFrom(s => s.TrainingId))
                .ReverseMap();

                cfg.CreateMap<Exercise, ExerciseViewModel>()
                .ForMember(m => m.ExerciseId, o => o.MapFrom(z => z.ExerciseId));

                cfg.CreateMap<Metric, MetricViewModel>();

                cfg.CreateMap<Set, SetViewModel>();

                cfg.CreateMap<MuscleCategory, MuscleCategoryViewModel>().ForMember(m => m.MuscleCategoryId, o => o.MapFrom(s => s.MuscleCategoryId));

                cfg.CreateMap<MuscleGroup, MuscleGroupViewModel>();
            });
        }
    }
}
