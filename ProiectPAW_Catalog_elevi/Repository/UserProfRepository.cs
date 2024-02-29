using ProiectPAW_Catalog_elevi.Entities;
using ProiectPAW_Catalog_elevi.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public class UserProfRepository : IUserProfRepository
    {
        
        TeacherUserName_pas IUserProfRepository.GetById(Guid id)
        {
            return StudentsDataBase.TeacherUsers.First(x => x.Id == id);
        }

        TeacherUserName_pas IUserProfRepository.GetUserNamePass(string password, string userName)
        {
            return StudentsDataBase.TeacherUsers.FirstOrDefault(x => x.Password == password && x.UserName == userName);
        }
    }
}
