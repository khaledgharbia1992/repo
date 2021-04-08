using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgrammationConformit.Models
{
    public class Evenement
    {
        [Key]
        public int Event { get; set; }
        [MaxLength(50)]

        public string Titre { get; set; }
        public string Personne { get; set; }
        public List<Commentaire> commentaires { get; set; }= new List<Commentaire>();


     
    }
}
