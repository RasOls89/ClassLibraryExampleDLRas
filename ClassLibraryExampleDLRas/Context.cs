using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibraryExampleDLRas
{
    public class Context : DbContext
    {

            private readonly string _connectionString;

            public Context(string connectionString)
            {
                _connectionString = connectionString;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }


    }
}
