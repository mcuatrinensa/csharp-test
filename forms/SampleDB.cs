using Npgsql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    internal class Row
    {
        public string foo;
    }

    internal class SampleDB
    {
        public static async Task<string> ExecuteQuery()
        {
            var dbHost = "localhost";
            var dbUser = "postgres";
            var dbPass = "postgres";
            var dbName = "postgres";
            var connectionString = $"Host={dbHost};Username={dbUser};Password={dbPass};Database={dbName}";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Row>("select * from (values ('bar')) t (foo)");
                return result.First().foo;
            }
        }
    }
}
