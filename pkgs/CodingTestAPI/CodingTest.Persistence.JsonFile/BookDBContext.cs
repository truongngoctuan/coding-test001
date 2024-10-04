using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Persistence.JsonFile
{
    public class BookDBContext: DbContext
    {
        public DbSet<Entities.Book> Books { get; set; }
        public DbSet<Entities.Author> Authors { get; set; }
    }
}
