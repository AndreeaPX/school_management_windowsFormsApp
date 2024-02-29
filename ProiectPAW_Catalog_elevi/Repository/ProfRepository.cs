using ProiectPAW_Catalog_elevi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.DataBase;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public class ProfRepository : IProfRepository
    {
        public Teacher getById(Guid id)
        {
            return StudentsDataBase.teachers.FirstOrDefault(x => x.UserId == id);
        }

        public List<Teacher> getTeacherForUser(Guid idUser)
        {
            return StudentsDataBase.teachers.Where(x => x.UserId == idUser).ToList();
        }

        public string getMaterie(Guid id)
        {
            Guid temp = StudentsDataBase.teachers.FirstOrDefault(x => x.UserId == id).SubjectId;
            return StudentsDataBase.subjects.FirstOrDefault(x => x.Id == temp).Denumire;

        }

        public string getDescriere(Guid id)
        {
            Guid temp = StudentsDataBase.teachers.FirstOrDefault(x => x.UserId == id).SubjectId;
            return StudentsDataBase.subjects.FirstOrDefault(x => x.Id == temp).Descriere;
        }

        public List<Class> GetClassesForTeacher (Guid idUser)
        {
            List<Class> result = new List<Class>();
            List<Teacher_class> temp = StudentsDataBase.teacher_Classes.Where(x => x.IdT == idUser).ToList();
            foreach(var e in temp)
            {
                List<Class> elements = StudentsDataBase.classes.Where(x => x.Id == e.IdC).ToList();
                foreach(var f in elements)
                {
                    var element = new Class();
                    element.Id = f.Id;
                    element.Name = f.Name;
                    result.Add(element);
                }
            }
            return result;
        }

        public List<ObjectSubject> getSubjectAndGradeForCatalog(Guid idProf, Guid clasa)
        {
            List<ObjectSubject> result = new List<ObjectSubject>();
            Guid idSubject = StudentsDataBase.teachers.FirstOrDefault(x => x.UserId == idProf).SubjectId;
            List<Teacher_class> classes = StudentsDataBase.teacher_Classes.Where(x => x.IdT == idProf && x.IdC == clasa).ToList();
            foreach (var c in classes)
            {
                
                var studenti = StudentsDataBase.students.Where(x => x.ClassId == c.IdC).ToList();
                foreach (var s in studenti)
                {
                    List<Grade> aux = StudentsDataBase.grades.Distinct().Where(x => x.SubjectId == idSubject && x.StudentId==s.UserId).ToList();
                    foreach (var g in aux)
                    {

                        var elem = new ObjectSubject();
                        elem.Id = g.Id;
                        elem.Denumire = StudentsDataBase.subjects.FirstOrDefault(z => z.Id == g.SubjectId).Denumire;
                        elem.Nume_elev = StudentsDataBase.students.FirstOrDefault(x => x.UserId == g.StudentId).Nume;
                        elem.Value = g.Value;
                        elem.Absenta = g.Absenta;
                        elem.data = g.data;

                        result.Add(elem);

                    }
                }
            }
            return result;
        }

        public List<string> getStudForClass(Guid idClasa)
        {
            List<string> result = new List<string>();
            
            
                var studenti = StudentsDataBase.students.Where(x => x.ClassId == idClasa).ToList();
                foreach(var s in studenti)
                {
                    result.Add(s.Nume);
                }
            
            return result;
        }

       
    }
}
