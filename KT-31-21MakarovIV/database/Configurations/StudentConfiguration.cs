﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KT_31_21MakarovIV.Models;
using KT_31_21MakarovIV.database.Helpers;
namespace KT_31_21MakarovIV.database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Students>
    {
        private const string TableName = "cd_student";
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder
           .HasKey(p => p.StudentId)
           .HasName($"pk_{TableName}_student_id");

            builder.Property(p => p.StudentId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.StudentId)
                .HasColumnName("student_id")
                .HasComment("Идентификатор записи студента");

            builder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("c_student_firstname")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Имя студента");

            builder
                .Property(p => p.LastName)
                .IsRequired()
                .HasColumnName("c_student_lastname")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Фамилия студента");

            builder
                .Property(p => p.MiddleName)
                .IsRequired()
                .HasColumnName("c_student_middlename")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Отчество студента");

            builder
                .Property(p => p.GroupId)
                .IsRequired()
                .HasColumnName("f_group_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("Идентификатор группы");

            builder
               .ToTable(TableName)
               .HasOne(p => p.Group)
               .WithMany()
               .HasForeignKey(p => p.GroupId)
               .HasConstraintName("fk_f_group_id")
               .OnDelete(DeleteBehavior.Cascade);


            builder.ToTable(TableName)
                .HasIndex(p => p.GroupId, $"idx_{TableName}_fk_f_group_id");

            builder.Navigation(p => p.Group)
                .AutoInclude();
        }
    }
}
