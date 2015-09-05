using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public interface IUserData
    {
        DataTable getUser(IUserEntity user);

        DataTable getSPUser(IUserEntity user);

        DataTable InsertUser(string userRole, string roleData, string userLogin, IUserEntity user);

        DataTable DeactivateUser(string userRole, string roleData, string userLogin, IUserEntity user);

        //  void Delete(IUserEntity user);

        // void Update(IUserEntity user);
    }
}
