using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBookBlog.Data.Models
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
