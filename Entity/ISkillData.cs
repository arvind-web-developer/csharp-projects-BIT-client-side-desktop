using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public interface ISkillData
    {
        DataTable ListSkill(string userRole, string roleData, string userLogin);

        DataTable InsertSkill(string userRole, string roleData, string userLogin, ISkillEntity skill);
     //   void Insert(ISkillEntity skill);

        //  void Delete(ISkillData skill);

        // void Update(ISkillData skill);
    }
}
