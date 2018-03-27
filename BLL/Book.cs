using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Book
    {
        //public Book()
        //{
        //    Books 
        //}

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
