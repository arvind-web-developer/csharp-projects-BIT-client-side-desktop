using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface ISkillEntity
    {
        int SkillID { get; set; }

        string SkillType { get; set; }

        bool IsActive { get; set; }
    }
}
