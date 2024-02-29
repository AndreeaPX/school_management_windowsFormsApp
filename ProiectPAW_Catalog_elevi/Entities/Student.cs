using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Nume { get; set; }
      
        public string CNP { get; set; }
        public Gen gen { get; set; }
        public string Adresa { get; set; }
        public string NrTelefonTutore { get; set; }
        public string emailPersonal { get; set; }

        public Guid UserId { get; set; }

        public Guid ClassId { get; set; }

        public override string ToString()
        {
            return $"{Nume}";
        }
    }
}
