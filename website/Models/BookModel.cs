using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace website.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string FechaPublicacion { get; set; }
        

        public List<BookModel> GetAll()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            var cn = DBConection.ConectionMySQL.GetConnection();
            string query = "SELECT * FROM Books";
            return cn.Query<BookModel>(query).ToList();
        }
    }
}