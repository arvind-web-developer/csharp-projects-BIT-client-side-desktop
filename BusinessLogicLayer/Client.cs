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
    public class Client
    {
        public int ClientID { get; set; }

        public string ClientTitle { get; set; }

        public string ClientFirstName { get; set; }

        public string ClientLastName { get; set; }

        public string ClientEmailPrimary { get; set; }

        public string ClientEmailAlternate { get; set; }

        public string ClientFax { get; set; }

        public string ClientPhonePrimary { get; set; }

        public string ClientPhoneHome { get; set; }

        public string ClientPhoneMobile { get; set; }

        public string ClientPhoneWork { get; set; }

        public string ClientPhoneEmergency { get; set; }

        public string ClientCompanyName { get; set; }

        public string ClientPosition { get; set; }

        public string ClientDescription { get; set; }

        public bool ClientIsActive { get; set; }

        public Client()
        {
        }

        public PersonEntity Entity(Client client)
        {
            PersonEntity entity = new PersonEntity();
            entity.PersonID = client.ClientID;
            entity.PersonType = 1;      // "Client"
            entity.PersonTitle = client.ClientTitle;
            entity.PersonFirstName = client.ClientFirstName;
            entity.PersonLastName = client.ClientLastName;
            entity.PersonEmailPrimary = client.ClientEmailPrimary;
            entity.PersonEmailAlternate = client.ClientEmailAlternate;
            entity.PersonFax = client.ClientFax;
            entity.PersonPhonePrimary = client.ClientPhonePrimary;
            entity.PersonPhoneHome = client.ClientPhoneHome;
            entity.PersonPhoneMobile = client.ClientPhoneMobile;
            entity.PersonPhoneWork = client.ClientPhoneWork;
            entity.PersonPhoneEmergency = client.ClientPhoneEmergency;
            entity.PersonCompanyName = client.ClientCompanyName;
            entity.PersonPosition = client.ClientPosition;
            entity.PersonDescription = client.ClientDescription;
            entity.PersonIsActive = client.ClientIsActive;
            return entity;
        }

        public static DataTable ListClient(string userRole, string userLogin)
        {
            IPersonData clientdata = new PersonData();
            DataTable tb = clientdata.ListPerson(userRole, "Client", userLogin);
            return tb;
        }

        public static DataTable InsertClient(string userRole, string userLogin, Client client)
        {
            IPersonData clientData = new PersonData();
            client.ClientIsActive = false;
            DataTable tb = clientData.InsertPerson(userRole, "Client", userLogin, client.Entity(client));        
            return tb;
        }

        public static DataTable ApproveClient(string userRole, string userLogin, Client client)
        {
            IPersonData clientData = new PersonData();
            client.ClientIsActive = true;
            DataTable tb = clientData.ApprovePerson(userRole, "Client", userLogin, client.Entity(client));
            return tb;
        }

        public static DataTable UpdateClient(string userRole, string userLogin, Client client)
        {
            IPersonData clientData = new PersonData();
            DataTable tb = clientData.UpdatePerson(userRole, "Client", userLogin, client.Entity(client));
            return tb;
        }
    }
}
