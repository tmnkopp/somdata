﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

using SOMData;

namespace SOMData.Migrations
{
    [DbContext(typeof(SOMDbContext))]
    [Migration("20210123144619_ConsoleCommand")]
    partial class ConsoleCommand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SOMData.Models.CompilationWorkspace", b =>
                {
                    b.Property<int>("CompilationWorkspaceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Command");

                    b.Property<string>("CommandParams");

                    b.Property<string>("CompilationTitle");

                    b.Property<string>("CompileFrom");

                    b.Property<string>("CompileTo");

                    b.Property<string>("ParseLines");

                    b.Property<string>("ReplaceTerms");

                    b.Property<string>("WrapExpression");

                    b.HasKey("CompilationWorkspaceId");

                    b.ToTable("CompilationWorkspaces");
                });

            modelBuilder.Entity("SOMData.Models.ConsoleCommand", b =>
                {
                    b.Property<int>("ConsoleCommandID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommandAssembly");

                    b.Property<DateTime>("CommandDate");

                    b.Property<string>("CommandLine");

                    b.Property<string>("CommandType");

                    b.Property<string>("InstanceType");

                    b.HasKey("ConsoleCommandID");

                    b.ToTable("ConsoleCommands");
                });
#pragma warning restore 612, 618
        }
    }
}