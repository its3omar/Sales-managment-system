using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SalesMS.DAL.Context;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=.;Database=SalesMS_DB;Trusted_Connection=True;TrustServerCertificate=True"
        );

        return new AppDbContext(optionsBuilder.Options);
    }
}