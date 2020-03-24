using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebAPI.model;

namespace ProAgil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] { 
                new Evento(){
                    eventoId = 1,
                    tema = "Angular e .Net Core",
                    local  = "Belo Horizonte",
                    qtsPessoas = 250,
                    lote = "1ª Lote",
                    dataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    eventoId = 2,
                    tema = "Angular e Suas Novidades",
                    local  = "São Paulo",
                    qtsPessoas = 350,
                    lote = "2ª Lote",
                    dataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
             };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] { 
                new Evento(){
                    eventoId = 1,
                    tema = "Angular e .Net Core",
                    local  = "Belo Horizonte",
                    qtsPessoas = 250,
                    lote = "1ª Lote",
                    dataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    eventoId = 2,
                    tema = "Angular e Suas Novidades",
                    local  = "São Paulo",
                    qtsPessoas = 350,
                    lote = "2ª Lote",
                    dataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
             }.FirstOrDefault(x => x.eventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
