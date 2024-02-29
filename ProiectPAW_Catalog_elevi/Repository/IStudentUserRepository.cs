using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Entities;

namespace ProiectPAW_Catalog_elevi.Repository
{
    public interface IStudentUserRepository
    {
        StudentUserName_pas GetById(Guid id);

        StudentUserName_pas GetByPas_UserName(string password, string userName);
    }
}
