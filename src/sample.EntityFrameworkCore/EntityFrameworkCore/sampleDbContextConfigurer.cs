using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace sample.EntityFrameworkCore
{
    public static class sampleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<sampleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<sampleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
