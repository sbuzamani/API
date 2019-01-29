using System;
using System.Collections.Generic;
using System.Text;
using MyLibrary.Domain.Entities;

namespace MyLibrary.Domain
{
    public interface IBookRepository
    {
        IList<Book> GetAll();
        Book GetOne(string v);
        void Insert(Book book);
        void Update(Book book);
        void DeleteAll();
        Book GetOneById(Guid guid);
    }
}
