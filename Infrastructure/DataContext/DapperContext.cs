using Npgsql;
namespace Infrastructure;

public class DapperContext
{
    private readonly string _connectionString = "Host=localhost;Port=5432;Database=Dapper_db2; User Id=postgres;Password=11223344;";


    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_connectionString);
    } 
}
