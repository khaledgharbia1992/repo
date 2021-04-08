using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EvenementController : ControllerBase
    {
        private readonly DefaultContext _context = null;
        public EvenementController(DefaultContext context)
        {
            this._context = context;
        }
        [Route("events")]

        public IActionResult GetAllEvents()

        {
            var EventsQuery = from item in this._context.evenements
                                 select item;
            if (EventsQuery != null)
                return (Ok(EventsQuery));
            else
                return NotFound();
        }
        [HttpGet]
        [Route("events/{evenement}")]
        public IActionResult GetSpeceficEvents(int evenement)

        {
            Evenement result = null;
            result = this._context.evenements.FirstOrDefault(item => item.Event == evenement);
            if (result != null)
                return (Ok(result));
            else
                return NotFound();
        }
        [HttpPost]
        [Route("addevents")]

        public IActionResult AddEvent([FromBody]Evenement evenement)
        {
            this._context.evenements.Add(evenement);
            this._context.SaveChanges();
            return (Ok());
        }

        [HttpPost]
        [Route("updateEvents")]

        public IActionResult UpdateEvent([FromBody] Evenement evenement)
        {
            var entity = this._context.evenements.FirstOrDefault(item => item.Event== evenement.Event);
            entity.Personne = evenement.Personne;
            entity.Titre = evenement.Titre;
            this._context.SaveChanges();
            return (Ok());
        }

        [HttpPost]
        [Route("deleteEvents")]

        public IActionResult DeleteEvent([FromBody] Evenement evenement)
        {
            var entity = this._context.evenements.FirstOrDefault(item => item.Event == evenement.Event);
            this._context.evenements.Remove(entity);
            this._context.SaveChanges();
            return (Ok());
        }
    }
}
