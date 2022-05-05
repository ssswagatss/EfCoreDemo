using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo
{
    public static class QueryHelper
    {
        public static List<Dictionary<string, object>> RawSqlQuery<T>(this EfDbContext db, string query)
        {
            using (var command = db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                db.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    var entities = new List<Dictionary<string, object>>();
                    var names = Enumerable.Range(0, result.FieldCount).Select(result.GetName).ToList();
                    foreach (IDataRecord record in result as IEnumerable)
                    {
                        
                        entities.Add(names.ToDictionary(n => n, n => record[n]));
                    }
                    return entities;
                }
            }
        }
    }
}
