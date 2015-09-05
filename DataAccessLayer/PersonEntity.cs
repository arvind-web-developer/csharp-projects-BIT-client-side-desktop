using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer
{
    public class PersonEntity : Entity.IPersonEntity
    {
        public int PersonID { get; set; }

        public int PersonType { get; set; }

        public string PersonTitle { get; set; }

        public string PersonFirstName { get; set; }

        public string PersonLastName { get; set; }

        public string PersonEmailPrimary { get; set; }

        public string PersonEmailAlternate { get; set; }

        public string PersonFax { get; set; }

        public string PersonPhonePrimary { get; set; }

        public string PersonPhoneHome { get; set; }

        public string PersonPhoneMobile { get; set; }

        public string PersonPhoneWork { get; set; }

        public string PersonPhoneEmergency { get; set; }

        public string PersonCompanyName { get; set; }

        public string PersonPosition { get; set; }

        public string PersonDescription { get; set; }

        public bool PersonIsActive { get; set; }

    }
}
