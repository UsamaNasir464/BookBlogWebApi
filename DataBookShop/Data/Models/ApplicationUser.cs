using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBookShop.Data.Models
{
    public class ApplicationUser
    {
        public int AuthorId { get; set; }
        public string  AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string AuthorAddress { get; set; }
        public int PhoneNumber { get; set; }

    } 
}
