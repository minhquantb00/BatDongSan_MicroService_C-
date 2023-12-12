using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared
{
    public static class GlobalConnectionStrings
    {
        // Databases
        public const string RealEstate_DB_Connection = "server = QUANMOVIT\\SQLEXPRESS; database=Real_State; integrated security = sspi; encrypt = true; trustservercertificate = true;";
        //Host=127.0.0.1;Database=RealEstate;Username=postgres;Password=admin
        // Keycloak
        public const string Keycloak_DB_Connection = "Server=postgres;Port=5432;Database=keycloak;User Id=keycloak;Password=password;Integrated Security=true;Pooling=true";
        public const string Keycloak_Auth_Server = "http://localhost:8080/";
        public const string Keycloak_Secret = "Tgx4lvbyhho7oNFmiIupDRVA8ioQY7PW";

        // Micro Databases
        public const string Clients_MicroDB_Connection = "Server=QUANMOVIT\\SQLEXPRESS;Port=5001;Database=Clients;integrated security = sspi; encrypt = true; trustservercertificate = true;";
        public const string Contracts_MicroDB_Connection = "Server=QUANMOVIT\\SQLEXPRESS;Port=5002;Database=Contracts;integrated security = sspi; encrypt = true; trustservercertificate = true;";
        public const string Estates_MicroDB_Connection = "Server=QUANMOVIT\\SQLEXPRESS;Port=5003;Database=Estates;integrated security = sspi; encrypt = true; trustservercertificate = true;";
        public const string Listings_MicroDB_Connection = "Server=QUANMOVIT\\SQLEXPRESS;Port=5005;Database=Listings;integrated security = sspi; encrypt = true; trustservercertificate = true;";

        // NoSQL Databases
        public const string Redis_Connection = "localhost:6379";
        public const string Mongo_Connection = "";

        // Event Bus
        public const string RabbitMQ_Connection = "amqp://guest:guest@host.docker.internal:5672/"; //"amqp://guest:guest@localhost:5672/

        public const string GRPC_Connection = "http://localhost:5003";

        // Logginng
        public const string Elasticsearch_Connection = "http://localhost:9200";
    }
}
