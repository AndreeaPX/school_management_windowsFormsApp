using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Entities
{
    public class Grade
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public Guid SubjectId { get; set; }
        public Guid StudentId { get; set; }
        public bool Absenta { get; set; }

        public DateTime data { get; set; }

    }
}
