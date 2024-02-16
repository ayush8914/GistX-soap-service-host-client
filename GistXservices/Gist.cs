using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices
{
    public class Gist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string fileName { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<GistUser> GistUsers { get; set; }
        public virtual ICollection<Fork> Forks { get; set; }
    }

}
