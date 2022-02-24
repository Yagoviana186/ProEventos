using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class EventosController : ControllerBase
    {
            
    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento() {
        EventoId = 1,
        Tema = "Angular 11 e .NET 5",
        Local = "Belo Horizonte",
        Lote = "1° Lote",
        QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        ImagemURL = "foto.png"
                    
        },
        new Evento() {
        EventoId = 2,
        Tema = "Angular e Suas Novidades",
        Local = "Sao Paulo",
        Lote = "2° Lote",
        QtdPessoas = 350,
        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
        ImagemURL = "foto1.png"
                    
            }
        };

        public DataContext Context { get; }

        public EventosController(DataContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
           return new Evento[] {
            new Evento() {
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
            
            },
             new Evento() {
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
            
            }
        };
    }

        
      
        [HttpGet("{id}")]

        public Evento GetById(int id)
        {
            return _evento.FirstOrDefault
            (evento => evento.EventoId == id);
        }
        
        
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
        
        [HttpPut ("{id}")]

        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        
        
        }
    }
}