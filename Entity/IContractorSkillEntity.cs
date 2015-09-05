using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IContractorSkillEntity
    {
        int ContractorID { get; set; }

        string SkillType { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        int SkillID { get; set; }
    }
}
