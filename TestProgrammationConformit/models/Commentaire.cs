using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgrammationConformit.Models
{
    public class Commentaire
    {[Key]
        public int CommentaireId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int EventId { get; set; }
        public Evenement evenement { get; set; }
    }
}
