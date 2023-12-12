using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BatDongSan.Shared.ServiceExtensions
{
    public class EnvironmentConfig
    {
        public const string ENVIRONMENT_VARIABLE_NAME = "Development";

        public MyEnvironment Environment { get; set; }
        public string RedisConnectionString { get; set; }

        // PostgreSQL
        public string PostgreSQLMainConnection { get; set; }

        public string PostgreEstatesConnection { get; set; }
        public string PostgreIdentityConnection { get; set; }
        public string PostgreListingsConnection { get; set; }
        public string PostgreClientsConnection { get; set; }
        public string PostgreContractsConnection { get; set; }

        //MySQL
        public string MySQLMainConnection { get; set; }
        public static EnvironmentConfig Current { get; set; }

        public static void LoadFromEnvironmentVariable()
        {
            var environment = System.Environment.GetEnvironmentVariable(ENVIRONMENT_VARIABLE_NAME);
            Enum.TryParse(typeof(MyEnvironment), environment, true, out var env);
            if (string.IsNullOrEmpty(environment) || env == null)
            {
                //throw new Exception($"Hey, you need to set the App Environment Variable!");
            }

            Load((MyEnvironment)env);
        }

        public static void Load(object env)
        {
            var path = Assembly.GetExecutingAssembly().Location;
            var dir = Path.GetDirectoryName(path);
            var json = File.ReadAllText(Path.Combine(dir, "connectionStrings.json"));
            var config = JsonSerializer.Deserialize<Dictionary<string, EnvironmentConfig>>(json);
            Current = config[env.ToString()];
        }

        public static void LoadFromDifferentAssembly(MyEnvironment env, string assemblyFilePath)
        {
            var assembly = Assembly.Load(assemblyFilePath);
            var resourceName = "MyAssemblyName.connectionStrings.json";
            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
            {
                throw new FileNotFoundException($"Resource '{resourceName}' not found in assembly '{assembly.FullName}'.");
            }
            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            var config = JsonSerializer.Deserialize<Dictionary<string, EnvironmentConfig>>(json);
            Current = config[env.ToString()];
        }
    }


    public enum MyEnvironment
    {
        Unknown,
        Local,
        Dev,
        Prod
    }
}
