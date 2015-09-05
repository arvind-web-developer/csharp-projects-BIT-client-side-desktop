using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer
{
    public class SkillEntity : Entity.ISkillEntity
    {
        public int SkillID { get; set; }

        public string SkillType { get; set; }

        public bool IsActive { get; set; }
    }
}
