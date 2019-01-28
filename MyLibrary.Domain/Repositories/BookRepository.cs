namespace MyLibrary.Domain.Integration.Tests
{
    internal class BookRepository : IBookRepository
    {
        private string cONNECTIONSTRING;
        private string dATABASE_NAME;

        public BookRepository(string cONNECTIONSTRING, string dATABASE_NAME)
        {
            this.cONNECTIONSTRING = cONNECTIONSTRING;
            this.dATABASE_NAME = dATABASE_NAME;
        }
    }
}