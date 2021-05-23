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
    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _event = new Event[] {
            new Event{
                EventId = 1,
                Local = "Campo Grande",
                EventDate = DateTime.Now.AddDays(2).ToString(),
                Theme = "Angular",
                AmountPeople = 250,
                Lot = "1º Lote",
                ImageURL = "foto.png"
            },
            new Event{
                EventId = 2,
                Local = "Campo Grande",
                EventDate = DateTime.Now.AddDays(2).ToString(),
                Theme = ".Net",
                AmountPeople = 350,
                Lot = "1º Lote",
                ImageURL = "foto.png"
            }
        };
        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(item => item.EventId == id);
        }
    }
}
