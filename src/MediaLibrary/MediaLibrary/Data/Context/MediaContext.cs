using MediaLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Data
{
    public class MediaContext : DbContext
    {
        public MediaContext(DbContextOptions<MediaContext> options)
            : base(options)
        {
        }

        public DbSet<Media> Media { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Music> Music { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Media>()
            //.HasRequired(c => c.)
            //.WithMany()
            //.WillCascadeOnDelete(false);

            //modelBuilder.Entity<Book>()
            //   .HasMany<BookGenre>(s => s.Genre)
            //   .WithMany(c => c.Books)
            //   .Map(cs =>
            //   {
            //       cs.MapLeftKey("StudentRefId");
            //       cs.MapRightKey("CourseRefId");
            //       cs.ToTable("StudentCourse");
            //   });

            modelBuilder.Entity<BookGenreBook>()
       .HasKey(bc => new { bc.BookId, bc.BookGenreId });
            modelBuilder.Entity<BookGenreBook>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.Genre)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookGenreBook>()
                .HasOne(bc => bc.BookGenre)
                .WithMany(c => c.Books)
                .HasForeignKey(bc => bc.BookGenreId);
        }
    }
}
