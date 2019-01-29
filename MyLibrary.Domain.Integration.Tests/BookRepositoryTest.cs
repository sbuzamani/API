using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MyLibrary.Domain.Integration.Tests
{
    [TestClass]
    public class BookRepositoryTest
    {
        private const string CONNECTIONSTRING = "lalala";

        private const string DATABASE_NAME = "";
        private IBookRepository _bookRepository;
        [TestInitialize]
        public void setup()
        {
            _bookRepository = new BookRepository(CONNECTIONSTRING, DATABASE_NAME);
        }
        [TestCleanup]
        public void Cleanup()
        {
            _bookRepository.DeleteAll();
            _bookRepository = null;
        }

        [TestMethod]
        public void GetAll_BooksExist_ReturnsAllBooks()
        {
            IList<Book> bookList = _bookRepository.GetAll();
            Assert.IsNotNull(bookList);
        }
        [TestMethod]
        public void GetOne_ValidID_ReturnsBookByTitle()
        {
            Book result = _bookRepository.GetOneById(new Guid());
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Insert_ValidBookObject_AddsBook()
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = "Test Title",
                Isbn = "18179770799",
                rating = 4,
                Review = "A great book on nothing",
                Genre = "Philosphy",
                Status = "home"
            };
            _bookRepository.Insert(book);
            var result = _bookRepository.GetOne(book.Title);
            Assert.IsNotNull(result);
        }
        public void Update_ValidBookFields_UpdatesBook()
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = "Test Title",
                Isbn = "18179770799",
                rating = 4,
                Review = "A great book on nothing",
                Genre = "Philosphy",
                Status = "home"
            };
            _bookRepository.Insert(book);
            book.Title = "Wrong Test Title";
            book.rating = 5;

            _bookRepository.Update(book);
            var updatedBook = _bookRepository.GetOne(book.Title);
            Assert.AreEqual(book.Title, updatedBook.Title);
        }
    }
}
