using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DynamicCv.DataContext.CvDbContext;

namespace DynamicCv.Web.Migrations
{
    [DbContext(typeof(CvContext))]
    [Migration("20170630085935_Added required to project and entires")]
    partial class Addedrequiredtoprojectandentires
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.CvUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Role");

                    b.Property<string>("UserLogin");

                    b.HasKey("Id");

                    b.ToTable("CvUser");
                });

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentText");

                    b.Property<DateTime>("From");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("To");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Entrys");
                });

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EntryId");

                    b.Property<DateTime>("From");

                    b.Property<string>("ProjectDescription");

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.Property<DateTime>("To");

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

            modelBuilder.Entity("DynamicCv.Entities.CvEntities.Entry", b =>
                {
                    b.HasOne("DynamicCv.Entities.CvEntities.CvUser", "User")
                        .WithMany("Entires")
                        .HasForeignKey("UserId");
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
