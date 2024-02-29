using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Entities
{
    public class ObjectSubject
    {
        public Guid Id { get; set; }
        public string Denumire { get; set; }

        public string Nume_elev { get; set; }

        public int Value { get; set; }
        public bool Absenta { get; set; }

        public DateTime data { get; set; }

    }
}
