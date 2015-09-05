using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using Entity;

namespace BusinessLogicLayer
{
    public class Skill
    {
        public int SkillID { get; set; }

        public string SkillType { get; set; }

        public bool IsActive { get; set; }

        
        
        public Skill()
        {
        }

        public SkillEntity Entity(Skill skill)
        {
            SkillEntity entity = new SkillEntity();
            entity.SkillID = skill.SkillID;
            entity.SkillType = skill.SkillType;
            entity.IsActive = skill.IsActive;

            return entity;
        }

        public static DataTable ListSkill(string userRole, string userLogin)
        {
            ISkillData skilldata = new SkillData();
            DataTable tb = skilldata.ListSkill(userRole, "Contractor", userLogin);
            return tb;
        }

        public static DataTable InsertSkill(string userRole, string roleData, string userLogin, Skill skill)
        {
            ISkillData skilldata = new SkillData();
            //skilldata.IsActive = false;
            DataTable tb = skilldata.InsertSkill(userRole, roleData, userLogin, skill.Entity(skill));
            return tb;
        }

        //public static void InsertSkill(Skill skill)
        //{
        //    ISkillData skilldata = new SkillData();
        //    skilldata.Insert(skill.Entity(skill));
        //}
    }
}
