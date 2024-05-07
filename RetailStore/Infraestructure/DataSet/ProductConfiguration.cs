﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.DataSet
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { ProductId = Guid.NewGuid(), Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V", Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", Price = 1298199, CategoryId = 1, Discount = 31, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", Description = "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", Price = 744292, CategoryId = 1, Discount = 39, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", Description = "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", Price = 1209224, CategoryId = 1, Discount = 47, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", Description = "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", Price = 124999, CategoryId = 1, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", Description = "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", Price = 668249, CategoryId = 2, Discount = 19, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro", Description = "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", Price = 517999, CategoryId = 2, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Cargador Móvil Con Lde Indicador De Batería 25000 Mah Color Negro", Description = "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh", Price = 41749, CategoryId = 2, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", Description = "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", Price = 269999, CategoryId = 2, Discount = 11, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", Description = "PULSERA DE ACERO QUIRURGICO 2 EN 1", Price = 2547.25m, CategoryId = 3, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", Description = "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", Price = 18400, CategoryId = 3, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", Description = "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", Price = 21899, CategoryId = 3, Discount = 10, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Bolso Wilson Deportivo Viaje Urbano Gimnasio Cierre Color Verde Liso", Description = "Bolso Wilson 65.150005.", Price = 39999, CategoryId = 3, Discount = 11, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", Description = "Pileta Encastrable HARDEST Modelo HQ-113XT.", Price = 102999, CategoryId = 4, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Tendedero Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", Description = "TENDER DE PIE ACERO CON ALAS.", Price = 16341.18m, CategoryId = 4, Discount = 15, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Cuadro Madera Calado Hojas Moderno Living Decorativo Color Degrade", Description = "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", Price = 13999, CategoryId = 4, Discount = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", Description = "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", Price = 29000, CategoryId = 4, Discount = 67, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", Description = "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", Price = 25814, CategoryId = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", Description = "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", Price = 12516, CategoryId = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo", Description = "KIT DE CUIDADO FACIAL COMPLETO.", Price = 22999, CategoryId = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Corrector De Ojereas Artez Westerley Distr. Oficial", Description = "Contenido 7gr", Price = 7900, CategoryId = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Pelota adidas Argentum 19 Liga Argentina Balón Oficial", Description = "Adidas Argentum 19.", Price = 140000, CategoryId = 6, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Guante Arquero Attrakt Solid Reusch Exclusivo", Description = "GUANTE ATTRAKT SOLID.", Price = 43230, CategoryId = 6, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", Description = "Edad recomendada: de 8 años a 120 años.", Price = 20200, CategoryId = 6, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", Description = "Soga de saltar de acero Speed Rope.", Price = 14998, CategoryId = 6, Discount = 19, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", Description = "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", Price = 17990, CategoryId = 7, Discount = 316, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Cocinita De Juguete Cocina Madera Infantil Color Marrón", Description = "Cocina para nenas nenes chicos infantil madera.", Price = 34999, CategoryId = 7, Discount = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Super Mario Bros Wonder Nintendo Switch", Description = "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", Price = 82999, CategoryId = 7, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch", Description = "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", Price = 79206, CategoryId = 7, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Tableta Milka Chocolate Biscuit 300 gr - Importado", Description = "Tableta Milka Chocolate Biscuit 300 gr", Price = 9999, CategoryId = 8, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", Description = "Pack de 6 latas de 354 mL cada una.", Price = 4381.82m, CategoryId = 8, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", Description = "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", Price = 9005.29m, CategoryId = 8, Discount = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Milka Chocolate Oreo Max X 300 Gr - Importado", Description = "Milka Chocolate Oreo Max X 300 Gr.", Price = 9999, CategoryId = 8, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Libro Hábitos Atómicos - James Clear - Booket", Description = "Libro Hábitos Atómicos - James Clear - Booket.", Price = 14600, CategoryId = 9, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Libro El duelo - Gabriel Rolón - Booket Edition", Description = "EL DUELO (BOLSILLO) - Gabriel Rolón.", Price = 16000, CategoryId = 9, Discount = 10, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Expedicion Matematica 6 - Claudia Broitman", Description = "Expedicion Matematica 6 - Claudia Broitman.", Price = 16700, CategoryId = 9, Discount = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Libro La Felicidad - Gabriel Rolón - Planeta", Description = "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", Price = 17990, CategoryId = 9, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "GrowMix Profesional Multipro 80 Litros - Importado", Description = "Sustrato Growmix 80Lts Multipro.", Price = 19860, CategoryId = 10, Discount = 5, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC", Description = "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", Price = 127110, CategoryId = 10, Discount = 36, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", Description = "Potencia: 80 W.", Price = 9888, CategoryId = 10, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp" },
                new Product { ProductId = Guid.NewGuid(), Name = "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", Description = "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", Price = 12000, CategoryId = 10, ImageLink = "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp" }
                );
        }
    }
}
