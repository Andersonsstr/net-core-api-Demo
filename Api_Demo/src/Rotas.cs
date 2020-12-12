using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Api_Demo.src.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Demo.src
{
    [Produces("application/json")]
    [ApiController]
    public class Rotas : Controller
    {
        [HttpPost]
        [Route("/teste")]
        public Usuario receiver(object teste)
        {
            //dynamic json = new ExpandoObject();
            //json.nome = "Anderson";
            //json.idade = "20";

            Usuario usuario = new Usuario("Anderson", "20");

            return usuario;
        }

        [HttpGet]
        [Route("/")]
        public string receiver()
        {

            return "Hello World";
        }
    }
}
