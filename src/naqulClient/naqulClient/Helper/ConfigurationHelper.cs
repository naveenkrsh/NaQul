using Microsoft.Extensions.Configuration;

namespace naqulClient.Helper
{
    public class ConfigurationHelper
    {
        private readonly IConfiguration configuration;

        public ConfigurationHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetNaQulBackendEndpoint()
        {
            return configuration.GetSection("naqulBackendEndpoint").Value;
        }

        public string GetClientDbConnectionString()
        {
            return GetDbConnectionSection().GetSection("DefaultConnection").Value;
        }

        public string GetNaqulDbConnectionString()
        {
            return GetDbConnectionSection().GetSection("NaqulConnection").Value;
        }

        public IConfigurationSection GetDbConnectionSection()
        {
            return configuration.GetSection("ConnectionStrings");
        }
    }
}