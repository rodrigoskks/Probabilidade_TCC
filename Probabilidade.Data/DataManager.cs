using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Probabilidade.Data.DB;

namespace Probabilidade.Data
{
    public class DataManager
    {
        private static DBSqlConnection _dbHelper = new DBSqlConnection();
        public static DBSqlConnection DbHelper
        {
            get { return _dbHelper; }
            set { _dbHelper = value; }
        }
    }
}
