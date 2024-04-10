using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.DataSet
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Electrodomésticos" },
                new Category { CategoryId = 2, Name = "Tecnología_y_Electrónica" },
                new Category { CategoryId = 3, Name = "Moda_y_Accesorios" },
                new Category { CategoryId = 4, Name = "Hogar_y_Decoración" },
                new Category { CategoryId = 5, Name = "Salud_y_Belleza" },
                new Category { CategoryId = 6, Name = "Deportes_y_Ocio" },
                new Category { CategoryId = 7, Name = "Juguetes_y_Juegos" },
                new Category { CategoryId = 8, Name = "Alimentos_y_Bebidas" },
                new Category { CategoryId = 9, Name = "Libros_y_Material_Educativo" },
                new Category { CategoryId = 10, Name = "Jardinería_y_Bricolaje" }
                );
        }
    }
}
