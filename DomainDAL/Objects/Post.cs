using System;
using System.Collections.Generic;
using System.Text;

namespace DomainDAL.Objects
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public virtual string Description { get; set; }

        public virtual string Meta { get; set; }

        public virtual string  UrlSlug { get; set; }

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOnDateTime { get; set; }

        public virtual DateTime? ModifiedDateTime { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public IList<Tag> Tags { get; set; }
    }
    
}
