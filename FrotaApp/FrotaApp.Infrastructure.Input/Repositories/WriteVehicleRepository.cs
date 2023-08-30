using Dapper;
using FrotaApp.Application.Input.Repositories;
using FrotaApp.Domain.Entities;
using FrotaApp.Infrastructure.Input.Factory;
using FrotaApp.Infrastructure.Input.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrotaApp.Infrastructure.Input.Repositories
{
    internal class WriteVehicleRepository : IWriteVehicleRepository
    {
        private readonly IDbConnection _connection;

        public WriteVehicleRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public void InsertVehicle(VehicleEntity vehicle)
        {
            var query = new VehicleQuery();
            query.InsertVehicleQuery(vehicle);

            try
            {
                using (_connection)
                {
                    _connection.Execute(query.Query, query.Parameters);
                }
            }
            catch
            {
                throw new Exception("Erro ao inserir!");
            }
        }
    }
}
