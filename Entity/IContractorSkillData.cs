using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public interface IContractorSkillData
    {
        DataTable ListContractorSkill(string userRole, string roleData, string userLogin, int contractorId);

        DataTable InsertContractorSkill(string userRole, string roleData, string userLogin, IContractorSkillEntity contractorskill);

        //void Insert(IContractorSkillEntity contractorskill);

        //  void Delete(IContractorSkillEntity contractorskill);

        // void Update(IContractorSkillEntity contractorskill);
    }
}
