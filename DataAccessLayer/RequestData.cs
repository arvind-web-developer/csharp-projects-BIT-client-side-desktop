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

    public class RequestData : DB, IRequestData
    {
        public void Insert(IRequestEntity request)
        {
            ConnectDB("ConnectionString");
            string queryString = "Insert into Request([contractor_person_ref], [client_person_ref], [job_ref], [date_requested], [time_requested], [status_type]) values ('" +
                //request.RequestType + "','" +
                      request.RequestContractorID + "','" +
                      request.RequestClientID + "','" +
                      request.RequestJobID + "','" +
                      request.RequestDateRequested + "','" +
                      request.RequestTimeRequested + "','" +
                      request.RequestStatusType + "')";


            SqlCommand sqlcmd = new SqlCommand(queryString, Connection);

            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();


        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

        public DataTable ListRequest(string userRole, string roleData, string userLogin)
        {
            DB obj = new DB();

            //string queryString = "";
            //return obj.getRecords(queryString, "ConnectionString");


            //String storedProcName = "[usp_GetRequest]";
            String storedProcName = "[usp_GetSelectedRequest]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin)
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;
        }

    }
}