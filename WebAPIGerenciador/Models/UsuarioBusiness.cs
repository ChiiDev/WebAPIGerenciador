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
