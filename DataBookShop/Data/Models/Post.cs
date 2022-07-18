using DataBookBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBookShop.Data.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ICollection<PostCategory>PostCategory{ get; set; }
        public ApplicationUser Author { get; set; }
    }
}
