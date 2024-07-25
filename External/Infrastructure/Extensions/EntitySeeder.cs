using Domain.Common;
using Domain.LessonBoundaryModel;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace Infrastructure.Extensions;

public static class EntitySeeder
{
    public static ModelBuilder SeedEntity<T>(this ModelBuilder builder)
        where T : class
    {
        var entities = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (T)field.GetValue(null)!)
            .ToArray();

        builder.Entity<T>().HasData(entities);
        return builder;
    }

    public static ModelBuilder SeedEntity<T>(this ModelBuilder builder, Type type)
        where T : class
    {
        var entities = type.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (T)field.GetValue(null)!)
            .ToArray();

        builder.Entity<T>().HasData(entities);
        return builder;
    }

    public static ModelBuilder SeedUnitOwnsMany(this ModelBuilder builder, Type type)
    {
        var entities = type.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (Source)field.GetValue(null)!)
            .ToArray();

        builder.Entity<Unit>().OwnsMany(x => x.Sources).HasData(entities);
        return builder;
    }

    public static ModelBuilder SeedUnitTaskOwnsMany(this ModelBuilder builder, Type type)
    {
        var entities = type.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (UnitTaskSource)field.GetValue(null)!)
            .ToArray();

        builder.Entity<UnitTask>().OwnsMany(x => x.Sources).HasData(entities);
        return builder;
    }
}
