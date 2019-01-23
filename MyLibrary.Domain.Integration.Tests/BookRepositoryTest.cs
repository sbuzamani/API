using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary.Domain.Entities;

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

        }
        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        public void GetAll_ReturnsAllBooks()
        {
            var result = _bookRepository.GetAll();
            Assert.AreNotEqual(null, result);
        }
        [TestMethod]
        public void GetOne_ReturnsBookByTitle()
        {
            var result = _bookRepository.GetOne("Title");
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Insert_AddsBook()
        {
            var book = new Book
            {
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
        public void Update_UpdatesBook()
        {
            var book = new Book
            {
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
