using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace GaphQLIntro
{
    public class Query
    {
        public List<Book> GetBooks([Service] BookDbContext dbContext) => dbContext.Books.Include(x => x.Author).ToList();

        public Book GetBook([Service] BookDbContext dbContext, int id) => dbContext.Books.FirstOrDefault(x => x.Id == id);
    }
}
