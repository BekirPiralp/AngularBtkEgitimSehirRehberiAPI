﻿using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Model;

namespace SehirRehberi.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        public DbSet<Value> Values { get; set; }
    }
}