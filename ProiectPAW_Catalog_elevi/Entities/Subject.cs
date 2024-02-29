using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public Subject_type Tip_materie {get; set; }
    }
}
