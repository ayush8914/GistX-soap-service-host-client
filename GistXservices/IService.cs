using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        ResponseContract Register(string username, string email,string password);
        
        [OperationContract]
        ResponseContract Login(string email, string password);
    }

    [DataContract]
    public class ResponseContract
    {
        [DataMember(Order =1)]
        public int status;

        [DataMember(Order =2)]
        public string message;

        [DataMember(Order =3)]
        public int id;

    }
}
