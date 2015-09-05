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
    public class Coordinator
    {
        public int CoordinatorID { get; set; }

        public string CoordinatorTitle { get; set; }

        public string CoordinatorFirstName { get; set; }

        public string CoordinatorLastName { get; set; }

        public string CoordinatorEmailPrimary { get; set; }

        public string CoordinatorEmailAlternate { get; set; }

        public string CoordinatorFax { get; set; }

        public string CoordinatorPhonePrimary { get; set; }

        public string CoordinatorPhoneHome { get; set; }

        public string CoordinatorPhoneMobile { get; set; }

        public string CoordinatorPhoneWork { get; set; }

        public string CoordinatorPhoneEmergency { get; set; }

        public string CoordinatorCompanyName { get; set; }

        public string CoordinatorPosition { get; set; }

        public string CoordinatorDescription { get; set; }

        public bool CoordinatorIsActive { get; set; }


        public Coordinator()
        {
        }

        public PersonEntity Entity(Coordinator coordinator)
        {
            PersonEntity entity = new PersonEntity();
            entity.PersonID = coordinator.CoordinatorID;
            entity.PersonType = 3;      // "Coordinator"
            entity.PersonTitle = coordinator.CoordinatorTitle;
            entity.PersonFirstName = coordinator.CoordinatorFirstName;
            entity.PersonLastName = coordinator.CoordinatorLastName;
            entity.PersonEmailPrimary = coordinator.CoordinatorEmailPrimary;
            entity.PersonEmailAlternate = coordinator.CoordinatorEmailAlternate;
            entity.PersonFax = coordinator.CoordinatorFax;
            entity.PersonPhonePrimary = coordinator.CoordinatorPhonePrimary;
            entity.PersonPhoneHome = coordinator.CoordinatorPhoneHome;
            entity.PersonPhoneMobile = coordinator.CoordinatorPhoneMobile;
            entity.PersonPhoneWork = coordinator.CoordinatorPhoneWork;
            entity.PersonPhoneEmergency = coordinator.CoordinatorPhoneEmergency;
            entity.PersonCompanyName = coordinator.CoordinatorCompanyName;
            entity.PersonPosition = coordinator.CoordinatorPosition;
            entity.PersonDescription = coordinator.CoordinatorDescription;
            entity.PersonIsActive = coordinator.CoordinatorIsActive;
            return entity;
        }

        public static DataTable ListCoordinator(string userRole, string userLogin)
        {
            IPersonData coordinatordata = new PersonData();
            DataTable tb = coordinatordata.ListPerson(userRole, "Coordinator", userLogin);
      
            return tb;
        }

        public static DataTable InsertCoordinator(string userRole, string userLogin, Coordinator coordinator)
        {
            IPersonData coordinatorData = new PersonData();
            coordinator.CoordinatorIsActive = false;
            DataTable tb = coordinatorData.InsertPerson(userRole, "Coordinator", userLogin, coordinator.Entity(coordinator));
            return tb;
        }

        public static DataTable ApproveCoordinator(string userRole, string userLogin, Coordinator coordinator)
        {
            IPersonData coordinatorData = new PersonData();
            coordinator.CoordinatorIsActive = true;
            DataTable tb = coordinatorData.ApprovePerson(userRole, "Coordinator", userLogin, coordinator.Entity(coordinator));
            return tb;
        }

        public static DataTable UpdateCoordinator(string userRole, string userLogin, Coordinator coordinator)
        {
            IPersonData coordinatorData = new PersonData();
            coordinator.CoordinatorIsActive = false;
            DataTable tb = coordinatorData.UpdatePerson(userRole, "Coordinator", userLogin, coordinator.Entity(coordinator));
            return tb;
        }
    }
}
