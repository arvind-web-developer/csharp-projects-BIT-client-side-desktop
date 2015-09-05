using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer
{
    public class RequestEntity : Entity.IRequestEntity
    {
        public int RequestContractorID { get; set; }

        public int RequestClientID { get; set; }

        public int RequestJobID { get; set; }

        public DateTime RequestDateRequested { get; set; }

        public DateTime RequestTimeRequested { get; set; }

        public int RequestStatusType { get; set; }
    }
}
