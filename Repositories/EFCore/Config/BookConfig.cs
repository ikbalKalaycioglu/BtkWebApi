using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Name = "Karagöz Ve Hacıvat", Price = 75, CategoryId = 1 },
                new Book { Id = 2, Name = "Mesnevi", Price = 175, CategoryId = 1 },
                new Book { Id = 3, Name = "Devlet", Price = 375, CategoryId = 2 }
                );
        }
    }
}
