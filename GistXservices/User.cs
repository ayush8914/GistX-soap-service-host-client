using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices 
{
    [DataContract]
    public class User
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public DateTime? UpdatedAt { get; set; }

        [DataMember]
        public virtual ICollection<GistUser> GistUsers { get; set; }

        [DataMember]
        public virtual ICollection<Fork> Forks { get; set; }


    }
}
