using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaFinanceiro.API.Data;
using SistemaFinanceiro.API.Models;

namespace SistemaFinanceiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LucroController : ControllerBase
    {
        private readonly DataContext context;
        public LucroController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Lucro> Get()
        {
            return context.Lucros;
        }

        [HttpGet("{id}")]
        public Lucro GetById(int id)
        {
            return context.Lucros.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public Lucro AddLucro([FromBody] Lucro lucro)
        {
            context.Lucros.Add(lucro);
            context.SaveChanges();
            return lucro;
        }
    }
}
