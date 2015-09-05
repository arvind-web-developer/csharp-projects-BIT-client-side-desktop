using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public interface IPersonData
    {
        DataTable ListPerson(string userRole, string roleData, string userLogin);

        DataTable InsertPerson(string userRole, string roleData, string userLogin, IPersonEntity person);

        DataTable ApprovePerson(string userRole, string roleData, string userLogin, IPersonEntity person);

        DataTable UpdatePerson(string userRole, string roleData, string userLogin, IPersonEntity person);

        // void Update(IPersonEntity person);


    }
}