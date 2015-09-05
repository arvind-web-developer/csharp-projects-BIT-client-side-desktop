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
    public class Request
    {
        public int RequestContractorID { get; set; }

        public int RequestClientID { get; set; }

        public int RequestJobID { get; set; }

        public DateTime RequestDateRequested { get; set; }

        public DateTime RequestTimeRequested { get; set; }

        public int RequestStatusType { get; set; }

        
        public Request()
        {
        }

        public RequestEntity Entity(Request request)
        {
            RequestEntity entity = new RequestEntity();
            entity.RequestContractorID = request.RequestContractorID;
            entity.RequestClientID = request.RequestClientID;
            entity.RequestJobID = request.RequestJobID;
            entity.RequestDateRequested = request.RequestDateRequested;
            entity.RequestTimeRequested = request.RequestTimeRequested;
            entity.RequestStatusType = request.RequestStatusType;
            return entity;
        }

        public static DataTable ListRequest(string userRole, string userLogin)
        {
            IRequestData requestdata = new RequestData();

            DataTable tb = requestdata.ListRequest(userRole, "Contractor", userLogin);
            return tb;
        }

        public static void Insert(Request request)
        {
            IRequestData requestData = new RequestData();
            requestData.Insert(request.Entity(request));
        }

    }
}
