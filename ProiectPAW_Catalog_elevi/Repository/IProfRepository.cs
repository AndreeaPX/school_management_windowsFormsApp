using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Entities;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public interface IProfRepository
    {
        List<Teacher> getTeacherForUser(Guid idUser);
        Teacher getById(Guid id);
        string getMaterie(Guid id);
        string getDescriere(Guid id);

        List<Class> GetClassesForTeacher(Guid idUser);
        List<ObjectSubject> getSubjectAndGradeForCatalog(Guid idProf, Guid clasa);
        List<string> getStudForClass(Guid idClasa);

     
    }
}
