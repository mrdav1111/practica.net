using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_JSON_parser
{
    class LocalDBContext : DbContext
    {
        public LocalDBContext() : base("personasSqlServer") { }

        public DbSet<Persona> personas { get; set; }
    }
}
