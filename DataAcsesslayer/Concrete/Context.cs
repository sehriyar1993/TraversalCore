using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesslayer.Concrete
{
    public class Context: IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database= TraversalDb1; integrated security=true; TrustServerCertificate=True; "); ;
        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<Contact>?   Contacts { get; set; }
        public DbSet<ContactUs>?   ContactUss { get; set; }
        public DbSet<Destination>? Destinations { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<FeatureTwo>? Feature2s { get; set; }
        public DbSet<Guide>? Guides { get; set; }
        public DbSet<Newsletter>? Newsletters { get; set; }
        public DbSet<SubAbout>? SubAbouts { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<Commentler>? Commentlers { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }
        public DbSet<Announcement>? Announcements { get; set; }
        public DbSet<Account>? Accounts { get; set; }


    }
}
