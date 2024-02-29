using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Entities
{
    [Serializable]
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Salariu { get; set; }

        public Guid SubjectId { get; set; }
        public Guid UserId { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
