﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GistXservices
{
    public class Fork
    {
        public int Id { get; set; }
        public int GistId { get; set; }
        public virtual Gist Gist { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
