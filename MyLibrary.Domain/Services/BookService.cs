namespace MyLibrary.Domain.Services
{
    public class BookService:IBookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public object GetBooks()
        {
            throw new System.NotImplementedException();
        }
    }
}
