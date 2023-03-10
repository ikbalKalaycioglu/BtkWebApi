using System.ComponentModel.DataAnnotations;

namespace Entites.DataTransferObjects
{
    public record BookDtoForInsertion : BookDtoForManipulation
    {
        [Required(ErrorMessage ="CategoryId is required")]
        public int CategoryId { get; init; }
    }
}
