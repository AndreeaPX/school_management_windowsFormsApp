using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Entities;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public class StudentUserRepository : IStudentUserRepository
    {
        public StudentUserName_pas GetById(Guid id)
        {
           return StudentsDataBase.StudentUsers.First(x => x.Id == id);
        }

        public StudentUserName_pas GetByPas_UserName(string password, string userName)
        {
            return StudentsDataBase.StudentUsers.FirstOrDefault(x => x.StudentPassword == password && x.StudentUserName == userName);
       
        }
    }
}
