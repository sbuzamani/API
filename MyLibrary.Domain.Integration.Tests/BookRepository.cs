using System.Collections.Generic;
using MyLibrary.Domain.Entities;
namespace MyLibrary.Domain

{
    public class BookRepository : IBookRepository
    {
        private string cONNECTIONSTRING;
        private string dATABASE_NAME;

        public BookRepository(string cONNECTIONSTRING, string dATABASE_NAME)
        {
            this.cONNECTIONSTRING = cONNECTIONSTRING;
            this.dATABASE_NAME = dATABASE_NAME;
        }

        public void DeleteAll()
        {
            throw new System.NotImplementedException();
        }

        public IList<Book> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Book GetOne(string v)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}