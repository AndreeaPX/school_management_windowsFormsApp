using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Entities;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public interface IUserProfRepository
    {
        TeacherUserName_pas GetById(Guid id);
        TeacherUserName_pas GetUserNamePass(string password, string userName);
    }
}
