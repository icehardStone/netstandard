using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sample_use_in_memroy.Model;

namespace sample_use_in_memroy
{
    public class MemoryContext : DbContext
    {
        public DbSet<Person> Perons{set;get;}
        public MemoryContext(DbContextOptions options) : base(options){}
    }
}