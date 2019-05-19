using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebPage.Models
{
    public class WebPageContext : DbContext
    {
        public WebPageContext (DbContextOptions<WebPageContext> options)
            : base(options)
        {
        }

        public DbSet<WebPage.Models.Movie> Movie { get; set; }
    }
}
