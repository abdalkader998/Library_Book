using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class WebApplication6Context : DbContext
    {
        

        public DbSet<WebApplication6.Models.Author> Author { get; set; } = default!;

        public DbSet<WebApplication6.Models.Book> Book { get; set; } = default!;
        public WebApplication6Context(DbContextOptions<WebApplication6Context> options) : base(options)
        {
        }
    }
}
