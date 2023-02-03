using AppEventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _eventos = new Evento[] {
            new Evento() {
                            EventoId = 1,
                            Tema = "Angular e .Net core6",
                            Local = "Sergipe",
                            Lote = "1º Lote",
                            QtdPessoas = 120,
                            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                            ImagemURL = "foto1.png"
            },
            new Evento() {
                            EventoId = 2,
                            Tema = "Angular 15 e .Net core",
                            Local = "Sergipe",
                            Lote = "2º Lote",
                            QtdPessoas = 200,
                            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                            ImagemURL = "foto2.png"
            }
        };

        public EventoController() { }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _eventos.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string EventoPost()
        {
            return "Post return okay";
        }

        [HttpPut("{id}")]
        public string EventoPut(int id)
        {
            return $"Put return okay com id => {id}";
        }

        [HttpDelete("{id}")]
        public string EventoDelete(int id)
        {
            return $"Delete return okay com id => {id}";
        }
    }
}