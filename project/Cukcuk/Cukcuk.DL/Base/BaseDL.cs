using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cukcuk.DL.Base
{
    public class BaseDL<T> where T: class
    {
        private readonly IDbConnection _conn = new MySqlConnection("server=35.194.135.168;port=3306;user=dev;password=12345678@Abc;database=MISA_NBAnh_Import;");

        public IEnumerable<T> GetAll()
        {
            return _conn.GetAll<T>();
        }

        public T GetById(Guid id)
        {
            return _conn.Get<T>(id);
        }

        public bool InsertData(T data)
        {
            return _conn.Insert<T>(data) > 0;
        }

        public bool UpdateData(T data)
        {
            return _conn.Update<T>(data);
        }

        public bool DeleteData(Guid id)
        {
            var item = _conn.Get<T>(id);

            return _conn.Delete<T>(item);
        }
    }
}
