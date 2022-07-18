using DataBookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBookBlog.Data.Models
{
    class PostCategory
    {
        public int PostCategoryID { get; set; }
        public string PostCategoryName { get; set; }
        public Category Category { get; set; }
        public Post Posts { get; set; }
    }
}
