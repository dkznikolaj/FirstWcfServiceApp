using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FirstWcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //[ServiceContract]
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// Gets name
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetMyName();

        /// <summary>
        /// Gets Address
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetMyAddress();

        /// <summary>
        /// Gets Email
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        string GetMyEmail();

    }
}

