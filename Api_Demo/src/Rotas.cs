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
        [HttpGet]
        [Route("/teste")]
        public string receiver()
        {
            return "Requisição recebida na rota GET com sucesso!";
        }

        [HttpPost]
        [Route("/teste")]
        public string receiverTeste(requisicaoRecebida teste)
        {
            
            string nome = teste.nome;
            return "Requisição recebida na rota Post com sucesso " + nome;
        }

        [HttpPost]
        [Route("/Soma")]
        public dynamic receiver(requisicaoRecebida objUsuario)
        {
            dynamic json = new ExpandoObject();

            try
            {
                int soma = objUsuario.numero1 + objUsuario.numero2;             
                json.resultado = $"O resultado da soma é {soma}";
            }
            catch (Exception ex)
            {
                json.Erro = "Erro: " + ex.Message;
            }
            return json;
        }
    }
}
