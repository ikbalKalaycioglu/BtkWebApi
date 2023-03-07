using Entites.DataTransferObjects;
using Entites.LinkModels;
using Entites.Models;
using Entites.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IBookService
    {
        Task<(LinkResponse linkResponse, MetaData metaData)> GetAllBooksAsync(LinkParameters linkParameters, bool trackChanges);
        Task<BookDto> GetBookByIdAsync(int id, bool trackChanges);
        Task<BookDto> CreateAsync(BookDtoForInsertion bookDto);
        Task UpdateAsync(int id, BookDtoForUpdate bookDto, bool trackChanges);
        Task DeleteAsync(int id, bool trackChanges);
    }
}
