using Microsoft.Data.SqlClient;
using System.Data;

namespace FrotaApp.Infrastructure.Input.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost; Database=BANCO_FROTA; User=sa; Password=@Passw0rd; Trusted_Connection=False; TrustServerCertificate=True;");
        }
    }
}
