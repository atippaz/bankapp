using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using banking_service.DB;
using banking_service.Repositories;

namespace banking_service
{
    public static class InjectClass
    {
        public static void DependencyInjection(IServiceCollection builder)
        {
            builder.AddDbContext<ContextDB>(option =>
            {
                var crmDbContext = new MySqlConnectionStringBuilder();
                crmDbContext.Server = "localhost";
                crmDbContext.Port = 3306;
                crmDbContext.Database = "banking";
                crmDbContext.UserID = "root";
                crmDbContext.Password = "Pan28060.";
                crmDbContext.Add("GuidFormat", "Binary16");
                var connectionString = crmDbContext.ConnectionString;
                option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            builder.AddScoped<TransectionRepository>();

        }
    }
}
