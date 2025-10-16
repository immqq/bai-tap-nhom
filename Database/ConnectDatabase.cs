namespace BaiTapNhom.Database
{
    public class ConnectDatabase(string connectionString)
    {
        private readonly string _connectionString = connectionString;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
