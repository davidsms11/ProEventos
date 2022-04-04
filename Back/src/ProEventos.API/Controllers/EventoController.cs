using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable< Evento > _evento = new Evento [] {
                new Evento() {

                
                EventoId = 1,
                Tema = "Angular11 e dotnet ",
                Local = "Brasil",
                Lote = "1 lote",
                quantidade	= 250,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagenUrl = "foto png"
                },
                  new Evento() {

                
                EventoId = 2,
                Tema = "Angular11 e dotnet ",
                Local = "GErmany",
                Lote = "2 lote",
                quantidade	= 450,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagenUrl = "foto2 png"
                }
            };
        
        

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _evento;
        }

        
        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById( int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

         [HttpPost]
        public string Post()
        {
            return "Exemplo post";
        }

        [HttpPut("{id}")]
        public string Put( int id)
        {
            return $"Exemplo put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete( int id)
        {
            return $"Exemplo Delete com id = {id}";
        }

        
    }
}

