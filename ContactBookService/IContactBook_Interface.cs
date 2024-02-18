using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactBookService
{
    [ServiceContract]
    public interface IContactBook_Interface
    {
        [OperationContract]
        string PERFORM_ACTIONS(string ACTION_REQUEST);

        // TODO: Add your service operations here
    }
}
