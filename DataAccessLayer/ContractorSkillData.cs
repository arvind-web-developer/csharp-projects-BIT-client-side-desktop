using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using Entity;


namespace DataAccessLayer
{
    public class ContractorSkillData : DB, IContractorSkillData
    {
        public DataTable ListContractorSkill(string userRole, string roleData, string userLogin, int contractorId)
        {
            DB obj = new DB();

            
            String storedProcName = "[usp_GetSelectedContractorSkill]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),
                                        new SqlParameter("@ContractorId", contractorId)
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;
        }

        public DataTable InsertContractorSkill(string userRole, string roleData, string userLogin, IContractorSkillEntity contractorskill)
        {
            DB obj = new DB();

            String storedProcName = "[usp_InsertContractorSkill]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
	                                    new SqlParameter("@ContractorId", contractorskill.ContractorID),
	                                    new SqlParameter("@SkillId", contractorskill.SkillID)                        
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;
        }

        //public void Insert(IContractorSkillEntity contractorskill)
        //{
        //    ConnectDB("ConnectionString");
        //    string queryString = "Insert into ContractorSkill([contractor_person_ref], [skill_ref]) values ('" +
        //              contractorskill.ContractorID + "','" +
        //              contractorskill.SkillID + "')";


        //    SqlCommand sqlcmd = new SqlCommand(queryString, Connection);

        //    sqlcmd.Connection.Open();
        //    sqlcmd.ExecuteNonQuery();
        //    sqlcmd.Connection.Close();


        //}

        public void Update()
        {
        }

        public void Delete()
        {
        }

       
    }
}
