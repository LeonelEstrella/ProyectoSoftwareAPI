using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class dataset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electrodomésticos" },
                    { 2, "Tecnología_y_Electrónica" },
                    { 3, "Moda_y_Accesorios" },
                    { 4, "Hogar_y_Decoración" },
                    { 5, "Salud_y_Belleza" },
                    { 6, "Deportes_y_Ocio" },
                    { 7, "Juguetes_y_Juegos" },
                    { 8, "Alimentos_y_Bebidas" },
                    { 9, "Libros_y_Material_Educativo" },
                    { 10, "Jardinería_y_Bricolaje" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "Discount", "ImageLink", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("048936cf-145f-431e-9e5e-612846303ca9"), 2, "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", 11, "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp", "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", 269999m },
                    { new Guid("05faf37e-8d6b-4035-b69d-61411c1d8148"), 4, "Pileta Encastrable HARDEST Modelo HQ-113XT.", 0, "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp", "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", 102999m },
                    { new Guid("06dda32d-9186-47d9-94e2-9c57c9317210"), 4, "TENDER DE PIE ACERO CON ALAS.", 15, "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp", "Tendedero Tender Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", 16341.18m },
                    { new Guid("12e597bc-cf8d-4641-b7a7-483f7b64a310"), 1, "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", 31, "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp", "Heladera Drean HDR400F11 steel con freezer 396L 220V", 1298199m },
                    { new Guid("13d3a7dd-8d86-4b24-aac0-1aa0e681191e"), 9, "Libro Hábitos Atómicos - James Clear - Booket.", 0, "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp", "Libro Hábitos Atómicos - James Clear - Booket", 14600m },
                    { new Guid("1668a5f9-3ff1-4306-9c8e-754a7086765d"), 5, "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", 0, "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp", "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", 25814m },
                    { new Guid("1d2348d5-3601-4750-9af1-541433be7b03"), 9, "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", 0, "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp", "Libro La Felicidad - Gabriel Rolón - Planeta", 17990m },
                    { new Guid("1f4e10fa-a942-4868-8c32-ebb197b85593"), 5, "KIT DE CUIDADO FACIAL COMPLETO.", 0, "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp", "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo", 22999m },
                    { new Guid("21821e9c-d6de-44c0-9c60-b3b6bbcbfb76"), 6, "GUANTE ATTRAKT SOLID.", 0, "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp", "Guante Arquero Attrakt Solid Reusch Exclusivo", 43230m },
                    { new Guid("248bbf2c-fbfc-426a-b52f-c50975ce1b21"), 3, "Bolso Wilson 65.150005.", 11, "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp", "Bolso Wilson Deportivo Viaje Urbano Bolsillo Gimnasio Cierre Color Verde Liso", 39999m },
                    { new Guid("266cdb0d-26d1-433e-a0eb-08bda9a072c1"), 9, "EL DUELO (BOLSILLO) - Gabriel Rolón.", 10, "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp", "Libro El duelo - Gabriel Rolón - Booket", 16000m },
                    { new Guid("2808628d-29e1-4c5b-b54d-c6216fee0543"), 3, "PULSERA DE ACERO QUIRURGICO 2 EN 1", 0, "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp", "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", 2547.25m },
                    { new Guid("2c1e605f-da5a-4965-b6c8-87b0cd966943"), 7, "Cocina para nenas nenes chicos infantil madera.", 5, "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp", "Cocinita De Juguete Cocina Madera Infantil Juego Niños Niñas Color Marrón", 34999m },
                    { new Guid("2d23afda-1f2c-4db7-b45b-d62d5f238d6e"), 9, "Expedicion Matematica 6 - Claudia Broitman.", 5, "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp", "Expedicion Matematica 6 - Claudia Broitman", 16700m },
                    { new Guid("31cc3454-56b8-4a86-bcb2-346376efabb2"), 5, "Contenido 7gr", 0, "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp", "Corrector De Ojereas Artez Westerley Distr. Oficial", 7900m },
                    { new Guid("35b5478f-972d-4eb9-b6fa-984180cfc005"), 10, "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", 36, "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp", "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC", 127110m },
                    { new Guid("3b4d10de-aecc-40e5-9df3-38ed08a627bf"), 2, "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", 0, "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp", "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro", 517999m },
                    { new Guid("4b9020c4-aef5-4206-9fe2-8bf46453eb0a"), 4, "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", 67, "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp", "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", 29000m },
                    { new Guid("4eee312d-fc04-4aa3-a501-89fd10020aac"), 2, "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", 19, "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp", "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", 668249m },
                    { new Guid("52a5b4fb-e1b3-4118-b57e-b450037701af"), 6, "Edad recomendada: de 8 años a 120 años.", 0, "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp", "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", 20200m },
                    { new Guid("70699415-d852-4716-b0ca-ae9e6c750b0f"), 7, "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", 316, "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp", "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", 17990m },
                    { new Guid("7359f245-8bed-4f0b-9b7a-402f87dbb6ec"), 6, "Soga de saltar de acero Speed Rope.", 19, "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp", "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", 14998m },
                    { new Guid("78f01d84-91b8-4693-bd17-efe0c4723094"), 6, "Adidas Argentum 19.", 0, "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp", "Pelota adidas Argentum 19 Liga Argentina Balón Oficial", 140000m },
                    { new Guid("7a22912d-49c4-472f-ad4d-27d98d366695"), 8, "Pack de 6 latas de 354 mL cada una.", 0, "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp", "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", 4381.82m },
                    { new Guid("7b21c009-c6ae-47c6-aa60-4f00b59d68d5"), 8, "Milka Chocolate Oreo Max X 300 Gr.", 0, "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp", "Milka Chocolate Oreo Max X 300 Gr", 9999m },
                    { new Guid("9746f48d-c9ec-42c8-a39a-e32e5f221ee4"), 10, "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", 0, "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp", "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", 12000m },
                    { new Guid("98a18d0c-c3f5-4cb2-b285-9ca82886f010"), 1, "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", 47, "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp", "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", 1209224m },
                    { new Guid("9ed57af9-aac3-4e0e-be75-a49a1ec1f86e"), 7, "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", 0, "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp", "Super Mario Bros Wonder Nintendo Switch", 82999m },
                    { new Guid("a1389e09-8e88-4103-9605-a657d7e00a4c"), 4, "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", 5, "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp", "Cuadro Madera Calado Mdf 5 Hojas Moderno Living Decorativo Color Degrade", 13999m },
                    { new Guid("a3914187-b862-455e-b80f-d5f32ec7b744"), 3, "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", 0, "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp", "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", 18400m },
                    { new Guid("a4e1c988-7517-4293-baf5-051e2bfa133f"), 8, "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", 5, "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp", "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", 9005.29m },
                    { new Guid("a5dab790-2a53-423c-931b-8bb8ccb1c663"), 2, "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh", 0, "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp", "Cargador Móvil Gadnic Con Lde Indicador De Batería 25000 Mah Color Negro", 41749m },
                    { new Guid("a6c0467d-f2be-4be7-9710-91674fc55561"), 5, "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", 0, "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp", "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", 12516m },
                    { new Guid("aaf623d1-d533-4394-82d6-cc0a39d93561"), 7, "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", 0, "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp", "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch Físico", 79206m },
                    { new Guid("d13b15f2-0ed0-4c00-ae05-3fc9f8357e21"), 1, "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", 39, "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp", "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", 744292m },
                    { new Guid("d2daea04-ef56-4810-acb8-a727fc212cdd"), 10, "Potencia: 80 W.", 0, "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp", "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", 9888m },
                    { new Guid("da2fba84-f361-40ad-a015-12bcaba656ff"), 8, "Tableta Milka Chocolate Biscuit 300 gr", 0, "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp", "Tableta Milka Chocolate Biscuit 300 gr", 9999m },
                    { new Guid("e41c6169-203d-4645-b94d-377ec3ab8e84"), 10, "Sustrato Growmix 80Lts Multipro.", 5, "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp", "GrowMix Profesional Multipro 80L", 19860m },
                    { new Guid("f929b41c-7892-42da-a647-2244786433a0"), 1, "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", 0, "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp", "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", 124999m },
                    { new Guid("f9c2b106-7f14-468a-ae6f-1fbfd260ee87"), 3, "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", 10, "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp", "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", 21899m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("048936cf-145f-431e-9e5e-612846303ca9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("05faf37e-8d6b-4035-b69d-61411c1d8148"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("06dda32d-9186-47d9-94e2-9c57c9317210"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("12e597bc-cf8d-4641-b7a7-483f7b64a310"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("13d3a7dd-8d86-4b24-aac0-1aa0e681191e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1668a5f9-3ff1-4306-9c8e-754a7086765d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1d2348d5-3601-4750-9af1-541433be7b03"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1f4e10fa-a942-4868-8c32-ebb197b85593"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("21821e9c-d6de-44c0-9c60-b3b6bbcbfb76"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("248bbf2c-fbfc-426a-b52f-c50975ce1b21"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("266cdb0d-26d1-433e-a0eb-08bda9a072c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2808628d-29e1-4c5b-b54d-c6216fee0543"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2c1e605f-da5a-4965-b6c8-87b0cd966943"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2d23afda-1f2c-4db7-b45b-d62d5f238d6e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("31cc3454-56b8-4a86-bcb2-346376efabb2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("35b5478f-972d-4eb9-b6fa-984180cfc005"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("3b4d10de-aecc-40e5-9df3-38ed08a627bf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4b9020c4-aef5-4206-9fe2-8bf46453eb0a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4eee312d-fc04-4aa3-a501-89fd10020aac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("52a5b4fb-e1b3-4118-b57e-b450037701af"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("70699415-d852-4716-b0ca-ae9e6c750b0f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("7359f245-8bed-4f0b-9b7a-402f87dbb6ec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("78f01d84-91b8-4693-bd17-efe0c4723094"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("7a22912d-49c4-472f-ad4d-27d98d366695"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("7b21c009-c6ae-47c6-aa60-4f00b59d68d5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9746f48d-c9ec-42c8-a39a-e32e5f221ee4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98a18d0c-c3f5-4cb2-b285-9ca82886f010"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9ed57af9-aac3-4e0e-be75-a49a1ec1f86e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a1389e09-8e88-4103-9605-a657d7e00a4c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a3914187-b862-455e-b80f-d5f32ec7b744"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a4e1c988-7517-4293-baf5-051e2bfa133f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a5dab790-2a53-423c-931b-8bb8ccb1c663"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a6c0467d-f2be-4be7-9710-91674fc55561"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("aaf623d1-d533-4394-82d6-cc0a39d93561"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d13b15f2-0ed0-4c00-ae05-3fc9f8357e21"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d2daea04-ef56-4810-acb8-a727fc212cdd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("da2fba84-f361-40ad-a015-12bcaba656ff"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e41c6169-203d-4645-b94d-377ec3ab8e84"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f929b41c-7892-42da-a647-2244786433a0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f9c2b106-7f14-468a-ae6f-1fbfd260ee87"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}
