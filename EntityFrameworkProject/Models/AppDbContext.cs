﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkProject.Models {
    public class AppDbContext : DbContext {


        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr =
                "server=localhost\\sqlexpress;database=AppEfDb;trusted_connection=true;";
            builder.UseLazyLoadingProxies();
            builder.UseSqlServer(connStr);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
 