using System.Data.SqlClient;

namespace SeuProjeto.Data
{
    public static class Db
    {
        // Connection String oficial da Azure
        private static readonly string connectionString =
            "Server=tcp:techflow.database.windows.net,1433;" +
            "Initial Catalog=techflow;" +
            "Persist Security Info=False;" +
            "User ID=techflow;" +
            "Password=Pim@2025;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
