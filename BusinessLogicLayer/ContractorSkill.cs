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
    public class ContractorSkill
    {
        public int ContractorID { get; set; }

        public string SkillType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SkillID { get; set; }

        public ContractorSkill()
        {
        }

        public ContractorSkillEntity Entity(ContractorSkill contractorskill)
        {
            ContractorSkillEntity entity = new ContractorSkillEntity();
            entity.ContractorID = contractorskill.ContractorID;
            entity.SkillType = contractorskill.SkillType;
            entity.FirstName = contractorskill.FirstName;
            entity.LastName = contractorskill.LastName;
            entity.SkillID = contractorskill.SkillID;
            
            return entity;
        }

        public static DataTable ListContractorSkill(string userRole, string userLogin, int contractorId)
        {
            IContractorSkillData contractorskilldata = new ContractorSkillData();
            DataTable tb = contractorskilldata.ListContractorSkill(userRole, "Contractor", userLogin, contractorId);
            return tb;
        }

        public static DataTable InsertContractorSkill(string userRole, string roleData, string userLogin, ContractorSkill contractorskill)
        {
            IContractorSkillData contractorskilldata = new ContractorSkillData();
            DataTable tb = contractorskilldata.InsertContractorSkill(userRole, roleData, userLogin, contractorskill.Entity(contractorskill));
            return tb;
        }

        //public static void Insert(ContractorSkill contractorskill)
        //{
        //    IContractorSkillData contractorskilldata = new ContractorSkillData();
        //    contractorskilldata.Insert(contractorskill.Entity(contractorskill));
        //}
    }
}
