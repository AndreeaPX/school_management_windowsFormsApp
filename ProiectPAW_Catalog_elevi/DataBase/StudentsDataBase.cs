using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.Entities;

namespace ProiectPAW_Catalog_elevi.DataBase
{
    public static class StudentsDataBase
    {
        public static List<StudentUserName_pas> StudentUsers = new List<StudentUserName_pas>()
        {
            new StudentUserName_pas{Id=Guid.NewGuid(),StudentUserName="panaandreea@stud.cuza.ro",StudentPassword="1234"},
            new StudentUserName_pas{Id=Guid.NewGuid(),StudentUserName="grosuteodora@stud.cuza.ro",StudentPassword="1235"},
            new StudentUserName_pas{Id=Guid.NewGuid(),StudentUserName="burceaandra@stud.cuza.ro",StudentPassword="1236"}
        };

        public static List<TeacherUserName_pas> TeacherUsers = new List<TeacherUserName_pas>()
        {
            new TeacherUserName_pas{Id=Guid.NewGuid(), UserName="stoe@prof.cuza.ro",Password="1234"},
            new TeacherUserName_pas{Id=Guid.NewGuid(), UserName="jum@prof.cuza.ro",Password="1234"},
            new TeacherUserName_pas{Id=Guid.NewGuid(), UserName="aliu@prof.cuza.ro",Password="1234"}
        };

        public static List<Class> classes = new List<Class>()
        {
            new Class(){Id=Guid.NewGuid(), Name="12 B"},
            new Class(){Id=Guid.NewGuid(), Name="11 C"},
            new Class(){Id=Guid.NewGuid(), Name="9 A"}
        };

        public static List<Student> students = new List<Student>()
        {
            new Student() { Id = Guid.NewGuid(), Nume = "Pana Andreea", CNP = "6010730341188", gen = Gen.F, Adresa = "Strada Dispensarului nr5 Frasinet-TR", NrTelefonTutore = "0726151777", UserId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id, emailPersonal="panaandreea1802@yahoo.com", ClassId=classes.FirstOrDefault(x=>x.Name=="12 B").Id},
            new Student() { Id = Guid.NewGuid(), Nume = "Grosu Teodora", CNP = "6010751915884", gen = Gen.F, Adresa = "Strada Principala nr2 Poroschia-TR", NrTelefonTutore = "0725789145", UserId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="grosuteodora@stud.cuza.ro").Id , emailPersonal="TheoGrosu@yahoo.com" ,ClassId=classes.FirstOrDefault(x=>x.Name=="12 B").Id},
            new Student() { Id = Guid.NewGuid(), Nume = "Burcea Andra", CNP = "6010751915884", gen = Gen.F, Adresa = "Strada Bisericii nr9 Soimu-TR", NrTelefonTutore = "0725789145" ,UserId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="burceaandra@stud.cuza.ro").Id, emailPersonal="Burcea.andra@gmail.com" ,ClassId=classes.FirstOrDefault(x=>x.Name=="12 B").Id}
        };

        public static List<Subject> subjects = new List<Subject>()
        {
            new Subject() {Id= Guid.NewGuid(), Denumire="Matematica", Descriere="ceva filosofic", Tip_materie=Subject_type.Obligatorie},
            new Subject() {Id= Guid.NewGuid(), Denumire="Limba Romana", Descriere="altceva filosofic", Tip_materie=Subject_type.Obligatorie},
            new Subject() {Id= Guid.NewGuid(), Denumire="Economie", Descriere="altceva si mai filosofic", Tip_materie=Subject_type.Optional},
            new Subject() {Id= Guid.NewGuid(), Denumire="Fizica", Descriere="ceva atat de filosofic ca nu am inteles-o niciodata", Tip_materie=Subject_type.Optional}
        };


        public static List<Grade> grades = new List<Grade>()
       {
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Matematica").Id, Value=10,data=new DateTime(2022, 3, 1, 3, 0, 0), Absenta=false },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Matematica").Id, Value=9,data=new DateTime(2022, 4, 5, 7, 0, 0), Absenta=false },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Matematica").Id, Value=7,data=new DateTime(2022, 4, 29, 6, 0, 0), Absenta=false },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Limba Romana").Id, Value=10,data=new DateTime(2022, 4, 29, 4, 0, 0), Absenta=false },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Limba Romana").Id ,data=new DateTime(2022, 4, 30, 4, 0, 0), Absenta=true },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="panaandreea@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Economie").Id, Value=10,data=new DateTime(2022, 4, 28, 7, 0, 0), Absenta=false },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="burceaandra@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Matematica").Id, Value=10,data=new DateTime(2022, 4, 28, 7, 0, 0), Absenta=false },
       new Grade() {Id=Guid.NewGuid(), StudentId=StudentUsers.FirstOrDefault(x=>x.StudentUserName=="burceaandra@stud.cuza.ro").Id,SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Matematica").Id,data=new DateTime(2022, 4, 28, 7, 0, 0), Absenta=true }
       };

        public static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher() {Id=Guid.NewGuid(), Name="Stoenescu Simona", Salariu=9000, SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Matematica").Id, UserId=TeacherUsers.FirstOrDefault(x=>x.UserName=="stoe@prof.cuza.ro").Id},
            new Teacher() {Id=Guid.NewGuid(), Name="Aliu Felicia", Salariu=9000, SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Limba Romana").Id, UserId=TeacherUsers.FirstOrDefault(x=>x.UserName=="aliu@prof.cuza.ro").Id},
            new Teacher() {Id=Guid.NewGuid(), Name="Jumatate Ramona", Salariu=9000, SubjectId=subjects.FirstOrDefault(x=>x.Denumire=="Economie").Id,UserId=TeacherUsers.FirstOrDefault(x=>x.UserName=="jum@prof.cuza.ro").Id}
        };
        public static List<Teacher> teacherData = new List<Teacher>();

        public static List<Teacher_class> teacher_Classes = new List<Teacher_class>()
        {
            new Teacher_class(){Id=Guid.NewGuid(), IdT=TeacherUsers.FirstOrDefault(x=>x.UserName=="stoe@prof.cuza.ro").Id,IdC=classes.FirstOrDefault(x=>x.Name=="12 B").Id},
            new Teacher_class(){Id=Guid.NewGuid(), IdT=TeacherUsers.FirstOrDefault(x=>x.UserName=="aliu@prof.cuza.ro").Id,IdC=classes.FirstOrDefault(x=>x.Name=="12 B").Id},
            new Teacher_class(){Id=Guid.NewGuid(), IdT=TeacherUsers.FirstOrDefault(x=>x.UserName=="stoe@prof.cuza.ro").Id,IdC=classes.FirstOrDefault(x=>x.Name=="11 C").Id},
            new Teacher_class(){Id=Guid.NewGuid(), IdT=TeacherUsers.FirstOrDefault(x=>x.UserName=="stoe@prof.cuza.ro").Id,IdC=classes.FirstOrDefault(x=>x.Name=="9 A").Id}
        };

    }
}
