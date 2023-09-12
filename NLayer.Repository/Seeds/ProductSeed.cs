using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Price = 100, Stock = 20, Name = "Kalem1", CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Price = 222, Stock = 21, Name = "Kalem2", CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, Price = 333, Stock = 23, Name = "Kalem3", CreatedDate = DateTime.Now },
                new Product { Id = 5, CategoryId = 2, Price = 444, Stock = 25, Name = "Kitap1", CreatedDate = DateTime.Now },
                new Product { Id = 6, CategoryId = 3, Price = 555, Stock = 24, Name = "Defter1", CreatedDate = DateTime.Now }
                );
        }
    }
}
