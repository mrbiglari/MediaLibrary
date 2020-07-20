using MediaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MediaLibrary.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MediaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Media.
            if (context.Media.Any())
            {
                return;   // DB has been seeded
            }




            var books = new List<Book>()
            {
                new Book()
                {
                    Title = "Harry Potter and the Philosopher's Stone",
                    PageCount = 332,
                    ChapterCount = 17,
                    Author = new Artist()
                    {
                        FullName = "J. K. Rowling"
                    },
                    Genre = new List<BookGenreBook>()
                    {
                        new BookGenreBook()
                        {
                            BookGenre = new BookGenre()
                            {
                                Name = "Fantasy"
                            }
                        }
                    }                                            
                    
                }                   
                ,
                new Book()
                {
                    Title = "Beyond Good and Evil",
                    PageCount = 194,
                    ChapterCount = 9,
                    Author = new Artist()
                    {
                        FullName = "Friedrich Nietzsche"
                    },
                    Genre = new List<BookGenreBook>()
                    {
                        new BookGenreBook()
                        {
                            BookGenre = new BookGenre()
                            {
                                Name = "Philosophy"
                            }
                        }
                    }                    
                },
                 new Book()
                {
                    Title = "Doctor Sleep",
                    PageCount = 531,
                    ChapterCount = 25,
                    Author = new Artist()
                    {
                        FullName = "Stephen King"
                    },
                    Genre = new List<BookGenreBook>()
                    {
                        new BookGenreBook()
                        {
                            BookGenre = new BookGenre()
                            {
                                Name = "Horror"
                            }
                        },
                        new BookGenreBook()
                        {
                            BookGenre = new BookGenre()
                            {
                                Name = "Mystery"
                            }
                        }
                    }                   
                }
            };

            context.Books.AddRange(books);

            context.SaveChanges();
        }
    }
}

