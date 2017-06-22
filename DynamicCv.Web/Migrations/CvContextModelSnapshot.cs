using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DynamicCv.DataContext.CvDbContext;

namespace DynamicCv.Web.Migrations
{
    [DbContext(typeof(CvContext))]
    partial class CvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EntryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentText");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Entrys");
                });

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EntryId");

                    b.Property<string>("ProjectDescription");

                    b.Property<string>("ProjectName");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Area", b =>
                {
                    b.HasOne("DynamicCv.Entities.CvEntities.Entry", "Entry")
                        .WithMany("Areas")
                        .HasForeignKey("EntryId");
                });

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Project", b =>
                {
                    b.HasOne("DynamicCv.Entities.CvEntities.Entry", "Entry")
                        .WithMany("Projects")
                        .HasForeignKey("EntryId");
                });
        }
    }
}
