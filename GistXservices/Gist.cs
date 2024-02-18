using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices
{
    [DataContract]
    [KnownType(typeof(List<Gist>))]
    [KnownType(typeof(Gist))]
    public class Gist
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public DateTime? UpdatedAt { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public virtual User User { get; set; }

        [DataMember]
        public virtual ICollection<GistUser> GistUsers { get; set; }

        [DataMember]
        public virtual ICollection<Fork> Forks { get; set; }
    }

}
