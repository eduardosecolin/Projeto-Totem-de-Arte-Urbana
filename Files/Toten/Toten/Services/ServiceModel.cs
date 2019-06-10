using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Toten.Model;
using System.Data.Entity.Migrations;

namespace Toten.Services
{
    public class ServiceModel
    {


        public string GetAddressImg(int id)
        {
            string result = string.Empty;
            using(DB_Connection con = new DB_Connection())
            {
                var sql = con.Imagens.Where(x => x.id == id).FirstOrDefault();
                return result = sql.bairro + ", " + sql.cidade;
            }
        }

        public string GetRegionImg(int id)
        {
            string result = string.Empty;
            using (DB_Connection con = new DB_Connection())
            {
                var sql = con.Imagens.Where(x => x.id == id).FirstOrDefault();
                return result = sql.regiao;
            }
        }

        public void UpdateTable(Comentarios comentario)
        {
            using(DB_Connection con = new DB_Connection())
            {
                con.Comentarios.Add(comentario);
                con.SaveChanges();
            }
        }
    }
}
