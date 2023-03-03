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
        Task<IEnumerable<BookDto>> GetAllBooksAsync(bool trackChanges);
        Task<BookDto> GetBookByIdAsync(int id, bool trackChanges);
        Task<BookDto> CreateAsync(BookDtoForInsertion book);
        Task UpdateAsync(int id, BookDtoForUpdate bookDto, bool trackChanges);
        Task DeleteAsync(int id, bool trackChanges);
    }
}
