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
    public class Contractor
    {
        public int ContractorID { get; set; }

        public string ContractorTitle { get; set; }

        public string ContractorFirstName { get; set; }

        public string ContractorLastName { get; set; }

        public string ContractorEmailPrimary { get; set; }

        public string ContractorEmailAlternate { get; set; }

        public string ContractorFax { get; set; }

        public string ContractorPhonePrimary { get; set; }

        public string ContractorPhoneHome { get; set; }

        public string ContractorPhoneMobile { get; set; }

        public string ContractorPhoneWork { get; set; }

        public string ContractorPhoneEmergency { get; set; }

        public string ContractorCompanyName { get; set; }

        public string ContractorPosition { get; set; }

        public string ContractorDescription { get; set; }

        public bool ContractorIsActive { get; set; }


        public Contractor()
        {
        }

        public PersonEntity Entity(Contractor contractor)
        {
            PersonEntity entity = new PersonEntity();
            entity.PersonID = contractor.ContractorID;
            entity.PersonType = 2;   // "Contractor"
            entity.PersonTitle = contractor.ContractorTitle;
            entity.PersonFirstName = contractor.ContractorFirstName;
            entity.PersonLastName = contractor.ContractorLastName;
            entity.PersonEmailPrimary = contractor.ContractorEmailPrimary;
            entity.PersonEmailAlternate = contractor.ContractorEmailAlternate;
            entity.PersonFax = contractor.ContractorFax;
            entity.PersonPhonePrimary = contractor.ContractorPhonePrimary;
            entity.PersonPhoneHome = contractor.ContractorPhoneHome;
            entity.PersonPhoneMobile = contractor.ContractorPhoneMobile;
            entity.PersonPhoneWork = contractor.ContractorPhoneWork;
            entity.PersonPhoneEmergency = contractor.ContractorPhoneEmergency;
            entity.PersonCompanyName = contractor.ContractorCompanyName;
            entity.PersonPosition = contractor.ContractorPosition;
            entity.PersonDescription = contractor.ContractorDescription;
            entity.PersonIsActive = contractor.ContractorIsActive;
            return entity;
        }

        public static DataTable ListContractor(string userRole, string userLogin)
        {
            IPersonData contractordata = new PersonData();
            DataTable tb = contractordata.ListPerson(userRole, "Contractor", userLogin);
            return tb;
        }

        public static DataTable InsertContractor(string userRole, string userLogin, Contractor contractor)
        {
            IPersonData contractorData = new PersonData();
            contractor.ContractorIsActive = false;
            DataTable tb = contractorData.InsertPerson(userRole, "Contractor", userLogin, contractor.Entity(contractor));
            return tb;
        }

        public static DataTable ApproveContractor(string userRole, string userLogin, Contractor contractor)
        {
            IPersonData contractorData = new PersonData();
            contractor.ContractorIsActive = true;
            DataTable tb = contractorData.ApprovePerson(userRole, "Contractor", userLogin, contractor.Entity(contractor));
            return tb;
        }

        public static DataTable UpdateContractor(string userRole, string userLogin, Contractor contractor)
        {
            IPersonData contractorData = new PersonData();
            contractor.ContractorIsActive = false;
            DataTable tb = contractorData.UpdatePerson(userRole, "Contractor", userLogin, contractor.Entity(contractor));
            return tb;
        }
    }
}
