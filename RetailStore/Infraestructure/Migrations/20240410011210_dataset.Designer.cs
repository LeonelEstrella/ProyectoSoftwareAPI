﻿// <auto-generated />
using System;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240410011210_dataset")]
    partial class dataset
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Tecnología_y_Electrónica"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Moda_y_Accesorios"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Hogar_y_Decoración"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Salud_y_Belleza"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Deportes_y_Ocio"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Juguetes_y_Juegos"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Alimentos_y_Bebidas"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Libros_y_Material_Educativo"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Jardinería_y_Bricolaje"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("12e597bc-cf8d-4641-b7a7-483f7b64a310"),
                            CategoryId = 1,
                            Description = "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.",
                            Discount = 31,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp",
                            Name = "Heladera Drean HDR400F11 steel con freezer 396L 220V",
                            Price = 1298199m
                        },
                        new
                        {
                            ProductId = new Guid("d13b15f2-0ed0-4c00-ae05-3fc9f8357e21"),
                            CategoryId = 1,
                            Description = "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.",
                            Discount = 39,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp",
                            Name = "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V",
                            Price = 744292m
                        },
                        new
                        {
                            ProductId = new Guid("98a18d0c-c3f5-4cb2-b285-9ca82886f010"),
                            CategoryId = 1,
                            Description = "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.",
                            Discount = 47,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp",
                            Name = "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero",
                            Price = 1209224m
                        },
                        new
                        {
                            ProductId = new Guid("f929b41c-7892-42da-a647-2244786433a0"),
                            CategoryId = 1,
                            Description = "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp",
                            Name = "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro",
                            Price = 124999m
                        },
                        new
                        {
                            ProductId = new Guid("4eee312d-fc04-4aa3-a501-89fd10020aac"),
                            CategoryId = 2,
                            Description = "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.",
                            Discount = 19,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp",
                            Name = "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v",
                            Price = 668249m
                        },
                        new
                        {
                            ProductId = new Guid("3b4d10de-aecc-40e5-9df3-38ed08a627bf"),
                            CategoryId = 2,
                            Description = "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp",
                            Name = "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro",
                            Price = 517999m
                        },
                        new
                        {
                            ProductId = new Guid("a5dab790-2a53-423c-931b-8bb8ccb1c663"),
                            CategoryId = 2,
                            Description = "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp",
                            Name = "Cargador Móvil Gadnic Con Lde Indicador De Batería 25000 Mah Color Negro",
                            Price = 41749m
                        },
                        new
                        {
                            ProductId = new Guid("048936cf-145f-431e-9e5e-612846303ca9"),
                            CategoryId = 2,
                            Description = "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.",
                            Discount = 11,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp",
                            Name = "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv",
                            Price = 269999m
                        },
                        new
                        {
                            ProductId = new Guid("2808628d-29e1-4c5b-b54d-c6216fee0543"),
                            CategoryId = 3,
                            Description = "PULSERA DE ACERO QUIRURGICO 2 EN 1",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp",
                            Name = "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack",
                            Price = 2547.25m
                        },
                        new
                        {
                            ProductId = new Guid("a3914187-b862-455e-b80f-d5f32ec7b744"),
                            CategoryId = 3,
                            Description = "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp",
                            Name = "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)",
                            Price = 18400m
                        },
                        new
                        {
                            ProductId = new Guid("f9c2b106-7f14-468a-ae6f-1fbfd260ee87"),
                            CategoryId = 3,
                            Description = "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.",
                            Discount = 10,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp",
                            Name = "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger",
                            Price = 21899m
                        },
                        new
                        {
                            ProductId = new Guid("248bbf2c-fbfc-426a-b52f-c50975ce1b21"),
                            CategoryId = 3,
                            Description = "Bolso Wilson 65.150005.",
                            Discount = 11,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp",
                            Name = "Bolso Wilson Deportivo Viaje Urbano Bolsillo Gimnasio Cierre Color Verde Liso",
                            Price = 39999m
                        },
                        new
                        {
                            ProductId = new Guid("05faf37e-8d6b-4035-b69d-61411c1d8148"),
                            CategoryId = 4,
                            Description = "Pileta Encastrable HARDEST Modelo HQ-113XT.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp",
                            Name = "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm",
                            Price = 102999m
                        },
                        new
                        {
                            ProductId = new Guid("06dda32d-9186-47d9-94e2-9c57c9317210"),
                            CategoryId = 4,
                            Description = "TENDER DE PIE ACERO CON ALAS.",
                            Discount = 15,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp",
                            Name = "Tendedero Tender Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco",
                            Price = 16341.18m
                        },
                        new
                        {
                            ProductId = new Guid("a1389e09-8e88-4103-9605-a657d7e00a4c"),
                            CategoryId = 4,
                            Description = "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.",
                            Discount = 5,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp",
                            Name = "Cuadro Madera Calado Mdf 5 Hojas Moderno Living Decorativo Color Degrade",
                            Price = 13999m
                        },
                        new
                        {
                            ProductId = new Guid("4b9020c4-aef5-4206-9fe2-8bf46453eb0a"),
                            CategoryId = 4,
                            Description = "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.",
                            Discount = 67,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp",
                            Name = "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos",
                            Price = 29000m
                        },
                        new
                        {
                            ProductId = new Guid("1668a5f9-3ff1-4306-9c8e-754a7086765d"),
                            CategoryId = 5,
                            Description = "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp",
                            Name = "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml",
                            Price = 25814m
                        },
                        new
                        {
                            ProductId = new Guid("a6c0467d-f2be-4be7-9710-91674fc55561"),
                            CategoryId = 5,
                            Description = "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp",
                            Name = "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente",
                            Price = 12516m
                        },
                        new
                        {
                            ProductId = new Guid("1f4e10fa-a942-4868-8c32-ebb197b85593"),
                            CategoryId = 5,
                            Description = "KIT DE CUIDADO FACIAL COMPLETO.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp",
                            Name = "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo",
                            Price = 22999m
                        },
                        new
                        {
                            ProductId = new Guid("31cc3454-56b8-4a86-bcb2-346376efabb2"),
                            CategoryId = 5,
                            Description = "Contenido 7gr",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp",
                            Name = "Corrector De Ojereas Artez Westerley Distr. Oficial",
                            Price = 7900m
                        },
                        new
                        {
                            ProductId = new Guid("78f01d84-91b8-4693-bd17-efe0c4723094"),
                            CategoryId = 6,
                            Description = "Adidas Argentum 19.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp",
                            Name = "Pelota adidas Argentum 19 Liga Argentina Balón Oficial",
                            Price = 140000m
                        },
                        new
                        {
                            ProductId = new Guid("21821e9c-d6de-44c0-9c60-b3b6bbcbfb76"),
                            CategoryId = 6,
                            Description = "GUANTE ATTRAKT SOLID.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp",
                            Name = "Guante Arquero Attrakt Solid Reusch Exclusivo",
                            Price = 43230m
                        },
                        new
                        {
                            ProductId = new Guid("52a5b4fb-e1b3-4118-b57e-b450037701af"),
                            CategoryId = 6,
                            Description = "Edad recomendada: de 8 años a 120 años.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp",
                            Name = "Destroza Este Diario Color - Keri Smith - Libro Del Fondo",
                            Price = 20200m
                        },
                        new
                        {
                            ProductId = new Guid("7359f245-8bed-4f0b-9b7a-402f87dbb6ec"),
                            CategoryId = 6,
                            Description = "Soga de saltar de acero Speed Rope.",
                            Discount = 19,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp",
                            Name = "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit",
                            Price = 14998m
                        },
                        new
                        {
                            ProductId = new Guid("70699415-d852-4716-b0ca-ae9e6c750b0f"),
                            CategoryId = 7,
                            Description = "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.",
                            Discount = 316,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp",
                            Name = "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro",
                            Price = 17990m
                        },
                        new
                        {
                            ProductId = new Guid("2c1e605f-da5a-4965-b6c8-87b0cd966943"),
                            CategoryId = 7,
                            Description = "Cocina para nenas nenes chicos infantil madera.",
                            Discount = 5,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp",
                            Name = "Cocinita De Juguete Cocina Madera Infantil Juego Niños Niñas Color Marrón",
                            Price = 34999m
                        },
                        new
                        {
                            ProductId = new Guid("9ed57af9-aac3-4e0e-be75-a49a1ec1f86e"),
                            CategoryId = 7,
                            Description = "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp",
                            Name = "Super Mario Bros Wonder Nintendo Switch",
                            Price = 82999m
                        },
                        new
                        {
                            ProductId = new Guid("aaf623d1-d533-4394-82d6-cc0a39d93561"),
                            CategoryId = 7,
                            Description = "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp",
                            Name = "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch Físico",
                            Price = 79206m
                        },
                        new
                        {
                            ProductId = new Guid("da2fba84-f361-40ad-a015-12bcaba656ff"),
                            CategoryId = 8,
                            Description = "Tableta Milka Chocolate Biscuit 300 gr",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp",
                            Name = "Tableta Milka Chocolate Biscuit 300 gr",
                            Price = 9999m
                        },
                        new
                        {
                            ProductId = new Guid("7a22912d-49c4-472f-ad4d-27d98d366695"),
                            CategoryId = 8,
                            Description = "Pack de 6 latas de 354 mL cada una.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp",
                            Name = "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und",
                            Price = 4381.82m
                        },
                        new
                        {
                            ProductId = new Guid("a4e1c988-7517-4293-baf5-051e2bfa133f"),
                            CategoryId = 8,
                            Description = "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.",
                            Discount = 5,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp",
                            Name = "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas",
                            Price = 9005.29m
                        },
                        new
                        {
                            ProductId = new Guid("7b21c009-c6ae-47c6-aa60-4f00b59d68d5"),
                            CategoryId = 8,
                            Description = "Milka Chocolate Oreo Max X 300 Gr.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp",
                            Name = "Milka Chocolate Oreo Max X 300 Gr",
                            Price = 9999m
                        },
                        new
                        {
                            ProductId = new Guid("13d3a7dd-8d86-4b24-aac0-1aa0e681191e"),
                            CategoryId = 9,
                            Description = "Libro Hábitos Atómicos - James Clear - Booket.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp",
                            Name = "Libro Hábitos Atómicos - James Clear - Booket",
                            Price = 14600m
                        },
                        new
                        {
                            ProductId = new Guid("266cdb0d-26d1-433e-a0eb-08bda9a072c1"),
                            CategoryId = 9,
                            Description = "EL DUELO (BOLSILLO) - Gabriel Rolón.",
                            Discount = 10,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp",
                            Name = "Libro El duelo - Gabriel Rolón - Booket",
                            Price = 16000m
                        },
                        new
                        {
                            ProductId = new Guid("2d23afda-1f2c-4db7-b45b-d62d5f238d6e"),
                            CategoryId = 9,
                            Description = "Expedicion Matematica 6 - Claudia Broitman.",
                            Discount = 5,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp",
                            Name = "Expedicion Matematica 6 - Claudia Broitman",
                            Price = 16700m
                        },
                        new
                        {
                            ProductId = new Guid("1d2348d5-3601-4750-9af1-541433be7b03"),
                            CategoryId = 9,
                            Description = "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp",
                            Name = "Libro La Felicidad - Gabriel Rolón - Planeta",
                            Price = 17990m
                        },
                        new
                        {
                            ProductId = new Guid("e41c6169-203d-4645-b94d-377ec3ab8e84"),
                            CategoryId = 10,
                            Description = "Sustrato Growmix 80Lts Multipro.",
                            Discount = 5,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp",
                            Name = "GrowMix Profesional Multipro 80L",
                            Price = 19860m
                        },
                        new
                        {
                            ProductId = new Guid("35b5478f-972d-4eb9-b6fa-984180cfc005"),
                            CategoryId = 10,
                            Description = "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.",
                            Discount = 36,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp",
                            Name = "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC",
                            Price = 127110m
                        },
                        new
                        {
                            ProductId = new Guid("d2daea04-ef56-4810-acb8-a727fc212cdd"),
                            CategoryId = 10,
                            Description = "Potencia: 80 W.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp",
                            Name = "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm",
                            Price = 9888m
                        },
                        new
                        {
                            ProductId = new Guid("9746f48d-c9ec-42c8-a39a-e32e5f221ee4"),
                            CategoryId = 10,
                            Description = "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.",
                            Discount = 0,
                            ImageLink = "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp",
                            Name = "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape",
                            Price = 12000m
                        });
                });

            modelBuilder.Entity("Domain.Entities.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPay")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("Domain.Entities.SaleProduct", b =>
                {
                    b.Property<int>("SaleProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleProductId"));

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("SaleProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleProduct");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Entities.SaleProduct", b =>
                {
                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany("SaleProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sale", null)
                        .WithMany("SaleProduct")
                        .HasForeignKey("SaleId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("SaleProduct");
                });

            modelBuilder.Entity("Domain.Entities.Sale", b =>
                {
                    b.Navigation("SaleProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
