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
                    { new Guid("08dfb5d6-b386-4108-9e05-f406dd05af01"), 8, "Tableta Milka Chocolate Biscuit 300 gr.", null, "https://http2.mlstatic.com/D_739884-MLA54985070288_052023-C.jpg", "Tableta Milka Chocolate Biscuit 300 gr - Importado", 9999m },
                    { new Guid("12aad569-6e62-44c5-bca3-ab5bf839238f"), 1, "Marca líder mundial en la comercialización de electrodomésticos que orienta su trabajo en la tecnología, el diseño y la innovación para mejorar la calidad de vida.", 47, "https://drean.com.ar/medias/1200Wx1200H-A-Lavavajillas-Drean-DISH15.2DTX-1.jpg?context=bWFzdGVyfGltYWdlc3wyNjc1Mjd8aW1hZ2UvanBlZ3xhRGN6TDJoaE5TOHhNVEV3TURnME1qYzFOREEzT0M4eE1qQXdWM2d4TWpBd1NGOUJMVXhoZG1GMllXcHBiR3hoY3kxRWNtVmhiaTFFU1ZOSU1UVXVNa1JVV0MweExtcHdad3wwMjVkMDQ4ODQ1NzUwODkxMGRlOWU4YTNkYjgyN2QyOGVjZjM5NDMzY2E5YThkZjk1M2U4OWE4YmFjZDAyNjRi", "Lavavajilla Drean Dish 12.2 Ltx 12 Cubiertos Acero", 1209224m },
                    { new Guid("12d2c4d1-71a5-4e83-a4d8-f414ccb203c3"), 3, "PANTALON CARGO JOGGER 4 BOLSILLOS Y 2 SOLAPAS TRASERAS DE GABARDINA.", 10, "https://alcatraz.com.ar/2602-large_default/pantalon-alcatraz-ultra-negro-hombre-y-mujer.jpg", "Pantalones Hombre Cargo Gabardina Bolsillos Casuales Jogger", 21899m },
                    { new Guid("1adb2309-81dd-4635-ac65-8a1a0eb28c83"), 10, "Sustrato Growmix 80Lts Multipro.", 5, "https://juanijuana.com.ar/wp-content/uploads/2021/10/Growmix-Multripro-Sustrato.png", "GrowMix Profesional Multipro 80 Litros - Importado", 19860m },
                    { new Guid("298ac52c-151e-4f7f-8ef7-782ed44977f5"), 9, "DESAFÍOS - Comunicación 4 Secundaria.", 5, "https://tienda.proyectopilares.com.pe/assets/img/Image-02-01-24-to-6-33-19png", "Comunicación 4 - Proyecto Educativo Pilares", 16700m },
                    { new Guid("2d1e6b22-4ae0-480e-ae2a-00b00c0bdab0"), 3, "PULSERA DE ACERO QUIRURGICO 2 EN 1.", null, "https://importadora376.com.ar/wp-content/uploads/2021/12/DL-PUL20615S.jpg", "Combo Pulsera Hombre 2 En 1 Acero Quirugico Inoxidable Pack", 2547.25m },
                    { new Guid("3a6c8c8c-f04f-423b-b858-3ec1a49ce10c"), 6, "Soga de saltar de acero Speed Rope.", 19, "https://cbdeportes.com/wp-content/uploads/2019/04/soga.crossfit.aluminio2.jpg", "Soga Para Saltar Aluminio Rulemanes/ Boxeo Fitness Crossfit", 14998m },
                    { new Guid("3ca1a2a2-b527-4b0d-80ae-615d6f7b8dd9"), 8, "Pack de 6 latas de 354 mL cada una.", null, "https://quirinobebidas.com.ar/wp-content/uploads/2022/10/productos-2022-10-04T114921.209.png", "Lata De Pepsi Cola Gaseosa X 354ml Pack X6 Und", 4381.82m },
                    { new Guid("3f778370-a1dd-4fac-8489-a84a07618bbe"), 3, "Bolso Wilson 65.150005.", 11, "https://acdn.mitiendanube.com/stores/003/429/444/products/65-151005__5-ed12a1fa2666b02e3e17031783821796-1024-1024.jpg", "Bolso Wilson Deportivo Viaje Urbano Gimnasio Cierre Color Verde Liso", 39999m },
                    { new Guid("44a5f009-3f24-43b9-87b0-6db81da3fe47"), 5, "Bienvenido a la tienda oficial de SanCor Bebé, donde podés comprar todos nuestros productos directo de fábrica, pagarlos online y recibirlos donde quieras de forma segura y confiable.", null, "https://www.anikashop.com.ar/product_images/w/563/BioGaia-gotas-probioticas__01751_zoom.png", "Biogaia Gotas Probioticas Suplemento Dietario X 5 Ml", 25814m },
                    { new Guid("44e94fe9-38cf-4d5a-8926-023e2895bcf8"), 10, "La cinta doble faz Universal tesa® es una cinta adhesiva de papel muy versátil, ideal para fijar alfombras, o para la decoración en casa y bricolaje.", null, "https://http2.mlstatic.com/D_NQ_NP_860188-MLA47568116839_092021-O.webp", "Cinta Doble Faz 50mm X 25m Pega Alfombra-bricolage Tesa Tape", 12000m },
                    { new Guid("53a6109a-7d8a-4f3a-b8c2-770c7886cef3"), 6, "Edad recomendada: de 8 años a 120 años.", null, "https://tienda.planetadelibros.com.ar/cdn/shop/products/Destroza-este-diario-ahora-a-todo-color_fte.jpg?v=1684348323", "Destroza Este Diario Color - Keri Smith - Libro Del Fondo", 20200m },
                    { new Guid("5f92d388-ebb3-417e-a3e6-91a427f48e89"), 4, "Cuadro moderno decorativo calado sobre madera mdf ideal para hogar casa oficina living ambientes minimalistas degrade.", 5, "https://mondecoshop.com/wp-content/uploads/2018/04/JA-83582-cuadro-madera-hojas-blancas.jpg", "Cuadro Madera Calado Hojas Moderno Living Decorativo Color Degrade", 13999m },
                    { new Guid("5ff5e951-9307-4af4-97d5-ffccc2387b6b"), 2, "Cargador Móvil Gadnic con LED Indicador de Batería 25000 mAh.", null, "https://http2.mlstatic.com/D_NQ_NP_639848-MLU73345299871_122023-O.webp", "Cargador Móvil Con Lde Indicador De Batería 25000 Mah Color Negro", 41749m },
                    { new Guid("614cb241-6897-4892-bbf8-16e0c76bc072"), 10, "Mantener los espacios verdes de tu hogar ahora es más fácil, olvidate de cortes desprolijos y malezas.", 36, "https://images.fravega.com/f500/10fab03c3a4881539442a1778a2a608f.jpg", "Desmalezadora A Explosión 52cc Potencia 1500w 2 Hp DESMA52CC", 127110m },
                    { new Guid("640922de-f6d4-4fff-a357-2035bc25ef75"), 2, "El Robot de limpieza ATMA facilita la tarea de mantener los pisos impecables, combinando las funciones de aspirar y trapear simultáneamente.", 19, "https://images.fravega.com/f500/86482108dd01b2588c7231a760ea7c32.jpg", "Aspiradora Trapeadora Robot Atma Atar21c1dh Blanca 220v", 668249m },
                    { new Guid("65c1b39a-75bf-4317-99b1-24e9707f1ce6"), 8, "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas.", 5, "https://carrefourar.vtexassets.com/arquivos/ids/332158/7790895000232_E02.jpg?v=638211437437130000", "Coca Cola Lata 354ml Original Gaseosa Pack X6 Latas", 9005.29m },
                    { new Guid("6bac8259-1f45-4be1-98b9-7a730488a119"), 7, "Cocina para nenas nenes chicos infantil madera.", 5, "https://falabella.scene7.com/is/image/FalabellaPE/119952569_1?wid=800&hei=800&qlt=70", "Cocinita De Juguete Cocina Madera Infantil", 34999m },
                    { new Guid("6f845f6c-53ee-45c0-a74c-3d2824345a64"), 5, "KIT DE CUIDADO FACIAL COMPLETO.", null, "https://images.fravega.com/f1000/b2744115bf9175e98017c8fd6e1a3abd.jpg", "Kit Limpieza Cuidado Facial Belleza Mascarilla", 22999m },
                    { new Guid("70b47609-8ee6-4cd3-9685-9935ca92a0bb"), 4, "Pileta Encastrable HARDEST Modelo HQ-113XT.", null, "https://images.fravega.com/f500/ae7eef26b384dd0cfdd6f5276ff92299.jpg", "Bacha Cocina Pileta Simple Acero Inoxidable Dosificador 56cm", 102999m },
                    { new Guid("77782baa-710b-4396-8b50-a4cbdb445493"), 9, "EL DUELO (BOLSILLO) - Gabriel Rolón.", 10, "https://tienda.planetadelibros.com.ar/cdn/shop/products/EldueloBK_drs.jpg?v=1684356447", "Libro El duelo - Gabriel Rolón - Booket Edition", 16000m },
                    { new Guid("7ba4f4da-ab7b-4db2-b52b-d3e2684026fc"), 7, "En sus distintas ediciones, la franquicia de Super Mario ha logrado combinar su estilo con modernos modos de juego que divierten y desafían constantemente a quienes juegan.", null, "https://www.radioshackla.com/media/catalog/product/4/6/464310200015-1_1.jpg?optimize=medium&bg-color=255,255,255&fit=bounds&height=700&width=700&canvas=700:700", "Super Mario Bros Wonder Nintendo Switch", 82999m },
                    { new Guid("84b2ff92-3b7d-434f-879f-dad9552501b9"), 10, "Potencia: 80 W.", null, "https://http2.mlstatic.com/D_NQ_NP_870740-MLU72833533367_112023-O.webp", "Pistola Encoladora 80 W Para Barras De Silicona De 11,2 Mm", 9888m },
                    { new Guid("8816c07c-d4ec-41d0-a81c-cf804355165d"), 5, "El Aspirador Nasal Asistido Nuby es el aliado perfecto para cuidar la salud de tu bebé desde los primeros meses de vida.", null, "https://http2.mlstatic.com/D_NQ_NP_661607-MLU72831502725_112023-O.webp", "Nuby Aspirador Nasal Asistido Con Boquilla Y Filtro Color Transparente", 12516m },
                    { new Guid("8ccddc25-e291-442a-ac7d-400feebbdb7c"), 2, "Con tu consola Switch tendrás entretenimiento asegurado todos los días. Su tecnología fue creada para poner nuevos retos tanto a jugadores principiantes como expertos. ", null, "https://http2.mlstatic.com/D_Q_NP_803086-MLA47920649105_102021-O.webp", "Nintendo Switch OLED 64GB Standard color rojo neón, azul neón y negro", 517999m },
                    { new Guid("978aa1f9-502a-446f-bb76-52dd2a67ebbe"), 6, "Adidas Argentum 19.", null, "https://http2.mlstatic.com/D_NQ_NP_716010-MLA73530650055_122023-O.webp", "Pelota adidas Argentum 19 Liga Argentina Balón Oficial", 140000m },
                    { new Guid("9a7046e1-2659-471f-b14c-5b6921f3ab72"), 3, "Shoter premium shoe cleaner es un producto innovador para la limpieza de calzado urbano y deportivo.", null, "https://essential.vtexassets.com/arquivos/ids/862812-800-auto?v=638235033358400000&width=800&height=auto&aspect=true", "Limpia Zapatillas Shoter - Kit (limpiador Premium + Cepillo)", 18400m },
                    { new Guid("9c22d4c8-ab18-4f72-9d6b-2a21a7d82dac"), 7, "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja.", 31, "https://modelixracing.com/17560-large_default/cuadricoptero-plegable-24ghz-4ch-con-camara-wifi-hd-f166.jpg", "Helicóptero Dron Inteligente Sensorial Vuela Sube Y Baja Color Negro", 17990m },
                    { new Guid("a542413b-5f19-4be0-aca5-335143299529"), 9, "Como imposible y como quimera, como fin y también como imperativo, la idea de la felicidad nos interpela más que nunca en los tiempos que corren. “¿Cómo ser felices?”.", null, "https://tienda.planetadelibros.com.ar/cdn/shop/files/Lafelicidad_Fte.jpg?v=1700776214", "Libro La Felicidad - Gabriel Rolón - Planeta", 17990m },
                    { new Guid("a9ddc0a2-d1ba-45e2-8ad6-8be517fa4052"), 6, "GUANTE ATTRAKT SOLID.", null, "https://http2.mlstatic.com/D_NQ_NP_737373-MLA69694206154_052023-O.webp", "Guante Arquero Attrakt Solid Reusch Exclusivo", 43230m },
                    { new Guid("ae89f931-1af7-4d0e-981d-440f1b2eb919"), 2, "Google TV de Philips le ofrece el contenido que desea, cuando lo desee. Puede personalizar su pantalla principal para mostrar sus aplicaciones favoritas.", 11, "https://76338a6a.flyingcdn.com/44030-large_default/philips-led-tv-32-phd691877-google-tv-tv-hd-hdmi-usb-control-voz-tda-.jpg", "Tv Smart Led Philips 32 Hd 32phd6918/77 Google Tv", 269999m },
                    { new Guid("c5cd79b1-8026-4649-90ec-d190597fbc1a"), 1, "Freidora de Aire Gadnic F4.0 Sin Aceite 4Lts Digital.", null, "https://www.ecelectronica.com.ar/10774-large_default/freidora-de-aire-caliente-sin-aceite-electrica-4-lts-vonne.jpg", "Freidora Eléctrica De Aire Sin Aceite + Pinza Gratis 1400w Color Negro", 124999m },
                    { new Guid("cbbf58f3-660e-4429-aa2c-10e4050eae20"), 4, "TENDER DE PIE ACERO CON ALAS.", 15, "https://http2.mlstatic.com/D_NQ_NP_685369-MLU72549946435_102023-O.webp", "Tendedero Ropa Alas Acero Pintado Plegable De Pie 953 Color Blanco", 16341.18m },
                    { new Guid("d0e6ca64-a5d8-4787-8fa9-81ae2b0cfdce"), 1, "Disfrutá de tus alimentos frescos y almacenalos de manera práctica y cómoda en la heladera Drean, la protagonista de la cocina.", 31, "https://drean.com.ar/medias/1200Wx1200H-A-Heladera-Ciclica-Drean-HDR320F00N-1.jpg?context=bWFzdGVyfGltYWdlc3wxMjYyMjJ8aW1hZ2UvanBlZ3xhRGhtTDJoa1ppOHhNVEV3T1RjMk9UTTBOekV3TWk4eE1qQXdWM2d4TWpBd1NGOUJMVWhsYkdGa1pYSmhMVU5wWTJ4cFkyRXRSSEpsWVc0dFNFUlNNekl3UmpBd1RpMHhMbXB3Wnd8ZmUzZWY3NzYyMmI2MDIwN2FhY2UxNGUyMGFiMWU0MGJhMWM2ZDllZDM4ZTU0ZjgyZjMxODRiYTEzMTgyZmI1MQ", "Heladera Drean HDR400F11 steel con freezer 396L 220V", 1298199m },
                    { new Guid("d4c3af8a-d27c-45d8-95b3-312597c0c9ed"), 1, "Únicamente necesita que se introduzcan los productos de limpieza y se elija el programa deseado.", 39, "https://www.dmaker.com/media/catalog/product/7/0/709803860_1.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=700&width=700&canvas=700:700", "Lavarropas automático Drean Next 8.14 P ECO inverter blanco 8kg 220 V", 744292m },
                    { new Guid("d6fb7f0a-ca5c-472b-a0ee-994192854ebe"), 9, "Libro Hábitos Atómicos - James Clear - Booket.", null, "https://tienda.planetadelibros.com.ar/cdn/shop/files/HabitosatomicosTD_Fte.jpg?v=1701373336", "Libro Hábitos Atómicos - James Clear - Booket", 14600m },
                    { new Guid("d7b77133-3ee2-48cb-a006-5fcf3eb9813f"), 8, "Milka Chocolate Oreo Max X 300 Gr.", null, "https://http2.mlstatic.com/D_Q_NP_752599-MLU74227122493_012024-O.webp", "Milka Chocolate Oreo Max X 300 Gr - Importado", 9999m },
                    { new Guid("f4beb1a8-8a9a-4f5e-9624-c8400c87c7a1"), 7, "Con este juego de Mario vas a disfrutar de horas de diversión y de nuevos desafíos que te permitirán mejorar como gamer.", null, "https://nextgames.com.ar/img/Public/1040-producto-super-mario-addysey-176.jpg", "Super Mario Odyssey Super Mario Standard Edition Nintendo Switch", 79206m },
                    { new Guid("f66f2b23-592c-4d52-b860-d897620a1006"), 5, "Contenido 7gr.", null, "https://farmaciaspatagonicasar.vtexassets.com/arquivos/ids/157030/7798052941978.jpg?v=638017166389700000", "Corrector De Ojereas Artez Westerley Distr. Oficial", 7900m },
                    { new Guid("fb784cf8-941d-4c58-8b8e-e753ff4ef6c0"), 4, "Cortina Guirnalda Estrellas Luz Led Cálida Amarilla Efectos.", 67, "https://http2.mlstatic.com/D_NQ_NP_810631-MLA52751735019_122022-O.webp", "Cortina Guirnalda Estrellas Luz Led Calida Amarilla Efectos", 29000m }
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
