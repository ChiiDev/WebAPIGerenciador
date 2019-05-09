using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;


//GET para recuperar, POST para criar, PUT para alterar e DELETE para apagar;
namespace WebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: Produto
        public IEnumerable<Usuario> Get()
        {
            return new UsuarioBusiness().Listar();
        }

        // POST 
    }
}