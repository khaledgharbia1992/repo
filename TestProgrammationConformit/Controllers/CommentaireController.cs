using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentaireController : ControllerBase
    {
        private readonly DefaultContext _context = null;
        public CommentaireController(DefaultContext context)
        {
            this._context = context;
        }
        [Route("comments")]

        public IActionResult GetAllComments()

        {
            var EventsQuery = from item in this._context.commentaires
                              select item;
            if (EventsQuery != null)
                return (Ok(EventsQuery));
            else
                return NotFound();
        }
        [HttpGet]
        [Route("comments/{commentaire}")]
        public IActionResult GetSpeceficComment(int commentaire)

        {
            Commentaire result = null;
            result = this._context.commentaires.FirstOrDefault(item => item.CommentaireId == commentaire);
            if (result != null)
                return (Ok(result));
            else
                return NotFound();
        }
        [HttpPost]
        [Route("addCommentaire")]

        public IActionResult AddCommentaire([FromBody] Commentaire commentaire)
        {

            this._context.commentaires.Add(commentaire);
           var result = this._context.evenements.FirstOrDefault(item => item.Event == commentaire.EventId);
            result.commentaires.Add(commentaire);
            this._context.SaveChanges();
            return (Ok());
        }

        [HttpPost]
        [Route("updateCommentaire")]

        public IActionResult UpdateComment([FromBody] Commentaire commentaire)
        {
            var entity = this._context.commentaires.FirstOrDefault(item => item.CommentaireId == commentaire.CommentaireId);
            entity.Description = commentaire.Description;
            entity.Date = commentaire.Date;
            entity.evenement = commentaire.evenement;
            entity.EventId = commentaire.EventId;
            this._context.SaveChanges();
            return (Ok());
        }

        [HttpPost]
        [Route("deleteComments")]

        public IActionResult DeleteComment([FromBody] Commentaire commentaire)
        {
            var entity = this._context.commentaires.FirstOrDefault(item => item.CommentaireId == commentaire.CommentaireId);
            this._context.commentaires.Remove(entity);
            this._context.SaveChanges();
            return (Ok());
        }
    }
}
