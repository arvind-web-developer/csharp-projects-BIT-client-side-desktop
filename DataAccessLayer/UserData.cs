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
    public class UserData : DB, IUserData
    {
        public DataTable getUser(IUserEntity user)
        {
            DB obj = new DB();

            string queryString = "SELECT     r.RoleName, u.* " +
                                                        "FROM       Users u, UsersToRoles s, Roles r " +
                                                         "WHERE     u.UserID = s.FKUserID " +
                                                         "AND       s.FKRoleID = r.RoleID " +
                                                         "AND " +
                                                                    "Name='"
                                                                    + user.UserName +
                                                                    "' and password='"
                                                                    + user.Password +
                                                                    "'and IsApproved ='"
                                                                    + true +
                                                                    "'and IsLockedOut ='"
                                                                    + false +
                                                                          "'";

            return obj.getRecords(queryString, "SecurityConnectionString");

        }

        public DataTable getSPUser(IUserEntity user)
        {
            DB obj = new DB();

            string storedProcName = "[usp_ValidateUser]";


            //List of parameter required
            SqlParameter[] param = { 
                                     new SqlParameter("@Username", user.UserName),
                                     new SqlParameter("@Password", user.Password)       
                                   };

            DataTable dt = obj.getSPRecords("SecurityConnectionString", storedProcName, param);

            return dt;
        }

        public DataTable InsertUser(string userRole, string roleData, string userLogin, IUserEntity user)
        {
            DB obj = new DB();

            String storedProcName = "[usp_InsertUser]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
	                                    new SqlParameter("@UserName", user.UserName),
	                                    new SqlParameter("@Password", user.Password),
	                                    new SqlParameter("@Email", user.Email),
	                                    new SqlParameter("@IsApproved", user.IsApproved),
	                                    new SqlParameter("@IsLockedOut", user.IsLockedOut)	                                    
                                    };

            DataTable dt = obj.getSPRecords("SecurityConnectionString", storedProcName, param);

            return dt;
        }

        public DataTable DeactivateUser(string userRole, string roleData, string userLogin, IUserEntity user)
        {
            DB obj = new DB();

            String storedProcName = "[usp_DeactivateUser]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
	                                    new SqlParameter("@Name", user.UserName)                            
                                    };

            DataTable dt = obj.getSPRecords("SecurityConnectionString", storedProcName, param);

            return dt;
        }

        //public void Update()
        //{
        //}

        //public void Delete()
        //{
        //}
    }
}
