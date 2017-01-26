using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PagaDiario
{
    public class ClienteController : ApiController
    {
        // GET api/cliente
        public Clientes Get()
        {
            Clientes cliente = new Clientes();

            return cliente; ;
        }



        //[Route("api/values/getNames")]
        // GET api/cliente/5
        public string Get(int id)
        {
           //TODO: Logica de programación

            return "Hola mundo!";
        }

        // POST api/cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cliente/5
        public void Delete(int id)
        {
        }
    }
}
