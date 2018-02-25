using System;
using System.Collections.Generic;

namespace DomainDAL.Objects
{
    public class Category
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual string Description { get; set; }
        
        public virtual IList<Post> Posts { get; set; }
    }
}