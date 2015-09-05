using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer
{
    public class ContractorSkillEntity : Entity.IContractorSkillEntity
    {
        public int ContractorID { get; set; }

        public string SkillType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SkillID { get; set; }
    }
}
