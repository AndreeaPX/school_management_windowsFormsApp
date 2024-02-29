using ProiectPAW_Catalog_elevi.Entities;
using ProiectPAW_Catalog_elevi.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public class StudentRepository : IStudentRepository
    {

        public Student getById(Guid id)
        {
            return StudentsDataBase.students.FirstOrDefault(x => x.UserId == id);
        }

        public string getClass(Guid id)
        {
            Guid temp= StudentsDataBase.students.FirstOrDefault(x=>x.UserId==id).ClassId;
            return StudentsDataBase.classes.FirstOrDefault(x => x.Id == temp).Name;
            
        }

        public List<Student> getStudentForUser(Guid idUser)
        {
            return StudentsDataBase.students.Where(x => x.UserId == idUser).ToList();
        }

        public List<ObjectSubject> getSubjectAndGradeForStudent(Guid idStud)
        {
            
            List<Grade> aux = StudentsDataBase.grades.Where(x => x.StudentId == idStud).ToList();
            List<ObjectSubject> result = new List<ObjectSubject>();
            foreach(Grade g in aux)
            {
                var elem = new ObjectSubject();
                elem.Id = g.Id;
                elem.Denumire = StudentsDataBase.subjects.FirstOrDefault(z => z.Id == g.SubjectId).Denumire;
                elem.Value = g.Value;
                elem.Absenta = g.Absenta;
                elem.data = g.data;
                result.Add(elem);
            }
            return result;
        }
    }
}
