using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TestProgrammationConformit.Models;

namespace TestProgrammationConformit.Models
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        public DefaultContext()
        {

        }

        #region proprietés
        public DbSet<Commentaire> commentaires { get; set; }
        public DbSet<Evenement> evenements { get; set; }

        #endregion

    }
}