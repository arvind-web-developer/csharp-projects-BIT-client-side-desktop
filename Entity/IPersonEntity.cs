using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IPersonEntity
    {
        int PersonID { get; set; }

        int PersonType { get; set; }

        string PersonTitle { get; set; }

        string PersonFirstName { get; set; }

        string PersonLastName { get; set; }

        string PersonEmailPrimary { get; set; }

        string PersonEmailAlternate { get; set; }

        string PersonFax { get; set; }

        string PersonPhonePrimary { get; set; }

        string PersonPhoneHome { get; set; }

        string PersonPhoneMobile { get; set; }

        string PersonPhoneWork { get; set; }

        string PersonPhoneEmergency { get; set; }

        string PersonCompanyName { get; set; }

        string PersonPosition { get; set; }

        string PersonDescription { get; set; }

        bool PersonIsActive { get; set; }
    }
}
