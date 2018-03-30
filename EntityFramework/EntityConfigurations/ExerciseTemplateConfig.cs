﻿using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class ExerciseTemplateConfig : IEntityTypeConfiguration<ExerciseTemplate>
    {
        public void Configure(EntityTypeBuilder<ExerciseTemplate> builder)
        {
            builder.HasKey(m => m.ExerciseTemplateId);
            builder.Property(m => m.ExerciseTemplateId).ValueGeneratedOnAdd();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(20);
            builder.OwnsOne(m => m.Metrics);
        }
    }
}