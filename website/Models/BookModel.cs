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
        public DateTime FechaPublicacion { get; set; }


        public BookModel Get(int id)
        {
            var cn = DBConection.ConectionMySQL.GetConnection();
            string query = "SELECT * FROM Books WHERE id = @id";
            var result = cn.Query<BookModel>(query, new { id}).FirstOrDefault();
            return result;
        }

        public List<BookModel> GetAll()
        {
            var cn = DBConection.ConectionMySQL.GetConnection();
            string query = "SELECT * FROM Books";
            var result =  cn.Query<BookModel>(query).ToList();
            return result;
        }

        public bool Edit(BookModel model)
        {
            var cn = DBConection.ConectionMySQL.GetConnection();
            string query = "UPDATE Books SET titulo = @Titulo, fecha_publicacion = @FechaPublicacion WHERE id = @id ";
            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Insert(BookModel model)
        {
            var cn = DBConection.ConectionMySQL.GetConnection();
            string query = "INSERT INTO Books(titulo, fecha_publicacion)VALUES(@Titulo, @FechaPublicacion)";
            if (cn.Execute(query, model) > 0)
            {
                return true;
            }
            return false;
        }
    }
}