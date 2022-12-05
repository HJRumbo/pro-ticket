namespace Domain.Common
{
    public class ConnectionDB
    {
        public string? ConnectionString { get; set; }

        public ConnectionDB(string? connectionString) => ConnectionString = connectionString;
    }
}
