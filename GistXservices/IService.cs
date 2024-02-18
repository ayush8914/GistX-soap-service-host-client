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

    [ServiceContract]
    public interface IGistService
    {
        //create gist
        [OperationContract]
        ResponseContract CreateGist(string title, string content, int userId);

        [OperationContract]
        ResponseContract UpdateGist(int id, string title, string content);

        [OperationContract]
        ResponseContract DeleteGist(int id);

        [OperationContract]
        GistMessage GetGist(int id);

        [OperationContract]
        List<Gist> GetGists(int userId);

        [OperationContract]
        ResponseContract ForkGist(int gistId, int userId);

        [OperationContract]
        List<Gist> GetForks(int gistId);

        [OperationContract]
        ResponseContract AddUserToGist(int gistId, int userId);

        [OperationContract]
        ResponseContract RemoveUserFromGist(int gistId, int userId);

        [OperationContract]
        List<User> GetGistUsers(int gistId);
    }


    [DataContract]
    public class GistMessage
    {
        [DataMember(Order = 1)]
        public int Id;

        [DataMember(Order = 2)]
        public string Title;

        [DataMember(Order = 3)]
        public string Content;
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
