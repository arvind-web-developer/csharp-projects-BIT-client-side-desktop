using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IRequestEntity
    {
        int RequestContractorID { get; set; }

        int RequestClientID { get; set; }

        int RequestJobID { get; set; }

        DateTime RequestDateRequested { get; set; }

        DateTime RequestTimeRequested { get; set; }

        int RequestStatusType { get; set; }
    }
}
