using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hobinhan.Models;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<hobinhan.Models.Category> Category { get; set; }

        public DbSet<hobinhan.Models.Comment> Comment { get; set; }

        public DbSet<hobinhan.Models.News> News { get; set; }
    }
