using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Entities;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public interface IStudentRepository
    {
        List <Student> getStudentForUser(Guid idUser);
        Student getById(Guid id);

        List<ObjectSubject> getSubjectAndGradeForStudent(Guid idStud);

        string getClass(Guid id);
    }
}
