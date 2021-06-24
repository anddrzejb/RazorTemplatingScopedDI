using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Common
{
    public class AppState
    {
        private readonly IConfiguration _configuration;
        public int ConfigCount { get; set; }
        public string ManuallySetProperty { get; set; }

        public AppState(IConfiguration configuration)
        {
            _configuration = configuration;
            ConfigCount = configuration.GetChildren().Count();
        }
    }
}
