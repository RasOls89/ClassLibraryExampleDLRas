using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibraryExampleDLRas
{
    public class Context : DbContext
    {
        public Context(string connectionString) : base(GetOptions(connectionString))
        {
            
        }


        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

    }
}
