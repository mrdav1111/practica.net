using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_JSON_parser
{
    public class Persona
    {
       
        [Key]
        public int personaId { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string noTelefonico { get; set; }
    }

   
}
