using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Post
    {
        public int id { get; set; }
        public string content { get; set; }
        public List<Comments> comments { get; set; }
    }
}
