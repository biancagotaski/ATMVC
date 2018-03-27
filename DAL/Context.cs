using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public Context()
            : base("")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithMany()
                .Map(x =>
                {
                    x.MapLeftKey("AuthorId");
                    x.MapLeftKey("BookId");
                    x.ToTable("AuthorBook");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
