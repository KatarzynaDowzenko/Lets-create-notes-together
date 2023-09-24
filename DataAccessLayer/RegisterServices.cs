using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DataAccessLayer;

public static class RegisterServices
{
    public static void Register(HostBuilderContext hostBuilderContext, IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapper).Assembly);
        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseSqlServer(hostBuilderContext.Configuration["LetsCreateNotesTogether:SQLConnectionString"],
                o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
        });
    }
}