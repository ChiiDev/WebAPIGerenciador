using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIGerenciador.Models;
using Dapper;

namespace WebAPI.Models
{
    public class UsuarioBusiness : Conexao
    {
        public List<Usuario> Listar()
        {
            return con.Query<Usuario>(@"select * from Usuarios").ToList();
        }
    }
}



//List<Usuario> lista = new List<Usuario>();
            //lista.Add(new Usuario { ID = 1, Login = "Ane", Email = "anecarolineba@hotmail.com", Password = "paçoca" });
            //lista.Add(new Usuario { ID = 2, Login = "Ane", Email = "anecarolineba@hotmail.com", Password = "paçoca" });
            //lista.Add(new Usuario { ID = 3, Login = "Ane", Email = "anecarolineba@hotmail.com", Password = "paçoca" });
            //lista.Add(new Usuario { ID = 4, Login = "Ane", Email = "anecarolineba@hotmail.com", Password = "paçoca" });

            //return lista;
