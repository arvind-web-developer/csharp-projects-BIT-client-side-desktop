using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataAccessLayer
{
    public class DB
    {

        private static SqlConnection _connection;

        public SqlConnection Connection
        {
            get { return _connection; }
        }


        public static void ConnectDB(string connString)
        {

            // Problem with this connection: If any changes within the code, you have to Rebuild the entire solution, otherwise SQLexception or database cannot be loaded
            string conStr = ConfigurationManager.ConnectionStrings[connString].ConnectionString; 
            _connection = new SqlConnection(conStr);
        }

        // Open SQL Connection
        protected void Open()
        {
            if (!(_connection.State == ConnectionState.Open))
            {
                _connection.Open();
            }
        }

        // Close SQL Connection
        protected void Close()
        {
            if (!(_connection.State == ConnectionState.Closed))
            {
                _connection.Close();
            }
        }


        public DataTable getRecords(string sqlString, string connStr)
        {
            //ConnectDB("ConnectionString");
            ConnectDB(connStr);
            try
            {
               _connection.Open(); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            SqlDataAdapter sqlAdap = new SqlDataAdapter(sqlString, _connection);

            DataTable dt = new DataTable();
            sqlAdap.Fill(dt);
            
            return dt;
        }


        public DataTable getSPRecords(string connStr, string storedProcName, SqlParameter[] Param)
        {
            ConnectDB(connStr);   

            try
            {
                SqlCommand sqlCmd = new SqlCommand(storedProcName, _connection);
                

                foreach (SqlParameter p in Param)
                {
                    sqlCmd.Parameters.Add(p);

                }

                sqlCmd.CommandType = CommandType.StoredProcedure;
                _connection.Open();

                DataTable dt = new DataTable();

                SqlDataAdapter sqlAdap = new SqlDataAdapter();
                sqlAdap.SelectCommand = sqlCmd;
                sqlAdap.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }

        }
    }
}
