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

    public class PersonData : DB, IPersonData
    {
        public DataTable ApprovePerson(string userRole, string roleData, string userLogin, IPersonEntity person)
        {
            DB obj = new DB();

            String storedProcName = "[usp_ApprovePerson]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
	                                    new SqlParameter("@PersonID", person.PersonID),
	                                    new SqlParameter("@IsActive", person.PersonIsActive)
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;

        }

        public DataTable InsertPerson(string userRole, string roleData, string userLogin, IPersonEntity person)
        {
            //ConnectDB("ConnectionString");
            //string queryString = "Insert into Person([person_type_ref], [title], [firstname], [lastname], [emailprimary], [emailalternate], [fax], [phoneprimary], [phonehome], [phonemobile], [phonework], [phoneemergency], [companyname], [position], [description]) values ('" +
            //        person.PersonType + "','" +
            //          person.PersonTitle + "','" +
            //          person.PersonFirstName + "','" +
            //          person.PersonLastName + "','" +
            //          person.PersonEmailPrimary + "','" +
            //          person.PersonEmailAlternate + "','" +
            //          person.PersonFax + "','" +
            //          person.PersonPhonePrimary + "','" +
            //          person.PersonPhoneHome + "','" +
            //          person.PersonPhoneMobile + "','" +
            //          person.PersonPhoneWork + "','" +
            //          person.PersonPhoneEmergency + "','" +
            //          person.PersonCompanyName + "','" +
            //          person.PersonPosition + "','" +
            //          person.PersonDescription + "')";


            //SqlCommand sqlcmd = new SqlCommand(queryString, Connection);

            //sqlcmd.Connection.Open();
            //sqlcmd.ExecuteNonQuery();
            //sqlcmd.Connection.Close();


            DB obj = new DB();

            String storedProcName = "[usp_InsertPerson]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
	                                    new SqlParameter("@PersonType", person.PersonType),
	                                    new SqlParameter("@PersonTitle", person.PersonTitle),
	                                    new SqlParameter("@PersonFirstName", person.PersonFirstName),
	                                    new SqlParameter("@PersonLastName", person.PersonLastName),
	                                    new SqlParameter("@PersonEmailPrimary", person.PersonEmailPrimary),
	                                    new SqlParameter("@PersonEmailAlternate", person.PersonEmailAlternate),
	                                    new SqlParameter("@PersonFax", person.PersonFax),
	                                    new SqlParameter("@PersonPhonePrimary", person.PersonPhonePrimary),
	                                    new SqlParameter("@PersonPhoneHome", person.PersonPhoneHome),
	                                    new SqlParameter("@PersonPhoneMobile", person.PersonPhoneMobile),
	                                    new SqlParameter("@PersonPhoneWork", person.PersonPhoneWork),
	                                    new SqlParameter("@PersonPhoneEmergency", person.PersonPhoneEmergency),
	                                    new SqlParameter("@PersonCompanyName", person.PersonCompanyName),
	                                    new SqlParameter("@PersonPosition", person.PersonPosition),
	                                    new SqlParameter("@PersonDescription", person.PersonDescription),
	                                    new SqlParameter("@IsActive", person.PersonIsActive)
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;

        }

        public DataTable UpdatePerson(string userRole, string roleData, string userLogin, IPersonEntity person)
        {
            DB obj = new DB();

            String storedProcName = "[usp_UpdatePerson]";

            //List of parameter required
            SqlParameter[] param = { 
                                        new SqlParameter("@UserRole", userRole),                                       
                                        new SqlParameter("@RoleData", roleData),
                                        new SqlParameter("@UserLogin", userLogin),   
                                        new SqlParameter("@PersonID", person.PersonID),
	                                    //new SqlParameter("@PersonType", person.PersonType),
	                                    //new SqlParameter("@PersonTitle", person.PersonTitle),
	                                    new SqlParameter("@PersonFirstName", person.PersonFirstName),
	                                    new SqlParameter("@PersonLastName", person.PersonLastName),
	                                    //new SqlParameter("@PersonEmailPrimary", person.PersonEmailPrimary),
	                                    //new SqlParameter("@PersonEmailAlternate", person.PersonEmailAlternate),
	                                    //new SqlParameter("@PersonFax", person.PersonFax),
	                                    new SqlParameter("@PersonPhonePrimary", person.PersonPhonePrimary),
	                                    //new SqlParameter("@PersonPhoneHome", person.PersonPhoneHome),
	                                    new SqlParameter("@PersonPhoneMobile", person.PersonPhoneMobile),
	                                    //new SqlParameter("@PersonPhoneWork", person.PersonPhoneWork),
	                                    //new SqlParameter("@PersonPhoneEmergency", person.PersonPhoneEmergency),
	                                    //new SqlParameter("@PersonCompanyName", person.PersonCompanyName),
	                                    //new SqlParameter("@PersonPosition", person.PersonPosition),
	                                    //new SqlParameter("@PersonDescription", person.PersonDescription),
	                                    //new SqlParameter("@IsActive", person.PersonIsActive)
                                    };

            DataTable dt = obj.getSPRecords("ConnectionString", storedProcName, param);

            return dt;

        }

        public void Delete()
        {
        }

        public DataTable ListPerson(string userRole, string roleData, string userLogin)
        {
            DB obj = new DB();

            //string queryString = "SELECT title, firstname, lastname, emailprimary, emailalternate, fax, phoneprimary, phonehome, phonemobile, phonework, phoneemergency, companyname, position, description FROM person where person_type_ref = 1";
            //return obj.getRecords(queryString, "ConnectionString");


        
            String storedProcName = "[usp_GetSelectedPerson]";

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