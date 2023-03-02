using Entites.DataTransferObjects;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAllBooks(bool trackChanges);
        Book GetBook(int id, bool trackChanges);
        Book Create(Book book);
        void Update(int id, BookDtoForUpdate bookDto, bool trackChanges);
        void Delete(int id, bool trackChanges);
    }
}
