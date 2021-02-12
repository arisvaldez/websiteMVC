using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace website.DBConection
{
    public static class ConectionMySQL
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost; database=library; uid=root; pwd=");
        }
    }
}