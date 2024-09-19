using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWT_ProductManager.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    username = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cost", "name" },
                values: new object[] { 578.57744646114611, "Handcrafted Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cost", "name" },
                values: new object[] { 278.17205368680584, "Handmade Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.26700567527655, "Refined Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cost", "name" },
                values: new object[] { 505.58748319271029, "Tasty Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cost", "name" },
                values: new object[] { 651.34097898990126, "Tasty Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cost", "name" },
                values: new object[] { 599.99006682856839, "Refined Granite Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cost", "name" },
                values: new object[] { 890.60763364886895, "Handmade Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cost", "name" },
                values: new object[] { 126.51089876240488, "Sleek Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cost", "name" },
                values: new object[] { 603.64765568451264, "Rustic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.71749422599584, "Refined Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cost", "name" },
                values: new object[] { 39.380515990424627, "Handmade Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cost", "name" },
                values: new object[] { 34.209072035126077, "Gorgeous Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cost", "name" },
                values: new object[] { 302.5652987050097, "Intelligent Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cost", "name" },
                values: new object[] { 609.76079492519864, "Unbranded Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cost", "name" },
                values: new object[] { 243.63121908917384, "Awesome Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cost", "name" },
                values: new object[] { 383.98587228001588, "Intelligent Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cost", "name" },
                values: new object[] { 581.75443176289252, "Tasty Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cost", "name" },
                values: new object[] { 271.79594021425675, "Rustic Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cost", "name" },
                values: new object[] { 34.402434675061322, "Small Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cost", "name" },
                values: new object[] { 401.71289085183031, "Handmade Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cost", "name" },
                values: new object[] { 796.5264167277262, "Licensed Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cost", "name" },
                values: new object[] { 802.95385064469281, "Fantastic Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cost", "name" },
                values: new object[] { 480.83100352350829, "Tasty Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.78823717598902, "Refined Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cost", "name" },
                values: new object[] { 327.01852075320119, "Incredible Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "cost", "name" },
                values: new object[] { 628.19639987545349, "Gorgeous Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "cost", "name" },
                values: new object[] { 71.093701877932602, "Awesome Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "cost", "name" },
                values: new object[] { 29.032584854006316, "Handmade Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "cost", "name" },
                values: new object[] { 586.76532784237565, "Refined Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "cost", "name" },
                values: new object[] { 867.73433596787572, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "cost", "name" },
                values: new object[] { 428.37623005913429, "Ergonomic Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.39335471727202, "Gorgeous Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "cost", "name" },
                values: new object[] { 327.71256570007904, "Handcrafted Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.1674556155458, "Fantastic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.32081185323977, "Ergonomic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "cost", "name" },
                values: new object[] { 101.41375891555444, "Awesome Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "cost", "name" },
                values: new object[] { 350.12016908844822, "Ergonomic Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.21814982870626, "Tasty Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.932278980582964, "Fantastic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "cost", "name" },
                values: new object[] { 267.19017596779827, "Refined Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "cost", "name" },
                values: new object[] { 545.67989731314742, "Tasty Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "cost", "name" },
                values: new object[] { 815.4789653632306, "Generic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "cost", "name" },
                values: new object[] { 821.95314953419359, "Licensed Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "cost", "name" },
                values: new object[] { 705.81180357366145, "Sleek Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "cost", "name" },
                values: new object[] { 2.2855212889647696, "Sleek Metal Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "cost", "name" },
                values: new object[] { 221.7901149104058, "Unbranded Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "cost", "name" },
                values: new object[] { 914.5362597224921, "Handmade Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.52377166304831, "Incredible Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.71870847935975, "Generic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "cost", "name" },
                values: new object[] { 519.02884054241349, "Handmade Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 51,
                column: "cost",
                value: 177.18522937820796);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "cost", "name" },
                values: new object[] { 640.52350489996434, "Sleek Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "cost", "name" },
                values: new object[] { 143.53269413164531, "Practical Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.83409163744162, "Generic Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "cost", "name" },
                values: new object[] { 112.32880441520128, "Tasty Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "cost", "name" },
                values: new object[] { 768.63437858558814, "Licensed Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "cost", "name" },
                values: new object[] { 376.1283728343742, "Awesome Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.79308154874315, "Small Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "cost", "name" },
                values: new object[] { 701.70586313248748, "Generic Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "cost", "name" },
                values: new object[] { 296.18143332397955, "Handcrafted Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "cost", "name" },
                values: new object[] { 361.67201920826363, "Tasty Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "cost", "name" },
                values: new object[] { 214.36982229357133, "Fantastic Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "cost", "name" },
                values: new object[] { 112.51732596281855, "Sleek Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "cost", "name" },
                values: new object[] { 636.5230520952091, "Ergonomic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "cost", "name" },
                values: new object[] { 543.65197242058468, "Fantastic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.39980940185353, "Rustic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "cost", "name" },
                values: new object[] { 544.87685603750458, "Licensed Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "cost", "name" },
                values: new object[] { 125.30579059223672, "Fantastic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.64628553192483, "Gorgeous Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "cost", "name" },
                values: new object[] { 898.36592008339937, "Licensed Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.71315867741356, "Tasty Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "cost", "name" },
                values: new object[] { 406.30937776832735, "Generic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.15423333281569, "Handcrafted Wooden Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "cost", "name" },
                values: new object[] { 829.92355721312629, "Sleek Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "cost", "name" },
                values: new object[] { 388.58015953130553, "Intelligent Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.50568942239428, "Handmade Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "cost", "name" },
                values: new object[] { 166.77180226036785, "Rustic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "cost", "name" },
                values: new object[] { 557.94217710095609, "Unbranded Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "cost", "name" },
                values: new object[] { 970.20880276916114, "Tasty Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.76371775305449, "Handcrafted Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "cost", "name" },
                values: new object[] { 125.97843944590502, "Incredible Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "cost", "name" },
                values: new object[] { 555.01998142053492, "Gorgeous Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "cost", "name" },
                values: new object[] { 994.51621078844721, "Awesome Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "cost", "name" },
                values: new object[] { 692.8400371078751, "Tasty Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "cost", "name" },
                values: new object[] { 155.28746126851593, "Sleek Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "cost", "name" },
                values: new object[] { 868.08290949531192, "Refined Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.01749880434392, "Incredible Granite Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "cost", "name" },
                values: new object[] { 991.45544652864555, "Handmade Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.57515486822103, "Fantastic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "cost", "name" },
                values: new object[] { 268.54773161604021, "Licensed Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "cost", "name" },
                values: new object[] { 312.90129757744626, "Licensed Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "cost", "name" },
                values: new object[] { 124.52474031565787, "Small Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "cost", "name" },
                values: new object[] { 634.31482399644426, "Small Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "cost", "name" },
                values: new object[] { 492.69882284851656, "Handmade Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.537687761848758, "Incredible Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "cost", "name" },
                values: new object[] { 920.52917879279994, "Rustic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "cost", "name" },
                values: new object[] { 24.77201363105825, "Unbranded Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "cost", "name" },
                values: new object[] { 175.99680350537398, "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "cost", "name" },
                values: new object[] { 431.99231723809447, "Small Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.80783525685058, "Intelligent Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "cost", "name" },
                values: new object[] { 855.87718231100234, "Awesome Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "cost", "name" },
                values: new object[] { 425.84363435450047, "Ergonomic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "cost", "name" },
                values: new object[] { 15.600974654088343, "Incredible Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "cost", "name" },
                values: new object[] { 571.64207963902425, "Tasty Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "cost", "name" },
                values: new object[] { 957.94446264813575, "Licensed Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.00974016061809, "Rustic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "cost", "name" },
                values: new object[] { 464.62546540970095, "Incredible Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "cost", "name" },
                values: new object[] { 250.03470717973693, "Licensed Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "cost", "name" },
                values: new object[] { 722.87964464978393, "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "cost", "name" },
                values: new object[] { 793.70445972655568, "Fantastic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "cost", "name" },
                values: new object[] { 100.88341454423175, "Sleek Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "cost", "name" },
                values: new object[] { 465.64774033765366, "Practical Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "cost", "name" },
                values: new object[] { 814.26579870382204, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "cost", "name" },
                values: new object[] { 551.87258452114838, "Small Cotton Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "cost", "name" },
                values: new object[] { 442.13057973701939, "Refined Metal Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "cost", "name" },
                values: new object[] { 449.01516422139798, "Refined Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "cost", "name" },
                values: new object[] { 678.60839737636081, "Handcrafted Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "cost", "name" },
                values: new object[] { 631.33636516598631, "Licensed Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "cost", "name" },
                values: new object[] { 979.89347220030265, "Unbranded Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "cost", "name" },
                values: new object[] { 267.91555250126157, "Rustic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "cost", "name" },
                values: new object[] { 510.20079489867817, "Awesome Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.1866891521131, "Licensed Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "cost", "name" },
                values: new object[] { 434.53631207154422, "Intelligent Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "cost", "name" },
                values: new object[] { 122.86442004253652, "Gorgeous Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "cost", "name" },
                values: new object[] { 674.94824147929342, "Practical Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "cost", "name" },
                values: new object[] { 311.3759056089317, "Unbranded Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.89207825007628, "Gorgeous Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "cost", "name" },
                values: new object[] { 94.382709877859455, "Unbranded Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.06590908754376, "Refined Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "cost", "name" },
                values: new object[] { 283.18668380469472, "Awesome Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "cost", "name" },
                values: new object[] { 90.067684077320706, "Fantastic Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.40681343141932, "Handcrafted Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "cost", "name" },
                values: new object[] { 380.61745031991541, "Ergonomic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "cost", "name" },
                values: new object[] { 742.48650431400472, "Incredible Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "cost", "name" },
                values: new object[] { 218.28342224596105, "Rustic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "cost", "name" },
                values: new object[] { 422.80572294238084, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "cost", "name" },
                values: new object[] { 881.32038535933975, "Intelligent Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "cost", "name" },
                values: new object[] { 773.58423409659679, "Unbranded Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "cost", "name" },
                values: new object[] { 794.69656604475938, "Tasty Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "cost", "name" },
                values: new object[] { 546.44378779396925, "Practical Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "cost", "name" },
                values: new object[] { 807.21728829657593, "Incredible Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "cost", "name" },
                values: new object[] { 915.94847354443073, "Fantastic Soft Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "cost", "name" },
                values: new object[] { 153.69066559554639, "Awesome Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "cost", "name" },
                values: new object[] { 96.083213352729587, "Ergonomic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "cost", "name" },
                values: new object[] { 655.48303109114192, "Handcrafted Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.3828838692956, "Handcrafted Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "cost", "name" },
                values: new object[] { 889.99906641837265, "Ergonomic Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.67951265994827, "Rustic Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.43137453118294, "Incredible Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "cost", "name" },
                values: new object[] { 220.1385232547992, "Licensed Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "cost", "name" },
                values: new object[] { 410.00418022084006, "Intelligent Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "cost", "name" },
                values: new object[] { 26.713383674568643, "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.18607181053042, "Incredible Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "cost", "name" },
                values: new object[] { 565.19914471899017, "Unbranded Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "cost", "name" },
                values: new object[] { 306.2914362605818, "Unbranded Steel Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.11886123505951, "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "cost", "name" },
                values: new object[] { 333.81720863379655, "Licensed Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "cost", "name" },
                values: new object[] { 849.01468042149043, "Handmade Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.13272084226406, "Sleek Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "cost", "name" },
                values: new object[] { 786.29416660458662, "Incredible Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.43592482884526, "Small Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.3090639107204, "Practical Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "cost", "name" },
                values: new object[] { 122.51046627167547, "Licensed Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "cost", "name" },
                values: new object[] { 455.28506570416795, "Gorgeous Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "cost", "name" },
                values: new object[] { 196.51011893862344, "Rustic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "cost", "name" },
                values: new object[] { 710.27190826563526, "Generic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.66671556464547, "Refined Steel Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "cost", "name" },
                values: new object[] { 359.19572762927248, "Ergonomic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "cost", "name" },
                values: new object[] { 373.67453210462628, "Practical Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "cost", "name" },
                values: new object[] { 547.56280230178299, "Tasty Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "cost", "name" },
                values: new object[] { 386.03909580811398, "Small Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "cost", "name" },
                values: new object[] { 992.45038886615066, "Handcrafted Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "cost", "name" },
                values: new object[] { 840.55180170914241, "Small Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "cost", "name" },
                values: new object[] { 229.32269670821549, "Generic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "cost", "name" },
                values: new object[] { 3.0470413381330448, "Sleek Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "cost", "name" },
                values: new object[] { 93.560812454020891, "Intelligent Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "cost", "name" },
                values: new object[] { 612.49587894575245, "Awesome Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.655746662349173, "Incredible Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.52614946476319, "Practical Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "cost", "name" },
                values: new object[] { 608.53701689101672, "Awesome Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "cost", "name" },
                values: new object[] { 770.69816963997698, "Intelligent Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "cost", "name" },
                values: new object[] { 468.43195667832504, "Incredible Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "cost", "name" },
                values: new object[] { 555.16478530309939, "Fantastic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.58680888973163, "Ergonomic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.077396346946614, "Ergonomic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "cost", "name" },
                values: new object[] { 745.60691663892521, "Handcrafted Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "cost", "name" },
                values: new object[] { 155.99716284125506, "Licensed Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "cost", "name" },
                values: new object[] { 556.61842420605888, "Fantastic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "cost", "name" },
                values: new object[] { 976.85035879899249, "Handcrafted Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.79335983465944, "Unbranded Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "cost", "name" },
                values: new object[] { 51.985146994653597, "Sleek Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "cost", "name" },
                values: new object[] { 843.96895434446037, "Gorgeous Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "cost", "name" },
                values: new object[] { 590.32697121875526, "Handmade Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "cost", "name" },
                values: new object[] { 786.15441285251347, "Tasty Metal Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "cost", "name" },
                values: new object[] { 632.02006191174871, "Incredible Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.22579651524995, "Practical Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "cost", "name" },
                values: new object[] { 323.13808404154571, "Intelligent Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "cost", "name" },
                values: new object[] { 392.79736788362317, "Tasty Granite Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "cost", "name" },
                values: new object[] { 922.50886002000186, "Practical Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "cost", "name" },
                values: new object[] { 506.3130001698712, "Practical Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "cost", "name" },
                values: new object[] { 959.52350795473751, "Handmade Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "cost", "name" },
                values: new object[] { 608.692553962121, "Intelligent Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "cost", "name" },
                values: new object[] { 867.34185448446669, "Awesome Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.001069646816887, "Handcrafted Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "cost", "name" },
                values: new object[] { 280.92375456066236, "Tasty Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "cost", "name" },
                values: new object[] { 61.850827266778495, "Intelligent Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.94844851028824, "Licensed Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.9179327771717, "Refined Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "cost", "name" },
                values: new object[] { 878.17946439299328, "Handcrafted Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "cost", "name" },
                values: new object[] { 91.1455762735485, "Rustic Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "cost", "name" },
                values: new object[] { 396.94543023417151, "Unbranded Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "cost", "name" },
                values: new object[] { 22.538855439649772, "Awesome Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.69859606424529, "Rustic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "cost", "name" },
                values: new object[] { 488.90735712400499, "Rustic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "cost", "name" },
                values: new object[] { 186.27434297293058, "Practical Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "cost", "name" },
                values: new object[] { 182.73124007321951, "Awesome Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "cost", "name" },
                values: new object[] { 112.30358542572367, "Generic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.04878056794462, "Gorgeous Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "cost", "name" },
                values: new object[] { 873.78757093429078, "Generic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.66011341006867, "Small Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "cost", "name" },
                values: new object[] { 813.98400174328765, "Generic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.47704590064114, "Practical Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "cost", "name" },
                values: new object[] { 648.83404240959919, "Fantastic Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "cost", "name" },
                values: new object[] { 396.09755306691858, "Incredible Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.89629670784291, "Unbranded Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.14282749284143, "Fantastic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "cost", "name" },
                values: new object[] { 54.388315885000829, "Tasty Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.30704693848142, "Ergonomic Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "cost", "name" },
                values: new object[] { 793.92763327757496, "Licensed Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "cost", "name" },
                values: new object[] { 257.80377024687834, "Sleek Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "cost", "name" },
                values: new object[] { 446.80437731695832, "Ergonomic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "cost", "name" },
                values: new object[] { 482.55305750620994, "Awesome Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.73051782467638, "Sleek Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "cost", "name" },
                values: new object[] { 557.31061354107305, "Intelligent Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.03918445910705, "Awesome Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.88681240537744, "Licensed Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "cost", "name" },
                values: new object[] { 197.0913927277592, "Sleek Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "cost", "name" },
                values: new object[] { 582.17137210303883, "Tasty Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.04196288581511, "Unbranded Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "cost", "name" },
                values: new object[] { 2.2251695992989884, "Gorgeous Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.53480608931091, "Incredible Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "cost", "name" },
                values: new object[] { 321.56732466809871, "Awesome Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "cost", "name" },
                values: new object[] { 898.41965380057582, "Generic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "cost", "name" },
                values: new object[] { 766.10273042433221, "Rustic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "cost", "name" },
                values: new object[] { 406.38720164870074, "Licensed Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "cost", "name" },
                values: new object[] { 750.93458274528905, "Sleek Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "cost", "name" },
                values: new object[] { 965.689387344539, "Handmade Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "cost", "name" },
                values: new object[] { 243.50538897527537, "Handcrafted Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "cost", "name" },
                values: new object[] { 709.97917229059954, "Rustic Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "cost", "name" },
                values: new object[] { 644.45137388176499, "Practical Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.35924877890312, "Ergonomic Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.70491495007298, "Sleek Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.34379710529765, "Generic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.78122413214453, "Licensed Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "cost", "name" },
                values: new object[] { 715.07607193421325, "Small Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "cost", "name" },
                values: new object[] { 809.39000872679105, "Rustic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "cost", "name" },
                values: new object[] { 285.76205771019761, "Gorgeous Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "cost", "name" },
                values: new object[] { 605.91246633493506, "Tasty Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "cost", "name" },
                values: new object[] { 148.07845232196436, "Unbranded Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "cost", "name" },
                values: new object[] { 845.49207708318193, "Incredible Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "cost", "name" },
                values: new object[] { 629.59470444620968, "Gorgeous Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "cost", "name" },
                values: new object[] { 934.83948274550892, "Intelligent Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.61215951920525, "Unbranded Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "cost", "name" },
                values: new object[] { 505.33919885376355, "Refined Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "cost", "name" },
                values: new object[] { 977.10806082639112, "Incredible Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.54928943093307, "Small Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "cost", "name" },
                values: new object[] { 932.17824125045956, "Small Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "cost", "name" },
                values: new object[] { 376.07434340788899, "Small Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.285682654518766, "Small Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "cost", "name" },
                values: new object[] { 709.56885774943225, "Unbranded Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "cost", "name" },
                values: new object[] { 86.445832614015885, "Handmade Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "cost", "name" },
                values: new object[] { 320.49416905910232, "Sleek Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.01517229026501, "Handcrafted Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.44731521907465, "Refined Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "cost", "name" },
                values: new object[] { 914.02682902567653, "Tasty Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "cost", "name" },
                values: new object[] { 348.2707080294166, "Sleek Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.40146670469665, "Awesome Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "cost", "name" },
                values: new object[] { 495.75537333248724, "Generic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "cost", "name" },
                values: new object[] { 226.49033775808763, "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "cost", "name" },
                values: new object[] { 624.11074922935677, "Rustic Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "cost", "name" },
                values: new object[] { 494.93625459866092, "Practical Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "cost", "name" },
                values: new object[] { 732.66702944692747, "Tasty Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.77065210381042, "Practical Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.58542444733598, "Licensed Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "cost", "name" },
                values: new object[] { 299.58309445771181, "Tasty Steel Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "cost", "name" },
                values: new object[] { 704.41916963508584, "Rustic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "cost", "name" },
                values: new object[] { 328.98254808488855, "Tasty Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "cost", "name" },
                values: new object[] { 68.31754866306099, "Awesome Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "cost", "name" },
                values: new object[] { 95.435049427900708, "Handmade Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.01741302489074, "Gorgeous Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "cost", "name" },
                values: new object[] { 41.5501856129221, "Awesome Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.01696638529017, "Awesome Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "cost", "name" },
                values: new object[] { 684.2357458410338, "Licensed Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "cost", "name" },
                values: new object[] { 691.69002209983807, "Incredible Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "cost", "name" },
                values: new object[] { 271.03688212667964, "Unbranded Metal Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "cost", "name" },
                values: new object[] { 220.19817851547205, "Handmade Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "cost", "name" },
                values: new object[] { 840.94741531166517, "Awesome Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.79390903526109, "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "cost", "name" },
                values: new object[] { 448.03666338340486, "Rustic Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "cost", "name" },
                values: new object[] { 383.85573878233708, "Practical Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "cost", "name" },
                values: new object[] { 888.35577072103081, "Sleek Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.03019001959603, "Unbranded Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "cost", "name" },
                values: new object[] { 96.800616585463274, "Practical Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "cost", "name" },
                values: new object[] { 390.03639701032006, "Small Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "cost", "name" },
                values: new object[] { 994.75962810699377, "Sleek Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "cost", "name" },
                values: new object[] { 399.64684802289088, "Refined Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.64623918309201, "Tasty Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "cost", "name" },
                values: new object[] { 292.10007992050481, "Intelligent Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "cost", "name" },
                values: new object[] { 241.83844200795815, "Incredible Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "cost", "name" },
                values: new object[] { 989.35212436526547, "Incredible Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "cost", "name" },
                values: new object[] { 928.87081171695252, "Sleek Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "cost", "name" },
                values: new object[] { 847.45724738816568, "Small Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "cost", "name" },
                values: new object[] { 550.64718842940317, "Incredible Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "cost", "name" },
                values: new object[] { 970.68636206302233, "Handcrafted Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "cost", "name" },
                values: new object[] { 359.77365987461889, "Handcrafted Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.755015364485256, "Sleek Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "cost", "name" },
                values: new object[] { 803.82052772357883, "Intelligent Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "cost", "name" },
                values: new object[] { 497.63779612772095, "Unbranded Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "cost", "name" },
                values: new object[] { 170.8183374631956, "Small Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "cost", "name" },
                values: new object[] { 311.10006762004866, "Gorgeous Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "cost", "name" },
                values: new object[] { 6.3782551483674883, "Gorgeous Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "cost", "name" },
                values: new object[] { 60.32077807503299, "Handmade Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "cost", "name" },
                values: new object[] { 741.31527979586826, "Awesome Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "cost", "name" },
                values: new object[] { 407.24768447009797, "Ergonomic Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "cost", "name" },
                values: new object[] { 991.67927805641557, "Unbranded Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "cost", "name" },
                values: new object[] { 812.11599925648886, "Handcrafted Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.59853941602475, "Fantastic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "cost", "name" },
                values: new object[] { 623.02312042161032, "Unbranded Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "cost", "name" },
                values: new object[] { 913.2871169218987, "Practical Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "cost", "name" },
                values: new object[] { 423.21728275200962, "Intelligent Metal Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "cost", "name" },
                values: new object[] { 245.5834963184578, "Practical Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "cost", "name" },
                values: new object[] { 709.39804229390552, "Incredible Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "cost", "name" },
                values: new object[] { 990.65612125147982, "Tasty Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "cost", "name" },
                values: new object[] { 982.33214605482578, "Handmade Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "cost", "name" },
                values: new object[] { 373.85481624106882, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "cost", "name" },
                values: new object[] { 747.65225044217755, "Licensed Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "cost", "name" },
                values: new object[] { 62.627613334756077, "Tasty Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "cost", "name" },
                values: new object[] { 663.34677798896303, "Gorgeous Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.98599154942086, "Ergonomic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "cost", "name" },
                values: new object[] { 104.61980060940459, "Refined Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "cost", "name" },
                values: new object[] { 648.30265156413532, "Handmade Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "cost", "name" },
                values: new object[] { 538.44918705613759, "Refined Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "cost", "name" },
                values: new object[] { 52.148004320907205, "Intelligent Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "cost", "name" },
                values: new object[] { 768.29218289883977, "Unbranded Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.76364117146593, "Incredible Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.98083091029036, "Unbranded Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "cost", "name" },
                values: new object[] { 493.71375450236775, "Practical Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.09728454957542, "Unbranded Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "cost", "name" },
                values: new object[] { 991.44589998383958, "Ergonomic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "cost", "name" },
                values: new object[] { 830.34018735653422, "Awesome Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "cost", "name" },
                values: new object[] { 219.99236649861854, "Rustic Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.53369846987391, "Sleek Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "cost", "name" },
                values: new object[] { 696.66096609424676, "Handmade Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "cost", "name" },
                values: new object[] { 653.29270517517875, "Awesome Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.74426737956446, "Tasty Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "cost", "name" },
                values: new object[] { 16.020488360092912, "Incredible Soft Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "cost", "name" },
                values: new object[] { 281.8841588163798, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "cost", "name" },
                values: new object[] { 64.702023931511135, "Practical Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "cost", "name" },
                values: new object[] { 976.38919206000173, "Awesome Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "cost", "name" },
                values: new object[] { 898.64556516344965, "Handmade Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "cost", "name" },
                values: new object[] { 280.42365078826248, "Intelligent Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.50790905553961, "Sleek Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.62777289860836, "Handmade Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.80878518552629, "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "cost", "name" },
                values: new object[] { 588.11866556309747, "Sleek Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "cost", "name" },
                values: new object[] { 405.16480732516823, "Ergonomic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "cost", "name" },
                values: new object[] { 559.11022985962222, "Handcrafted Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "cost", "name" },
                values: new object[] { 426.79536863610974, "Sleek Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "cost", "name" },
                values: new object[] { 31.173792042713373, "Handmade Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "cost", "name" },
                values: new object[] { 501.37227712925539, "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "cost", "name" },
                values: new object[] { 368.22929354062808, "Refined Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "cost", "name" },
                values: new object[] { 335.50817026148542, "Sleek Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "cost", "name" },
                values: new object[] { 580.46310681901059, "Handmade Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "cost", "name" },
                values: new object[] { 504.99703955859246, "Generic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "cost", "name" },
                values: new object[] { 113.48339243959852, "Licensed Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "cost", "name" },
                values: new object[] { 369.59783004354739, "Unbranded Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "cost", "name" },
                values: new object[] { 335.68124464726588, "Generic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "cost", "name" },
                values: new object[] { 260.50245287803432, "Gorgeous Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "cost", "name" },
                values: new object[] { 332.30300878035445, "Rustic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "cost", "name" },
                values: new object[] { 224.84325068136482, "Gorgeous Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "cost", "name" },
                values: new object[] { 383.8745716409511, "Intelligent Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.89571204277559, "Tasty Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "cost", "name" },
                values: new object[] { 219.90992429084667, "Small Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "cost", "name" },
                values: new object[] { 373.37326714131063, "Refined Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "cost", "name" },
                values: new object[] { 347.91442480182627, "Tasty Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.78716937013905, "Small Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.63734881001608, "Awesome Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "cost", "name" },
                values: new object[] { 536.85051012456938, "Gorgeous Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "cost", "name" },
                values: new object[] { 625.22386370323829, "Gorgeous Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "cost", "name" },
                values: new object[] { 538.78026654900282, "Practical Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "cost", "name" },
                values: new object[] { 784.1537582995777, "Small Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "cost", "name" },
                values: new object[] { 896.94012651067703, "Handmade Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "cost", "name" },
                values: new object[] { 807.37393673924919, "Licensed Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.93995075104823, "Practical Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "cost", "name" },
                values: new object[] { 396.59211829344264, "Sleek Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.88326646577019, "Gorgeous Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "cost", "name" },
                values: new object[] { 725.85760228226991, "Gorgeous Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "cost", "name" },
                values: new object[] { 275.40153884533891, "Intelligent Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "cost", "name" },
                values: new object[] { 159.12484630995144, "Refined Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.17966572730495, "Gorgeous Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "cost", "name" },
                values: new object[] { 951.27352959842995, "Intelligent Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "cost", "name" },
                values: new object[] { 730.38908488774427, "Tasty Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "cost", "name" },
                values: new object[] { 936.16761795736568, "Intelligent Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.27183520670289, "Gorgeous Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "cost", "name" },
                values: new object[] { 288.28180040666308, "Rustic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "cost", "name" },
                values: new object[] { 127.64261264762273, "Handmade Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "cost", "name" },
                values: new object[] { 841.33195724068707, "Generic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "cost", "name" },
                values: new object[] { 75.082171824458143, "Practical Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "cost", "name" },
                values: new object[] { 599.90988414656636, "Practical Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "cost", "name" },
                values: new object[] { 849.47959646745846, "Refined Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "cost", "name" },
                values: new object[] { 349.5420757155689, "Generic Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "cost", "name" },
                values: new object[] { 537.6679204926495, "Licensed Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "cost", "name" },
                values: new object[] { 726.30384564659948, "Generic Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "cost", "name" },
                values: new object[] { 75.215629404002414, "Awesome Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "cost", "name" },
                values: new object[] { 68.688336225049639, "Licensed Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "cost", "name" },
                values: new object[] { 612.27110501440472, "Small Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.629266461619181, "Fantastic Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "cost", "name" },
                values: new object[] { 286.15918274953532, "Rustic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "cost", "name" },
                values: new object[] { 175.87597549353916, "Practical Metal Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "cost", "name" },
                values: new object[] { 263.2559008027319, "Gorgeous Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.363630599142752, "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "cost", "name" },
                values: new object[] { 272.42506624306674, "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.43470462520213, "Refined Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "cost", "name" },
                values: new object[] { 801.88603581841573, "Generic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "cost", "name" },
                values: new object[] { 455.06104312938328, "Awesome Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "cost", "name" },
                values: new object[] { 830.30421672017462, "Awesome Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "cost", "name" },
                values: new object[] { 123.9305641804728, "Sleek Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "cost", "name" },
                values: new object[] { 935.71947929220062, "Refined Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "cost", "name" },
                values: new object[] { 793.16033773875381, "Licensed Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "cost", "name" },
                values: new object[] { 485.74080788311119, "Licensed Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "cost", "name" },
                values: new object[] { 459.70826675033749, "Generic Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "cost", "name" },
                values: new object[] { 191.65627621403738, "Tasty Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "cost", "name" },
                values: new object[] { 564.25452428206665, "Generic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "cost", "name" },
                values: new object[] { 404.37434119249139, "Incredible Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.01747358444231, "Tasty Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "cost", "name" },
                values: new object[] { 318.67256510052721, "Handcrafted Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "cost", "name" },
                values: new object[] { 901.00394147740258, "Ergonomic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "cost", "name" },
                values: new object[] { 2.9831072536677254, "Rustic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.13476638267338, "Licensed Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "cost", "name" },
                values: new object[] { 706.47339162854098, "Tasty Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "cost", "name" },
                values: new object[] { 757.50759401385699, "Gorgeous Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "cost", "name" },
                values: new object[] { 527.37125889307822, "Unbranded Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "cost", "name" },
                values: new object[] { 784.58742186639131, "Gorgeous Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "cost", "name" },
                values: new object[] { 727.55025161841218, "Small Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "cost", "name" },
                values: new object[] { 679.50953524860347, "Incredible Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "cost", "name" },
                values: new object[] { 780.80193430751751, "Awesome Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "cost", "name" },
                values: new object[] { 868.94016290735897, "Licensed Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "cost", "name" },
                values: new object[] { 867.99217111299492, "Tasty Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.215019370748546, "Handcrafted Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "cost", "name" },
                values: new object[] { 656.31354046814965, "Intelligent Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.66260221685033, "Refined Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "cost", "name" },
                values: new object[] { 960.41475659441301, "Small Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "cost", "name" },
                values: new object[] { 487.27812295432284, "Gorgeous Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "cost", "name" },
                values: new object[] { 109.48729329870076, "Small Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "cost", "name" },
                values: new object[] { 286.35497930039423, "Rustic Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "cost", "name" },
                values: new object[] { 261.74687380837446, "Handmade Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "cost", "name" },
                values: new object[] { 930.92189502753399, "Handmade Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "cost", "name" },
                values: new object[] { 643.84366388140961, "Small Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "cost", "name" },
                values: new object[] { 636.16963003070452, "Incredible Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "cost", "name" },
                values: new object[] { 145.77421438638734, "Rustic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "cost", "name" },
                values: new object[] { 628.67605010323257, "Licensed Soft Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "cost", "name" },
                values: new object[] { 467.59025928130274, "Licensed Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "cost", "name" },
                values: new object[] { 262.8758880662956, "Handcrafted Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.17551690721507, "Refined Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "cost", "name" },
                values: new object[] { 148.99027767038879, "Practical Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "cost", "name" },
                values: new object[] { 695.51338949782462, "Rustic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "cost", "name" },
                values: new object[] { 693.67854058098806, "Generic Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "cost", "name" },
                values: new object[] { 475.11751414343837, "Practical Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "cost", "name" },
                values: new object[] { 874.39570129923584, "Handcrafted Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "cost", "name" },
                values: new object[] { 225.14509628783881, "Unbranded Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "cost", "name" },
                values: new object[] { 325.64735324781412, "Handmade Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "cost", "name" },
                values: new object[] { 835.69468522420539, "Ergonomic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "cost", "name" },
                values: new object[] { 815.37565903721895, "Rustic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "cost", "name" },
                values: new object[] { 132.7985271453021, "Awesome Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "cost", "name" },
                values: new object[] { 924.80324834970577, "Fantastic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "cost", "name" },
                values: new object[] { 48.417277481827007, "Unbranded Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "cost", "name" },
                values: new object[] { 3.9769054625293099, "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "cost", "name" },
                values: new object[] { 500.75458038368123, "Ergonomic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.21663506889576, "Handcrafted Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "cost", "name" },
                values: new object[] { 752.73995680019004, "Licensed Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.07153491149313, "Ergonomic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "cost", "name" },
                values: new object[] { 684.72351739985868, "Fantastic Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "cost", "name" },
                values: new object[] { 697.8087800565778, "Refined Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "cost", "name" },
                values: new object[] { 681.79549474324278, "Awesome Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "cost", "name" },
                values: new object[] { 355.82209299308522, "Handcrafted Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "cost", "name" },
                values: new object[] { 504.41680485297161, "Handmade Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "cost", "name" },
                values: new object[] { 150.81898882852784, "Awesome Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "cost", "name" },
                values: new object[] { 288.69181443558256, "Small Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "cost", "name" },
                values: new object[] { 686.1075288560445, "Practical Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "cost", "name" },
                values: new object[] { 469.88552904195819, "Ergonomic Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "cost", "name" },
                values: new object[] { 991.98611285633422, "Rustic Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "cost", "name" },
                values: new object[] { 666.25767860333895, "Sleek Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "cost", "name" },
                values: new object[] { 61.837065568419256, "Licensed Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "cost", "name" },
                values: new object[] { 491.95305824871809, "Incredible Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "cost", "name" },
                values: new object[] { 633.85350408212742, "Rustic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.03943761727183, "Rustic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "cost", "name" },
                values: new object[] { 201.5981082057705, "Rustic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "cost", "name" },
                values: new object[] { 585.63671932829516, "Generic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "cost", "name" },
                values: new object[] { 913.69758262555251, "Small Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "cost", "name" },
                values: new object[] { 845.45071606557804, "Tasty Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "cost", "name" },
                values: new object[] { 747.09089444281835, "Licensed Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "cost", "name" },
                values: new object[] { 384.41099097957107, "Handcrafted Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "cost", "name" },
                values: new object[] { 949.25593542515014, "Refined Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "cost", "name" },
                values: new object[] { 896.25744764033982, "Licensed Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "cost", "name" },
                values: new object[] { 122.09783072103397, "Sleek Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "cost", "name" },
                values: new object[] { 880.02208867157651, "Sleek Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "cost", "name" },
                values: new object[] { 248.02569848752165, "Incredible Soft Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "cost", "name" },
                values: new object[] { 314.64907521320407, "Handcrafted Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "cost", "name" },
                values: new object[] { 771.45505050646136, "Sleek Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "cost", "name" },
                values: new object[] { 171.54261522898906, "Small Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "cost", "name" },
                values: new object[] { 265.68604302228408, "Incredible Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "cost", "name" },
                values: new object[] { 360.31477673558942, "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "cost", "name" },
                values: new object[] { 804.96481924260115, "Generic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.98949354791296, "Handmade Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.34413391389137, "Incredible Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "cost", "name" },
                values: new object[] { 688.56659680248322, "Handmade Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "cost", "name" },
                values: new object[] { 547.90068798496861, "Refined Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "cost", "name" },
                values: new object[] { 758.00583099005246, "Tasty Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "cost", "name" },
                values: new object[] { 302.81222649854755, "Ergonomic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "cost", "name" },
                values: new object[] { 17.082773250180573, "Refined Granite Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "cost", "name" },
                values: new object[] { 884.18895394415892, "Fantastic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "cost", "name" },
                values: new object[] { 826.61142973981964, "Awesome Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "cost", "name" },
                values: new object[] { 445.6792829479823, "Licensed Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "cost", "name" },
                values: new object[] { 981.78683993393975, "Gorgeous Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "cost", "name" },
                values: new object[] { 757.28134337487222, "Tasty Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.25451889747865, "Unbranded Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "cost", "name" },
                values: new object[] { 359.64653431221177, "Gorgeous Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "cost", "name" },
                values: new object[] { 539.64897938225965, "Generic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "cost", "name" },
                values: new object[] { 202.33844673458748, "Small Metal Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "cost", "name" },
                values: new object[] { 488.97089050056786, "Unbranded Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "cost", "name" },
                values: new object[] { 728.14573781005492, "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.08332238451032, "Unbranded Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.71214430967035, "Refined Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "cost", "name" },
                values: new object[] { 951.03530589414447, "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "cost", "name" },
                values: new object[] { 459.53653755856357, "Gorgeous Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "cost", "name" },
                values: new object[] { 647.81556998051747, "Handmade Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "cost", "name" },
                values: new object[] { 399.25033788930892, "Generic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "cost", "name" },
                values: new object[] { 275.68261787573664, "Awesome Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "cost", "name" },
                values: new object[] { 773.38235392073568, "Incredible Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "cost", "name" },
                values: new object[] { 405.60380230118108, "Refined Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "cost", "name" },
                values: new object[] { 111.0869317520349, "Ergonomic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "cost", "name" },
                values: new object[] { 196.45661410181725, "Practical Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "cost", "name" },
                values: new object[] { 443.31048118036983, "Handcrafted Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "cost", "name" },
                values: new object[] { 491.43971658368514, "Fantastic Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.08682547581867, "Awesome Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "cost", "name" },
                values: new object[] { 592.66586714946925, "Ergonomic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "cost", "name" },
                values: new object[] { 322.02409042917543, "Fantastic Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "cost", "name" },
                values: new object[] { 397.0269700328322, "Awesome Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "cost", "name" },
                values: new object[] { 668.25665533429878, "Ergonomic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "cost", "name" },
                values: new object[] { 741.42741806301854, "Refined Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "cost", "name" },
                values: new object[] { 468.57856955983539, "Practical Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "cost", "name" },
                values: new object[] { 391.46497584212375, "Gorgeous Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "cost", "name" },
                values: new object[] { 498.43881057383663, "Intelligent Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "cost", "name" },
                values: new object[] { 231.90643059652641, "Incredible Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "cost", "name" },
                values: new object[] { 94.557327058091857, "Sleek Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "cost", "name" },
                values: new object[] { 883.62339255897712, "Handmade Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "cost", "name" },
                values: new object[] { 303.68597348467256, "Small Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.5404742705374, "Handcrafted Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "cost", "name" },
                values: new object[] { 642.34955803009655, "Licensed Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "cost", "name" },
                values: new object[] { 248.66908781228301, "Awesome Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "cost", "name" },
                values: new object[] { 113.51978077509315, "Sleek Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.82945454347879, "Ergonomic Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "cost", "name" },
                values: new object[] { 571.0543814025483, "Fantastic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "cost", "name" },
                values: new object[] { 191.88239626123499, "Fantastic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "cost", "name" },
                values: new object[] { 437.75202887126596, "Unbranded Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "cost", "name" },
                values: new object[] { 625.21884997628229, "Awesome Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "cost", "name" },
                values: new object[] { 28.694192223044876, "Handcrafted Soft Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "cost", "name" },
                values: new object[] { 396.52337716968907, "Incredible Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "cost", "name" },
                values: new object[] { 693.05349951293749, "Fantastic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "cost", "name" },
                values: new object[] { 264.89629526585571, "Gorgeous Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "cost", "name" },
                values: new object[] { 760.22001968267682, "Awesome Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.63186750133502, "Practical Metal Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.05918114229098, "Handcrafted Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "cost", "name" },
                values: new object[] { 818.46944345119857, "Ergonomic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "cost", "name" },
                values: new object[] { 748.86980341594938, "Unbranded Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "cost", "name" },
                values: new object[] { 410.48163241624542, "Intelligent Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "cost", "name" },
                values: new object[] { 129.09187309640356, "Sleek Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "cost", "name" },
                values: new object[] { 876.36892579074345, "Intelligent Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "cost", "name" },
                values: new object[] { 314.89780370104074, "Sleek Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "cost", "name" },
                values: new object[] { 945.55058708378488, "Ergonomic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "cost", "name" },
                values: new object[] { 434.92205575545739, "Unbranded Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "cost", "name" },
                values: new object[] { 285.65029837927864, "Incredible Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "cost", "name" },
                values: new object[] { 55.385170812582707, "Awesome Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "cost", "name" },
                values: new object[] { 669.34718254200902, "Incredible Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "cost", "name" },
                values: new object[] { 626.59693025949491, "Sleek Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "cost", "name" },
                values: new object[] { 100.93451402020149, "Handmade Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "cost", "name" },
                values: new object[] { 891.97098712527577, "Gorgeous Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "cost", "name" },
                values: new object[] { 907.24391177079519, "Small Wooden Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "cost", "name" },
                values: new object[] { 596.39433857892084, "Handmade Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.11109786697583, "Handmade Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "cost", "name" },
                values: new object[] { 639.20678205938555, "Licensed Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "cost", "name" },
                values: new object[] { 307.45836342238226, "Ergonomic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "cost", "name" },
                values: new object[] { 286.08788139499404, "Small Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "cost", "name" },
                values: new object[] { 720.03605237611396, "Rustic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.25334111184407, "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "cost", "name" },
                values: new object[] { 265.09109521951876, "Tasty Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "cost", "name" },
                values: new object[] { 25.716753390851999, "Practical Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.24425310190782, "Refined Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.83025406079909, "Tasty Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "cost", "name" },
                values: new object[] { 140.83712608772768, "Handcrafted Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "cost", "name" },
                values: new object[] { 51.771761277434159, "Refined Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "cost", "name" },
                values: new object[] { 305.64146058125903, "Awesome Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "cost", "name" },
                values: new object[] { 780.46553480289026, "Ergonomic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "cost", "name" },
                values: new object[] { 280.94235649871547, "Generic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "cost", "name" },
                values: new object[] { 37.172967702317138, "Tasty Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "cost", "name" },
                values: new object[] { 81.388309475488242, "Tasty Fresh Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.07005703423374, "Handcrafted Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "cost", "name" },
                values: new object[] { 402.85134062633131, "Handcrafted Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "cost", "name" },
                values: new object[] { 453.05820731292971, "Generic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "cost", "name" },
                values: new object[] { 554.43719389598232, "Generic Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "cost", "name" },
                values: new object[] { 376.51371501323416, "Handmade Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "cost", "name" },
                values: new object[] { 285.68818897360035, "Unbranded Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "cost", "name" },
                values: new object[] { 977.70658622599171, "Ergonomic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.34283766997203, "Generic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "cost", "name" },
                values: new object[] { 697.04109985021591, "Fantastic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "cost", "name" },
                values: new object[] { 92.362573318377329, "Generic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "cost", "name" },
                values: new object[] { 65.727875801050288, "Generic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "cost", "name" },
                values: new object[] { 973.33767475265404, "Handmade Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "cost", "name" },
                values: new object[] { 656.63334280546894, "Rustic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "cost", "name" },
                values: new object[] { 542.49944190143287, "Practical Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.36744478591712, "Handcrafted Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "cost", "name" },
                values: new object[] { 72.315583702573704, "Tasty Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "cost", "name" },
                values: new object[] { 270.23156202866261, "Tasty Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.82432304688072, "Incredible Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "cost", "name" },
                values: new object[] { 398.6169521975375, "Handcrafted Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.1396782550587, "Licensed Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.06634322042134, "Refined Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "cost", "name" },
                values: new object[] { 983.65567459908743, "Rustic Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "cost", "name" },
                values: new object[] { 329.3867849481241, "Handcrafted Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "cost", "name" },
                values: new object[] { 715.39303053224933, "Small Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "cost", "name" },
                values: new object[] { 146.30135259040131, "Licensed Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "cost", "name" },
                values: new object[] { 892.3595155304705, "Practical Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "cost", "name" },
                values: new object[] { 305.37361242426311, "Intelligent Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "cost", "name" },
                values: new object[] { 138.34060235816349, "Handmade Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "cost", "name" },
                values: new object[] { 443.31868546664225, "Generic Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "cost", "name" },
                values: new object[] { 299.17793858674298, "Practical Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "cost", "name" },
                values: new object[] { 253.85788762916928, "Gorgeous Granite Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "cost", "name" },
                values: new object[] { 56.780261747744483, "Tasty Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "cost", "name" },
                values: new object[] { 323.87318208745148, "Small Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "cost", "name" },
                values: new object[] { 489.89211653164699, "Licensed Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "cost", "name" },
                values: new object[] { 336.97928472900139, "Tasty Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "cost", "name" },
                values: new object[] { 655.94771668977046, "Licensed Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "cost", "name" },
                values: new object[] { 918.48883075889057, "Fantastic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "cost", "name" },
                values: new object[] { 787.16607151661901, "Tasty Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "cost", "name" },
                values: new object[] { 165.14445575000317, "Refined Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "cost", "name" },
                values: new object[] { 907.52532006186357, "Ergonomic Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "cost", "name" },
                values: new object[] { 242.41424932951881, "Sleek Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "cost", "name" },
                values: new object[] { 10.255513189283088, "Licensed Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.22445874974977, "Rustic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "cost", "name" },
                values: new object[] { 946.77975971824992, "Incredible Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "cost", "name" },
                values: new object[] { 20.678973771761992, "Unbranded Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "cost", "name" },
                values: new object[] { 629.064069229751, "Intelligent Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "cost", "name" },
                values: new object[] { 295.4150391961665, "Handmade Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "cost", "name" },
                values: new object[] { 878.01995499105135, "Small Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "cost", "name" },
                values: new object[] { 757.57837884044932, "Intelligent Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "cost", "name" },
                values: new object[] { 343.50946008091472, "Refined Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "cost", "name" },
                values: new object[] { 432.678236849006, "Ergonomic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "cost", "name" },
                values: new object[] { 242.47854345869186, "Rustic Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.14595560164219, "Gorgeous Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "cost", "name" },
                values: new object[] { 758.85996308971426, "Licensed Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.02818541027187, "Handcrafted Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "cost", "name" },
                values: new object[] { 625.94559903536822, "Refined Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "cost", "name" },
                values: new object[] { 620.18443980853885, "Rustic Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "cost", "name" },
                values: new object[] { 766.61716876804678, "Gorgeous Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "cost", "name" },
                values: new object[] { 210.31968684299267, "Unbranded Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.05514489941709, "Ergonomic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "cost", "name" },
                values: new object[] { 954.13260727549437, "Practical Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "cost", "name" },
                values: new object[] { 292.92239673624726, "Small Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "cost", "name" },
                values: new object[] { 533.04118043088658, "Licensed Metal Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "cost", "name" },
                values: new object[] { 915.90817184180275, "Awesome Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "cost", "name" },
                values: new object[] { 773.16009116205134, "Handmade Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "cost", "name" },
                values: new object[] { 643.98053802006473, "Handmade Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "cost", "name" },
                values: new object[] { 454.07719726506031, "Generic Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "cost", "name" },
                values: new object[] { 84.337830332458964, "Handcrafted Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "cost", "name" },
                values: new object[] { 304.11726501377041, "Gorgeous Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.50214174212647, "Tasty Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "cost", "name" },
                values: new object[] { 246.88295102832228, "Handcrafted Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "cost", "name" },
                values: new object[] { 330.28709228512344, "Incredible Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.68573182142609, "Sleek Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "cost", "name" },
                values: new object[] { 210.8359993602177, "Handmade Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "cost", "name" },
                values: new object[] { 241.45839368465275, "Handmade Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "cost", "name" },
                values: new object[] { 929.61498946011454, "Generic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "cost", "name" },
                values: new object[] { 256.93067948041084, "Incredible Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "cost", "name" },
                values: new object[] { 741.29910350408795, "Tasty Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "cost", "name" },
                values: new object[] { 503.80938601499827, "Generic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "cost", "name" },
                values: new object[] { 212.1243416369538, "Gorgeous Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "cost", "name" },
                values: new object[] { 934.0846079403633, "Ergonomic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.16136883987394, "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "cost", "name" },
                values: new object[] { 337.82234397871406, "Awesome Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "cost", "name" },
                values: new object[] { 353.82593731329939, "Unbranded Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "cost", "name" },
                values: new object[] { 937.89844937067846, "Handmade Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "cost", "name" },
                values: new object[] { 198.99292331948442, "Small Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "cost", "name" },
                values: new object[] { 51.430546686237072, "Awesome Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "cost", "name" },
                values: new object[] { 69.635179373557165, "Fantastic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "cost", "name" },
                values: new object[] { 188.69878102997924, "Sleek Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "cost", "name" },
                values: new object[] { 826.87872556947957, "Unbranded Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.303102829261142, "Sleek Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "cost", "name" },
                values: new object[] { 394.07567265887883, "Sleek Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "cost", "name" },
                values: new object[] { 954.89894711751344, "Handmade Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "cost", "name" },
                values: new object[] { 639.3898683868473, "Ergonomic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.971618765362393, "Rustic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.02029069530005, "Small Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "cost", "name" },
                values: new object[] { 673.20934815077646, "Small Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "cost", "name" },
                values: new object[] { 611.33867537129117, "Practical Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "cost", "name" },
                values: new object[] { 453.80489955260242, "Ergonomic Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "cost", "name" },
                values: new object[] { 442.79780849923452, "Awesome Cotton Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "cost", "name" },
                values: new object[] { 224.04704747428542, "Sleek Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "cost", "name" },
                values: new object[] { 456.09001442377081, "Sleek Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "cost", "name" },
                values: new object[] { 896.59335624168409, "Unbranded Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "cost", "name" },
                values: new object[] { 79.939368641973104, "Sleek Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "cost", "name" },
                values: new object[] { 975.31995892113093, "Intelligent Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "cost", "name" },
                values: new object[] { 520.36893185988583, "Ergonomic Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "cost", "name" },
                values: new object[] { 62.44717145278252, "Intelligent Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "cost", "name" },
                values: new object[] { 63.050648148300041, "Incredible Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.59281145627165, "Generic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "cost", "name" },
                values: new object[] { 236.29490483206376, "Practical Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "cost", "name" },
                values: new object[] { 340.23060768768767, "Ergonomic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "cost", "name" },
                values: new object[] { 81.453976223175914, "Handmade Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "cost", "name" },
                values: new object[] { 167.55543384937172, "Small Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.98802738428714, "Sleek Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "cost", "name" },
                values: new object[] { 289.39985771116937, "Licensed Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.92990265091669, "Unbranded Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "cost", "name" },
                values: new object[] { 934.62387176769812, "Fantastic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "cost", "name" },
                values: new object[] { 947.36378057479612, "Awesome Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "cost", "name" },
                values: new object[] { 182.71715037667869, "Fantastic Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "cost", "name" },
                values: new object[] { 439.38161694292268, "Fantastic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "cost", "name" },
                values: new object[] { 457.32190848298245, "Handcrafted Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "cost", "name" },
                values: new object[] { 161.0024494335199, "Ergonomic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "cost", "name" },
                values: new object[] { 19.002924406918563, "Intelligent Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "cost", "name" },
                values: new object[] { 362.45157801610594, "Sleek Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "cost", "name" },
                values: new object[] { 114.54126663928571, "Fantastic Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "cost", "name" },
                values: new object[] { 330.12409778262383, "Rustic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "cost", "name" },
                values: new object[] { 872.43078885743603, "Intelligent Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.47234701619732, "Rustic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "cost", "name" },
                values: new object[] { 977.61341244688163, "Practical Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "cost", "name" },
                values: new object[] { 568.72950962201674, "Ergonomic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.95195767587461, "Incredible Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "cost", "name" },
                values: new object[] { 58.155025539182759, "Incredible Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "cost", "name" },
                values: new object[] { 149.14064952041517, "Fantastic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "cost", "name" },
                values: new object[] { 635.17315119875991, "Generic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "cost", "name" },
                values: new object[] { 655.18747573161261, "Tasty Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.43739812548188, "Generic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "cost", "name" },
                values: new object[] { 964.46816640892484, "Handmade Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "cost", "name" },
                values: new object[] { 440.32493523481924, "Licensed Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.54863268393308, "Fantastic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "cost", "name" },
                values: new object[] { 924.28595249417117, "Licensed Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "cost", "name" },
                values: new object[] { 225.66757536510843, "Unbranded Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "cost", "name" },
                values: new object[] { 19.363807017049417, "Sleek Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.501452284648877, "Awesome Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "cost", "name" },
                values: new object[] { 291.31752909240225, "Handmade Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "cost", "name" },
                values: new object[] { 382.38272902082639, "Small Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "cost", "name" },
                values: new object[] { 949.57209515671445, "Rustic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "cost", "name" },
                values: new object[] { 769.76556177369048, "Handmade Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "cost", "name" },
                values: new object[] { 295.76690951565803, "Handcrafted Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "cost", "name" },
                values: new object[] { 797.09206240459628, "Incredible Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "cost", "name" },
                values: new object[] { 916.9284346508274, "Handcrafted Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "cost", "name" },
                values: new object[] { 818.08678641800304, "Practical Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "cost", "name" },
                values: new object[] { 542.72591737018001, "Intelligent Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "cost", "name" },
                values: new object[] { 837.72021575870679, "Generic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "cost", "name" },
                values: new object[] { 429.19790260832843, "Incredible Wooden Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.88589830065087, "Rustic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "cost", "name" },
                values: new object[] { 318.78758035374295, "Practical Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "cost", "name" },
                values: new object[] { 547.20433157132049, "Handcrafted Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "cost", "name" },
                values: new object[] { 519.99644503363709, "Handmade Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "cost", "name" },
                values: new object[] { 290.97793938548693, "Refined Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "cost", "name" },
                values: new object[] { 425.594336360927, "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "cost", "name" },
                values: new object[] { 171.83752417376408, "Licensed Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "cost", "name" },
                values: new object[] { 711.58998456034328, "Handcrafted Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "cost", "name" },
                values: new object[] { 97.378370314173026, "Gorgeous Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "cost", "name" },
                values: new object[] { 173.50278149435883, "Generic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "cost", "name" },
                values: new object[] { 173.21121592439499, "Gorgeous Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "cost", "name" },
                values: new object[] { 806.51500920200294, "Handmade Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "cost", "name" },
                values: new object[] { 98.027060680114559, "Refined Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "cost", "name" },
                values: new object[] { 839.61895668997965, "Fantastic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "cost", "name" },
                values: new object[] { 399.22583673802666, "Gorgeous Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "cost", "name" },
                values: new object[] { 705.91972221004482, "Intelligent Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "cost", "name" },
                values: new object[] { 165.6632282846555, "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "cost", "name" },
                values: new object[] { 308.53271933984695, "Handcrafted Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "cost", "name" },
                values: new object[] { 91.256590663439141, "Generic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "cost", "name" },
                values: new object[] { 206.19326525717875, "Fantastic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.82241655280109, "Licensed Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.57509835772089, "Fantastic Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "cost", "name" },
                values: new object[] { 995.79568257965104, "Practical Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "cost", "name" },
                values: new object[] { 680.49725355817111, "Awesome Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "cost", "name" },
                values: new object[] { 48.55509481733462, "Ergonomic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "cost", "name" },
                values: new object[] { 576.105524537826, "Small Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "cost", "name" },
                values: new object[] { 593.32921649760431, "Generic Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "cost", "name" },
                values: new object[] { 617.58714957205802, "Intelligent Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.60022035583461, "Awesome Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.375824513838694, "Incredible Granite Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "cost", "name" },
                values: new object[] { 685.80037019866336, "Licensed Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "cost", "name" },
                values: new object[] { 508.7848014517586, "Practical Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "cost", "name" },
                values: new object[] { 383.83019905438272, "Practical Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "cost", "name" },
                values: new object[] { 563.44124273080581, "Licensed Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "cost", "name" },
                values: new object[] { 224.66240359094743, "Handmade Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "cost", "name" },
                values: new object[] { 431.34305231197743, "Awesome Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "cost", "name" },
                values: new object[] { 332.28197035688555, "Licensed Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "cost", "name" },
                values: new object[] { 243.01685773660157, "Handmade Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "cost", "name" },
                values: new object[] { 509.64666422925097, "Small Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "cost", "name" },
                values: new object[] { 877.44491107733541, "Tasty Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.23045696747363, "Licensed Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "cost", "name" },
                values: new object[] { 702.23469175172113, "Handcrafted Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "cost", "name" },
                values: new object[] { 362.77026402190108, "Tasty Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "cost", "name" },
                values: new object[] { 886.54199411323566, "Intelligent Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.8707391295996, "Intelligent Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "cost", "name" },
                values: new object[] { 463.46336905422862, "Refined Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.23706909955325, "Rustic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.47290902396219, "Handcrafted Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "cost", "name" },
                values: new object[] { 212.47572148124669, "Intelligent Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "cost", "name" },
                values: new object[] { 114.41076833472695, "Incredible Granite Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.30049365776665, "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "cost", "name" },
                values: new object[] { 159.23854731149305, "Practical Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "cost", "name" },
                values: new object[] { 427.05235976998057, "Generic Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "cost", "name" },
                values: new object[] { 329.99112228505936, "Fantastic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "cost", "name" },
                values: new object[] { 419.41191714188005, "Ergonomic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "cost", "name" },
                values: new object[] { 670.05447113428215, "Incredible Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "cost", "name" },
                values: new object[] { 352.87377529806162, "Gorgeous Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "cost", "name" },
                values: new object[] { 21.244445357945214, "Awesome Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "cost", "name" },
                values: new object[] { 750.69766345887263, "Unbranded Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.16325032305866, "Ergonomic Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "cost", "name" },
                values: new object[] { 5.5186024060141117, "Handmade Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "cost", "name" },
                values: new object[] { 78.070656614589922, "Sleek Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "cost", "name" },
                values: new object[] { 582.73500665813629, "Sleek Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "cost", "name" },
                values: new object[] { 58.060015132631335, "Gorgeous Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.46671870901889, "Handcrafted Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "cost", "name" },
                values: new object[] { 372.25593022286529, "Sleek Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "cost", "name" },
                values: new object[] { 828.87991497880057, "Unbranded Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "cost", "name" },
                values: new object[] { 925.65486755943414, "Generic Soft Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.44133280609958, "Licensed Granite Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "cost", "name" },
                values: new object[] { 594.59598422607758, "Licensed Steel Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "cost", "name" },
                values: new object[] { 7.6790893245110476, "Awesome Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "cost", "name" },
                values: new object[] { 537.23199185228555, "Refined Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "cost", "name" },
                values: new object[] { 369.12316894456097, "Handmade Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "cost", "name" },
                values: new object[] { 425.2115101115553, "Generic Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "cost", "name" },
                values: new object[] { 187.65891381143157, "Handmade Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "cost", "name" },
                values: new object[] { 845.29628552956603, "Licensed Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "cost", "name" },
                values: new object[] { 900.7716791188268, "Practical Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "cost", "name" },
                values: new object[] { 895.87473286282761, "Licensed Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "cost", "name" },
                values: new object[] { 48.046436935695553, "Handmade Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "cost", "name" },
                values: new object[] { 181.03788093043349, "Gorgeous Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "cost", "name" },
                values: new object[] { 598.00800122982128, "Handcrafted Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "cost", "name" },
                values: new object[] { 784.49233310087391, "Rustic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.53150808318605, "Ergonomic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.2032637316367363, "Fantastic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "cost", "name" },
                values: new object[] { 584.74956298932477, "Fantastic Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "cost", "name" },
                values: new object[] { 484.94400863422015, "Ergonomic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "cost", "name" },
                values: new object[] { 764.74754560337101, "Licensed Fresh Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "cost", "name" },
                values: new object[] { 505.43647487820402, "Fantastic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "cost", "name" },
                values: new object[] { 845.32975508937022, "Tasty Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "cost", "name" },
                values: new object[] { 993.24081586585248, "Gorgeous Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "cost", "name" },
                values: new object[] { 289.78043441419589, "Ergonomic Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.87844742973107, "Unbranded Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "cost", "name" },
                values: new object[] { 90.773526346338812, "Tasty Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "cost", "name" },
                values: new object[] { 239.56292300189924, "Ergonomic Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "cost", "name" },
                values: new object[] { 147.60078701143246, "Licensed Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "cost", "name" },
                values: new object[] { 415.10608047465456, "Generic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "cost", "name" },
                values: new object[] { 147.04472026453243, "Rustic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.27208779521021, "Handmade Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "cost", "name" },
                values: new object[] { 311.45997046821384, "Licensed Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "cost", "name" },
                values: new object[] { 125.67359993764707, "Rustic Soft Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "cost", "name" },
                values: new object[] { 554.81917172959913, "Rustic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "cost", "name" },
                values: new object[] { 146.10493628712763, "Handcrafted Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "cost", "name" },
                values: new object[] { 65.056785984411704, "Sleek Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "cost", "name" },
                values: new object[] { 594.02099888688736, "Licensed Steel Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "cost", "name" },
                values: new object[] { 842.37029540780418, "Incredible Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "cost", "name" },
                values: new object[] { 99.96769848740324, "Rustic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "cost", "name" },
                values: new object[] { 727.30091104469602, "Gorgeous Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "cost", "name" },
                values: new object[] { 573.50987332047976, "Practical Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "cost", "name" },
                values: new object[] { 813.55168301843401, "Handmade Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "cost", "name" },
                values: new object[] { 817.74666014425202, "Intelligent Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "cost", "name" },
                values: new object[] { 768.90677841478453, "Generic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "cost", "name" },
                values: new object[] { 623.73479219156911, "Practical Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "cost", "name" },
                values: new object[] { 797.93582599030685, "Awesome Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "cost", "name" },
                values: new object[] { 688.19373221753551, "Generic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "cost", "name" },
                values: new object[] { 123.47976910986289, "Rustic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.15257569256767, "Incredible Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "cost", "name" },
                values: new object[] { 490.36384787666481, "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.66321125270417, "Ergonomic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "cost", "name" },
                values: new object[] { 289.43217241493591, "Practical Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "cost", "name" },
                values: new object[] { 948.47043119496243, "Fantastic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "cost", "name" },
                values: new object[] { 450.10311418987584, "Handcrafted Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "cost", "name" },
                values: new object[] { 654.85903217771647, "Rustic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "cost", "name" },
                values: new object[] { 414.27384255850444, "Handcrafted Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "cost", "name" },
                values: new object[] { 587.65358609141515, "Handcrafted Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "cost", "name" },
                values: new object[] { 186.02811161221643, "Incredible Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "cost", "name" },
                values: new object[] { 875.398210748221, "Licensed Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "cost", "name" },
                values: new object[] { 847.72307869287886, "Incredible Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.03759379804023, "Tasty Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "cost", "name" },
                values: new object[] { 739.24003186569428, "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "cost", "name" },
                values: new object[] { 623.91470217659139, "Refined Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "cost", "name" },
                values: new object[] { 670.14164902169534, "Tasty Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "cost", "name" },
                values: new object[] { 954.90105437700277, "Licensed Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "cost", "name" },
                values: new object[] { 324.05706419175465, "Generic Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "cost", "name" },
                values: new object[] { 385.63191593038374, "Practical Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "cost", "name" },
                values: new object[] { 650.45685143398532, "Gorgeous Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "cost", "name" },
                values: new object[] { 817.2768466434319, "Generic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "cost", "name" },
                values: new object[] { 970.99601813923266, "Incredible Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "cost", "name" },
                values: new object[] { 26.967340176209277, "Rustic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "cost", "name" },
                values: new object[] { 503.26364055845897, "Small Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "cost", "name" },
                values: new object[] { 501.91912256683526, "Awesome Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "cost", "name" },
                values: new object[] { 273.23121375390684, "Fantastic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "cost", "name" },
                values: new object[] { 647.57023764090479, "Ergonomic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "cost", "name" },
                values: new object[] { 543.70854221243656, "Generic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "cost", "name" },
                values: new object[] { 158.1498969209604, "Tasty Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "cost", "name" },
                values: new object[] { 503.10125228172666, "Sleek Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "cost", "name" },
                values: new object[] { 955.92600249948782, "Licensed Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "cost", "name" },
                values: new object[] { 376.39146606780872, "Awesome Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "cost", "name" },
                values: new object[] { 593.28595619679447, "Incredible Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.15573380260867, "Ergonomic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "cost", "name" },
                values: new object[] { 481.58141621026687, "Gorgeous Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "cost", "name" },
                values: new object[] { 585.66215329707211, "Sleek Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "cost", "name" },
                values: new object[] { 841.11087017629916, "Small Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.80239562760721, "Intelligent Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "cost", "name" },
                values: new object[] { 908.33515377481183, "Refined Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "cost", "name" },
                values: new object[] { 628.91207300948565, "Licensed Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "cost", "name" },
                values: new object[] { 126.68130328681683, "Incredible Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "cost", "name" },
                values: new object[] { 64.867702293998747, "Rustic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "cost", "name" },
                values: new object[] { 185.684742966377, "Practical Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "cost", "name" },
                values: new object[] { 995.93502737545703, "Unbranded Soft Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "cost", "name" },
                values: new object[] { 321.32496629873947, "Handcrafted Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "cost", "name" },
                values: new object[] { 611.75193673644947, "Practical Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "cost", "name" },
                values: new object[] { 418.46347480921611, "Generic Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "cost", "name" },
                values: new object[] { 728.2009750382017, "Refined Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.25473571614225, "Incredible Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "cost", "name" },
                values: new object[] { 355.84305494910893, "Ergonomic Granite Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "cost", "name" },
                values: new object[] { 648.20183678401918, "Awesome Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "cost", "name" },
                values: new object[] { 420.46965957359276, "Handmade Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "cost", "name" },
                values: new object[] { 729.97330831789873, "Small Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "cost", "name" },
                values: new object[] { 921.20319920104998, "Gorgeous Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "cost", "name" },
                values: new object[] { 853.86853789450026, "Generic Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "cost", "name" },
                values: new object[] { 408.16079041052933, "Tasty Granite Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "cost", "name" },
                values: new object[] { 361.87360676199694, "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "cost", "name" },
                values: new object[] { 857.09415700272666, "Tasty Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "cost", "name" },
                values: new object[] { 532.04973377920101, "Fantastic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "cost", "name" },
                values: new object[] { 170.43713206218456, "Handmade Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "cost", "name" },
                values: new object[] { 796.89329909505852, "Ergonomic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.203772238600791, "Generic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.33393053434838, "Tasty Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "cost", "name" },
                values: new object[] { 539.49322161981013, "Awesome Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 940,
                columns: new[] { "cost", "name" },
                values: new object[] { 552.43852011616866, "Rustic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 941,
                columns: new[] { "cost", "name" },
                values: new object[] { 397.45716658660797, "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 942,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.26051346715167, "Small Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 943,
                columns: new[] { "cost", "name" },
                values: new object[] { 977.29190442582183, "Ergonomic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 944,
                columns: new[] { "cost", "name" },
                values: new object[] { 862.14875780987688, "Rustic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 945,
                columns: new[] { "cost", "name" },
                values: new object[] { 461.2886580328443, "Handmade Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 946,
                columns: new[] { "cost", "name" },
                values: new object[] { 56.109861917186151, "Unbranded Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 947,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.82931220549654, "Incredible Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 948,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.9871491982008, "Generic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 949,
                columns: new[] { "cost", "name" },
                values: new object[] { 238.07496505576324, "Generic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 950,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.03145135143086, "Awesome Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 951,
                columns: new[] { "cost", "name" },
                values: new object[] { 870.14243570273436, "Refined Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 952,
                columns: new[] { "cost", "name" },
                values: new object[] { 660.65676870268032, "Sleek Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 953,
                columns: new[] { "cost", "name" },
                values: new object[] { 944.59387182731143, "Unbranded Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 954,
                columns: new[] { "cost", "name" },
                values: new object[] { 449.87067980123317, "Generic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 955,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.81313808123741, "Incredible Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 956,
                columns: new[] { "cost", "name" },
                values: new object[] { 480.17058093455506, "Practical Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 957,
                columns: new[] { "cost", "name" },
                values: new object[] { 270.75379592037734, "Handcrafted Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 958,
                columns: new[] { "cost", "name" },
                values: new object[] { 925.58677886874068, "Sleek Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 959,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.15422123220912, "Incredible Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 960,
                columns: new[] { "cost", "name" },
                values: new object[] { 104.54186726717009, "Incredible Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 961,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.039575128462479, "Handcrafted Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 962,
                columns: new[] { "cost", "name" },
                values: new object[] { 221.64027559247273, "Fantastic Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 963,
                columns: new[] { "cost", "name" },
                values: new object[] { 755.81185748962343, "Handcrafted Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 964,
                columns: new[] { "cost", "name" },
                values: new object[] { 692.61420008950722, "Unbranded Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 965,
                columns: new[] { "cost", "name" },
                values: new object[] { 814.7901014781811, "Handcrafted Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 966,
                columns: new[] { "cost", "name" },
                values: new object[] { 899.56191977446554, "Unbranded Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 967,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.895518834110128, "Fantastic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 968,
                columns: new[] { "cost", "name" },
                values: new object[] { 754.92706461673845, "Fantastic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 969,
                columns: new[] { "cost", "name" },
                values: new object[] { 575.74535553872545, "Refined Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 970,
                columns: new[] { "cost", "name" },
                values: new object[] { 407.72252741115648, "Small Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 971,
                columns: new[] { "cost", "name" },
                values: new object[] { 836.74996631389217, "Incredible Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 972,
                columns: new[] { "cost", "name" },
                values: new object[] { 212.02717960427307, "Incredible Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 973,
                columns: new[] { "cost", "name" },
                values: new object[] { 386.93197269315971, "Refined Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 974,
                columns: new[] { "cost", "name" },
                values: new object[] { 177.70780270134668, "Fantastic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 975,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.072767900751884, "Generic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 976,
                columns: new[] { "cost", "name" },
                values: new object[] { 435.10345044369774, "Unbranded Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 977,
                columns: new[] { "cost", "name" },
                values: new object[] { 293.20373691498696, "Sleek Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 978,
                columns: new[] { "cost", "name" },
                values: new object[] { 530.5419734238626, "Small Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 979,
                columns: new[] { "cost", "name" },
                values: new object[] { 206.59694611207337, "Gorgeous Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 980,
                columns: new[] { "cost", "name" },
                values: new object[] { 514.9118713604272, "Tasty Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 981,
                columns: new[] { "cost", "name" },
                values: new object[] { 649.18425602242519, "Incredible Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 982,
                columns: new[] { "cost", "name" },
                values: new object[] { 860.05960873801621, "Unbranded Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 983,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.68337341944974, "Small Steel Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 984,
                columns: new[] { "cost", "name" },
                values: new object[] { 404.45438828786956, "Rustic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 985,
                columns: new[] { "cost", "name" },
                values: new object[] { 651.46019790004391, "Gorgeous Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 986,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.88370116294573, "Practical Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 987,
                columns: new[] { "cost", "name" },
                values: new object[] { 331.42943017578705, "Handcrafted Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 988,
                columns: new[] { "cost", "name" },
                values: new object[] { 535.67850907305137, "Rustic Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 989,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.60000198975285, "Fantastic Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 990,
                columns: new[] { "cost", "name" },
                values: new object[] { 162.32183618099461, "Practical Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 991,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.95481041741408, "Handmade Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 992,
                columns: new[] { "cost", "name" },
                values: new object[] { 594.20663056022897, "Handmade Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 993,
                columns: new[] { "cost", "name" },
                values: new object[] { 501.63254195962895, "Handcrafted Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 994,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.27116492367992, "Rustic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 995,
                columns: new[] { "cost", "name" },
                values: new object[] { 57.843167242303444, "Refined Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 996,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.4142528015542, "Handcrafted Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 997,
                columns: new[] { "cost", "name" },
                values: new object[] { 181.66761463190892, "Intelligent Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 998,
                columns: new[] { "cost", "name" },
                values: new object[] { 319.57577940385102, "Gorgeous Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 999,
                columns: new[] { "cost", "name" },
                values: new object[] { 988.13799032235215, "Gorgeous Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1000,
                columns: new[] { "cost", "name" },
                values: new object[] { 569.1109944208664, "Intelligent Cotton Chips" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "cost", "name" },
                values: new object[] { 49.77242532446467, "Fantastic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "cost", "name" },
                values: new object[] { 108.51195823950169, "Incredible Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "cost", "name" },
                values: new object[] { 919.67337251765662, "Unbranded Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.40588948673872, "Refined Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.18519574442973, "Fantastic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "cost", "name" },
                values: new object[] { 74.165842483364386, "Sleek Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "cost", "name" },
                values: new object[] { 431.32758608638483, "Generic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "cost", "name" },
                values: new object[] { 322.12845949139239, "Gorgeous Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "cost", "name" },
                values: new object[] { 650.12849029995414, "Practical Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "cost", "name" },
                values: new object[] { 439.58821430170178, "Gorgeous Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.89483574251778, "Ergonomic Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.13414067094686, "Practical Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "cost", "name" },
                values: new object[] { 252.52856746287458, "Intelligent Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "cost", "name" },
                values: new object[] { 831.21426062525484, "Practical Cotton Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "cost", "name" },
                values: new object[] { 544.8112826401391, "Incredible Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "cost", "name" },
                values: new object[] { 311.17106031554744, "Awesome Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "cost", "name" },
                values: new object[] { 865.98554429120554, "Ergonomic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "cost", "name" },
                values: new object[] { 919.16332689240051, "Intelligent Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "cost", "name" },
                values: new object[] { 870.66765281134099, "Practical Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "cost", "name" },
                values: new object[] { 921.1532590914918, "Licensed Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "cost", "name" },
                values: new object[] { 3.4076270166742701, "Rustic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.61117394078786, "Handmade Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "cost", "name" },
                values: new object[] { 960.09161437428895, "Small Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "cost", "name" },
                values: new object[] { 281.15427540799192, "Sleek Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.64321586917526, "Practical Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "cost", "name" },
                values: new object[] { 616.8586426450189, "Practical Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "cost", "name" },
                values: new object[] { 406.49514712455368, "Practical Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "cost", "name" },
                values: new object[] { 434.17034037492573, "Refined Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "cost", "name" },
                values: new object[] { 671.97256807642589, "Gorgeous Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "cost", "name" },
                values: new object[] { 444.97355483543447, "Sleek Steel Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "cost", "name" },
                values: new object[] { 392.69170200812187, "Refined Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "cost", "name" },
                values: new object[] { 492.98997309838626, "Unbranded Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "cost", "name" },
                values: new object[] { 455.77530462318578, "Generic Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "cost", "name" },
                values: new object[] { 242.97958484433261, "Practical Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "cost", "name" },
                values: new object[] { 235.38178670572819, "Refined Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.24100204859667, "Incredible Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "cost", "name" },
                values: new object[] { 332.79944670859447, "Awesome Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.69328583775484, "Fantastic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "cost", "name" },
                values: new object[] { 739.59832840464242, "Licensed Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "cost", "name" },
                values: new object[] { 849.2388137359319, "Practical Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "cost", "name" },
                values: new object[] { 735.67194563705334, "Sleek Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.96051879680783, "Licensed Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "cost", "name" },
                values: new object[] { 717.58795065683069, "Intelligent Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "cost", "name" },
                values: new object[] { 252.23944340576662, "Incredible Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "cost", "name" },
                values: new object[] { 246.19169942307809, "Intelligent Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "cost", "name" },
                values: new object[] { 818.87974384303766, "Fantastic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.34093533135115, "Handmade Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "cost", "name" },
                values: new object[] { 46.754711962832054, "Incredible Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "cost", "name" },
                values: new object[] { 576.01648289840773, "Fantastic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "cost", "name" },
                values: new object[] { 925.89710110153885, "Sleek Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 51,
                column: "cost",
                value: 205.2454042247891);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "cost", "name" },
                values: new object[] { 374.50464463307571, "Practical Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.44001833660502, "Unbranded Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "cost", "name" },
                values: new object[] { 820.84262694127733, "Incredible Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "cost", "name" },
                values: new object[] { 528.8902141342395, "Practical Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "cost", "name" },
                values: new object[] { 919.51966554607634, "Handcrafted Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "cost", "name" },
                values: new object[] { 926.78285867715749, "Handcrafted Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "cost", "name" },
                values: new object[] { 471.10639549864948, "Generic Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "cost", "name" },
                values: new object[] { 414.00484192680625, "Handcrafted Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.92409518536317, "Small Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "cost", "name" },
                values: new object[] { 940.08497429756835, "Awesome Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "cost", "name" },
                values: new object[] { 685.35484055000927, "Intelligent Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "cost", "name" },
                values: new object[] { 309.17891680721709, "Fantastic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "cost", "name" },
                values: new object[] { 843.85049369285241, "Incredible Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "cost", "name" },
                values: new object[] { 144.16324341885471, "Unbranded Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "cost", "name" },
                values: new object[] { 953.40921530797095, "Licensed Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "cost", "name" },
                values: new object[] { 593.19025566730613, "Gorgeous Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "cost", "name" },
                values: new object[] { 636.56670187287114, "Intelligent Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "cost", "name" },
                values: new object[] { 732.71333171400636, "Unbranded Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "cost", "name" },
                values: new object[] { 509.66651325832657, "Rustic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.533368976345, "Ergonomic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "cost", "name" },
                values: new object[] { 334.29254508086643, "Fantastic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "cost", "name" },
                values: new object[] { 659.37184090498204, "Awesome Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "cost", "name" },
                values: new object[] { 389.79636532223583, "Small Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "cost", "name" },
                values: new object[] { 483.13298137336062, "Intelligent Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "cost", "name" },
                values: new object[] { 559.20571837932664, "Handmade Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "cost", "name" },
                values: new object[] { 846.01155641325909, "Generic Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "cost", "name" },
                values: new object[] { 501.60997596191436, "Ergonomic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "cost", "name" },
                values: new object[] { 536.21058331897586, "Refined Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "cost", "name" },
                values: new object[] { 878.66438881826207, "Tasty Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "cost", "name" },
                values: new object[] { 765.06992299762419, "Handmade Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "cost", "name" },
                values: new object[] { 329.62495924828971, "Awesome Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "cost", "name" },
                values: new object[] { 39.269525958168714, "Ergonomic Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "cost", "name" },
                values: new object[] { 322.0911466312217, "Tasty Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "cost", "name" },
                values: new object[] { 184.40129602392898, "Licensed Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "cost", "name" },
                values: new object[] { 228.50842928874852, "Handcrafted Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.86098818934806, "Practical Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.27151413134663, "Licensed Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "cost", "name" },
                values: new object[] { 357.71872081698865, "Generic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "cost", "name" },
                values: new object[] { 227.22896100604433, "Ergonomic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "cost", "name" },
                values: new object[] { 392.16160322128485, "Awesome Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "cost", "name" },
                values: new object[] { 130.34908147771242, "Gorgeous Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "cost", "name" },
                values: new object[] { 625.34792823558632, "Generic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "cost", "name" },
                values: new object[] { 564.12483394094875, "Tasty Metal Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "cost", "name" },
                values: new object[] { 960.45889859863553, "Refined Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.67774853119181, "Awesome Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "cost", "name" },
                values: new object[] { 621.39984123053353, "Refined Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "cost", "name" },
                values: new object[] { 116.99593708657223, "Awesome Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "cost", "name" },
                values: new object[] { 762.22453254619461, "Refined Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "cost", "name" },
                values: new object[] { 481.74746119583779, "Refined Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "cost", "name" },
                values: new object[] { 975.08396123391867, "Licensed Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "cost", "name" },
                values: new object[] { 513.92312151608746, "Handcrafted Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "cost", "name" },
                values: new object[] { 193.38403538280201, "Handmade Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "cost", "name" },
                values: new object[] { 481.35869456995169, "Awesome Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "cost", "name" },
                values: new object[] { 962.7985698122742, "Ergonomic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "cost", "name" },
                values: new object[] { 621.43449419242495, "Sleek Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "cost", "name" },
                values: new object[] { 721.96788873001049, "Licensed Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.39767015750112, "Sleek Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "cost", "name" },
                values: new object[] { 908.3418285456811, "Ergonomic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "cost", "name" },
                values: new object[] { 268.30338652811196, "Tasty Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "cost", "name" },
                values: new object[] { 877.40165904571393, "Ergonomic Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "cost", "name" },
                values: new object[] { 337.30712032001793, "Intelligent Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "cost", "name" },
                values: new object[] { 866.87326414941026, "Ergonomic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "cost", "name" },
                values: new object[] { 563.22078148537764, "Practical Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.94506539098273, "Licensed Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "cost", "name" },
                values: new object[] { 140.75782251737388, "Practical Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.03361945691591, "Gorgeous Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "cost", "name" },
                values: new object[] { 414.66290293857332, "Handcrafted Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "cost", "name" },
                values: new object[] { 345.16835960688564, "Intelligent Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "cost", "name" },
                values: new object[] { 249.81180955587402, "Refined Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "cost", "name" },
                values: new object[] { 207.23207186113888, "Sleek Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.97432621605822, "Refined Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "cost", "name" },
                values: new object[] { 666.62552260324742, "Awesome Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "cost", "name" },
                values: new object[] { 742.16652746988643, "Ergonomic Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "cost", "name" },
                values: new object[] { 927.61490172486367, "Handcrafted Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "cost", "name" },
                values: new object[] { 835.08817017324998, "Incredible Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "cost", "name" },
                values: new object[] { 50.247398168706788, "Handcrafted Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "cost", "name" },
                values: new object[] { 322.61647738991167, "Gorgeous Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "cost", "name" },
                values: new object[] { 650.76177058062126, "Handmade Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "cost", "name" },
                values: new object[] { 413.26452828010571, "Tasty Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "cost", "name" },
                values: new object[] { 875.30915452589613, "Gorgeous Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "cost", "name" },
                values: new object[] { 421.92938205621925, "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "cost", "name" },
                values: new object[] { 901.65104362972613, "Rustic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "cost", "name" },
                values: new object[] { 349.67773268481193, "Incredible Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "cost", "name" },
                values: new object[] { 181.22107539500948, "Rustic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "cost", "name" },
                values: new object[] { 947.74978514676297, "Sleek Wooden Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "cost", "name" },
                values: new object[] { 457.97597160821937, "Small Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.24921063311871, "Tasty Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.089263543496521, "Unbranded Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "cost", "name" },
                values: new object[] { 346.25658498454703, "Handmade Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "cost", "name" },
                values: new object[] { 704.19185287523965, "Practical Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.366988528447, "Licensed Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "cost", "name" },
                values: new object[] { 26.272290301418941, "Intelligent Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "cost", "name" },
                values: new object[] { 440.29106602362771, "Refined Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "cost", "name" },
                values: new object[] { 737.55157713097958, "Handcrafted Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.13198487465257, "Handcrafted Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "cost", "name" },
                values: new object[] { 881.61836797278715, "Licensed Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.4878920806608, "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "cost", "name" },
                values: new object[] { 116.09922383893768, "Unbranded Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "cost", "name" },
                values: new object[] { 417.67541758883783, "Generic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "cost", "name" },
                values: new object[] { 699.47692920275063, "Handmade Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "cost", "name" },
                values: new object[] { 445.66240765321049, "Refined Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "cost", "name" },
                values: new object[] { 666.82643336096783, "Awesome Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "cost", "name" },
                values: new object[] { 546.90085302882369, "Sleek Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "cost", "name" },
                values: new object[] { 156.38780167326431, "Small Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "cost", "name" },
                values: new object[] { 185.18653138127846, "Sleek Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "cost", "name" },
                values: new object[] { 525.81048020655919, "Ergonomic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "cost", "name" },
                values: new object[] { 747.84125833970188, "Licensed Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "cost", "name" },
                values: new object[] { 893.93217489859148, "Incredible Metal Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "cost", "name" },
                values: new object[] { 547.98474782867765, "Gorgeous Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.92068022765147, "Unbranded Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "cost", "name" },
                values: new object[] { 295.47531290798344, "Tasty Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "cost", "name" },
                values: new object[] { 988.21462969063384, "Awesome Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "cost", "name" },
                values: new object[] { 744.5441125763009, "Ergonomic Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.96788747168068, "Unbranded Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "cost", "name" },
                values: new object[] { 835.40584866251481, "Handcrafted Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "cost", "name" },
                values: new object[] { 681.52071463364518, "Ergonomic Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "cost", "name" },
                values: new object[] { 528.22261259037373, "Incredible Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "cost", "name" },
                values: new object[] { 710.92889200524723, "Intelligent Soft Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "cost", "name" },
                values: new object[] { 478.67225402320702, "Licensed Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.8829181212167, "Fantastic Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "cost", "name" },
                values: new object[] { 15.366461637201729, "Practical Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "cost", "name" },
                values: new object[] { 197.44879752293025, "Fantastic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "cost", "name" },
                values: new object[] { 910.12541483596647, "Generic Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.05630617553533, "Small Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.37867585881645, "Generic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "cost", "name" },
                values: new object[] { 233.45547527068257, "Incredible Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "cost", "name" },
                values: new object[] { 583.91625445806392, "Fantastic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "cost", "name" },
                values: new object[] { 920.37330541289714, "Handmade Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "cost", "name" },
                values: new object[] { 708.8918519752242, "Licensed Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "cost", "name" },
                values: new object[] { 808.27627143975667, "Licensed Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "cost", "name" },
                values: new object[] { 449.72932977281874, "Handcrafted Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "cost", "name" },
                values: new object[] { 976.05768120768778, "Refined Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.33568902275475, "Licensed Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "cost", "name" },
                values: new object[] { 624.792862924823, "Tasty Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "cost", "name" },
                values: new object[] { 861.61734934805645, "Licensed Soft Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "cost", "name" },
                values: new object[] { 471.33232927944425, "Intelligent Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.90042431471477, "Incredible Granite Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "cost", "name" },
                values: new object[] { 779.62024631236022, "Incredible Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "cost", "name" },
                values: new object[] { 409.99687544193347, "Tasty Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "cost", "name" },
                values: new object[] { 809.67702095633365, "Tasty Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "cost", "name" },
                values: new object[] { 275.68671190853166, "Incredible Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "cost", "name" },
                values: new object[] { 121.19502191333127, "Fantastic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "cost", "name" },
                values: new object[] { 247.44530812923173, "Handcrafted Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.3317120463845, "Tasty Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "cost", "name" },
                values: new object[] { 934.9644999795288, "Small Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "cost", "name" },
                values: new object[] { 350.12654663865595, "Unbranded Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "cost", "name" },
                values: new object[] { 806.27619421434645, "Intelligent Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "cost", "name" },
                values: new object[] { 274.96977378593112, "Ergonomic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "cost", "name" },
                values: new object[] { 759.36290110395726, "Sleek Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "cost", "name" },
                values: new object[] { 152.16878620549801, "Refined Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "cost", "name" },
                values: new object[] { 807.3591163158685, "Licensed Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "cost", "name" },
                values: new object[] { 153.28175956334366, "Gorgeous Steel Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "cost", "name" },
                values: new object[] { 59.166823965581202, "Refined Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.29190545504741, "Licensed Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "cost", "name" },
                values: new object[] { 871.24156672227002, "Unbranded Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "cost", "name" },
                values: new object[] { 684.91016096308897, "Incredible Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.43347848579208, "Unbranded Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "cost", "name" },
                values: new object[] { 103.63624121582188, "Fantastic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "cost", "name" },
                values: new object[] { 630.57706736722128, "Awesome Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "cost", "name" },
                values: new object[] { 770.8062461216382, "Intelligent Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "cost", "name" },
                values: new object[] { 200.35967777110918, "Licensed Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "cost", "name" },
                values: new object[] { 788.05217306357326, "Awesome Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "cost", "name" },
                values: new object[] { 785.14643430665285, "Rustic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "cost", "name" },
                values: new object[] { 968.90222516738788, "Unbranded Granite Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "cost", "name" },
                values: new object[] { 940.32454205850775, "Gorgeous Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "cost", "name" },
                values: new object[] { 826.19555781265365, "Licensed Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "cost", "name" },
                values: new object[] { 571.1279327768201, "Handmade Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.75843466089026, "Generic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "cost", "name" },
                values: new object[] { 462.81187605918882, "Licensed Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "cost", "name" },
                values: new object[] { 971.74946540557914, "Incredible Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "cost", "name" },
                values: new object[] { 39.406138190704809, "Intelligent Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "cost", "name" },
                values: new object[] { 641.02507917471621, "Handcrafted Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "cost", "name" },
                values: new object[] { 990.3504899246293, "Generic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "cost", "name" },
                values: new object[] { 424.96045190997916, "Gorgeous Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "cost", "name" },
                values: new object[] { 842.81693861448582, "Awesome Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "cost", "name" },
                values: new object[] { 970.49809382179319, "Practical Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.32104637164866, "Fantastic Metal Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "cost", "name" },
                values: new object[] { 506.0690116059908, "Rustic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "cost", "name" },
                values: new object[] { 559.34908282391541, "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "cost", "name" },
                values: new object[] { 668.96798954793837, "Unbranded Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.40419013767985, "Generic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.10811159153047, "Handmade Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.90964762393088, "Handmade Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "cost", "name" },
                values: new object[] { 196.30150848900107, "Generic Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "cost", "name" },
                values: new object[] { 346.13641652844365, "Gorgeous Soft Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "cost", "name" },
                values: new object[] { 389.39576784227557, "Handmade Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "cost", "name" },
                values: new object[] { 283.78044229759729, "Handmade Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "cost", "name" },
                values: new object[] { 876.5582377079852, "Refined Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "cost", "name" },
                values: new object[] { 422.07227330685055, "Tasty Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "cost", "name" },
                values: new object[] { 583.22813094096273, "Intelligent Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "cost", "name" },
                values: new object[] { 742.58584700435586, "Gorgeous Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "cost", "name" },
                values: new object[] { 24.348741027747607, "Handmade Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "cost", "name" },
                values: new object[] { 884.03837822210937, "Generic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "cost", "name" },
                values: new object[] { 392.38028469267499, "Unbranded Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "cost", "name" },
                values: new object[] { 589.46424462939945, "Refined Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "cost", "name" },
                values: new object[] { 414.16818437847735, "Small Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.20589955893377, "Unbranded Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "cost", "name" },
                values: new object[] { 164.22699550821059, "Tasty Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.83727705666661, "Handmade Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "cost", "name" },
                values: new object[] { 400.72009989392819, "Generic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.478655270531817, "Licensed Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "cost", "name" },
                values: new object[] { 600.39306201043541, "Ergonomic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "cost", "name" },
                values: new object[] { 960.88882755314717, "Licensed Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "cost", "name" },
                values: new object[] { 476.48284725212432, "Unbranded Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "cost", "name" },
                values: new object[] { 608.98731642227756, "Ergonomic Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "cost", "name" },
                values: new object[] { 520.55994707675404, "Tasty Metal Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "cost", "name" },
                values: new object[] { 719.39874315975862, "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "cost", "name" },
                values: new object[] { 513.73370086544855, "Ergonomic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "cost", "name" },
                values: new object[] { 812.7158607615961, "Intelligent Steel Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "cost", "name" },
                values: new object[] { 332.60582814931007, "Awesome Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "cost", "name" },
                values: new object[] { 386.74821495061303, "Generic Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "cost", "name" },
                values: new object[] { 853.50703767659252, "Handmade Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "cost", "name" },
                values: new object[] { 518.00798267312598, "Rustic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "cost", "name" },
                values: new object[] { 738.44524824217956, "Intelligent Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "cost", "name" },
                values: new object[] { 404.62278063980847, "Licensed Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "cost", "name" },
                values: new object[] { 518.69092346817069, "Licensed Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "cost", "name" },
                values: new object[] { 603.85101155623681, "Tasty Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "cost", "name" },
                values: new object[] { 747.30987413047444, "Unbranded Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "cost", "name" },
                values: new object[] { 488.01790361292257, "Generic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "cost", "name" },
                values: new object[] { 636.31259701504257, "Handmade Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.09729262421257, "Awesome Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "cost", "name" },
                values: new object[] { 635.51965195538639, "Ergonomic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "cost", "name" },
                values: new object[] { 459.07079816861284, "Gorgeous Fresh Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "cost", "name" },
                values: new object[] { 371.30442028116289, "Incredible Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.89648224729524, "Refined Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "cost", "name" },
                values: new object[] { 508.69390388898563, "Incredible Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "cost", "name" },
                values: new object[] { 167.84396599415732, "Small Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "cost", "name" },
                values: new object[] { 368.53617046439177, "Rustic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "cost", "name" },
                values: new object[] { 321.76165764411041, "Tasty Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "cost", "name" },
                values: new object[] { 598.93353762906679, "Unbranded Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "cost", "name" },
                values: new object[] { 946.92513876909936, "Licensed Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.94058245633329, "Tasty Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.39897071159714, "Intelligent Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "cost", "name" },
                values: new object[] { 530.20138744045448, "Incredible Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "cost", "name" },
                values: new object[] { 304.89668394217449, "Awesome Metal Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "cost", "name" },
                values: new object[] { 215.53344845723211, "Handmade Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "cost", "name" },
                values: new object[] { 843.66596967682165, "Gorgeous Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.07128654088092, "Fantastic Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.144796263560835, "Incredible Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "cost", "name" },
                values: new object[] { 403.98818435866713, "Ergonomic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "cost", "name" },
                values: new object[] { 933.44742442096003, "Handcrafted Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "cost", "name" },
                values: new object[] { 867.51345622334895, "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "cost", "name" },
                values: new object[] { 942.17943516348964, "Gorgeous Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "cost", "name" },
                values: new object[] { 354.73779579469016, "Gorgeous Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "cost", "name" },
                values: new object[] { 91.690365703782803, "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "cost", "name" },
                values: new object[] { 682.72434282356676, "Ergonomic Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "cost", "name" },
                values: new object[] { 672.29647903745911, "Refined Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "cost", "name" },
                values: new object[] { 400.54695221962965, "Gorgeous Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "cost", "name" },
                values: new object[] { 154.31617985136563, "Unbranded Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 301,
                columns: new[] { "cost", "name" },
                values: new object[] { 273.20313166859177, "Small Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 302,
                columns: new[] { "cost", "name" },
                values: new object[] { 924.47863829948039, "Handmade Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 303,
                columns: new[] { "cost", "name" },
                values: new object[] { 17.516470039930475, "Practical Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 304,
                columns: new[] { "cost", "name" },
                values: new object[] { 989.90219790336516, "Tasty Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 305,
                columns: new[] { "cost", "name" },
                values: new object[] { 921.52774936635501, "Handcrafted Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 306,
                columns: new[] { "cost", "name" },
                values: new object[] { 267.8450991953124, "Handmade Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 307,
                columns: new[] { "cost", "name" },
                values: new object[] { 703.12835208705496, "Ergonomic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 308,
                columns: new[] { "cost", "name" },
                values: new object[] { 627.87132896793059, "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 309,
                columns: new[] { "cost", "name" },
                values: new object[] { 928.37213482271181, "Rustic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 310,
                columns: new[] { "cost", "name" },
                values: new object[] { 493.51096212848705, "Sleek Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 311,
                columns: new[] { "cost", "name" },
                values: new object[] { 764.91666301829355, "Generic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 312,
                columns: new[] { "cost", "name" },
                values: new object[] { 353.71593183891991, "Generic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 313,
                columns: new[] { "cost", "name" },
                values: new object[] { 923.93833821971805, "Fantastic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 314,
                columns: new[] { "cost", "name" },
                values: new object[] { 211.33023924699802, "Awesome Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 315,
                columns: new[] { "cost", "name" },
                values: new object[] { 650.39139463568779, "Tasty Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 316,
                columns: new[] { "cost", "name" },
                values: new object[] { 200.60779600052962, "Handcrafted Soft Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 317,
                columns: new[] { "cost", "name" },
                values: new object[] { 561.38822618581753, "Handcrafted Metal Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 318,
                columns: new[] { "cost", "name" },
                values: new object[] { 789.34579366209232, "Handmade Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 319,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.95971042580936, "Awesome Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 320,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.01156649253446, "Refined Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 321,
                columns: new[] { "cost", "name" },
                values: new object[] { 111.72098522579944, "Generic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 322,
                columns: new[] { "cost", "name" },
                values: new object[] { 458.51979044274418, "Awesome Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 323,
                columns: new[] { "cost", "name" },
                values: new object[] { 674.26407659048027, "Gorgeous Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 324,
                columns: new[] { "cost", "name" },
                values: new object[] { 1.1033833350458033, "Sleek Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 325,
                columns: new[] { "cost", "name" },
                values: new object[] { 910.57132146424226, "Tasty Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 326,
                columns: new[] { "cost", "name" },
                values: new object[] { 753.95345460777628, "Fantastic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 327,
                columns: new[] { "cost", "name" },
                values: new object[] { 846.07772204563048, "Unbranded Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 328,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.27063885673317, "Sleek Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 329,
                columns: new[] { "cost", "name" },
                values: new object[] { 829.43247814725055, "Incredible Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 330,
                columns: new[] { "cost", "name" },
                values: new object[] { 520.75500720820332, "Rustic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 331,
                columns: new[] { "cost", "name" },
                values: new object[] { 513.9585245591046, "Ergonomic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 332,
                columns: new[] { "cost", "name" },
                values: new object[] { 513.76833916752207, "Practical Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 333,
                columns: new[] { "cost", "name" },
                values: new object[] { 814.75470360582221, "Gorgeous Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 334,
                columns: new[] { "cost", "name" },
                values: new object[] { 437.97773826593129, "Unbranded Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 335,
                columns: new[] { "cost", "name" },
                values: new object[] { 461.59847772916123, "Incredible Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 336,
                columns: new[] { "cost", "name" },
                values: new object[] { 433.40737233156619, "Generic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 337,
                columns: new[] { "cost", "name" },
                values: new object[] { 287.35125903797382, "Small Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 338,
                columns: new[] { "cost", "name" },
                values: new object[] { 895.22474559576779, "Ergonomic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 339,
                columns: new[] { "cost", "name" },
                values: new object[] { 523.18169617934052, "Incredible Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 340,
                columns: new[] { "cost", "name" },
                values: new object[] { 303.77346632090598, "Sleek Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 341,
                columns: new[] { "cost", "name" },
                values: new object[] { 662.36921250122259, "Generic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 342,
                columns: new[] { "cost", "name" },
                values: new object[] { 102.44225333675428, "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 343,
                columns: new[] { "cost", "name" },
                values: new object[] { 741.58151552482207, "Small Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 344,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.74116004955806, "Generic Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 345,
                columns: new[] { "cost", "name" },
                values: new object[] { 248.05135709376842, "Awesome Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 346,
                columns: new[] { "cost", "name" },
                values: new object[] { 911.13899621086875, "Tasty Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 347,
                columns: new[] { "cost", "name" },
                values: new object[] { 65.814143208647053, "Fantastic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 348,
                columns: new[] { "cost", "name" },
                values: new object[] { 917.59114587929378, "Handcrafted Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 349,
                columns: new[] { "cost", "name" },
                values: new object[] { 672.58177083107921, "Awesome Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 350,
                columns: new[] { "cost", "name" },
                values: new object[] { 745.68296614919814, "Refined Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 351,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.00219431647292, "Intelligent Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 352,
                columns: new[] { "cost", "name" },
                values: new object[] { 876.80272880928931, "Fantastic Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 353,
                columns: new[] { "cost", "name" },
                values: new object[] { 75.10662050650221, "Practical Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 354,
                columns: new[] { "cost", "name" },
                values: new object[] { 77.149781388300369, "Small Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 355,
                columns: new[] { "cost", "name" },
                values: new object[] { 282.31011625186278, "Ergonomic Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 356,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.88877776244874, "Licensed Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 357,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.25526390277957, "Incredible Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 358,
                columns: new[] { "cost", "name" },
                values: new object[] { 67.69469941379738, "Ergonomic Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 359,
                columns: new[] { "cost", "name" },
                values: new object[] { 691.31788018798477, "Handcrafted Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 360,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.31971752547213, "Intelligent Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 361,
                columns: new[] { "cost", "name" },
                values: new object[] { 384.16369841809563, "Practical Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 362,
                columns: new[] { "cost", "name" },
                values: new object[] { 802.50054215002899, "Tasty Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 363,
                columns: new[] { "cost", "name" },
                values: new object[] { 964.14672291456327, "Rustic Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 364,
                columns: new[] { "cost", "name" },
                values: new object[] { 339.97255458407193, "Ergonomic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 365,
                columns: new[] { "cost", "name" },
                values: new object[] { 97.883156762660747, "Small Plastic Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 366,
                columns: new[] { "cost", "name" },
                values: new object[] { 890.77987422197714, "Intelligent Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 367,
                columns: new[] { "cost", "name" },
                values: new object[] { 471.21861154876296, "Intelligent Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 368,
                columns: new[] { "cost", "name" },
                values: new object[] { 255.18050180931436, "Licensed Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 369,
                columns: new[] { "cost", "name" },
                values: new object[] { 815.81600989401863, "Handcrafted Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 370,
                columns: new[] { "cost", "name" },
                values: new object[] { 450.27987956593097, "Handmade Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 371,
                columns: new[] { "cost", "name" },
                values: new object[] { 892.90890365590724, "Intelligent Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 372,
                columns: new[] { "cost", "name" },
                values: new object[] { 142.93344450925997, "Rustic Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 373,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.03977448668604, "Generic Metal Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 374,
                columns: new[] { "cost", "name" },
                values: new object[] { 418.32248265229117, "Intelligent Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 375,
                columns: new[] { "cost", "name" },
                values: new object[] { 374.60151975213523, "Generic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 376,
                columns: new[] { "cost", "name" },
                values: new object[] { 126.67382760063944, "Awesome Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 377,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.90924201868791, "Awesome Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 378,
                columns: new[] { "cost", "name" },
                values: new object[] { 903.75675233146239, "Ergonomic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 379,
                columns: new[] { "cost", "name" },
                values: new object[] { 776.62792881753001, "Tasty Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 380,
                columns: new[] { "cost", "name" },
                values: new object[] { 721.86441297032366, "Generic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 381,
                columns: new[] { "cost", "name" },
                values: new object[] { 624.66793279773151, "Refined Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 382,
                columns: new[] { "cost", "name" },
                values: new object[] { 762.23715440555372, "Incredible Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 383,
                columns: new[] { "cost", "name" },
                values: new object[] { 311.7654391601771, "Refined Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 384,
                columns: new[] { "cost", "name" },
                values: new object[] { 443.45369251257006, "Unbranded Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 385,
                columns: new[] { "cost", "name" },
                values: new object[] { 354.68397765505807, "Licensed Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 386,
                columns: new[] { "cost", "name" },
                values: new object[] { 129.50356280065296, "Gorgeous Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 387,
                columns: new[] { "cost", "name" },
                values: new object[] { 461.59828267673288, "Incredible Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 388,
                columns: new[] { "cost", "name" },
                values: new object[] { 15.888582958382148, "Incredible Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 389,
                columns: new[] { "cost", "name" },
                values: new object[] { 806.732451541969, "Tasty Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 390,
                columns: new[] { "cost", "name" },
                values: new object[] { 931.99430678597594, "Sleek Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 391,
                columns: new[] { "cost", "name" },
                values: new object[] { 435.36525142155591, "Awesome Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 392,
                columns: new[] { "cost", "name" },
                values: new object[] { 595.43723517282604, "Rustic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 393,
                columns: new[] { "cost", "name" },
                values: new object[] { 348.76840730841178, "Intelligent Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 394,
                columns: new[] { "cost", "name" },
                values: new object[] { 317.34939185145282, "Fantastic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 395,
                columns: new[] { "cost", "name" },
                values: new object[] { 683.38038160172334, "Rustic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 396,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.63457587065039, "Sleek Steel Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 397,
                columns: new[] { "cost", "name" },
                values: new object[] { 584.27162968892208, "Licensed Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 398,
                columns: new[] { "cost", "name" },
                values: new object[] { 668.33618696263477, "Refined Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 399,
                columns: new[] { "cost", "name" },
                values: new object[] { 737.88749824094759, "Sleek Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 400,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.15187994023489, "Awesome Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 401,
                columns: new[] { "cost", "name" },
                values: new object[] { 823.2870445263336, "Incredible Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 402,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.23576372360719, "Generic Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 403,
                columns: new[] { "cost", "name" },
                values: new object[] { 557.96236959085775, "Practical Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 404,
                columns: new[] { "cost", "name" },
                values: new object[] { 996.02657534668401, "Awesome Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 405,
                columns: new[] { "cost", "name" },
                values: new object[] { 718.78475106408507, "Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 406,
                columns: new[] { "cost", "name" },
                values: new object[] { 11.495393209894344, "Unbranded Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 407,
                columns: new[] { "cost", "name" },
                values: new object[] { 264.33369768733809, "Intelligent Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 408,
                columns: new[] { "cost", "name" },
                values: new object[] { 326.80738753194566, "Small Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 409,
                columns: new[] { "cost", "name" },
                values: new object[] { 511.20929431129224, "Intelligent Metal Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 410,
                columns: new[] { "cost", "name" },
                values: new object[] { 198.46435550465887, "Incredible Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 411,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.27331630907577, "Unbranded Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 412,
                columns: new[] { "cost", "name" },
                values: new object[] { 847.54068581830143, "Incredible Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 413,
                columns: new[] { "cost", "name" },
                values: new object[] { 361.99929693355551, "Fantastic Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 414,
                columns: new[] { "cost", "name" },
                values: new object[] { 794.62180787565887, "Generic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 415,
                columns: new[] { "cost", "name" },
                values: new object[] { 82.266113469650733, "Refined Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 416,
                columns: new[] { "cost", "name" },
                values: new object[] { 26.142773718893139, "Unbranded Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 417,
                columns: new[] { "cost", "name" },
                values: new object[] { 472.82691793847511, "Generic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 418,
                columns: new[] { "cost", "name" },
                values: new object[] { 836.96750783761252, "Small Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 419,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.63938427557048, "Fantastic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 420,
                columns: new[] { "cost", "name" },
                values: new object[] { 421.93372332767836, "Fantastic Granite Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 421,
                columns: new[] { "cost", "name" },
                values: new object[] { 888.62387568798454, "Incredible Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 422,
                columns: new[] { "cost", "name" },
                values: new object[] { 456.93713174488363, "Rustic Steel Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 423,
                columns: new[] { "cost", "name" },
                values: new object[] { 269.573027188651, "Handmade Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 424,
                columns: new[] { "cost", "name" },
                values: new object[] { 294.53416179358794, "Refined Cotton Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 425,
                columns: new[] { "cost", "name" },
                values: new object[] { 177.32005840587854, "Fantastic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 426,
                columns: new[] { "cost", "name" },
                values: new object[] { 864.61084817667108, "Awesome Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 427,
                columns: new[] { "cost", "name" },
                values: new object[] { 95.211180699660702, "Practical Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 428,
                columns: new[] { "cost", "name" },
                values: new object[] { 902.55408721226593, "Incredible Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 429,
                columns: new[] { "cost", "name" },
                values: new object[] { 390.5673444514631, "Fantastic Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 430,
                columns: new[] { "cost", "name" },
                values: new object[] { 932.97054896439261, "Unbranded Steel Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 431,
                columns: new[] { "cost", "name" },
                values: new object[] { 74.321941939672854, "Rustic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 432,
                columns: new[] { "cost", "name" },
                values: new object[] { 780.7381653941934, "Small Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 433,
                columns: new[] { "cost", "name" },
                values: new object[] { 265.41644960817973, "Intelligent Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 434,
                columns: new[] { "cost", "name" },
                values: new object[] { 998.02714429888704, "Unbranded Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 435,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.37967102635241, "Gorgeous Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 436,
                columns: new[] { "cost", "name" },
                values: new object[] { 586.42050905397684, "Intelligent Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 437,
                columns: new[] { "cost", "name" },
                values: new object[] { 943.37686640413665, "Licensed Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 438,
                columns: new[] { "cost", "name" },
                values: new object[] { 62.238896618773701, "Rustic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 439,
                columns: new[] { "cost", "name" },
                values: new object[] { 347.80721322537562, "Gorgeous Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 440,
                columns: new[] { "cost", "name" },
                values: new object[] { 359.91031717256101, "Gorgeous Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 441,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.39467352692438, "Unbranded Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 442,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.65046267679952, "Handmade Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 443,
                columns: new[] { "cost", "name" },
                values: new object[] { 966.97358459614316, "Refined Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 444,
                columns: new[] { "cost", "name" },
                values: new object[] { 211.10229286743029, "Sleek Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 445,
                columns: new[] { "cost", "name" },
                values: new object[] { 415.78773112730687, "Unbranded Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 446,
                columns: new[] { "cost", "name" },
                values: new object[] { 751.5057296917297, "Handmade Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 447,
                columns: new[] { "cost", "name" },
                values: new object[] { 812.28055594576074, "Tasty Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 448,
                columns: new[] { "cost", "name" },
                values: new object[] { 382.17180197060657, "Incredible Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 449,
                columns: new[] { "cost", "name" },
                values: new object[] { 512.85362660565193, "Handmade Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 450,
                columns: new[] { "cost", "name" },
                values: new object[] { 101.66382367333392, "Rustic Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 451,
                columns: new[] { "cost", "name" },
                values: new object[] { 47.727910435433387, "Ergonomic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 452,
                columns: new[] { "cost", "name" },
                values: new object[] { 45.288173659312868, "Small Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 453,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.18680326169994, "Rustic Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 454,
                columns: new[] { "cost", "name" },
                values: new object[] { 859.85982805259812, "Refined Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 455,
                columns: new[] { "cost", "name" },
                values: new object[] { 296.44046293784584, "Unbranded Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 456,
                columns: new[] { "cost", "name" },
                values: new object[] { 779.71878441014007, "Practical Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 457,
                columns: new[] { "cost", "name" },
                values: new object[] { 187.12557809406363, "Licensed Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 458,
                columns: new[] { "cost", "name" },
                values: new object[] { 860.61888697594952, "Tasty Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 459,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.228679018808506, "Sleek Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 460,
                columns: new[] { "cost", "name" },
                values: new object[] { 723.63433558204679, "Licensed Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 461,
                columns: new[] { "cost", "name" },
                values: new object[] { 366.64564712086286, "Ergonomic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 462,
                columns: new[] { "cost", "name" },
                values: new object[] { 696.0609663469711, "Rustic Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 463,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.35047455792596, "Unbranded Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 464,
                columns: new[] { "cost", "name" },
                values: new object[] { 259.5004858541771, "Refined Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 465,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.3384864588852, "Practical Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 466,
                columns: new[] { "cost", "name" },
                values: new object[] { 856.00944824537316, "Awesome Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 467,
                columns: new[] { "cost", "name" },
                values: new object[] { 221.51903507243185, "Small Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 468,
                columns: new[] { "cost", "name" },
                values: new object[] { 344.93260534212646, "Ergonomic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 469,
                columns: new[] { "cost", "name" },
                values: new object[] { 794.74732143416577, "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 470,
                columns: new[] { "cost", "name" },
                values: new object[] { 13.470795838345589, "Rustic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 471,
                columns: new[] { "cost", "name" },
                values: new object[] { 233.90007391953054, "Handmade Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 472,
                columns: new[] { "cost", "name" },
                values: new object[] { 991.07833313018148, "Refined Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 473,
                columns: new[] { "cost", "name" },
                values: new object[] { 496.14965399337609, "Sleek Steel Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 474,
                columns: new[] { "cost", "name" },
                values: new object[] { 302.05921525861021, "Handmade Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 475,
                columns: new[] { "cost", "name" },
                values: new object[] { 761.58252030061294, "Fantastic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 476,
                columns: new[] { "cost", "name" },
                values: new object[] { 934.76127755211951, "Licensed Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 477,
                columns: new[] { "cost", "name" },
                values: new object[] { 709.10395530318499, "Incredible Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 478,
                columns: new[] { "cost", "name" },
                values: new object[] { 764.57793046387246, "Intelligent Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 479,
                columns: new[] { "cost", "name" },
                values: new object[] { 383.56169510169235, "Incredible Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 480,
                columns: new[] { "cost", "name" },
                values: new object[] { 42.925230667697456, "Awesome Steel Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 481,
                columns: new[] { "cost", "name" },
                values: new object[] { 89.281746028993979, "Handmade Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 482,
                columns: new[] { "cost", "name" },
                values: new object[] { 671.95935419633099, "Small Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 483,
                columns: new[] { "cost", "name" },
                values: new object[] { 208.0257550584827, "Practical Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 484,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.407789344559433, "Handmade Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 485,
                columns: new[] { "cost", "name" },
                values: new object[] { 401.85283946070939, "Unbranded Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 486,
                columns: new[] { "cost", "name" },
                values: new object[] { 875.1528964767864, "Awesome Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 487,
                columns: new[] { "cost", "name" },
                values: new object[] { 378.61521285424976, "Ergonomic Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 488,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.70532545173808, "Gorgeous Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 489,
                columns: new[] { "cost", "name" },
                values: new object[] { 56.148801866241044, "Intelligent Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 490,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.945452704240417, "Fantastic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 491,
                columns: new[] { "cost", "name" },
                values: new object[] { 236.94606472614086, "Incredible Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 492,
                columns: new[] { "cost", "name" },
                values: new object[] { 421.91107045115552, "Gorgeous Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 493,
                columns: new[] { "cost", "name" },
                values: new object[] { 102.63736655219796, "Refined Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 494,
                columns: new[] { "cost", "name" },
                values: new object[] { 36.203427664338633, "Intelligent Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 495,
                columns: new[] { "cost", "name" },
                values: new object[] { 629.03671682033018, "Rustic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 496,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.80986637594458, "Sleek Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 497,
                columns: new[] { "cost", "name" },
                values: new object[] { 635.00974581688138, "Incredible Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 498,
                columns: new[] { "cost", "name" },
                values: new object[] { 345.13721099147449, "Licensed Metal Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 499,
                columns: new[] { "cost", "name" },
                values: new object[] { 140.97726030898497, "Ergonomic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 500,
                columns: new[] { "cost", "name" },
                values: new object[] { 341.31852654044729, "Generic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 501,
                columns: new[] { "cost", "name" },
                values: new object[] { 464.41485773282636, "Rustic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 502,
                columns: new[] { "cost", "name" },
                values: new object[] { 620.84808012776443, "Rustic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 503,
                columns: new[] { "cost", "name" },
                values: new object[] { 280.32266844965011, "Generic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 504,
                columns: new[] { "cost", "name" },
                values: new object[] { 362.64384354689946, "Tasty Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 505,
                columns: new[] { "cost", "name" },
                values: new object[] { 52.185304399395136, "Rustic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 506,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.07026482235611, "Tasty Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 507,
                columns: new[] { "cost", "name" },
                values: new object[] { 534.65513481707853, "Tasty Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 508,
                columns: new[] { "cost", "name" },
                values: new object[] { 299.28519314956168, "Refined Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 509,
                columns: new[] { "cost", "name" },
                values: new object[] { 984.35408603582016, "Handmade Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 510,
                columns: new[] { "cost", "name" },
                values: new object[] { 811.83561381781089, "Rustic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 511,
                columns: new[] { "cost", "name" },
                values: new object[] { 481.71334140501347, "Licensed Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 512,
                columns: new[] { "cost", "name" },
                values: new object[] { 385.38822229355884, "Generic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 513,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.855504488738973, "Refined Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 514,
                columns: new[] { "cost", "name" },
                values: new object[] { 634.42135814713413, "Tasty Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 515,
                columns: new[] { "cost", "name" },
                values: new object[] { 632.15485129544015, "Fantastic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 516,
                columns: new[] { "cost", "name" },
                values: new object[] { 752.64530126348473, "Rustic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 517,
                columns: new[] { "cost", "name" },
                values: new object[] { 776.43266946508663, "Fantastic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 518,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.94402690771574, "Intelligent Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 519,
                columns: new[] { "cost", "name" },
                values: new object[] { 875.65851270493567, "Fantastic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 520,
                columns: new[] { "cost", "name" },
                values: new object[] { 431.01235262352532, "Tasty Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 521,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.47747833487927, "Incredible Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 522,
                columns: new[] { "cost", "name" },
                values: new object[] { 314.13533308426122, "Tasty Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 523,
                columns: new[] { "cost", "name" },
                values: new object[] { 407.70224583753554, "Handcrafted Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 524,
                columns: new[] { "cost", "name" },
                values: new object[] { 776.44076055659878, "Rustic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 525,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.6586260591273, "Gorgeous Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 526,
                columns: new[] { "cost", "name" },
                values: new object[] { 649.42875214534831, "Awesome Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 527,
                columns: new[] { "cost", "name" },
                values: new object[] { 441.08207939212627, "Handcrafted Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 528,
                columns: new[] { "cost", "name" },
                values: new object[] { 478.4628821229237, "Practical Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 529,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.32512576513057, "Small Granite Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 530,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.268932434254843, "Small Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 531,
                columns: new[] { "cost", "name" },
                values: new object[] { 116.31023011381738, "Awesome Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 532,
                columns: new[] { "cost", "name" },
                values: new object[] { 176.84934634195096, "Intelligent Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 533,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.57497925577536, "Handmade Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 534,
                columns: new[] { "cost", "name" },
                values: new object[] { 964.3700908026741, "Unbranded Steel Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 535,
                columns: new[] { "cost", "name" },
                values: new object[] { 944.34474673858824, "Handcrafted Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 536,
                columns: new[] { "cost", "name" },
                values: new object[] { 542.21814905433439, "Awesome Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 537,
                columns: new[] { "cost", "name" },
                values: new object[] { 71.855502668441119, "Practical Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 538,
                columns: new[] { "cost", "name" },
                values: new object[] { 536.21272688984732, "Handcrafted Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 539,
                columns: new[] { "cost", "name" },
                values: new object[] { 152.52093658742001, "Licensed Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 540,
                columns: new[] { "cost", "name" },
                values: new object[] { 545.71428035677968, "Handcrafted Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 541,
                columns: new[] { "cost", "name" },
                values: new object[] { 454.7775039299899, "Fantastic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 542,
                columns: new[] { "cost", "name" },
                values: new object[] { 157.71245623766063, "Fantastic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 543,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.72886304144009, "Small Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 544,
                columns: new[] { "cost", "name" },
                values: new object[] { 370.40057530287169, "Small Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 545,
                columns: new[] { "cost", "name" },
                values: new object[] { 31.003909630841829, "Fantastic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 546,
                columns: new[] { "cost", "name" },
                values: new object[] { 69.593579237349331, "Refined Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 547,
                columns: new[] { "cost", "name" },
                values: new object[] { 906.5387245252125, "Tasty Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 548,
                columns: new[] { "cost", "name" },
                values: new object[] { 72.704722180720651, "Handmade Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 549,
                columns: new[] { "cost", "name" },
                values: new object[] { 975.20393522449592, "Ergonomic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 550,
                columns: new[] { "cost", "name" },
                values: new object[] { 677.52832314080615, "Sleek Plastic Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 551,
                columns: new[] { "cost", "name" },
                values: new object[] { 920.33896662126881, "Unbranded Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 552,
                columns: new[] { "cost", "name" },
                values: new object[] { 949.58011551459663, "Generic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 553,
                columns: new[] { "cost", "name" },
                values: new object[] { 823.9064131800659, "Handmade Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 554,
                columns: new[] { "cost", "name" },
                values: new object[] { 831.65197480434927, "Practical Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 555,
                columns: new[] { "cost", "name" },
                values: new object[] { 9.9737784602040698, "Refined Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 556,
                columns: new[] { "cost", "name" },
                values: new object[] { 773.17293382996036, "Refined Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 557,
                columns: new[] { "cost", "name" },
                values: new object[] { 508.25557918168994, "Awesome Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 558,
                columns: new[] { "cost", "name" },
                values: new object[] { 365.95029374089364, "Gorgeous Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 559,
                columns: new[] { "cost", "name" },
                values: new object[] { 597.34730025226634, "Ergonomic Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 560,
                columns: new[] { "cost", "name" },
                values: new object[] { 109.32273184114952, "Ergonomic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 561,
                columns: new[] { "cost", "name" },
                values: new object[] { 728.88170487409468, "Ergonomic Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 562,
                columns: new[] { "cost", "name" },
                values: new object[] { 667.27610563957478, "Ergonomic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 563,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.81826796938117, "Intelligent Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 564,
                columns: new[] { "cost", "name" },
                values: new object[] { 841.22848847586101, "Intelligent Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 565,
                columns: new[] { "cost", "name" },
                values: new object[] { 398.39602233456856, "Refined Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 566,
                columns: new[] { "cost", "name" },
                values: new object[] { 432.75173469287347, "Generic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 567,
                columns: new[] { "cost", "name" },
                values: new object[] { 478.64795888859589, "Incredible Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 568,
                columns: new[] { "cost", "name" },
                values: new object[] { 427.4035619647745, "Sleek Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 569,
                columns: new[] { "cost", "name" },
                values: new object[] { 818.12771731431292, "Generic Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 570,
                columns: new[] { "cost", "name" },
                values: new object[] { 672.8266202829717, "Awesome Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 571,
                columns: new[] { "cost", "name" },
                values: new object[] { 782.46678169445067, "Handcrafted Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 572,
                columns: new[] { "cost", "name" },
                values: new object[] { 589.40051386109337, "Rustic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 573,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.34125012460913, "Gorgeous Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 574,
                columns: new[] { "cost", "name" },
                values: new object[] { 896.57121459049608, "Small Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 575,
                columns: new[] { "cost", "name" },
                values: new object[] { 223.36759546632777, "Intelligent Granite Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 576,
                columns: new[] { "cost", "name" },
                values: new object[] { 642.84039117405644, "Generic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 577,
                columns: new[] { "cost", "name" },
                values: new object[] { 80.928579199525586, "Ergonomic Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 578,
                columns: new[] { "cost", "name" },
                values: new object[] { 667.41525933181765, "Fantastic Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 579,
                columns: new[] { "cost", "name" },
                values: new object[] { 745.03765141086376, "Awesome Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 580,
                columns: new[] { "cost", "name" },
                values: new object[] { 896.57807771688363, "Licensed Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 581,
                columns: new[] { "cost", "name" },
                values: new object[] { 597.25055349640979, "Sleek Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 582,
                columns: new[] { "cost", "name" },
                values: new object[] { 822.82192092630964, "Rustic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 583,
                columns: new[] { "cost", "name" },
                values: new object[] { 861.18501099105004, "Handmade Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 584,
                columns: new[] { "cost", "name" },
                values: new object[] { 317.37766779848096, "Gorgeous Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 585,
                columns: new[] { "cost", "name" },
                values: new object[] { 332.91468535767433, "Generic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 586,
                columns: new[] { "cost", "name" },
                values: new object[] { 815.95454959951792, "Awesome Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 587,
                columns: new[] { "cost", "name" },
                values: new object[] { 88.977534348191867, "Incredible Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 588,
                columns: new[] { "cost", "name" },
                values: new object[] { 41.358385067432309, "Sleek Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 589,
                columns: new[] { "cost", "name" },
                values: new object[] { 564.54988606748304, "Gorgeous Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 590,
                columns: new[] { "cost", "name" },
                values: new object[] { 358.07064645942523, "Ergonomic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 591,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.37709033543342, "Practical Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 592,
                columns: new[] { "cost", "name" },
                values: new object[] { 396.67826619452092, "Awesome Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 593,
                columns: new[] { "cost", "name" },
                values: new object[] { 6.3243416782653137, "Rustic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 594,
                columns: new[] { "cost", "name" },
                values: new object[] { 119.48588476661644, "Practical Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 595,
                columns: new[] { "cost", "name" },
                values: new object[] { 948.38340672548782, "Licensed Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 596,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.39090283065741, "Generic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 597,
                columns: new[] { "cost", "name" },
                values: new object[] { 763.49714529275514, "Incredible Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 598,
                columns: new[] { "cost", "name" },
                values: new object[] { 810.54928322258536, "Rustic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 599,
                columns: new[] { "cost", "name" },
                values: new object[] { 887.6988189368052, "Small Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 600,
                columns: new[] { "cost", "name" },
                values: new object[] { 382.37395411820717, "Fantastic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 601,
                columns: new[] { "cost", "name" },
                values: new object[] { 165.66182473432002, "Licensed Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 602,
                columns: new[] { "cost", "name" },
                values: new object[] { 77.871952440258667, "Rustic Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 603,
                columns: new[] { "cost", "name" },
                values: new object[] { 675.44085913253275, "Generic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 604,
                columns: new[] { "cost", "name" },
                values: new object[] { 222.06656668480494, "Incredible Frozen Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 605,
                columns: new[] { "cost", "name" },
                values: new object[] { 725.92662097351661, "Unbranded Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 606,
                columns: new[] { "cost", "name" },
                values: new object[] { 124.62781707198135, "Licensed Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 607,
                columns: new[] { "cost", "name" },
                values: new object[] { 289.8140779811929, "Handcrafted Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 608,
                columns: new[] { "cost", "name" },
                values: new object[] { 789.16247967183642, "Sleek Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 609,
                columns: new[] { "cost", "name" },
                values: new object[] { 725.93973402211554, "Sleek Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 610,
                columns: new[] { "cost", "name" },
                values: new object[] { 658.10872620634154, "Awesome Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 611,
                columns: new[] { "cost", "name" },
                values: new object[] { 841.99841620826862, "Incredible Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 612,
                columns: new[] { "cost", "name" },
                values: new object[] { 350.99345952017217, "Gorgeous Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 613,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.00705086973481, "Sleek Steel Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 614,
                columns: new[] { "cost", "name" },
                values: new object[] { 372.28797496350904, "Tasty Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 615,
                columns: new[] { "cost", "name" },
                values: new object[] { 280.45470430936354, "Gorgeous Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 616,
                columns: new[] { "cost", "name" },
                values: new object[] { 308.47837039084612, "Fantastic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 617,
                columns: new[] { "cost", "name" },
                values: new object[] { 364.93263721396517, "Refined Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 618,
                columns: new[] { "cost", "name" },
                values: new object[] { 628.30475946210288, "Intelligent Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 619,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.24877710504575, "Ergonomic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 620,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.98149457264037, "Unbranded Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 621,
                columns: new[] { "cost", "name" },
                values: new object[] { 90.972466952603838, "Gorgeous Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 622,
                columns: new[] { "cost", "name" },
                values: new object[] { 279.35768713944111, "Awesome Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 623,
                columns: new[] { "cost", "name" },
                values: new object[] { 517.63058537900929, "Handcrafted Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 624,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.3797661505788, "Practical Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 625,
                columns: new[] { "cost", "name" },
                values: new object[] { 759.56814756398603, "Licensed Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 626,
                columns: new[] { "cost", "name" },
                values: new object[] { 33.074027405058551, "Licensed Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 627,
                columns: new[] { "cost", "name" },
                values: new object[] { 613.11634248962196, "Tasty Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 628,
                columns: new[] { "cost", "name" },
                values: new object[] { 689.83313566201139, "Ergonomic Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 629,
                columns: new[] { "cost", "name" },
                values: new object[] { 237.83119475518308, "Incredible Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 630,
                columns: new[] { "cost", "name" },
                values: new object[] { 329.81110417861896, "Intelligent Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 631,
                columns: new[] { "cost", "name" },
                values: new object[] { 310.14504136160133, "Handcrafted Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 632,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.05027522884347, "Generic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 633,
                columns: new[] { "cost", "name" },
                values: new object[] { 926.21187029039606, "Ergonomic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 634,
                columns: new[] { "cost", "name" },
                values: new object[] { 524.7779730846695, "Rustic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 635,
                columns: new[] { "cost", "name" },
                values: new object[] { 604.20692777697445, "Sleek Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 636,
                columns: new[] { "cost", "name" },
                values: new object[] { 947.38093588594586, "Licensed Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 637,
                columns: new[] { "cost", "name" },
                values: new object[] { 466.94016413043232, "Intelligent Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 638,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.51554785907973, "Rustic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 639,
                columns: new[] { "cost", "name" },
                values: new object[] { 638.96260935720318, "Unbranded Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 640,
                columns: new[] { "cost", "name" },
                values: new object[] { 386.33982887840557, "Generic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 641,
                columns: new[] { "cost", "name" },
                values: new object[] { 757.44555626092426, "Incredible Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 642,
                columns: new[] { "cost", "name" },
                values: new object[] { 179.44220696819897, "Handmade Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 643,
                columns: new[] { "cost", "name" },
                values: new object[] { 108.63691191647938, "Handmade Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 644,
                columns: new[] { "cost", "name" },
                values: new object[] { 810.18362730941442, "Intelligent Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 645,
                columns: new[] { "cost", "name" },
                values: new object[] { 439.20758749736979, "Rustic Granite Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 646,
                columns: new[] { "cost", "name" },
                values: new object[] { 248.40017709054808, "Ergonomic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 647,
                columns: new[] { "cost", "name" },
                values: new object[] { 440.684305486688, "Handmade Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 648,
                columns: new[] { "cost", "name" },
                values: new object[] { 398.02463600099247, "Tasty Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 649,
                columns: new[] { "cost", "name" },
                values: new object[] { 795.2356972880176, "Handcrafted Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 650,
                columns: new[] { "cost", "name" },
                values: new object[] { 177.51988140703091, "Incredible Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 651,
                columns: new[] { "cost", "name" },
                values: new object[] { 408.41168076506267, "Ergonomic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 652,
                columns: new[] { "cost", "name" },
                values: new object[] { 407.06227052265723, "Ergonomic Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 653,
                columns: new[] { "cost", "name" },
                values: new object[] { 225.37426825968407, "Handcrafted Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 654,
                columns: new[] { "cost", "name" },
                values: new object[] { 284.08878467816714, "Ergonomic Soft Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 655,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.487346094135123, "Handcrafted Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 656,
                columns: new[] { "cost", "name" },
                values: new object[] { 263.99693796222533, "Awesome Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 657,
                columns: new[] { "cost", "name" },
                values: new object[] { 539.40627322903742, "Intelligent Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 658,
                columns: new[] { "cost", "name" },
                values: new object[] { 35.580405405945505, "Small Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 659,
                columns: new[] { "cost", "name" },
                values: new object[] { 930.72459154651904, "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 660,
                columns: new[] { "cost", "name" },
                values: new object[] { 132.30382748577571, "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 661,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.37510152001357, "Generic Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 662,
                columns: new[] { "cost", "name" },
                values: new object[] { 572.35249272497549, "Tasty Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 663,
                columns: new[] { "cost", "name" },
                values: new object[] { 637.54312216508595, "Unbranded Metal Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 664,
                columns: new[] { "cost", "name" },
                values: new object[] { 136.37358942061505, "Handcrafted Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 665,
                columns: new[] { "cost", "name" },
                values: new object[] { 657.8394852492512, "Small Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 666,
                columns: new[] { "cost", "name" },
                values: new object[] { 177.24591858315975, "Tasty Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 667,
                columns: new[] { "cost", "name" },
                values: new object[] { 381.60130939793231, "Practical Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 668,
                columns: new[] { "cost", "name" },
                values: new object[] { 326.959660314161, "Incredible Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 669,
                columns: new[] { "cost", "name" },
                values: new object[] { 328.7856974661355, "Incredible Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 670,
                columns: new[] { "cost", "name" },
                values: new object[] { 978.01985623671715, "Incredible Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 671,
                columns: new[] { "cost", "name" },
                values: new object[] { 860.57486922624037, "Handcrafted Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 672,
                columns: new[] { "cost", "name" },
                values: new object[] { 314.23511320808615, "Tasty Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 673,
                columns: new[] { "cost", "name" },
                values: new object[] { 845.32111848320415, "Licensed Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 674,
                columns: new[] { "cost", "name" },
                values: new object[] { 321.20643573444517, "Handcrafted Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 675,
                columns: new[] { "cost", "name" },
                values: new object[] { 852.4754490362975, "Incredible Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 676,
                columns: new[] { "cost", "name" },
                values: new object[] { 619.33667565590201, "Refined Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 677,
                columns: new[] { "cost", "name" },
                values: new object[] { 89.05248267780739, "Incredible Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 678,
                columns: new[] { "cost", "name" },
                values: new object[] { 783.7802900745495, "Gorgeous Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 679,
                columns: new[] { "cost", "name" },
                values: new object[] { 736.88512155576552, "Rustic Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 680,
                columns: new[] { "cost", "name" },
                values: new object[] { 408.99138430920431, "Awesome Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 681,
                columns: new[] { "cost", "name" },
                values: new object[] { 321.04946354770118, "Tasty Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 682,
                columns: new[] { "cost", "name" },
                values: new object[] { 997.50572280843551, "Practical Soft Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 683,
                columns: new[] { "cost", "name" },
                values: new object[] { 531.37698299042938, "Tasty Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 684,
                columns: new[] { "cost", "name" },
                values: new object[] { 234.97195055043304, "Tasty Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 685,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.406982336448543, "Handcrafted Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 686,
                columns: new[] { "cost", "name" },
                values: new object[] { 85.34930620090806, "Handcrafted Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 687,
                columns: new[] { "cost", "name" },
                values: new object[] { 279.540082433956, "Practical Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 688,
                columns: new[] { "cost", "name" },
                values: new object[] { 251.12139499463444, "Handcrafted Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 689,
                columns: new[] { "cost", "name" },
                values: new object[] { 199.12032581676803, "Handcrafted Metal Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 690,
                columns: new[] { "cost", "name" },
                values: new object[] { 768.86500848035587, "Licensed Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 691,
                columns: new[] { "cost", "name" },
                values: new object[] { 117.26444452588926, "Awesome Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 692,
                columns: new[] { "cost", "name" },
                values: new object[] { 504.15915724959967, "Fantastic Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 693,
                columns: new[] { "cost", "name" },
                values: new object[] { 737.04665357137924, "Refined Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 694,
                columns: new[] { "cost", "name" },
                values: new object[] { 446.07006601733485, "Gorgeous Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 695,
                columns: new[] { "cost", "name" },
                values: new object[] { 573.72772175120565, "Unbranded Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 696,
                columns: new[] { "cost", "name" },
                values: new object[] { 33.633752044712466, "Refined Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 697,
                columns: new[] { "cost", "name" },
                values: new object[] { 886.33701408534637, "Handcrafted Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 698,
                columns: new[] { "cost", "name" },
                values: new object[] { 483.39429862428284, "Generic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 699,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.27257778189175, "Intelligent Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 700,
                columns: new[] { "cost", "name" },
                values: new object[] { 86.669853141711712, "Small Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 701,
                columns: new[] { "cost", "name" },
                values: new object[] { 40.971597296730849, "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 702,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.467925936468461, "Refined Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 703,
                columns: new[] { "cost", "name" },
                values: new object[] { 44.150341781983997, "Sleek Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 704,
                columns: new[] { "cost", "name" },
                values: new object[] { 933.70925336508526, "Sleek Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 705,
                columns: new[] { "cost", "name" },
                values: new object[] { 750.96587348958042, "Handmade Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 706,
                columns: new[] { "cost", "name" },
                values: new object[] { 334.70738379929691, "Tasty Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 707,
                columns: new[] { "cost", "name" },
                values: new object[] { 350.16920062980211, "Handmade Granite Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 708,
                columns: new[] { "cost", "name" },
                values: new object[] { 655.42443110609724, "Licensed Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 709,
                columns: new[] { "cost", "name" },
                values: new object[] { 473.98790449010426, "Rustic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 710,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.57306768539001, "Ergonomic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 711,
                columns: new[] { "cost", "name" },
                values: new object[] { 425.41462083899967, "Intelligent Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 712,
                columns: new[] { "cost", "name" },
                values: new object[] { 128.18770395707142, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 713,
                columns: new[] { "cost", "name" },
                values: new object[] { 197.53784826216267, "Sleek Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 714,
                columns: new[] { "cost", "name" },
                values: new object[] { 370.09279350944576, "Refined Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 715,
                columns: new[] { "cost", "name" },
                values: new object[] { 544.08702766342378, "Incredible Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 716,
                columns: new[] { "cost", "name" },
                values: new object[] { 28.254646120087095, "Rustic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 717,
                columns: new[] { "cost", "name" },
                values: new object[] { 829.82945818251847, "Intelligent Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 718,
                columns: new[] { "cost", "name" },
                values: new object[] { 787.40807647001657, "Unbranded Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 719,
                columns: new[] { "cost", "name" },
                values: new object[] { 851.06734028730557, "Sleek Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 720,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.02595876867508, "Incredible Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 721,
                columns: new[] { "cost", "name" },
                values: new object[] { 956.42174232600587, "Unbranded Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 722,
                columns: new[] { "cost", "name" },
                values: new object[] { 825.19000964956695, "Small Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 723,
                columns: new[] { "cost", "name" },
                values: new object[] { 521.02785392040755, "Small Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 724,
                columns: new[] { "cost", "name" },
                values: new object[] { 981.84903994401657, "Awesome Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 725,
                columns: new[] { "cost", "name" },
                values: new object[] { 638.7456421659092, "Intelligent Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 726,
                columns: new[] { "cost", "name" },
                values: new object[] { 690.31788500339201, "Intelligent Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 727,
                columns: new[] { "cost", "name" },
                values: new object[] { 320.93077636800029, "Refined Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 728,
                columns: new[] { "cost", "name" },
                values: new object[] { 425.44955995216901, "Rustic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 729,
                columns: new[] { "cost", "name" },
                values: new object[] { 945.00247302216849, "Tasty Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 730,
                columns: new[] { "cost", "name" },
                values: new object[] { 972.04289709325212, "Fantastic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 731,
                columns: new[] { "cost", "name" },
                values: new object[] { 775.30682798837699, "Ergonomic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 732,
                columns: new[] { "cost", "name" },
                values: new object[] { 451.24027632451788, "Intelligent Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 733,
                columns: new[] { "cost", "name" },
                values: new object[] { 830.84655589706108, "Practical Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 734,
                columns: new[] { "cost", "name" },
                values: new object[] { 242.93389085495323, "Handcrafted Metal Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 735,
                columns: new[] { "cost", "name" },
                values: new object[] { 981.72501465216658, "Fantastic Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 736,
                columns: new[] { "cost", "name" },
                values: new object[] { 446.46831092580561, "Small Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 737,
                columns: new[] { "cost", "name" },
                values: new object[] { 456.66876841674565, "Generic Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 738,
                columns: new[] { "cost", "name" },
                values: new object[] { 951.76105447004534, "Handmade Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 739,
                columns: new[] { "cost", "name" },
                values: new object[] { 375.99272945494539, "Practical Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 740,
                columns: new[] { "cost", "name" },
                values: new object[] { 733.84466691131104, "Refined Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 741,
                columns: new[] { "cost", "name" },
                values: new object[] { 528.87702147186451, "Generic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 742,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.13833835393586, "Rustic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 743,
                columns: new[] { "cost", "name" },
                values: new object[] { 654.42516875824515, "Refined Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 744,
                columns: new[] { "cost", "name" },
                values: new object[] { 491.30626224730128, "Handmade Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 745,
                columns: new[] { "cost", "name" },
                values: new object[] { 387.36924729465363, "Unbranded Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 746,
                columns: new[] { "cost", "name" },
                values: new object[] { 230.98952428236683, "Sleek Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 747,
                columns: new[] { "cost", "name" },
                values: new object[] { 698.80420390616723, "Fantastic Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 748,
                columns: new[] { "cost", "name" },
                values: new object[] { 710.7906473200386, "Incredible Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 749,
                columns: new[] { "cost", "name" },
                values: new object[] { 98.233417523595293, "Fantastic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 750,
                columns: new[] { "cost", "name" },
                values: new object[] { 800.17217960267567, "Intelligent Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 751,
                columns: new[] { "cost", "name" },
                values: new object[] { 179.44225518646832, "Gorgeous Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 752,
                columns: new[] { "cost", "name" },
                values: new object[] { 199.16468062150039, "Intelligent Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 753,
                columns: new[] { "cost", "name" },
                values: new object[] { 342.79332911052512, "Gorgeous Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 754,
                columns: new[] { "cost", "name" },
                values: new object[] { 623.79802071669769, "Small Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 755,
                columns: new[] { "cost", "name" },
                values: new object[] { 279.86563662176673, "Gorgeous Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 756,
                columns: new[] { "cost", "name" },
                values: new object[] { 651.61387302839876, "Handcrafted Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 757,
                columns: new[] { "cost", "name" },
                values: new object[] { 974.2384793958181, "Unbranded Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 758,
                columns: new[] { "cost", "name" },
                values: new object[] { 968.29448465268979, "Gorgeous Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 759,
                columns: new[] { "cost", "name" },
                values: new object[] { 108.34060831980841, "Handmade Soft Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 760,
                columns: new[] { "cost", "name" },
                values: new object[] { 741.88140502556394, "Rustic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 761,
                columns: new[] { "cost", "name" },
                values: new object[] { 101.48897434004473, "Incredible Wooden Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 762,
                columns: new[] { "cost", "name" },
                values: new object[] { 983.82449336378556, "Rustic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 763,
                columns: new[] { "cost", "name" },
                values: new object[] { 431.33398202264971, "Practical Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 764,
                columns: new[] { "cost", "name" },
                values: new object[] { 699.26110828672097, "Unbranded Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 765,
                columns: new[] { "cost", "name" },
                values: new object[] { 631.2692405598367, "Small Metal Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 766,
                columns: new[] { "cost", "name" },
                values: new object[] { 469.56177840322459, "Incredible Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 767,
                columns: new[] { "cost", "name" },
                values: new object[] { 732.15628153484295, "Practical Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 768,
                columns: new[] { "cost", "name" },
                values: new object[] { 538.22856156800651, "Handcrafted Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 769,
                columns: new[] { "cost", "name" },
                values: new object[] { 458.3651696423982, "Tasty Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 770,
                columns: new[] { "cost", "name" },
                values: new object[] { 14.660322392049588, "Awesome Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 771,
                columns: new[] { "cost", "name" },
                values: new object[] { 393.33181300407182, "Licensed Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 772,
                columns: new[] { "cost", "name" },
                values: new object[] { 527.63861822107094, "Practical Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 773,
                columns: new[] { "cost", "name" },
                values: new object[] { 270.68170924310459, "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 774,
                columns: new[] { "cost", "name" },
                values: new object[] { 329.66536296929092, "Handcrafted Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 775,
                columns: new[] { "cost", "name" },
                values: new object[] { 439.21619802522349, "Ergonomic Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 776,
                columns: new[] { "cost", "name" },
                values: new object[] { 262.0243236519305, "Fantastic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 777,
                columns: new[] { "cost", "name" },
                values: new object[] { 239.58622464104263, "Unbranded Rubber Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 778,
                columns: new[] { "cost", "name" },
                values: new object[] { 700.88319820239519, "Gorgeous Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 779,
                columns: new[] { "cost", "name" },
                values: new object[] { 907.08854573947201, "Generic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 780,
                columns: new[] { "cost", "name" },
                values: new object[] { 2.5518806824310776, "Small Metal Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 781,
                columns: new[] { "cost", "name" },
                values: new object[] { 382.60497555259064, "Incredible Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 782,
                columns: new[] { "cost", "name" },
                values: new object[] { 524.36276665456501, "Unbranded Metal Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 783,
                columns: new[] { "cost", "name" },
                values: new object[] { 233.57460245313575, "Tasty Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 784,
                columns: new[] { "cost", "name" },
                values: new object[] { 20.863213511963998, "Unbranded Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 785,
                columns: new[] { "cost", "name" },
                values: new object[] { 884.92870538648276, "Gorgeous Granite Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 786,
                columns: new[] { "cost", "name" },
                values: new object[] { 937.5104911162814, "Handmade Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 787,
                columns: new[] { "cost", "name" },
                values: new object[] { 295.09755134224611, "Gorgeous Steel Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 788,
                columns: new[] { "cost", "name" },
                values: new object[] { 190.83284840827875, "Sleek Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 789,
                columns: new[] { "cost", "name" },
                values: new object[] { 434.67123077520512, "Rustic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 790,
                columns: new[] { "cost", "name" },
                values: new object[] { 65.402420971036975, "Fantastic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 791,
                columns: new[] { "cost", "name" },
                values: new object[] { 188.40519794300573, "Practical Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 792,
                columns: new[] { "cost", "name" },
                values: new object[] { 899.79512645980685, "Refined Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 793,
                columns: new[] { "cost", "name" },
                values: new object[] { 381.69487695118283, "Licensed Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 794,
                columns: new[] { "cost", "name" },
                values: new object[] { 636.59316749951813, "Generic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 795,
                columns: new[] { "cost", "name" },
                values: new object[] { 175.18330155472503, "Refined Soft Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 796,
                columns: new[] { "cost", "name" },
                values: new object[] { 455.09327777671933, "Rustic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 797,
                columns: new[] { "cost", "name" },
                values: new object[] { 123.24013213666959, "Licensed Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 798,
                columns: new[] { "cost", "name" },
                values: new object[] { 5.9082892292385907, "Fantastic Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 799,
                columns: new[] { "cost", "name" },
                values: new object[] { 145.81232656812108, "Handmade Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 800,
                columns: new[] { "cost", "name" },
                values: new object[] { 251.17216753354376, "Practical Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 801,
                columns: new[] { "cost", "name" },
                values: new object[] { 440.4987497593487, "Small Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 802,
                columns: new[] { "cost", "name" },
                values: new object[] { 13.225696254921234, "Gorgeous Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 803,
                columns: new[] { "cost", "name" },
                values: new object[] { 205.54475214470662, "Fantastic Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 804,
                columns: new[] { "cost", "name" },
                values: new object[] { 390.17963190678904, "Fantastic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 805,
                columns: new[] { "cost", "name" },
                values: new object[] { 627.13913989248363, "Intelligent Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 806,
                columns: new[] { "cost", "name" },
                values: new object[] { 232.27389360753622, "Refined Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 807,
                columns: new[] { "cost", "name" },
                values: new object[] { 436.57689891065723, "Unbranded Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 808,
                columns: new[] { "cost", "name" },
                values: new object[] { 945.05521485555357, "Gorgeous Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 809,
                columns: new[] { "cost", "name" },
                values: new object[] { 880.5245738467537, "Handmade Granite Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 810,
                columns: new[] { "cost", "name" },
                values: new object[] { 738.77668255286176, "Unbranded Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 811,
                columns: new[] { "cost", "name" },
                values: new object[] { 486.5467495011859, "Gorgeous Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 812,
                columns: new[] { "cost", "name" },
                values: new object[] { 711.91576429506176, "Tasty Soft Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 813,
                columns: new[] { "cost", "name" },
                values: new object[] { 930.99307932036697, "Unbranded Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 814,
                columns: new[] { "cost", "name" },
                values: new object[] { 533.07066295248353, "Handmade Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 815,
                columns: new[] { "cost", "name" },
                values: new object[] { 927.01502476487565, "Small Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 816,
                columns: new[] { "cost", "name" },
                values: new object[] { 736.56350014649729, "Generic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 817,
                columns: new[] { "cost", "name" },
                values: new object[] { 408.85543377893703, "Ergonomic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 818,
                columns: new[] { "cost", "name" },
                values: new object[] { 297.41483945950097, "Licensed Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 819,
                columns: new[] { "cost", "name" },
                values: new object[] { 760.49269269053332, "Rustic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 820,
                columns: new[] { "cost", "name" },
                values: new object[] { 165.39962404169376, "Incredible Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 821,
                columns: new[] { "cost", "name" },
                values: new object[] { 337.39607566322525, "Awesome Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 822,
                columns: new[] { "cost", "name" },
                values: new object[] { 714.57947790990193, "Incredible Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 823,
                columns: new[] { "cost", "name" },
                values: new object[] { 497.38272912759675, "Gorgeous Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 824,
                columns: new[] { "cost", "name" },
                values: new object[] { 824.32734594495241, "Licensed Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 825,
                columns: new[] { "cost", "name" },
                values: new object[] { 43.512897676696731, "Tasty Frozen Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 826,
                columns: new[] { "cost", "name" },
                values: new object[] { 754.79614899440446, "Generic Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 827,
                columns: new[] { "cost", "name" },
                values: new object[] { 546.46199869016959, "Handmade Granite Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 828,
                columns: new[] { "cost", "name" },
                values: new object[] { 506.51018980097484, "Fantastic Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 829,
                columns: new[] { "cost", "name" },
                values: new object[] { 853.94400282269578, "Practical Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 830,
                columns: new[] { "cost", "name" },
                values: new object[] { 743.7447760550865, "Intelligent Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 831,
                columns: new[] { "cost", "name" },
                values: new object[] { 354.23265133138062, "Licensed Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 832,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.02235563263525, "Gorgeous Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 833,
                columns: new[] { "cost", "name" },
                values: new object[] { 601.49748265848382, "Rustic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 834,
                columns: new[] { "cost", "name" },
                values: new object[] { 158.23345452549202, "Generic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 835,
                columns: new[] { "cost", "name" },
                values: new object[] { 116.01765645964657, "Sleek Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 836,
                columns: new[] { "cost", "name" },
                values: new object[] { 598.20544080673619, "Gorgeous Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 837,
                columns: new[] { "cost", "name" },
                values: new object[] { 470.92856700778401, "Sleek Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 838,
                columns: new[] { "cost", "name" },
                values: new object[] { 293.25963288698586, "Generic Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 839,
                columns: new[] { "cost", "name" },
                values: new object[] { 532.52588227960518, "Fantastic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 840,
                columns: new[] { "cost", "name" },
                values: new object[] { 877.52589667960513, "Handmade Concrete Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 841,
                columns: new[] { "cost", "name" },
                values: new object[] { 209.89748684738811, "Sleek Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 842,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.53856816475241, "Ergonomic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 843,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.27039519287271, "Refined Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 844,
                columns: new[] { "cost", "name" },
                values: new object[] { 326.18874440735965, "Refined Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 845,
                columns: new[] { "cost", "name" },
                values: new object[] { 76.551853406973777, "Small Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 846,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.20395145279787, "Awesome Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 847,
                columns: new[] { "cost", "name" },
                values: new object[] { 605.6176550918558, "Small Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 848,
                columns: new[] { "cost", "name" },
                values: new object[] { 871.03043858969568, "Refined Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 849,
                columns: new[] { "cost", "name" },
                values: new object[] { 936.21314626233982, "Practical Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 850,
                columns: new[] { "cost", "name" },
                values: new object[] { 987.29011513503258, "Practical Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 851,
                columns: new[] { "cost", "name" },
                values: new object[] { 234.51928977587335, "Licensed Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 852,
                columns: new[] { "cost", "name" },
                values: new object[] { 374.60768365048312, "Ergonomic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 853,
                columns: new[] { "cost", "name" },
                values: new object[] { 404.38934780144189, "Small Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 854,
                columns: new[] { "cost", "name" },
                values: new object[] { 412.32970869494727, "Handcrafted Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 855,
                columns: new[] { "cost", "name" },
                values: new object[] { 653.13942300514248, "Small Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 856,
                columns: new[] { "cost", "name" },
                values: new object[] { 689.25831802659525, "Incredible Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 857,
                columns: new[] { "cost", "name" },
                values: new object[] { 995.69007466279982, "Fantastic Granite Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 858,
                columns: new[] { "cost", "name" },
                values: new object[] { 317.95588387879309, "Generic Steel Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 859,
                columns: new[] { "cost", "name" },
                values: new object[] { 527.31583330221986, "Rustic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 860,
                columns: new[] { "cost", "name" },
                values: new object[] { 620.34162217793255, "Fantastic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 861,
                columns: new[] { "cost", "name" },
                values: new object[] { 715.27193712672579, "Licensed Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 862,
                columns: new[] { "cost", "name" },
                values: new object[] { 556.12721226716133, "Small Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 863,
                columns: new[] { "cost", "name" },
                values: new object[] { 259.8481289538957, "Tasty Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 864,
                columns: new[] { "cost", "name" },
                values: new object[] { 278.38273625970265, "Refined Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 865,
                columns: new[] { "cost", "name" },
                values: new object[] { 424.5538693431123, "Awesome Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 866,
                columns: new[] { "cost", "name" },
                values: new object[] { 910.78536357966641, "Handcrafted Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 867,
                columns: new[] { "cost", "name" },
                values: new object[] { 976.45691428129737, "Small Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 868,
                columns: new[] { "cost", "name" },
                values: new object[] { 466.12874529552488, "Licensed Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 869,
                columns: new[] { "cost", "name" },
                values: new object[] { 349.62325168248896, "Gorgeous Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 870,
                columns: new[] { "cost", "name" },
                values: new object[] { 484.43520753070686, "Practical Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 871,
                columns: new[] { "cost", "name" },
                values: new object[] { 772.45561652504625, "Generic Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 872,
                columns: new[] { "cost", "name" },
                values: new object[] { 674.68766906254996, "Licensed Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 873,
                columns: new[] { "cost", "name" },
                values: new object[] { 558.96097685506902, "Small Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 874,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.70748572052231, "Intelligent Steel Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 875,
                columns: new[] { "cost", "name" },
                values: new object[] { 277.74850331644069, "Sleek Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 876,
                columns: new[] { "cost", "name" },
                values: new object[] { 941.97393956555777, "Fantastic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 877,
                columns: new[] { "cost", "name" },
                values: new object[] { 133.25808336428949, "Handmade Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 878,
                columns: new[] { "cost", "name" },
                values: new object[] { 848.67090944398865, "Gorgeous Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 879,
                columns: new[] { "cost", "name" },
                values: new object[] { 437.67255178724179, "Rustic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 880,
                columns: new[] { "cost", "name" },
                values: new object[] { 153.53418633522799, "Handcrafted Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 881,
                columns: new[] { "cost", "name" },
                values: new object[] { 369.30956106789461, "Awesome Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 882,
                columns: new[] { "cost", "name" },
                values: new object[] { 622.69387526965943, "Awesome Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 883,
                columns: new[] { "cost", "name" },
                values: new object[] { 808.80025548823608, "Unbranded Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 884,
                columns: new[] { "cost", "name" },
                values: new object[] { 181.37125645107116, "Tasty Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 885,
                columns: new[] { "cost", "name" },
                values: new object[] { 961.12803340407936, "Tasty Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 886,
                columns: new[] { "cost", "name" },
                values: new object[] { 472.7548940822461, "Generic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 887,
                columns: new[] { "cost", "name" },
                values: new object[] { 899.67625460550425, "Refined Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 888,
                columns: new[] { "cost", "name" },
                values: new object[] { 195.5751426435238, "Small Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 889,
                columns: new[] { "cost", "name" },
                values: new object[] { 952.57448617248315, "Unbranded Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 890,
                columns: new[] { "cost", "name" },
                values: new object[] { 126.50460328573791, "Sleek Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 891,
                columns: new[] { "cost", "name" },
                values: new object[] { 997.95656675036366, "Sleek Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 892,
                columns: new[] { "cost", "name" },
                values: new object[] { 927.9404267053128, "Practical Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 893,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.71640692620781, "Gorgeous Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 894,
                columns: new[] { "cost", "name" },
                values: new object[] { 979.51163618094574, "Small Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 895,
                columns: new[] { "cost", "name" },
                values: new object[] { 716.15565991135315, "Rustic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 896,
                columns: new[] { "cost", "name" },
                values: new object[] { 700.04633409624535, "Licensed Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 897,
                columns: new[] { "cost", "name" },
                values: new object[] { 621.72735854687494, "Refined Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 898,
                columns: new[] { "cost", "name" },
                values: new object[] { 184.29097573623008, "Licensed Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 899,
                columns: new[] { "cost", "name" },
                values: new object[] { 345.21050884056973, "Intelligent Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 900,
                columns: new[] { "cost", "name" },
                values: new object[] { 386.3118294030258, "Practical Concrete Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 901,
                columns: new[] { "cost", "name" },
                values: new object[] { 963.74817483350455, "Ergonomic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 902,
                columns: new[] { "cost", "name" },
                values: new object[] { 168.75842788843332, "Sleek Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 903,
                columns: new[] { "cost", "name" },
                values: new object[] { 852.8133960187281, "Tasty Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 904,
                columns: new[] { "cost", "name" },
                values: new object[] { 937.8518311774593, "Small Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 905,
                columns: new[] { "cost", "name" },
                values: new object[] { 726.29122254382764, "Handmade Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 906,
                columns: new[] { "cost", "name" },
                values: new object[] { 558.14112218540856, "Refined Fresh Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 907,
                columns: new[] { "cost", "name" },
                values: new object[] { 394.02275438544223, "Sleek Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 908,
                columns: new[] { "cost", "name" },
                values: new object[] { 476.73429941904874, "Handcrafted Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 909,
                columns: new[] { "cost", "name" },
                values: new object[] { 228.01819051605662, "Unbranded Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 910,
                columns: new[] { "cost", "name" },
                values: new object[] { 901.29349086255229, "Refined Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 911,
                columns: new[] { "cost", "name" },
                values: new object[] { 397.38142232087506, "Small Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 912,
                columns: new[] { "cost", "name" },
                values: new object[] { 617.94495989832387, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 913,
                columns: new[] { "cost", "name" },
                values: new object[] { 699.83546465621089, "Awesome Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 914,
                columns: new[] { "cost", "name" },
                values: new object[] { 289.64283303315807, "Tasty Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 915,
                columns: new[] { "cost", "name" },
                values: new object[] { 985.91712419182409, "Generic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 916,
                columns: new[] { "cost", "name" },
                values: new object[] { 62.45450620325466, "Fantastic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 917,
                columns: new[] { "cost", "name" },
                values: new object[] { 55.872056165663579, "Gorgeous Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 918,
                columns: new[] { "cost", "name" },
                values: new object[] { 115.09791022724241, "Unbranded Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 919,
                columns: new[] { "cost", "name" },
                values: new object[] { 611.98066888504945, "Sleek Rubber Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 920,
                columns: new[] { "cost", "name" },
                values: new object[] { 937.58323686217318, "Small Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 921,
                columns: new[] { "cost", "name" },
                values: new object[] { 722.48370852184382, "Small Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 922,
                columns: new[] { "cost", "name" },
                values: new object[] { 276.10563274886783, "Awesome Granite Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 923,
                columns: new[] { "cost", "name" },
                values: new object[] { 731.96656247808255, "Intelligent Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 924,
                columns: new[] { "cost", "name" },
                values: new object[] { 724.15466718651123, "Tasty Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 925,
                columns: new[] { "cost", "name" },
                values: new object[] { 61.820582283759187, "Sleek Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 926,
                columns: new[] { "cost", "name" },
                values: new object[] { 105.84755853736688, "Rustic Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 927,
                columns: new[] { "cost", "name" },
                values: new object[] { 301.07393327545805, "Rustic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 928,
                columns: new[] { "cost", "name" },
                values: new object[] { 950.75017195270834, "Tasty Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 929,
                columns: new[] { "cost", "name" },
                values: new object[] { 70.095982387939173, "Refined Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 930,
                columns: new[] { "cost", "name" },
                values: new object[] { 244.68476010786054, "Ergonomic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 931,
                columns: new[] { "cost", "name" },
                values: new object[] { 233.24399482239573, "Sleek Metal Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 932,
                columns: new[] { "cost", "name" },
                values: new object[] { 853.29655428260628, "Small Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 933,
                columns: new[] { "cost", "name" },
                values: new object[] { 579.6510764021042, "Refined Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 934,
                columns: new[] { "cost", "name" },
                values: new object[] { 915.9113609732533, "Gorgeous Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 935,
                columns: new[] { "cost", "name" },
                values: new object[] { 798.97944093597982, "Incredible Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 936,
                columns: new[] { "cost", "name" },
                values: new object[] { 774.03552080802797, "Handmade Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 937,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.61714993179092, "Tasty Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 938,
                columns: new[] { "cost", "name" },
                values: new object[] { 471.34586690361044, "Ergonomic Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 939,
                columns: new[] { "cost", "name" },
                values: new object[] { 88.505799703794949, "Handcrafted Metal Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 940,
                columns: new[] { "cost", "name" },
                values: new object[] { 794.55102624544088, "Gorgeous Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 941,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.69684160846509, "Unbranded Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 942,
                columns: new[] { "cost", "name" },
                values: new object[] { 607.48493962963289, "Practical Steel Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 943,
                columns: new[] { "cost", "name" },
                values: new object[] { 269.23701420694988, "Handmade Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 944,
                columns: new[] { "cost", "name" },
                values: new object[] { 434.07664668094725, "Awesome Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 945,
                columns: new[] { "cost", "name" },
                values: new object[] { 663.04334041616357, "Fantastic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 946,
                columns: new[] { "cost", "name" },
                values: new object[] { 258.08420776415738, "Fantastic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 947,
                columns: new[] { "cost", "name" },
                values: new object[] { 791.11965530394218, "Incredible Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 948,
                columns: new[] { "cost", "name" },
                values: new object[] { 778.47226215765897, "Generic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 949,
                columns: new[] { "cost", "name" },
                values: new object[] { 219.17254639209241, "Practical Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 950,
                columns: new[] { "cost", "name" },
                values: new object[] { 426.29801796031234, "Tasty Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 951,
                columns: new[] { "cost", "name" },
                values: new object[] { 313.6888105387597, "Ergonomic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 952,
                columns: new[] { "cost", "name" },
                values: new object[] { 569.96504433121083, "Practical Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 953,
                columns: new[] { "cost", "name" },
                values: new object[] { 260.71520876759496, "Tasty Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 954,
                columns: new[] { "cost", "name" },
                values: new object[] { 399.82588006685546, "Ergonomic Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 955,
                columns: new[] { "cost", "name" },
                values: new object[] { 360.17623557654059, "Generic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 956,
                columns: new[] { "cost", "name" },
                values: new object[] { 691.34966588783823, "Handcrafted Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 957,
                columns: new[] { "cost", "name" },
                values: new object[] { 997.02409664251195, "Rustic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 958,
                columns: new[] { "cost", "name" },
                values: new object[] { 220.07720085085037, "Unbranded Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 959,
                columns: new[] { "cost", "name" },
                values: new object[] { 894.70741054990333, "Awesome Steel Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 960,
                columns: new[] { "cost", "name" },
                values: new object[] { 610.40139906530339, "Fantastic Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 961,
                columns: new[] { "cost", "name" },
                values: new object[] { 143.70426319625659, "Gorgeous Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 962,
                columns: new[] { "cost", "name" },
                values: new object[] { 670.72092012935229, "Small Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 963,
                columns: new[] { "cost", "name" },
                values: new object[] { 502.81582368092086, "Handcrafted Soft Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 964,
                columns: new[] { "cost", "name" },
                values: new object[] { 416.07980211292761, "Ergonomic Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 965,
                columns: new[] { "cost", "name" },
                values: new object[] { 925.3045858463372, "Rustic Soft Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 966,
                columns: new[] { "cost", "name" },
                values: new object[] { 192.63967580713154, "Licensed Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 967,
                columns: new[] { "cost", "name" },
                values: new object[] { 57.507487553545616, "Ergonomic Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 968,
                columns: new[] { "cost", "name" },
                values: new object[] { 900.16085648366561, "Tasty Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 969,
                columns: new[] { "cost", "name" },
                values: new object[] { 58.364034660018341, "Handmade Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 970,
                columns: new[] { "cost", "name" },
                values: new object[] { 790.2031343167871, "Sleek Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 971,
                columns: new[] { "cost", "name" },
                values: new object[] { 218.95752980945716, "Awesome Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 972,
                columns: new[] { "cost", "name" },
                values: new object[] { 367.89008571841993, "Incredible Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 973,
                columns: new[] { "cost", "name" },
                values: new object[] { 541.97011364796663, "Unbranded Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 974,
                columns: new[] { "cost", "name" },
                values: new object[] { 623.08498404707802, "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 975,
                columns: new[] { "cost", "name" },
                values: new object[] { 349.53784464092968, "Tasty Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 976,
                columns: new[] { "cost", "name" },
                values: new object[] { 717.63324281134339, "Refined Steel Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 977,
                columns: new[] { "cost", "name" },
                values: new object[] { 279.94451325740135, "Practical Granite Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 978,
                columns: new[] { "cost", "name" },
                values: new object[] { 537.09592858841586, "Intelligent Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 979,
                columns: new[] { "cost", "name" },
                values: new object[] { 930.11851098657917, "Rustic Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 980,
                columns: new[] { "cost", "name" },
                values: new object[] { 940.11691958154438, "Practical Metal Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 981,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.23872825646583, "Ergonomic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 982,
                columns: new[] { "cost", "name" },
                values: new object[] { 69.750491862126452, "Rustic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 983,
                columns: new[] { "cost", "name" },
                values: new object[] { 890.9578350362932, "Sleek Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 984,
                columns: new[] { "cost", "name" },
                values: new object[] { 131.3329121497373, "Practical Cotton Car" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 985,
                columns: new[] { "cost", "name" },
                values: new object[] { 969.49691927840297, "Refined Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 986,
                columns: new[] { "cost", "name" },
                values: new object[] { 863.02682104864789, "Unbranded Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 987,
                columns: new[] { "cost", "name" },
                values: new object[] { 334.57987037677094, "Tasty Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 988,
                columns: new[] { "cost", "name" },
                values: new object[] { 797.08457656623091, "Tasty Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 989,
                columns: new[] { "cost", "name" },
                values: new object[] { 155.98325693014866, "Awesome Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 990,
                columns: new[] { "cost", "name" },
                values: new object[] { 6.9714340049214476, "Practical Soft Bike" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 991,
                columns: new[] { "cost", "name" },
                values: new object[] { 758.44392624266243, "Intelligent Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 992,
                columns: new[] { "cost", "name" },
                values: new object[] { 882.53251107228368, "Small Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 993,
                columns: new[] { "cost", "name" },
                values: new object[] { 995.04716555819004, "Awesome Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 994,
                columns: new[] { "cost", "name" },
                values: new object[] { 928.12202383172257, "Gorgeous Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 995,
                columns: new[] { "cost", "name" },
                values: new object[] { 139.49649256360618, "Handcrafted Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 996,
                columns: new[] { "cost", "name" },
                values: new object[] { 447.56016394773707, "Incredible Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 997,
                columns: new[] { "cost", "name" },
                values: new object[] { 499.67404280012335, "Licensed Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 998,
                columns: new[] { "cost", "name" },
                values: new object[] { 968.60885897189758, "Generic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 999,
                columns: new[] { "cost", "name" },
                values: new object[] { 30.778729239018247, "Gorgeous Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "id",
                keyValue: 1000,
                columns: new[] { "cost", "name" },
                values: new object[] { 850.80467150337165, "Gorgeous Fresh Bike" });
        }
    }
}
