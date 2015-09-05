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
    public class SkillData : DB, ISkillData
    {
        public DataTable InsertSkill(string userRole, string roleData, string userLogin, ISkillEntity skill)
        {
            DB obj = new DB();

            String storedProcName = "[usp_InsertSkill]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
	                                    new SqlParameter("@SkillType", skill.SkillType),
	                                    new SqlParameter("@IsActive", skill.IsActive)                           
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;
        }

        public DataTable ListSkill(string userRole, string roleData, string userLogin)
        {
            DB obj = new DB();


            String storedProcName = "[usp_GetSelectedSkill]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin)
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;
        }

        //public void Insert(ISkillEntity skill)
        //{
        //    ConnectDB("ConnectionString");
        //    string queryString = "Insert into Skill([skill_type], [isactive]) values ('" +
        //              skill.SkillType + "','" +
        //              skill.IsActive + "')";


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
