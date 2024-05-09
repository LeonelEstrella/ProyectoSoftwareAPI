using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category",
                        column: x => x.Category,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleProduct",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleProduct", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Product_Product",
                        column: x => x.Product,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Sale_Sale",
                        column: x => x.Sale,
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electrodomésticos" },
                    { 2, "Tecnología y Electrónica" },
                    { 3, "Moda y Accesorios" },
                    { 4, "Hogar y Decoración" },
                    { 5, "Salud y Belleza" },
                    { 6, "Deportes y Ocio" },
                    { 7, "Juguetes y Juegos" },
                    { 8, "Alimentos y Bebidas" },
                    { 9, "Libros y Material Educativo" },
                    { 10, "Jardinería y Bricolaje" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02330863-1260-41c0-bf9f-3f1b705132ae"), 7, "Cocina para nenas nenes chicos infantil madera.", 5, "https://http2.mlstatic.com/D_NQ_NP_611047-MLU74163663259_012024-O.webp", "Cocinita De Juguete Cocina Madera Infantil Color Marrón", 34999m },
                    { new Guid("068d39a2-bd0a-42e4-88dd-a0c889983463"), 9, "Expedicion Matematica 6 - Claudia Broitman.", 5, "https://http2.mlstatic.com/D_NQ_NP_800174-MLU73415445799_122023-O.webp", "Expedicion Matematica 6 - Claudia Broitman", 16700m },
                    { new Guid("10f17e43-5cae-4c92-bd56-8e56ef3f88df"), 3, "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", 10, "https://http2.mlstatic.com/D_NQ_NP_964819-MLA70940869495_082023-O.webp", "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", 21899m },
                    { new Guid("1373291e-cefb-42dd-9684-32c061c7f3ae"), 9, "Libro Hábitos Atómicos - James Clear - Booket.", null, "https://http2.mlstatic.com/D_NQ_NP_673885-MLA54040457764_022023-O.webp", "Libro Hábitos Atómicos - James Clear - Booket", 14600m },
                    { new Guid("1f2aa424-8ce5-48be-9d58-1d441999c02f"), 7, "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", 31, "https://http2.mlstatic.com/D_NQ_NP_716599-MLU73126252000_122023-O.webp", "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", 17990m },
                    { new Guid("27c01753-b172-44b5-9be6-2d21cffb5f59"), 3, "Bolso Wilson 65.150005.", 11, "https://http2.mlstatic.com/D_NQ_NP_910443-MLU72877827774_112023-O.webp", "Bolso Wilson Deportivo Viaje Urbano Gimnasio Cierre Color Verde Liso", 39999m },
                    { new Guid("2c6ee745-e67f-4a03-97af-687958ebb5bc"), 2, "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", null, "https://http2.mlstatic.com/D_NQ_NP_803086-MLA47920649105_102021-O.webp", "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro", 517999m },
                    { new Guid("3982093c-e10c-4d24-a487-feec8ec42f15"), 10, "Sustrato Growmix 80Lts Multipro.", 5, "https://http2.mlstatic.com/D_NQ_NP_817546-MLU75142995540_032024-O.webp", "GrowMix Profesional Multipro 80 Litros - Importado", 19860m },
                    { new Guid("3984a743-593b-4fde-bb8f-30f264d99d44"), 5, "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", null, "https://http2.mlstatic.com/D_NQ_NP_808805-MLA51087990624_082022-O.webp", "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", 25814m },
                    { new Guid("3eca1054-db34-4dad-8215-08a7353e4e90"), 10, "Potencia: 80 W.", null, "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp", "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", 9888m },
                    { new Guid("54f45b68-7620-4451-9a54-2c0a648f40c2"), 4, "TENDER DE PIE ACERO CON ALAS.", 15, "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp", "Tendedero Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", 16341.18m },
                    { new Guid("56a4d417-0252-4193-8211-37b61f41e793"), 8, "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", 5, "https://http2.mlstatic.com/D_NQ_NP_790516-MLU72637348139_112023-O.webp", "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", 9005.29m },
                    { new Guid("5b0f2d89-9198-43c6-8760-fb67d77c9674"), 8, "Tableta Milka Chocolate Biscuit 300 gr", null, "https://http2.mlstatic.com/D_NQ_NP_740928-MLA74220113425_012024-O.webp", "Tableta Milka Chocolate Biscuit 300 gr - Importado", 9999m },
                    { new Guid("5cb86389-d807-4a57-af16-1e13dee23273"), 9, "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", null, "https://http2.mlstatic.com/D_NQ_NP_758457-MLU75135654463_032024-O.webp", "Libro La Felicidad - Gabriel Rolón - Planeta", 17990m },
                    { new Guid("5ea3173b-b79e-4e23-bce2-73bb41aecb1c"), 5, "KIT DE CUIDADO FACIAL COMPLETO.", null, "https://http2.mlstatic.com/D_NQ_NP_614555-MLA48554874576_122021-O.webp", "Kit Limpieza Cuidado Facial Belleza Mascarilla Cepillo", 22999m },
                    { new Guid("6bedbe2b-827e-432e-a1d2-74a2daefccfa"), 10, "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", 36, "https://http2.mlstatic.com/D_NQ_NP_643769-MLU71619277093_092023-O.webp", "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC", 127110m },
                    { new Guid("6c5d699c-d995-4c75-9254-f012cf91d6fe"), 1, "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital", null, "https://http2.mlstatic.com/D_NQ_NP_862380-MLU74244415875_012024-O.webp", "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", 124999m },
                    { new Guid("71858f56-8f58-4ce7-b8f8-af262de83a86"), 6, "Edad recomendada: de 8 años a 120 años.", null, "https://http2.mlstatic.com/D_NQ_NP_655528-MLU74053078727_012024-O.webp", "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", 20200m },
                    { new Guid("749e8da6-ed2b-4da1-a258-a569b8b54b76"), 6, "Soga de saltar de acero Speed Rope.", 19, "https://http2.mlstatic.com/D_NQ_NP_783722-MLA70257450564_072023-O.webp", "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", 14998m },
                    { new Guid("8212164b-785a-4ce5-b065-3b99cbce7d61"), 6, "GUANTE ATTRAKT SOLID.", null, "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp", "Guante Arquero Attrakt Solid Reusch Exclusivo", 43230m },
                    { new Guid("8d61603e-8e56-4aee-bdce-6f2d0f8f7c3f"), 3, "PULSERA DE ACERO QUIRURGICO 2 EN 1", null, "https://http2.mlstatic.com/D_NQ_NP_727752-MLA47723827894_102021-O.webp", "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", 2547.25m },
                    { new Guid("907bc934-c65a-4399-a4dd-45464532034d"), 5, "Contenido 7gr", null, "https://http2.mlstatic.com/D_NQ_NP_825714-MLU72831156837_112023-O.webp", "Corrector De Ojereas Artez Westerley Distr. Oficial", 7900m },
                    { new Guid("971fc7cb-dc7c-4613-a74d-94cba3728785"), 4, "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", 67, "https://http2.mlstatic.com/D_NQ_NP_817788-MLA73104183943_112023-O.webp", "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", 29000m },
                    { new Guid("994f7e19-6c8d-4163-a93b-b67c1026fcb1"), 8, "Milka Chocolate Oreo Max X 300 Gr.", null, "https://http2.mlstatic.com/D_NQ_NP_816357-MLA74049228146_012024-O.webp", "Milka Chocolate Oreo Max X 300 Gr - Importado", 9999m },
                    { new Guid("9d225feb-54cc-4ca0-bb8f-74c746f49faf"), 3, "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", null, "https://http2.mlstatic.com/D_NQ_NP_659147-MLA40000388003_122019-O.webp", "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", 18400m },
                    { new Guid("9db55930-63ad-485a-be70-0d9d1d946309"), 1, "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", 31, "https://http2.mlstatic.com/D_NQ_NP_661063-MLU74118278062_012024-O.webp", "Heladera Drean HDR400F11 steel con freezer 396L 220V", 1298199m },
                    { new Guid("9e1919a9-79b4-4ef8-bdf1-0763e316b757"), 10, "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", null, "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp", "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", 12000m },
                    { new Guid("a2d73d63-9fbd-456c-b930-d07b62cc48b9"), 1, "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", 39, "https://http2.mlstatic.com/D_NQ_NP_944011-MLA74651986202_022024-O.webp", "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", 744292m },
                    { new Guid("a7f65493-c835-4395-ae7b-77f3cecfecab"), 5, "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", null, "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp", "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", 12516m },
                    { new Guid("a814bd9f-efec-4b08-bb01-8a1cd8eea23b"), 9, "EL DUELO (BOLSILLO) - Gabriel Rolón.", 10, "https://http2.mlstatic.com/D_NQ_NP_869330-MLU73121803273_112023-O.webp", "Libro El duelo - Gabriel Rolón - Booket Edition", 16000m },
                    { new Guid("ada2b6b2-5314-4260-973f-cf0c257cdf96"), 7, "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", null, "https://http2.mlstatic.com/D_NQ_NP_764820-MLU70610438351_072023-O.webp", "Super Mario Bros Wonder Nintendo Switch", 82999m },
                    { new Guid("b2ee5d08-3239-42ef-afcd-e5c2040250bd"), 2, "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", 11, "https://http2.mlstatic.com/D_NQ_NP_677196-MLU74154724021_012024-O.webp", "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", 269999m },
                    { new Guid("be8d84a9-f4bc-4c1d-902a-2fc140eb8fb5"), 4, "Pileta Encastrable HARDEST Modelo HQ-113XT.", null, "https://http2.mlstatic.com/D_NQ_NP_760812-MLA54507511656_032023-O.webp", "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", 102999m },
                    { new Guid("ce9bda4e-a305-49c2-aadc-ccd6fce334a8"), 7, "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", null, "https://http2.mlstatic.com/D_NQ_NP_740157-MLU72836514627_112023-O.webp", "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch", 79206m },
                    { new Guid("d7a8c997-5610-4918-9473-91d05ebf334d"), 6, "Adidas Argentum 19.", null, "https://http2.mlstatic.com/D_NQ_NP_961577-MLA74277409609_012024-O.webp", "Pelota adidas Argentum 19 Liga Argentina Balón Oficial", 140000m },
                    { new Guid("db3aee75-4ed5-4cf7-9258-6f008a12e16a"), 4, "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", 5, "https://http2.mlstatic.com/D_NQ_NP_937605-MLU71497717015_092023-O.webp", "Cuadro Madera Calado Hojas Moderno Living Decorativo Color Degrade", 13999m },
                    { new Guid("e58e28c2-e164-4a6c-a4bc-2e372644caa9"), 2, "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", 19, "https://http2.mlstatic.com/D_NQ_NP_898750-MLU73587878148_122023-O.webp", "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", 668249m },
                    { new Guid("e814e78a-2ca9-4a75-99ea-60a37428435c"), 1, "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", 47, "https://http2.mlstatic.com/D_NQ_NP_973805-MLU74159511409_012024-O.webp", "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", 1209224m },
                    { new Guid("ea5788bb-ebaa-45ce-a868-d912e77ce925"), 2, "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh", null, "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp", "Cargador Móvil Con Lde Indicador De Batería 25000 Mah Color Negro", 41749m },
                    { new Guid("f7547616-1efd-4153-aa2d-28452d6d42dc"), 8, "Pack de 6 latas de 354 mL cada una.", null, "https://http2.mlstatic.com/D_NQ_NP_878966-MLU73885793875_012024-O.webp", "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", 4381.82m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category",
                table: "Product",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Product",
                table: "SaleProduct",
                column: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Sale",
                table: "SaleProduct",
                column: "Sale");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleProduct");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
