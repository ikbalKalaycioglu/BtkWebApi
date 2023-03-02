using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DataTransferObjects
{
    public record BookDtoForUpdate(int Id, string Name, decimal Price);
}
