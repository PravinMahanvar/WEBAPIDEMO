using WEBAPIDEMO.MODEL;

namespace WEBAPIDEMO.SERVICES
{
    public class BookServices : IBookServices
    {
        //need to inject repository as its dependency
        private readonly IBookRepository repo;

        public BookService(IBookRepository repo)
        {
            this.repo = repo;
        }
        public int AddBook(Book book)
        {
            return repo.AddBook(book);
        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            return repo.GetBookById(id);

        }

        public IEnumerable<Book> GetBooks()
        {
            return repo.GetBooks();
        }

        public int UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}

