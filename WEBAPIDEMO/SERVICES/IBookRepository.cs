using WEBAPIDEMO.MODEL;

namespace WEBAPIDEMO.SERVICES
{
    internal interface IBookRepository
    {
        int AddBook(Book book);
    }
}