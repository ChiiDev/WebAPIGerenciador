using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Dapper.SqlMapper;
using WebAPIGerenciador.Properties;
using Settings = WebAPIGerenciador.Properties.Settings;

namespace WebAPIGerenciador.Models
{
    public class Conexao
    {
        public SqlConnection con = null;

        public Conexao()
        {
            con = new SqlConnection(Settings.Default.conexao);
        }
    }
}