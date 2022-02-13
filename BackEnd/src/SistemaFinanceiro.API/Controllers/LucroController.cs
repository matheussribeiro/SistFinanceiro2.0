using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaFinanceiro.API.Models;

namespace SistemaFinanceiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LucroController : ControllerBase
    {
        public LucroController()
        {
            
        }

        [HttpGet]
        public Lucro Get()
        {
            return new Lucro(){
                Id = 1,
                Nome = "Salário",
                Valor = 3600
            };
        }
    }
}
