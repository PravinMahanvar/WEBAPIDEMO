using WEBAPIDEMO.MODEL;

namespace WEBAPIDEMO.REPOSITOR
{
    public interface IBookRespository
    {

        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        int AddBook(Book book);
        int updateBook(Book book);
        int DeleteBook(int id);

    }
}
