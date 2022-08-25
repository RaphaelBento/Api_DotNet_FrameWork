using ApiDotNetFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiDotNetFrameWork.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();
        

        public List<Cliente> Get()
        {
            return clientes;
        }

        public void Post(int id,string nome ,string sobreNome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
            {
                clientes.Add(new Cliente(id,nome,sobreNome));
            }
            
        }

        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }

    }
}
