using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public interface IRequestData
    {
        DataTable ListRequest(string userRole, string roleData, string userLogin);

        void Insert(IRequestEntity request);

        //  void Delete(IRequestEntity request);

        // void Update(IRequestEntity request);
    }
}
