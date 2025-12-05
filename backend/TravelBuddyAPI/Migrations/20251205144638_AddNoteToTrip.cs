using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNoteToTrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") });

            migrationBuilder.DeleteData(
                table: "ConditionProfilePlaceCondition",
                keyColumns: new[] { "ConditionProfileId", "PlaceConditionId" },
                keyValues: new object[] { new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") });

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0126b355-6f1d-4d65-baa4-df9f725656d7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0168dfdd-b23f-474f-9bcf-a435ddba8cb9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01c5086c-1e1d-4804-9b0b-ae9b18ad8807"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("01ce27ed-3189-42ef-816c-e64b963f2fa0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("02ef024c-503c-4ac2-8b9e-f4622e38c7f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("046b33d9-8b9c-4ef1-8e76-02232bceb9d5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("055e9136-7904-4b2f-9f2c-e9fc0b65a094"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("065c53eb-a19f-46cd-b0fb-7e165b17b64d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("07fd6909-b4e5-4fb1-b307-d7fe7141e8a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08cc3914-f217-47b0-9a60-848f002837c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("08cf52df-3bf6-499b-96b5-54f4d8d8e2f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b13c9c2-d128-44f8-9186-f6a9de63318e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ba72609-b79f-44e4-8380-26c041a93053"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c2b9ca9-59b7-4502-a6d8-ca12d88946d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c37c56a-7eab-41d5-97cb-393558c6654d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cf3fa9d-cf26-4cb2-a77c-5c250ca16d7a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f4534ff-4f24-4f7d-8474-6f686a4b77e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1056f1f8-8cf2-4523-8553-28e631d52fec"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("116c209a-c3e2-4f55-bc8a-39b2f70ebc03"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("117503b7-014f-4c85-950e-68140b86a670"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("11f382c1-9019-43ca-a323-40ffcb4846f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12ad7960-6fd4-47b6-8b40-d4d3e0130a5f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13bfd3dc-abb6-4f9e-9df1-622be15faa64"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("15af10de-7037-409e-9970-94f0a77377cb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("16cad34c-5dce-4710-819a-530da999b184"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17c05f8b-ce87-40bb-bf5c-d254a67c8558"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17f85471-d607-4fdb-ae84-5076dc9f32bd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("18e97a14-3ca6-430a-adee-395a9bb0a157"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a55c164-2126-4bfc-99a7-32905023c89e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b995dc2-5f5f-4d95-baec-c36b638bc2a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1c44a946-013f-4153-ae11-10d144010b53"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d2725bd-c96a-4a10-917c-0dc8af9e4768"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1dcaa3a5-fa93-4fef-af39-3a8ae634efd0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20edc26f-539b-430c-a5f8-e74a4c152655"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20f717e2-d40b-48d5-8cd7-8723779955c1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("25451861-2605-43b8-a19e-8335ca4e013f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("26a70dbb-9fe6-4c31-88aa-9c9175a64c36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28184ebf-d6b3-4c24-a0a4-cceafb897086"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("28d9bfb8-cc35-4529-9335-f215d4c9199f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2edb7842-63c3-47b2-a134-2e36078c45ad"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("321ab057-22a7-47fc-ac72-8464c2c8d96b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("36f50eca-a3cc-4f23-a4f4-b457f6e2f705"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38590d77-ae64-447f-82ad-4e497c23afc3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38aaae4c-c1f9-43fd-b695-908ace5fc2bd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38ab4808-e9b4-475b-8f4f-efb5b307ceea"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c422a5d-31be-4803-a24f-c4beea2638ba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d984a1c-2297-4bc9-96c8-aedcca0939ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3dbad5e2-f915-4a4d-98b0-b688edc3ec20"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4025efcf-7415-48c4-bb5c-f6225fc3e12d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("419eced0-4518-4220-90f3-6863accf4f9e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41ae3a96-7efd-4789-846d-28527d28977e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4363b2af-5f65-42ca-931a-4a5050d7491c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("46cd0446-ab4a-40c5-9318-b7232adeda52"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a1a601c-b676-4426-8484-55eed89b78f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a280d10-e352-4d8b-9bc5-43feb1b4fe72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a77bc45-b094-4ad0-b6c4-41c15b44b600"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4acf6e56-4121-4371-a799-6a910119cfd1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b2c8d4f-1c96-44e6-950c-e2cdb2a2f71f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cf4196d-43d4-443b-a3e9-c9005d2d80a8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4df95354-121a-4f30-9947-271c60f6de30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e565498-7b82-4a9f-aad8-2c1e0bc8d9b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50ec1d4e-8ce7-41ae-af51-b0a803ab3a36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("51ad71a3-f27c-42fa-82dc-7c35a4acb920"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("55367cdc-ed3f-4a79-bcff-a990ac590ddd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("56225a55-c6dd-47c8-a6bf-01e74e200cf2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5bc4a1ed-c117-454c-856c-ea26dab74428"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c1c5e8f-6d5f-4ca2-bd1c-087ea29cf38d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c80b244-7229-47a5-86ad-da2f2da61963"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5cbcc5d1-d7c1-4b94-8516-ba7d0df77e95"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e2029dd-e171-484c-87e1-02ca1c13d2fa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fea80b5-0d90-4eb2-b830-b9ca8fe6d4ab"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("616842da-f458-4b93-bbd4-a024bb018a30"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62b78d55-5d36-4eb7-a9ad-8d10e53fd765"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("62bf80f5-f610-4489-b62e-99422475a86c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63de6e24-42c9-48e3-b14e-1e95b6f60f49"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("664eed32-ce6f-4325-b65e-ed037cfb5fe2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("67117fa3-d333-40c5-9257-e36853ec8f18"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("676c4e49-cf10-4544-845f-ae7179961166"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6779f792-ac5d-48d0-87b6-430f8ae52193"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("691f025a-ea50-4c1f-801e-5822622248f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69282965-78a1-4163-a28a-7c330b688c34"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69f51b64-8e50-4f68-ae19-f8bbbc33aef0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b5d23f5-6b6a-4e19-8763-ebcca7bd04f8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d07bbbd-9e1a-4534-a65b-b2da9404988c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e4e3ffc-3cb6-425e-9017-73464e85dcb2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f69cea0-38c1-4b94-af21-b5b6d2e38096"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6fa0f10e-64c1-47c1-98e6-c06b8d75c45c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("702a29fb-72fb-498c-8e0e-3ec05bf5381a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("71aa1f04-b071-439b-bd64-9463eb02ca6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("72dd952e-756c-4db0-a522-f38a3c7844d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73cac96d-76ad-4228-9d6e-456b898fc47e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("74ed3423-a4c4-4b63-a1d0-2acc15c2689b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("772cf39f-b185-48f4-8809-b1854e429a6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("777f4839-4e56-46ad-b4dd-87516a61e9e2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7aa1a097-be64-484b-a280-b64e87c6c22d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ba18aba-c3fb-4f85-aefb-1ad064bc8322"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7bae482d-d487-4f6d-b1a6-af6a8b6eb1be"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7cd67dbd-211f-45af-842c-517fb143d427"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e57978a-2a11-4416-aa2e-2fecc617bacf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e9e5b63-d9c6-4a36-bfcb-7a7247f4477f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("824a9051-cb95-46d5-8995-5420a6af3fae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82e4b38b-ac1c-478a-9cbd-bb99a216088a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83883b63-d6e9-4f31-b9ac-1616e99e0060"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83d6c6be-0525-4dba-a607-927ed8f52d47"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("851873d1-0a04-4b5a-8f37-2f7ee2b42577"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("85e46b8c-a538-4eb6-b1af-b68fa4c777c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("860501f2-bbaf-4eaf-b567-45230f5a854b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8ab7915a-765b-452b-88ac-759e3e4dbd40"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b77d44e-2e2d-4d86-8a27-f6cb5311c53c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8cfde417-44e2-443a-af48-ac4384693d29"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8df7ecc4-0f73-49d0-a042-3a9a6473998b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f04736b-88dd-4f29-8fdf-969061551261"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("920d9df6-eeb1-45b7-93c3-6f551e96f781"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("95212037-5b17-44db-b428-faac48a381c9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9863d8b1-d870-427a-ae43-53f8e4f8d25e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("99ff2070-d0d5-45d4-b1ab-5844ed17fbf1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a31b172-a604-4385-9f4b-0456f78fce45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b0ae92e-f413-4307-8469-4ae39763a68d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b5a3108-da70-49f8-8583-d658ab9f480e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c8295ec-3c6f-4f0c-a90e-04a7246f6b2a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e08208a-62a5-48d2-831e-0a648b21ba51"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fed8c4a-a02d-49e5-a0bf-7cebd7689221"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a14d0b28-a448-414d-acfc-7037c12906c6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a27e3c60-a9b7-4063-b9fa-cbd891d89861"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2d83129-d2c3-4a30-a73e-ae1495776a56"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2fa84cc-b2e9-40da-9ecd-110717b4433b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3048f41-31c5-4f9f-9ebe-113ea6a92251"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a65bf379-0463-4cfb-8ee4-3a416fce3227"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8ab258d-2ed1-4549-8252-f5d095e8a25f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9ef90cd-d224-4016-a884-38f3241b47e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac954a86-9eb7-4ad1-92e5-f721838a6e4a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad1354ce-cf5f-409b-8e11-8e559e862546"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae2b912a-1d1d-4965-9c77-8791a402532a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b1c2b6ee-4236-4f66-bb97-cafe9f9d7bac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3756827-83aa-4861-a456-2325966c1893"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b3c350f0-fe62-44b4-a956-228b24141d8f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b420764f-a6d8-4400-8228-fe33ce4a2b6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b9cd7bb4-7760-4c57-bbf6-5b7f33dfee2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbda8310-c9a6-4a0e-a44b-93aad421895e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd9f78a2-7d71-43ca-ab8d-2c58f3cdc051"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf39d4b4-76be-4344-aba5-403bfad4fe83"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf4b9bb2-a715-47a6-9411-a1a64fded83a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0e1751b-701d-45d3-a8d7-a3cf86dd4149"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c25db3ee-36fc-4753-8118-adf025dc545e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c35b7c22-2e96-4960-970a-7a1c95072b50"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3d6b494-e243-4d05-823c-a6e72a0e3928"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c45b3112-885e-4536-bec5-26c55eb85589"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cef013f5-8cf0-4812-8b8b-dd89f1a5b26a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d27ae70c-9ee5-4e1b-9bfc-6f8b48d2a595"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d3ffbaa8-175e-44b5-9660-50263497edcc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4194cd1-2b90-4336-93d7-47a2117845ce"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8866c2a-8e3f-4674-9a45-e7c4ffe5e821"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d9b805f8-82a3-4cc3-b09e-743c75da6b53"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da2a75c1-f704-470b-a7e3-e2e83a5715d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e047a8ae-b475-49f6-a1d3-0f3744fc1cba"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0b5dac3-3109-4e6c-8e99-a286343f95c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e2fa4130-1244-4a2b-99af-0a4a55353a3b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3bcd580-f240-4114-9665-d3d8c6ceb391"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e740971c-54c7-474e-97ef-042891bbe916"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e76af9b6-2612-42ac-9b12-fbb40278db22"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7a4045a-44e7-4502-87b9-da4111f116dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e99d71b0-5e47-4b97-85d2-88b29e7ad9f4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecb4aa2e-f6b0-48ee-8f01-62c2a35b7a25"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("edae1a3a-7fb1-4786-9400-09fde31d49c4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee3371ed-5ac0-47ab-8e0f-9f8104d0ee9a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("efeb3f4d-2c29-4251-a4c8-a5c7aa0a28f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f204e07d-57c6-42cf-bf0e-8c3cb459f6d0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4f2d192-f326-47d8-85f5-b1fc47016f3e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f621a46b-5df6-4179-9303-3ced690aa344"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8d4b314-3bdc-46f1-9ac7-09b68a9daa2d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f94992cd-8c9c-4da3-bbd0-aef3d12049ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9f46c35-c17f-48e2-a3b8-ecff8172daf5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa7fff4a-41e7-4049-a4ce-760a9bfa7e45"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb6d1113-680d-41ba-a449-f09ac7c8e94f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fbaf9948-24e0-4685-b313-60d1e57740f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd80e5df-397b-4b09-ae23-4f3af5306403"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd869253-419d-4195-bed8-2e90c0eff5b8"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1ce23c66-1b40-4f22-b02f-6609aa59d24d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2252e854-7c22-41d8-85ca-859d2a716b54"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3837d52a-adb1-4c86-ab1c-3ad79dd19c86"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("41db4974-d535-4d5c-8733-09ddea0c34cb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4b8f3174-fc4e-4896-8b7d-3783319e027b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("61dffa8a-3270-486a-b628-2392a41b27c5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("65c4d2b2-e6a7-4c66-8249-94d8f7463539"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("822a74ae-7e39-4bb8-8cd2-39fc729e59ad"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8bb82328-5dbf-414e-bcdc-c22aeefca54c"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c1db5cb5-25ef-4286-bc20-b602eeb18b6b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c73a511c-fca8-40f0-b39b-021d0440cafb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3ad5bdd-0ec0-47f1-9530-341f255cb427"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d3f9041e-420f-4ee1-a267-837b8baeb63f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d5629a3f-e5ac-4687-967e-ad3ad69787df"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d88cdd99-2402-4ba4-a1f4-b05f9a75d1b5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ed1ab986-6da8-4a11-a229-107baf578281"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("edad88d7-3158-4ad5-9cc8-f01304b5ed06"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f1e67864-3da2-4172-b4dd-7d57bc0083d6"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("89d19266-7810-46ba-bcae-fd029692046e"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e80583c1-fb35-492f-828a-45441253fc43"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("09cb0b5d-3b36-4f28-bc20-26a1d9561205"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("33471b65-36ef-4e45-b65e-0b82cc328232"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("416d95a7-d16b-41c7-a918-a56bd96ba51c"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("679ee69f-3983-4352-a317-29ff898de647"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("b6c0088e-83eb-4ec3-bd2c-e94cd1175662"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("b8829d9f-b889-4c3b-86bd-82cd9d53d9c2"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c57269bb-fd4e-4ea7-93f1-b8cf99d0d419"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c72e1fde-4425-40ca-a465-892650635787"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("de2538d8-bb9b-4e71-96f8-d624510527c5"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("e8d7055f-08bc-42d7-b6e2-bc3768f6cc2f"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("f07bfe27-358f-4189-a251-9f9f6113499e"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("f26cac79-8bbf-4867-a60c-1c72fea085bc"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("9cc42d97-9d65-43ee-8ec8-df1ebf2aab6a"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("00a97dea-1347-44a7-acf2-16e8956d43d2"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("193b8039-c7a4-48de-a3a3-a0d2351a3654"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("2054631d-b31c-4038-ba13-0e2f231a29c4"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("28a809c3-2991-476b-965b-541c9cd80c27"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("2bef4837-2fe9-4937-bb96-e13007a35a74"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("30babcf1-0e4c-4e80-a0a8-e9bf3c3fd211"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("30f9b4a8-3829-46fa-980e-9860e3aa6022"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("3a50037a-02ba-4ad1-8a48-66e499e6c729"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("400db1c9-1a82-4447-b610-a53b83b34bcb"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("40cb2e38-bb8d-46f2-98b6-4f1c74dcdb48"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("49090605-1fa0-45d9-9a11-472bd5482619"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("6180b39d-9a99-4546-81fe-c393efbb30eb"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("80f18f18-b4b5-4b91-919e-c77ea3b117a9"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("9978502b-a95d-4a61-af6e-122b0a1f7aff"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("afe43f25-0e27-442f-a357-35279fdad74c"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("b94c6142-70d9-4dff-96cc-6da6f6c2c5a5"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c5e43721-9435-4bc7-9ca6-ab0bd1d194c8"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c7ca1758-6264-40b6-9b61-58f0cf86ebc2"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c8997bd5-e449-4d01-96e0-758eae15aa28"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("d069a5c7-3f6c-48dd-8a7f-fb7538a157ba"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("d723542b-2c5a-4a60-9dcf-0fbdac053fa6"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("f4559608-4d94-4790-bd6f-281a38a91461"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("1b70c4cf-4bf6-4508-8011-75370c0f786a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("783f44f9-d17d-4a30-83c4-587474792929"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("195c2f29-6a95-4da5-8637-f05892583cb0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("68b0c129-7b2a-49d0-9aeb-c6f7d7daf73a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("89d19266-7810-46ba-bcae-fd029692046e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("af0d7109-d550-4537-8b51-affb642297b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("af8af887-2e25-4edf-86ca-c54430573908"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e80583c1-fb35-492f-828a-45441253fc43"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("054c1e5d-2f56-4fb2-8617-310e9ff3855b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2651ead4-0c97-4141-b622-39fb1b8cce8e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("30788876-73cf-4fed-98b4-dc4e83bcb2b5"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4b449869-57d0-4fe4-9f2b-676402d89967"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("64738042-1334-4889-b98f-09e6e4f257db"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7875ec0e-799f-4abf-b519-70656bc18167"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("937b2203-3282-4abf-b885-8ce74231d594"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b0011601-c240-4508-8cec-e6a35bf0e863"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("de1385b2-ffee-4562-b818-759a4ecf6250"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("07989400-6725-4976-a1ec-77ca23b74255"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1c6cc576-778a-4808-954c-c046472c7036"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("1e70f971-a497-42c8-a563-23a68447418e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("f282d667-d800-4009-9e50-8e8f3cf67113"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("021389c6-d6d4-4b8a-a275-3d1d04292e97"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("25dc4853-cf52-437a-9b99-f8b0cce72d72"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("4da954c1-f554-4de5-bb03-7aac1a334fb6"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("53aaf231-b2d0-40ef-a78b-a82543a5bc11"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("568ec6c8-0084-4f45-a5fd-0070cee6c48e"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e379fa4d-3419-45de-85d3-bfcb6ca62145"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e8d519bb-e0e4-4ece-bfe9-c0bc148183e5"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("44609932-1913-412e-9682-ee17fab551a1"));

            migrationBuilder.DeleteData(
                table: "CategoryProfiles",
                keyColumn: "Id",
                keyValue: new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"));

            migrationBuilder.DeleteData(
                table: "ConditionProfiles",
                keyColumn: "Id",
                keyValue: new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("511b1c02-92a9-4157-8760-35b25407b752"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("076737d2-16b9-489c-b157-39f97aba1af2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("09afec0e-1382-4578-8ffd-000971cbbc19"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("32a817b9-6d03-4311-807b-d3d993feaca5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("977c8178-9039-47ff-ad5b-98373b292abc"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("9a0ddf04-1fc7-40a0-99d2-a52ea24c3edb"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("aea1d075-f00d-4966-bb07-09cc2f5ddd4a"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("be0b4d83-d85d-4ab5-bec0-d0c912a71e18"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("da044dbf-0f05-493d-a498-27156beeca18"));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CategoryProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "ConditionProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("87e81585-21b0-4d0f-a3e3-eae1cd312936"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("17536513-cf01-4222-b6ca-4e94c15d1ddd"), null, "other", null },
                    { new Guid("1bcc3c4e-ea11-470f-84f4-87e413663aee"), null, "sport", null },
                    { new Guid("4fecff68-43ec-4568-ba42-615341c243ae"), null, "natural", null },
                    { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), null, "entertainment", null },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), null, "tourism", null },
                    { new Guid("6b62950f-cac4-41c6-b20b-78c2196a3eb9"), null, "commercial", null },
                    { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), null, "heritage", null },
                    { new Guid("795e6870-250b-44c7-b124-cc3bdb37bb33"), null, "national_park", null },
                    { new Guid("7de161a9-2a13-4533-a2c1-d19d9c77ef6d"), null, "leisure", null },
                    { new Guid("9286cbbd-ee6c-465e-b9c1-55894acfe09a"), null, "activity", null },
                    { new Guid("a4e65971-fc09-4ad0-806b-bbccf10ca121"), null, "religion", null },
                    { new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed"), null, "catering", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("051006a6-91d3-4656-8c1c-f61b343055e0"), null, "internet_access", null },
                    { new Guid("0d653e96-aab2-4790-ad55-fbb2199f5db9"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("17c58dc3-df5f-4881-8795-4f1aa4376030"), "Name property defined for the place", "named", null },
                    { new Guid("1d82fa0c-8e9c-4d8f-9e2f-da0822c0e79b"), null, "no_dogs", null },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), null, "wheelchair", null },
                    { new Guid("311c046a-8a85-484e-84fc-85210fdc07a3"), null, "dogs", null },
                    { new Guid("323d7282-c2dc-4df9-87cd-f48400082749"), null, "access_limited", null },
                    { new Guid("4a9ae4ac-c257-42a5-b6ce-a747db359f39"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("6482dc7f-43f1-4e5c-a16c-26e23893e4dc"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("8354792d-1bac-4cc9-b363-199f4fa90cbb"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("9774a53a-9eb2-45de-a0e7-495484097f6b"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("9876f981-1891-494b-815d-40d28a5b8f04"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("b566e6ec-87ee-4b44-b14b-d9a56045da0d"), null, "access", null },
                    { new Guid("d22fc313-353b-4eca-9117-955ac920a8ca"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("de8c6a1e-3f59-4ed7-a8fd-44567076130e"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), null, "fee", null },
                    { new Guid("f294cc06-6a3d-4a25-be9a-368b74642b7a"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("fd93d17a-26d7-4071-ac68-73583be3354b"), "Places where you can buy or eat vegan food", "vegan", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("0d1f5704-d246-4410-bcf1-846d109f8822"), "Wrocław", "Poland", null, 51.10897760m, 17.03266890m, "Wrocław", null, "ProviderPlace", "51dfc081e697fa30405906310a6025904940f00101f901bce3060000000000c0020992030857726f63c5826177", "Lower Silesian Voivodeship", null },
                    { new Guid("5a31a5a7-1905-487c-89f2-193d81a86b3c"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c"), "Wrocław", "Poland", "1-5", 51.10425535m, 17.07484842m, "ZOO Wrocław", "Mar: Mo-Su 09:00-16:00; Apr-Sep: Mo-Fr 09:00-17:00; Apr-Sep: Sa,Su,PH 09:00-18:00; Oct: Mo-Su 09:00-16:00; Nov-Feb: Mo-Su 09:00-15:00", "ProviderPlace", "513a952f4429133140591ab1413d588d4940f00102f901012324020000000092030c5a4f4f2057726f63c5826177", "Lower Silesian Voivodeship", "Zygmunta Wróblewskiego" },
                    { new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419"), "Wrocław", "Poland", null, 51.10864425m, 17.07875630m, "Wrocławska Fontanna", "May-Oct: 00:00-24:00; Nov-Apr: Off", "ProviderPlace", "51299d5f5f291431405946ac040ee88d4940f00102f901e25aa7020000000092031457726f63c5826177736b6120466f6e74616e6e61", "Lower Silesian Voivodeship", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("6df0caf7-a54a-4371-916f-3dd4daa47d7d"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("8b04966c-1ccb-4860-8600-f3dc66981583"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null },
                    { new Guid("8e49a300-7a0b-4801-a35d-7ff185be656f"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null },
                    { new Guid("92dff543-3914-42d9-9a5b-8cdd8142c5a2"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2"), "Wrocław", "Poland", null, 51.10432090m, 17.03133350m, "Bolesław Chrobry", "24/7", "ProviderPlace", "51eac4e5780508314059b43e21635a8d4940f00103f901ace8111000000000920311426f6c6573c5826177204368726f627279", "Lower Silesian Voivodeship", null },
                    { new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" },
                    { new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b"), "Wrocław", "Poland", "1", 51.10688750m, 17.07731849m, "Hala Stulecia", "Su-Th 09:00-18:00; Fr-Sa 09:00-19:00", "ProviderPlace", "5159f5f324cb1331405964c6547dae8d4940f00102f90136e6691c0000000092030d48616c61205374756c65636961", "Lower Silesian Voivodeship", "Wystawowa" },
                    { new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb"), "Wrocław", "Poland", null, 51.10994465m, 17.07986499m, "Ogród Japoński", "Apr-Oct: Mo-Su,PH 09:00-19:00", "ProviderPlace", "51d8ce250872143140598b6890aa128e4940f00102f9014c34de0f000000009203104f6772c3b364204a61706fc584736b69", "Lower Silesian Voivodeship", "aleja Dąbska" },
                    { new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0"), "Wrocław", "Poland", null, 51.10248345m, 17.08599881m, "Kościół Najświętszej Maryi Panny Matki Pocieszenia", null, "ProviderPlace", "51324592040416314059a36a7b2d1e8d4940f00102f9010d300706000000009203374b6fc59b6369c3b3c582204e616ac59b7769c49974737a656a204d617279692050616e6e79204d61746b6920506f636965737a656e6961", "Lower Silesian Voivodeship", "Edwarda Wittiga" },
                    { new Guid("c64a35ed-5365-4a43-a478-d6e57e913011"), "Wrocław", "Poland", "35", 51.10744710m, 17.02887780m, "Muzeum Historyczne i Muzeum Sztuki Medalierskiej", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "51979416896407314059ca9f98d3c08d4940f00103f9010992932b020000009203304d757a65756d20486973746f7279637a6e652069204d757a65756d20537a74756b69204d6564616c696572736b69656a", "Lower Silesian Voivodeship", "Kazimierza Wielkiego" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("d138987b-de42-4ed2-9115-84ef37581ba1"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0"), "Wrocław", "Poland", null, 51.10957585m, 17.03206577m, "Ratusz", "We-Sa 10:00-17:00; Su 10:00-18:00", "ProviderPlace", "51b849627635083140596870d894068e4940f00102f90138ce3f330000000092030652617475737a", "Lower Silesian Voivodeship", "Rynek Ratusz" },
                    { new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983"), "Wrocław", "Poland", "9", 51.11288660m, 17.02688220m, "Muzeum Archeologiczne", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "5133d879c0e106314059f2ec6d11738e4940f00103f901710a264c000000009203154d757a65756d2041726368656f6c6f6769637a6e65", "Lower Silesian Voivodeship", "Antoniego Cieszyńskiego" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("f6689b7d-319f-48de-81ef-e0bdb8b0d65f"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "CategoryProfilePlaceCategory",
                columns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                values: new object[,]
                {
                    { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("4fecff68-43ec-4568-ba42-615341c243ae") },
                    { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") },
                    { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2") }
                });

            migrationBuilder.InsertData(
                table: "ConditionProfilePlaceCondition",
                columns: new[] { "ConditionProfileId", "PlaceConditionId" },
                values: new object[] { new Guid("87e81585-21b0-4d0f-a3e3-eae1cd312936"), new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823") });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("084d7285-f83a-4744-ab6e-bec594234c93"), null, "art", new Guid("6b62950f-cac4-41c6-b20b-78c2196a3eb9") },
                    { new Guid("146783ae-6deb-4041-bea6-663456595042"), null, "aquarium", new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") },
                    { new Guid("1674e06b-019c-479f-9ea1-89e82e42cb31"), null, "park", new Guid("7de161a9-2a13-4533-a2c1-d19d9c77ef6d") },
                    { new Guid("2021b739-d41a-43be-90e7-b4a057bf2798"), null, "water", new Guid("4fecff68-43ec-4568-ba42-615341c243ae") },
                    { new Guid("2b9f0ed7-44d9-41e6-a6c7-46506887e163"), null, "forest", new Guid("4fecff68-43ec-4568-ba42-615341c243ae") },
                    { new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf"), null, "fast_food", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("58ff3ce0-476b-4d03-9f83-6d17d681d805"), null, "biergarten", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac"), null, "restaurant", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("61e800b0-f6fa-4223-be18-41a37e9444a9"), null, "museum", new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") },
                    { new Guid("6a4f515e-7aa6-4d28-b1dc-3f6cd187b040"), null, "unesco", new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f") },
                    { new Guid("7a0be33f-777b-4985-8cb0-56e3c17edacb"), null, "planetarium", new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") },
                    { new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc"), null, "mountain", new Guid("4fecff68-43ec-4568-ba42-615341c243ae") },
                    { new Guid("864c464f-3c90-42f3-83b3-31abec960f04"), null, "sand", new Guid("4fecff68-43ec-4568-ba42-615341c243ae") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), null, "sights", new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2") },
                    { new Guid("9297b67f-5cf9-4a41-9b33-d09457b54835"), null, "ice_cream", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("a3593ad6-7b47-44bd-8121-ddc228553ebc"), null, "pub", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c"), null, "place_of_worship", new Guid("a4e65971-fc09-4ad0-806b-bbccf10ca121") },
                    { new Guid("d1b830dc-68db-41f6-a299-441fbf8d1533"), null, "zoo", new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") },
                    { new Guid("da48e1d2-1f18-4310-8e5b-d35165e053a5"), null, "stadium", new Guid("1bcc3c4e-ea11-470f-84f4-87e413663aee") },
                    { new Guid("dad1066f-9795-4a00-a3df-255753f3d481"), null, "cafe", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("df1cc19b-4691-457f-9b02-e396fcfa8231"), null, "culture", new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") },
                    { new Guid("e9330620-9a08-4f41-b6b0-f8cd7684b21b"), null, "bar", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("e96d8e3c-455d-4944-ae45-31db51b0a596"), null, "gift_and_souvenir", new Guid("6b62950f-cac4-41c6-b20b-78c2196a3eb9") },
                    { new Guid("ed742b48-dee1-4b36-bb1b-288432549ae9"), null, "taproom", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") },
                    { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), null, "attraction", new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2") },
                    { new Guid("fd0cba73-63a0-41c8-b95f-2515181bd4a0"), null, "food_court", new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("21410879-6a0a-405b-8b3e-5fefdd5f8276"), null, "no", new Guid("9876f981-1891-494b-815d-40d28a5b8f04") },
                    { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), null, "limited", new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823") },
                    { new Guid("3f58c5b3-9709-449f-a4b3-79ddef80eed7"), null, "only", new Guid("4a9ae4ac-c257-42a5-b6ce-a747db359f39") },
                    { new Guid("408c251f-940d-41bc-82f9-15b569fab948"), null, "leashed", new Guid("311c046a-8a85-484e-84fc-85210fdc07a3") },
                    { new Guid("507d65fb-da7e-4585-8c9a-7b8245917a0a"), null, "not_specified", new Guid("9876f981-1891-494b-815d-40d28a5b8f04") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), null, "yes", new Guid("311c046a-8a85-484e-84fc-85210fdc07a3") },
                    { new Guid("6231e569-64e5-4c21-9a28-bbee0cdd26ff"), null, "customers", new Guid("323d7282-c2dc-4df9-87cd-f48400082749") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), null, "yes", new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823") },
                    { new Guid("86a46030-791d-403e-830c-31311b5b5a0d"), null, "free", new Guid("051006a6-91d3-4656-8c1c-f61b343055e0") },
                    { new Guid("a4d621bc-b195-4fc6-b1ea-0e573e516e8b"), null, "only", new Guid("d22fc313-353b-4eca-9117-955ac920a8ca") },
                    { new Guid("bfc89c79-79cb-42e0-8e94-8949d9abc30b"), null, "only", new Guid("fd93d17a-26d7-4071-ac68-73583be3354b") },
                    { new Guid("c43f7418-720e-425c-8aeb-03318f493351"), null, "not_specified", new Guid("b566e6ec-87ee-4b44-b14b-d9a56045da0d") },
                    { new Guid("c51f591e-9a3e-47bb-a9b4-0d7830a4bc11"), null, "only", new Guid("9774a53a-9eb2-45de-a0e7-495484097f6b") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), "Places that are available for public", "yes", new Guid("b566e6ec-87ee-4b44-b14b-d9a56045da0d") },
                    { new Guid("f5c1a47f-0162-42ab-93bb-33fed2dd71fe"), null, "for_customers", new Guid("051006a6-91d3-4656-8c1c-f61b343055e0") },
                    { new Guid("fdd856ac-b5f7-49c7-87b2-bd5a81247654"), null, "only", new Guid("f294cc06-6a3d-4a25-be9a-368b74642b7a") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("4fecff68-43ec-4568-ba42-615341c243ae"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") },
                    { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("7de161a9-2a13-4533-a2c1-d19d9c77ef6d"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("a4e65971-fc09-4ad0-806b-bbccf10ca121"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed"), new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") },
                    { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f00f65f-6ac7-49ad-86ac-9c5a36741992"), 25m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0"), 4m, null, "3189e4f4-d916-46a2-9c84-5d3c0c11c9c8" },
                    { new Guid("17e7b8a8-48e3-4ce5-9b1b-d628b6e41592"), 80m, new TimeSpan(0, 1, 30, 0, 0), "PLN", 1m, new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c"), 4m, null, "efdbc435-f9f5-4b13-bcf7-eded612261ad" },
                    { new Guid("1cbf3868-e124-4e6b-a85b-01f1f869222f"), 20m, new TimeSpan(0, 0, 50, 0, 0), "PLN", 1m, new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb"), 5m, null, "cfe3fbbb-7bb5-4dd3-9a32-ba4fe4a65f91" },
                    { new Guid("207f8107-5919-4957-b723-9aa263888b97"), 14m, new TimeSpan(0, 1, 20, 0, 0), "PLN", 1m, new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb"), 5m, null, "f22341f5-98bb-4599-bdd6-314b58099136" },
                    { new Guid("21a5bf75-7548-49b5-8a05-4379646283d5"), 15m, new TimeSpan(0, 0, 35, 0, 0), "PLN", 1m, new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983"), 4m, null, "0c425410-952e-44d7-aef0-f553e09fa5ef" },
                    { new Guid("36ad4322-9a57-40f7-867b-db17dfb7e60a"), 30m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0"), 3m, null, "81c8fa3a-f3e5-455b-b847-3500e49d2040" },
                    { new Guid("46347cad-e41c-41cd-a61a-e6f398178c8f"), 0m, new TimeSpan(0, 0, 7, 0, 0), "PLN", 1m, new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2"), 5m, null, "6108900e-8211-4f89-8857-d008b5c20880" },
                    { new Guid("4e5ebf49-54f8-493e-866f-86077825e749"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b"), 4.5m, null, "dd82f2ea-76d6-43f1-b398-2bbf00e8461d" },
                    { new Guid("5acb4922-92d4-4a36-b56a-48b261c1aa7a"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419"), 4m, null, "d0a4eb15-ae3a-496f-ac1b-c4a035422e1f" },
                    { new Guid("5c4c7a33-4ac9-43eb-98a9-ee3f665ba6d1"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0"), 3.5m, null, "872303a4-475f-42bc-ad2f-7f86f4d6d324" },
                    { new Guid("87b7d7e0-f646-4129-b2e4-43ace2a131de"), 85m, new TimeSpan(0, 1, 37, 0, 0), "PLN", 1m, new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c"), 5m, null, "1fd5b35c-b514-46ef-9ff7-d2f59052940c" },
                    { new Guid("880e3f3c-8836-4576-b550-e9fde68d31e5"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419"), 4.5m, null, "64630090-4dea-4315-8e50-046d0e7a75e2" },
                    { new Guid("b2c2d061-5cb8-4126-bae1-a8985def6c93"), 10m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983"), 3.5m, null, "7b9053a1-9d7f-474b-9d61-4eb5eca09121" },
                    { new Guid("bed8a290-1380-49bc-bcd4-920df2ee5b61"), 17m, new TimeSpan(0, 0, 25, 0, 0), "PLN", 1m, new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b"), 5m, null, "f5fbaee3-979b-47c5-b9f4-ebcac02a6af9" },
                    { new Guid("d28560f5-c6f8-44e8-b2f9-cbb7f2640f6e"), 75m, new TimeSpan(0, 2, 0, 0, 0), "PLN", 1m, new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c"), 5m, null, "d6b77d74-3c26-41c5-98a1-1c58663328ac" },
                    { new Guid("dd0185d0-e698-4448-8906-c8b9951b96e1"), 0m, new TimeSpan(0, 0, 5, 0, 0), "PLN", 1m, new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2"), 5m, null, "187ccf51-91fd-49fe-8106-8b440cb5f8a1" },
                    { new Guid("e00a4425-6715-4878-a352-8a4fad4b4e23"), 20m, new TimeSpan(0, 0, 30, 0, 0), "PLN", 1m, new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b"), 5m, null, "e5bd0682-ed4e-4e9c-b80e-aaa107a8e00e" },
                    { new Guid("e12b7ba5-21d6-4514-93c9-56633b174202"), 5m, new TimeSpan(0, 0, 8, 0, 0), "PLN", 1m, new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0"), 4m, null, "cfd9552b-887c-4de6-9128-be7c47dfce60" },
                    { new Guid("e18ec75a-ec52-4de1-91c1-e38a20d7a5cf"), 14m, new TimeSpan(0, 1, 10, 0, 0), "PLN", 1m, new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb"), 5m, null, "429b9148-3ab6-4d22-a4b5-ac32efb29271" },
                    { new Guid("ee24dca3-3153-4172-a815-0699e14ee5f1"), 100m, new TimeSpan(0, 1, 45, 0, 0), "PLN", 1m, new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c"), 4.5m, null, "82843151-e6c1-4855-abe4-02e29c9343ca" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "Note", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d11ce1c-beba-4d72-be93-a2b6f98763e0"), 100m, null, null, "PLN", new Guid("5a31a5a7-1905-487c-89f2-193d81a86b3c"), new DateOnly(2024, 11, 21), 1m, "Wycieczka do Moszczanki", null, 1, new DateOnly(2024, 11, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("8f6be2a5-7db9-4005-b252-e4736cfaac96"), 200m, new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("87e81585-21b0-4d0f-a3e3-eae1cd312936"), "PLN", new Guid("0d1f5704-d246-4410-bcf1-846d109f8822"), new DateOnly(2025, 12, 6), 1m, "Wycieczka do Wrocławia", null, 1, new DateOnly(2025, 12, 6), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("dd47bded-d6c0-4e93-a28b-c69348d32300"), 100m, null, null, "PLN", new Guid("5a31a5a7-1905-487c-89f2-193d81a86b3c"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", null, 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("00c814a6-7454-40e1-a8ea-56514fa1ad72"), null, "seafood", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("04280244-f941-4d61-9f9c-d5fa1f23b7c3"), null, "ice_cream", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("057780a3-1116-4ac0-abf6-d9602237a51f"), null, "nepalese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("0614a27c-a690-48a7-9633-26d5fc678522"), null, "arts_centre", new Guid("df1cc19b-4691-457f-9b02-e396fcfa8231") },
                    { new Guid("0a5ea5fc-aa1e-4235-bdd4-5c867dd2a953"), null, "sandwich", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("0b97f1cd-4ad9-40a4-8eca-4f90a777da36"), null, "russian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("0cb5c43b-e744-4317-b216-0b1e630a1f95"), null, "austrian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("0d6ac9ff-ad62-4b91-9b36-dd77f62686d4"), null, "uzbek", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("0f5ce216-98ed-4644-a1c2-b65c87799709"), null, "tacos", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("0fb1b896-5534-4403-84ea-0c7ac5fbad31"), null, "monastery", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("0fbbce8c-ca00-4589-abdb-1bb25ac344c7"), null, "sea", new Guid("2021b739-d41a-43be-90e7-b4a057bf2798") },
                    { new Guid("10099c18-b1f9-4060-8dec-7afa11917397"), null, "waffle", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("11b1af00-5e2e-48fc-b22e-31c1a58be30b"), null, "christianity", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("12625b55-8a04-4060-8ff9-5bfb748d7e54"), null, "croatian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("12b42ecb-247f-44ac-bf83-76e81a6cf9e8"), null, "dessert", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("134882f2-5ae6-42f2-9d18-664a2321016c"), null, "spring", new Guid("2021b739-d41a-43be-90e7-b4a057bf2798") },
                    { new Guid("136d3fe3-f962-4907-afc5-73087fb53665"), null, "bolivian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("13d02cd5-ac81-4a08-b32c-a0c1f1c61d92"), null, "cave_entrance", new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc") },
                    { new Guid("15280def-ca8b-4925-b05b-f08db2b1a178"), null, "windmill", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("153343b1-f5de-4a1d-bdbf-f0fa3f3ebe02"), null, "latin_american", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("1a656e52-4211-4beb-a7c0-74c4428aaf6d"), null, "asian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("20367a31-b73d-401f-a715-3580e538558f"), null, "gallery", new Guid("df1cc19b-4691-457f-9b02-e396fcfa8231") },
                    { new Guid("2040cca4-65e1-4ad4-84d9-5944f8d01c16"), null, "cake", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("2451bcb9-51c6-42a8-936e-93fc4186e1b6"), null, "chinese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("24a125ab-3bf3-4571-b040-6ec10bf30e99"), null, "western", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("250f6955-53c6-4c67-813a-bcafd3cb9ede"), null, "hungarian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("2b6fda83-1b13-4d9f-b1cb-83cae581c1b8"), null, "castle", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("2b72129d-7445-4464-840d-19b32d1c790f"), null, "wings", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("2c1c6648-962c-4a2f-95ab-5916dc4e9fc4"), null, "reef", new Guid("2021b739-d41a-43be-90e7-b4a057bf2798") },
                    { new Guid("2c6f7f9c-d0de-4aa8-b357-cadcddad01e1"), null, "pita", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("2e789c40-4b0b-46c7-89e0-57f25a4ad7e4"), null, "malaysian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("30721bdd-2c10-46ae-b181-674fbe6d8adf"), null, "taiwanese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("363e6228-be61-4dd5-a472-3e0abdde34a3"), null, "bubble_tea", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("37c8d6c5-1c66-43fc-84b1-c3501a4b3da7"), null, "city_hall", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("382e358f-f102-453a-938a-ecbc6ef22c9f"), null, "buddhism", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("38e37d0e-d870-4a65-8c80-c3e6808cbae6"), null, "fountain", new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786") },
                    { new Guid("3a83d2cb-594d-4390-a0df-9e724cf69e9a"), null, "czech", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("3aa25ab8-a41e-4888-8be3-70f67792e137"), null, "kebab", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("3abebbfc-e014-4a49-a4ed-8a864c1bd062"), null, "pizza", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("3e46264a-d606-47de-af81-3e347b6c67ed"), null, "crepe", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("40b3d831-2486-4a00-abc2-86a28e4c0058"), null, "syrian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("4141d851-617d-4859-84ee-41f89ef8599f"), null, "glacier", new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc") },
                    { new Guid("41d6c8f7-7044-4a04-89ef-9263c54bda12"), null, "viewpoint", new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786") },
                    { new Guid("428dcd09-f780-448e-aa6b-96359993b30e"), null, "oriental", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("44120e94-fd15-41d0-989e-4c5a318d3dc9"), null, "pita", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("459dbf52-bc89-4d93-90d7-bfb6ab8039cf"), null, "turkish", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("481be157-7576-4656-846f-209a6eecf79e"), null, "geyser", new Guid("2021b739-d41a-43be-90e7-b4a057bf2798") },
                    { new Guid("48ae7d59-4820-4246-8cc7-e06e87bce151"), null, "friture", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("4ab65e5e-36da-4c54-90cd-775fa36833e5"), null, "garden", new Guid("1674e06b-019c-479f-9ea1-89e82e42cb31") },
                    { new Guid("4b46a5c1-54e9-46d3-b2c6-c5c4383880dd"), null, "battlefield", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("4bda31cf-bbb5-4457-8914-b0d088067268"), null, "shinto", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("4f1aeab4-36da-4a43-96e4-f366b756d1a9"), null, "soup", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("50a83d43-718c-4999-9362-9172bda602f6"), null, "regional", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("5484c72e-51dd-4e57-8a5e-5996609d1af0"), null, "tower", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("57156c51-d039-4d8b-b5c3-be8fb206e4a9"), null, "tea", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("58259bf7-7812-432c-a74b-2d6adf8e59e8"), null, "international", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("5a9a8fd7-745e-4e8f-bd2b-39f96c5ae047"), null, "korean", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("5b06ae78-409c-4b40-9fe0-0c6728c147ae"), null, "greek", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("5b8a2e28-7d65-4fa0-b50c-740bda396f21"), null, "chicken", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("5d4b665c-5791-4583-bfac-4e21201f9c35"), null, "caribbean", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("6051ebbf-9b00-452e-b5ca-f958d341bc32"), null, "cuban", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("614e3944-d62a-4f19-b2f2-fa5b4b9ac28f"), null, "burger", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("6385dc05-e70b-403e-971a-e0801e44f805"), null, "tapas", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("63c668f9-ec34-4cd5-a74a-f6ba93e7535d"), null, "peruvian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("649c92e3-f0a6-4f9c-8a04-9423ff543a2a"), null, "european", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("64d2d0d5-8025-4e5e-8a2c-2e58432dc956"), null, "noodle", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("6b3a9525-9f45-4b22-bf1a-d3bde8090d91"), null, "cliff", new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc") },
                    { new Guid("6ca9bdc0-e645-4668-834f-dd2b9f721725"), null, "brazilian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("6eecdf86-7786-4e8e-8344-6df8cdb6dcaa"), null, "coffee_shop", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("7275140b-960b-4079-bbee-ce20ac954cdf"), null, "peak", new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc") },
                    { new Guid("743634d7-f9be-46a3-a8f5-470fbfdaa412"), null, "sushi", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("75a86f47-6085-4355-b3fb-51112163230d"), null, "nature_reserve", new Guid("1674e06b-019c-479f-9ea1-89e82e42cb31") },
                    { new Guid("75e91faf-00c9-45ec-bc90-b013093955b4"), null, "african", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("7a7eb8dc-6975-4d91-b525-be7b85a5ace6"), null, "sikhism", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("7daa2844-b826-4c56-a291-c3a1e1cc7c13"), null, "dune", new Guid("864c464f-3c90-42f3-83b3-31abec960f04") },
                    { new Guid("803b9a3d-4a4b-45eb-bc16-9110b6637fe3"), null, "danish", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("82692c9b-147e-467f-abc8-fcf9f480e316"), null, "city_gate", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("829e2043-47ee-4a69-a4c2-ee42493ce224"), null, "clock", new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786") },
                    { new Guid("83c1fce4-9d04-45d5-b921-f1e988a532d2"), null, "curry", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("84013e61-dd76-4e22-a027-e047bbc5a01e"), null, "malay", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("84169f54-37c2-48cf-8a90-afed605e4145"), null, "archaeological_site", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("8a4bece7-18f7-458e-afd9-371957e33a4d"), null, "frozen_yogurt", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("8bb86510-7b66-4c39-b6b4-5d7ff1ee8477"), null, "spanish", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("8cf1657e-9fd9-4625-96d1-495cd73896ee"), null, "multifaith", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("9349765b-b31f-4129-9d25-831ee2c0138f"), null, "american", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), null, "memorial", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("98dcae14-e564-4cf0-994e-7f30a14f02f7"), null, "german", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("9b05b3e3-28af-460a-8c39-5d27e4b0f3a3"), null, "vietnamese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("9d1efac8-5474-4abf-af88-e4c84ead3f6c"), null, "ukrainian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("9db854ac-8fe8-4917-acf8-d2cd13313dc1"), null, "dumpling", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("9e002b79-e412-40e5-8b54-2f1b344bd30c"), null, "pizza", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("9e3812a3-ee6c-4f3f-a489-cd29fa434101"), null, "tex-mex", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("a2ada010-10e7-4f15-aa27-c466ef9e2c89"), null, "moroccan", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("a41c6c14-7b44-4b7e-bf58-eb085aa08fa5"), null, "ramen", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("a4d758e5-b43f-4cff-9a25-2bb01703aaf7"), null, "wings", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("a5fdf646-e267-494d-9942-ff4db84cf0d9"), null, "ethiopian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("a6369cc6-c2c9-49ab-86a0-3283c5879436"), null, "fish", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("a72453a9-6deb-4ad9-a04b-8de4df830006"), null, "bridge", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("a72eb7e8-146f-456e-bb76-d5ebfeed2dda"), null, "mexican", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("a89a32c6-19a9-4dd6-a192-e103f2397238"), null, "hinduism", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("a96d4ce9-a48d-44f4-b31f-cbb261171462"), null, "rock", new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc") },
                    { new Guid("aa11cb3d-b697-4938-b835-06070f0836b6"), null, "islam", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("aaeef86c-2599-4993-b8d4-fac49e08878e"), null, "mediterranean", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("aafcdb07-0cf3-4e53-bede-04dd3070f92e"), null, "afghan", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ab26c6f0-423d-4fb2-8722-0790006208b1"), null, "coffee", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914"), null, "place_of_worship", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("acbd5531-5fb7-46b3-80c5-2d76d668d776"), null, "tapas", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("af10cd08-ece0-4df8-9592-eb8982d28b43"), null, "italian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("b0826539-0564-431a-9df7-ec68eecc8d09"), null, "fish_and_chips", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("b19eb999-f820-41e0-8507-bd1cd4cf0924"), null, "hot_spring", new Guid("2021b739-d41a-43be-90e7-b4a057bf2798") },
                    { new Guid("b267ac75-6346-4a39-afa2-430824bdc267"), null, "portuguese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("b4171c2b-bf82-4d6f-a1a7-bf88bdc72de8"), null, "theatre", new Guid("df1cc19b-4691-457f-9b02-e396fcfa8231") },
                    { new Guid("b633269b-3df4-49c6-a80c-57ff3d905ed8"), null, "pakistani", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("b66872e8-e39f-4414-b7db-a35995a797c2"), null, "argentinian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("b7b9cb9a-ffee-4e4c-92b8-f4652dbe811b"), null, "indian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("be4686e3-491e-4902-935a-cf1ed6b1c655"), null, "noodle", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("bec7c0d9-c351-41f7-bd65-55d63df9f336"), null, "salad", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("bf2c5a23-5f74-4d35-8dfa-5e1746207acc"), null, "indonesian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("c16d308a-ae5b-4d20-9608-243ac30b52d4"), null, "bavarian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("c52dae29-55d6-4beb-930c-1ceb31df88bf"), null, "donut", new Guid("dad1066f-9795-4a00-a3df-255753f3d481") },
                    { new Guid("c5a646c0-e323-4370-beee-a5f8ab8be69f"), null, "french", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ca67eacf-2d5a-4b36-aebe-9d147bdf9907"), null, "steak_house", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("cbd921c6-238b-4749-88f1-64992e09fcdc"), null, "georgian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("d4611ac7-efd1-4c25-a7fd-a4006c0cbf6e"), null, "judaism", new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c") },
                    { new Guid("d64ca2eb-f5f8-428d-935e-bde7d01a28f2"), null, "filipino", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("d98d8a4a-e69a-47a4-acf8-728c88ebaa6e"), null, "hawaiian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("da15023c-d584-492b-9de1-75620b1e2d98"), null, "persian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("db8b72c9-ff17-4d0a-80c5-9387bb8235f5"), null, "fish_and_chips", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("df9d6ab5-d02b-4549-b389-a4dfe6935fef"), null, "soup", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("e1b8c0c3-f547-4454-99d1-96baa16d98f5"), null, "lighthouse", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("e42844d7-0fc1-4527-a6a4-03c74aac572b"), null, "ruines", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("e48f4044-4d04-4c13-b2d6-2e6835d733f2"), null, "japanese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("e49e8d95-3f8a-4c79-8e70-450eb5330e7d"), null, "tacos", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("e4af106b-a46f-49dd-bdb2-bbc4819764b0"), null, "jamaican", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("e5bcbf73-1fb8-4bda-91a7-de3a444ad095"), null, "hot_dog", new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf") },
                    { new Guid("e5e389fb-9252-4f74-b634-3967bd351f91"), null, "ramen", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ea8fa612-51e4-43d6-8881-d6f2d389edbf"), null, "thai", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ebae126d-d840-46a7-aaa1-e93760d104c2"), null, "artwork", new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786") },
                    { new Guid("ee0c018f-07a9-46d2-bc44-46f5d735ab29"), null, "fort", new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c") },
                    { new Guid("ef0f4ed2-1120-45db-915e-ba5611532c35"), null, "chili", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ef79a351-ad65-4085-b57a-eafca68639b3"), null, "lebanese", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("f0aa77cc-e515-4f30-928c-b1f7edf1aaa4"), null, "kebab", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("f6b7a907-dbfb-4340-b84f-69ad30dec057"), null, "barbecue", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("f6c50c2b-6ec1-4720-b51b-a4a92e5f323f"), null, "beef_bowl", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("f7be6a54-ec0b-455a-befd-5b7c063a0a29"), null, "irish", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("fa2cd0f8-2213-44d6-881a-cf2ba0f48b70"), null, "burger", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("fb52c87f-78c2-47ec-952b-7f1cba659dde"), null, "belgian", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("fcfa931d-dba7-49bb-852f-054e40bba8dc"), null, "arab", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("feea3cc0-9249-4da5-9d48-60b0bb8d38b3"), null, "swedish", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ff3186d6-2a67-4b5b-99af-41883a4a393e"), null, "sandwich", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") },
                    { new Guid("ff4d45d4-1905-486f-bcc2-83d617573483"), null, "balkan", new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("1674e06b-019c-479f-9ea1-89e82e42cb31"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("2021b739-d41a-43be-90e7-b4a057bf2798"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac"), new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e") },
                    { new Guid("61e800b0-f6fa-4223-be18-41a37e9444a9"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("61e800b0-f6fa-4223-be18-41a37e9444a9"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") },
                    { new Guid("6a4f515e-7aa6-4d28-b1dc-3f6cd187b040"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("d1b830dc-68db-41f6-a299-441fbf8d1533"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") },
                    { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") },
                    { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") },
                    { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") },
                    { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6"), new DateOnly(2024, 11, 21), new Guid("2d11ce1c-beba-4d72-be93-a2b6f98763e0") },
                    { new Guid("322aa444-6fb1-4b22-81da-354019667f75"), new DateOnly(2025, 12, 6), new Guid("8f6be2a5-7db9-4005-b252-e4736cfaac96") },
                    { new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec"), new DateOnly(2024, 11, 20), new Guid("2d11ce1c-beba-4d72-be93-a2b6f98763e0") },
                    { new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458"), new DateOnly(2024, 12, 21), new Guid("dd47bded-d6c0-4e93-a28b-c69348d32300") },
                    { new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571"), new DateOnly(2024, 12, 20), new Guid("dd47bded-d6c0-4e93-a28b-c69348d32300") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("31f3496a-45e4-4827-8611-26c78fd1dabf"), null, "wayside_cross", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("39622bde-d5fd-4808-b6b1-a38c13644810"), null, "tank", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("4658ba2b-395f-45d4-8400-8f27e8ce95b2"), null, "church", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("47c025eb-b02a-4bce-b1ce-61b03f094108"), null, "monument", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("511acc75-6c19-4d71-ba7e-e6545ed1195e"), null, "milestone", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("5bc82301-9e27-4dcd-a3b0-a35542422290"), null, "chapel", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("694dd2b3-1e72-4a5d-956f-f52be19b2207"), null, "pillory", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("697cd152-37be-4b43-a22b-e37f0b67843d"), null, "synagogue", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("69cc4b38-f56e-47bc-abbc-3ae4e3fe94b3"), null, "mosque", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("6ce9a522-1028-4c32-add2-ce178e08417b"), null, "cathedral", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("6e0dc21e-175a-4c7f-b1c1-628b4bdada01"), null, "tomb", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("7f64a49c-3875-4c7e-afde-10251b6c0fc8"), null, "boundary_stone", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("acc2268e-9865-4968-b530-843af6fe5ad6"), null, "temple", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("c00eb8cd-4d75-44b9-ad1e-fc0087068e72"), null, "ship", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("c2106dcc-46e2-4d8c-86ac-e1fecfcce10c"), null, "aircraft", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("ca37fee8-1c2d-4756-bd29-0a961ddccd36"), null, "shrine", new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914") },
                    { new Guid("dc3ceeba-130b-4882-be8d-01567d17d236"), null, "locomotive", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") },
                    { new Guid("ebd8de32-006d-4318-8982-2c38c90774cd"), null, "railway_car", new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("11b1af00-5e2e-48fc-b22e-31c1a58be30b"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("38e37d0e-d870-4a65-8c80-c3e6808cbae6"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") },
                    { new Guid("4ab65e5e-36da-4c54-90cd-775fa36833e5"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") },
                    { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c") },
                    { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f") },
                    { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") },
                    { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3") },
                    { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f") },
                    { new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") },
                    { new Guid("e42844d7-0fc1-4527-a6a4-03c74aac572b"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("00b0955e-9610-4e67-96a2-4658f6453520"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("00ec45ba-df3f-43e3-81dc-426f4b929aa6"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("92dff543-3914-42d9-9a5b-8cdd8142c5a2"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") },
                    { new Guid("0dfd2b86-2dee-4230-80cf-1ba8c7b1aa72"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("13c73b67-cc3f-4129-8a9d-6c55a620c766"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("184bad3e-9ae9-4e8a-93e7-5b34586967ff"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("6df0caf7-a54a-4371-916f-3dd4daa47d7d"), 0m, new TimeOnly(13, 30, 0), 2, new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") },
                    { new Guid("336ffc7a-0f9c-4ed1-9e49-720b2b9645cc"), new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e"), 30m, new TimeOnly(14, 0, 0), 3, new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("3bbed6f4-5460-439e-b5b3-6b4609707b70"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("3f65c39e-a19a-410a-8913-e8a65a214994"), new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("55c64124-e17b-4922-81bd-8ff910fb3b64"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f"), 0m, new TimeOnly(11, 50, 0), 1, new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") },
                    { new Guid("5e914133-85da-4d45-9e4a-26e583ed6719"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("8e49a300-7a0b-4801-a35d-7ff185be656f"), 5m, new TimeOnly(16, 30, 0), 3, new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("74875004-2aa5-4c20-b692-e239c5fb9a6f"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("b1137605-cef1-42e1-b888-53f141634187"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("d138987b-de42-4ed2-9115-84ef37581ba1"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("e6710aff-f78f-4e61-adeb-f10101579913"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("e78cf3a1-c3a9-446a-9cb5-aad66c0869e9"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58"), 0m, new TimeOnly(10, 0, 0), 1, new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") },
                    { new Guid("ea8d3ff1-0cd7-4789-bf0a-aa8a475386f8"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f"), 0m, new TimeOnly(13, 0, 0), 1, new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("edeb45d4-c629-42c6-a48e-305f5ba4b750"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("8b04966c-1ccb-4860-8600-f3dc66981583"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("fb5dc2e9-563e-4709-be54-1b51435122a2"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("f6689b7d-319f-48de-81ef-e0bdb8b0d65f"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("fc34f1b2-9edf-4e60-aba2-520602726869"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3"), 0m, new TimeOnly(11, 0, 0), 1, new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[] { new Guid("4658ba2b-395f-45d4-8400-8f27e8ce95b2"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("066a0f5d-742f-4a3f-bea3-bdbf067c5377"), new Guid("0dfd2b86-2dee-4230-80cf-1ba8c7b1aa72"), 2, new Guid("ea8d3ff1-0cd7-4789-bf0a-aa8a475386f8"), new TimeSpan(0, 0, 3, 13, 0), new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("0a27fa41-5ac7-4b18-9540-f267d0722939"), new Guid("74875004-2aa5-4c20-b692-e239c5fb9a6f"), 2, new Guid("13c73b67-cc3f-4129-8a9d-6c55a620c766"), new TimeSpan(0, 0, 3, 13, 0), new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("0df06959-728d-426d-91ca-738a809db26d"), new Guid("fb5dc2e9-563e-4709-be54-1b51435122a2"), null, new Guid("b1137605-cef1-42e1-b888-53f141634187"), new TimeSpan(0, 0, 20, 0, 0), new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("2e264e70-afd0-4513-8b57-0688faa11032"), new Guid("e6710aff-f78f-4e61-adeb-f10101579913"), 1, new Guid("fb5dc2e9-563e-4709-be54-1b51435122a2"), new TimeSpan(0, 0, 0, 55, 0), new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("58cd666e-7c92-42f1-98d4-101f9f27aa3d"), new Guid("ea8d3ff1-0cd7-4789-bf0a-aa8a475386f8"), 3, new Guid("336ffc7a-0f9c-4ed1-9e49-720b2b9645cc"), new TimeSpan(0, 0, 8, 18, 0), new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("70596f19-d673-4d53-a12c-0e33992988c5"), new Guid("3f65c39e-a19a-410a-8913-e8a65a214994"), 3, new Guid("edeb45d4-c629-42c6-a48e-305f5ba4b750"), new TimeSpan(0, 0, 13, 30, 0), new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("81a345ae-36e2-49da-8669-0d5f3e5e080d"), new Guid("55c64124-e17b-4922-81bd-8ff910fb3b64"), 1, new Guid("00ec45ba-df3f-43e3-81dc-426f4b929aa6"), new TimeSpan(0, 0, 0, 55, 0), new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") },
                    { new Guid("876f4a6b-b18c-4d83-94b9-72b7a1789f92"), new Guid("3bbed6f4-5460-439e-b5b3-6b4609707b70"), 0, new Guid("e6710aff-f78f-4e61-adeb-f10101579913"), new TimeSpan(0, 0, 4, 21, 0), new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571") },
                    { new Guid("8ff18e61-d161-4d60-87a2-8ae7881c14e7"), new Guid("13c73b67-cc3f-4129-8a9d-6c55a620c766"), 3, new Guid("3f65c39e-a19a-410a-8913-e8a65a214994"), new TimeSpan(0, 0, 8, 18, 0), new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458") },
                    { new Guid("949e219b-e28d-458e-b0aa-b5f85c67562d"), new Guid("336ffc7a-0f9c-4ed1-9e49-720b2b9645cc"), 3, new Guid("5e914133-85da-4d45-9e4a-26e583ed6719"), new TimeSpan(0, 0, 13, 30, 0), new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6") },
                    { new Guid("c9bf1f5b-c68b-4501-bf71-cc9f065cb4de"), new Guid("00ec45ba-df3f-43e3-81dc-426f4b929aa6"), null, new Guid("184bad3e-9ae9-4e8a-93e7-5b34586967ff"), new TimeSpan(0, 0, 20, 0, 0), new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") },
                    { new Guid("da6572a2-e506-4ae5-b1dd-ec7e322ed5c1"), new Guid("fc34f1b2-9edf-4e60-aba2-520602726869"), 0, new Guid("55c64124-e17b-4922-81bd-8ff910fb3b64"), new TimeSpan(0, 0, 4, 21, 0), new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c2d1cb86-de01-448e-b2b4-26c69cf80be3"), 40m, new TimeSpan(0, 1, 0, 0, 0), "PLN", 1m, new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e"), 5m, new Guid("336ffc7a-0f9c-4ed1-9e49-720b2b9645cc"), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("eef82b5d-a32d-4709-a827-78f27810c6c4"), 10m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("8e49a300-7a0b-4801-a35d-7ff185be656f"), 4.5m, new Guid("5e914133-85da-4d45-9e4a-26e583ed6719"), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("4fecff68-43ec-4568-ba42-615341c243ae") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("69f7398e-b596-4587-841b-cb8d98a055fb") });

            migrationBuilder.DeleteData(
                table: "CategoryProfilePlaceCategory",
                keyColumns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                keyValues: new object[] { new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"), new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2") });

            migrationBuilder.DeleteData(
                table: "ConditionProfilePlaceCondition",
                keyColumns: new[] { "ConditionProfileId", "PlaceConditionId" },
                keyValues: new object[] { new Guid("87e81585-21b0-4d0f-a3e3-eae1cd312936"), new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823") });

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("00c814a6-7454-40e1-a8ea-56514fa1ad72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("04280244-f941-4d61-9f9c-d5fa1f23b7c3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("057780a3-1116-4ac0-abf6-d9602237a51f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0614a27c-a690-48a7-9633-26d5fc678522"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("084d7285-f83a-4744-ab6e-bec594234c93"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0a5ea5fc-aa1e-4235-bdd4-5c867dd2a953"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b97f1cd-4ad9-40a4-8eca-4f90a777da36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cb5c43b-e744-4317-b216-0b1e630a1f95"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0d6ac9ff-ad62-4b91-9b36-dd77f62686d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f5ce216-98ed-4644-a1c2-b65c87799709"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fb1b896-5534-4403-84ea-0c7ac5fbad31"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("0fbbce8c-ca00-4589-abdb-1bb25ac344c7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("10099c18-b1f9-4060-8dec-7afa11917397"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12625b55-8a04-4060-8ff9-5bfb748d7e54"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("12b42ecb-247f-44ac-bf83-76e81a6cf9e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("134882f2-5ae6-42f2-9d18-664a2321016c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("136d3fe3-f962-4907-afc5-73087fb53665"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("13d02cd5-ac81-4a08-b32c-a0c1f1c61d92"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("146783ae-6deb-4041-bea6-663456595042"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("15280def-ca8b-4925-b05b-f08db2b1a178"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("153343b1-f5de-4a1d-bdbf-f0fa3f3ebe02"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("17536513-cf01-4222-b6ca-4e94c15d1ddd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a656e52-4211-4beb-a7c0-74c4428aaf6d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("20367a31-b73d-401f-a715-3580e538558f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2040cca4-65e1-4ad4-84d9-5944f8d01c16"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2451bcb9-51c6-42a8-936e-93fc4186e1b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("24a125ab-3bf3-4571-b040-6ec10bf30e99"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("250f6955-53c6-4c67-813a-bcafd3cb9ede"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b6fda83-1b13-4d9f-b1cb-83cae581c1b8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b72129d-7445-4464-840d-19b32d1c790f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b9f0ed7-44d9-41e6-a6c7-46506887e163"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c1c6648-962c-4a2f-95ab-5916dc4e9fc4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c6f7f9c-d0de-4aa8-b357-cadcddad01e1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e789c40-4b0b-46c7-89e0-57f25a4ad7e4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("30721bdd-2c10-46ae-b181-674fbe6d8adf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("31f3496a-45e4-4827-8611-26c78fd1dabf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("363e6228-be61-4dd5-a472-3e0abdde34a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("37c8d6c5-1c66-43fc-84b1-c3501a4b3da7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("382e358f-f102-453a-938a-ecbc6ef22c9f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("39622bde-d5fd-4808-b6b1-a38c13644810"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3a83d2cb-594d-4390-a0df-9e724cf69e9a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3aa25ab8-a41e-4888-8be3-70f67792e137"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3abebbfc-e014-4a49-a4ed-8a864c1bd062"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e46264a-d606-47de-af81-3e347b6c67ed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("40b3d831-2486-4a00-abc2-86a28e4c0058"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4141d851-617d-4859-84ee-41f89ef8599f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("41d6c8f7-7044-4a04-89ef-9263c54bda12"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("428dcd09-f780-448e-aa6b-96359993b30e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("44120e94-fd15-41d0-989e-4c5a318d3dc9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("459dbf52-bc89-4d93-90d7-bfb6ab8039cf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("47c025eb-b02a-4bce-b1ce-61b03f094108"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("481be157-7576-4656-846f-209a6eecf79e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("48ae7d59-4820-4246-8cc7-e06e87bce151"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b46a5c1-54e9-46d3-b2c6-c5c4383880dd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4bda31cf-bbb5-4457-8914-b0d088067268"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f1aeab4-36da-4a43-96e4-f366b756d1a9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("50a83d43-718c-4999-9362-9172bda602f6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("511acc75-6c19-4d71-ba7e-e6545ed1195e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5484c72e-51dd-4e57-8a5e-5996609d1af0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("57156c51-d039-4d8b-b5c3-be8fb206e4a9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58259bf7-7812-432c-a74b-2d6adf8e59e8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("58ff3ce0-476b-4d03-9f83-6d17d681d805"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a9a8fd7-745e-4e8f-bd2b-39f96c5ae047"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b06ae78-409c-4b40-9fe0-0c6728c147ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b8a2e28-7d65-4fa0-b50c-740bda396f21"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5bc82301-9e27-4dcd-a3b0-a35542422290"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d4b665c-5791-4583-bfac-4e21201f9c35"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6051ebbf-9b00-452e-b5ca-f958d341bc32"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("614e3944-d62a-4f19-b2f2-fa5b4b9ac28f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6385dc05-e70b-403e-971a-e0801e44f805"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("63c668f9-ec34-4cd5-a74a-f6ba93e7535d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("649c92e3-f0a6-4f9c-8a04-9423ff543a2a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("64d2d0d5-8025-4e5e-8a2c-2e58432dc956"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("694dd2b3-1e72-4a5d-956f-f52be19b2207"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("697cd152-37be-4b43-a22b-e37f0b67843d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69cc4b38-f56e-47bc-abbc-3ae4e3fe94b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b3a9525-9f45-4b22-bf1a-d3bde8090d91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ca9bdc0-e645-4668-834f-dd2b9f721725"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ce9a522-1028-4c32-add2-ce178e08417b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e0dc21e-175a-4c7f-b1c1-628b4bdada01"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6eecdf86-7786-4e8e-8344-6df8cdb6dcaa"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7275140b-960b-4079-bbee-ce20ac954cdf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("743634d7-f9be-46a3-a8f5-470fbfdaa412"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("75a86f47-6085-4355-b3fb-51112163230d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("75e91faf-00c9-45ec-bc90-b013093955b4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("795e6870-250b-44c7-b124-cc3bdb37bb33"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a0be33f-777b-4985-8cb0-56e3c17edacb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a7eb8dc-6975-4d91-b525-be7b85a5ace6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7daa2844-b826-4c56-a291-c3a1e1cc7c13"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f64a49c-3875-4c7e-afde-10251b6c0fc8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("803b9a3d-4a4b-45eb-bc16-9110b6637fe3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("82692c9b-147e-467f-abc8-fcf9f480e316"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("829e2043-47ee-4a69-a4c2-ee42493ce224"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("83c1fce4-9d04-45d5-b921-f1e988a532d2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("84013e61-dd76-4e22-a027-e047bbc5a01e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("84169f54-37c2-48cf-8a90-afed605e4145"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a4bece7-18f7-458e-afd9-371957e33a4d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8bb86510-7b66-4c39-b6b4-5d7ff1ee8477"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8cf1657e-9fd9-4625-96d1-495cd73896ee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9286cbbd-ee6c-465e-b9c1-55894acfe09a"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9297b67f-5cf9-4a41-9b33-d09457b54835"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9349765b-b31f-4129-9d25-831ee2c0138f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("98dcae14-e564-4cf0-994e-7f30a14f02f7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b05b3e3-28af-460a-8c39-5d27e4b0f3a3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9d1efac8-5474-4abf-af88-e4c84ead3f6c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9db854ac-8fe8-4917-acf8-d2cd13313dc1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e002b79-e412-40e5-8b54-2f1b344bd30c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e3812a3-ee6c-4f3f-a489-cd29fa434101"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2ada010-10e7-4f15-aa27-c466ef9e2c89"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3593ad6-7b47-44bd-8121-ddc228553ebc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a41c6c14-7b44-4b7e-bf58-eb085aa08fa5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4d758e5-b43f-4cff-9a25-2bb01703aaf7"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a5fdf646-e267-494d-9942-ff4db84cf0d9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a6369cc6-c2c9-49ab-86a0-3283c5879436"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a72453a9-6deb-4ad9-a04b-8de4df830006"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a72eb7e8-146f-456e-bb76-d5ebfeed2dda"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a89a32c6-19a9-4dd6-a192-e103f2397238"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a96d4ce9-a48d-44f4-b31f-cbb261171462"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa11cb3d-b697-4938-b835-06070f0836b6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aaeef86c-2599-4993-b8d4-fac49e08878e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aafcdb07-0cf3-4e53-bede-04dd3070f92e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab26c6f0-423d-4fb2-8722-0790006208b1"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("acbd5531-5fb7-46b3-80c5-2d76d668d776"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("acc2268e-9865-4968-b530-843af6fe5ad6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("af10cd08-ece0-4df8-9592-eb8982d28b43"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0826539-0564-431a-9df7-ec68eecc8d09"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b19eb999-f820-41e0-8507-bd1cd4cf0924"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b267ac75-6346-4a39-afa2-430824bdc267"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b4171c2b-bf82-4d6f-a1a7-bf88bdc72de8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b633269b-3df4-49c6-a80c-57ff3d905ed8"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b66872e8-e39f-4414-b7db-a35995a797c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("b7b9cb9a-ffee-4e4c-92b8-f4652dbe811b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("be4686e3-491e-4902-935a-cf1ed6b1c655"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bec7c0d9-c351-41f7-bd65-55d63df9f336"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("bf2c5a23-5f74-4d35-8dfa-5e1746207acc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c00eb8cd-4d75-44b9-ad1e-fc0087068e72"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c16d308a-ae5b-4d20-9608-243ac30b52d4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c2106dcc-46e2-4d8c-86ac-e1fecfcce10c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c52dae29-55d6-4beb-930c-1ceb31df88bf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("c5a646c0-e323-4370-beee-a5f8ab8be69f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca37fee8-1c2d-4756-bd29-0a961ddccd36"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca67eacf-2d5a-4b36-aebe-9d147bdf9907"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cbd921c6-238b-4749-88f1-64992e09fcdc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4611ac7-efd1-4c25-a7fd-a4006c0cbf6e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d64ca2eb-f5f8-428d-935e-bde7d01a28f2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d98d8a4a-e69a-47a4-acf8-728c88ebaa6e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da15023c-d584-492b-9de1-75620b1e2d98"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("da48e1d2-1f18-4310-8e5b-d35165e053a5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("db8b72c9-ff17-4d0a-80c5-9387bb8235f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc3ceeba-130b-4882-be8d-01567d17d236"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("df9d6ab5-d02b-4549-b389-a4dfe6935fef"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1b8c0c3-f547-4454-99d1-96baa16d98f5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e48f4044-4d04-4c13-b2d6-2e6835d733f2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e49e8d95-3f8a-4c79-8e70-450eb5330e7d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4af106b-a46f-49dd-bdb2-bbc4819764b0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5bcbf73-1fb8-4bda-91a7-de3a444ad095"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5e389fb-9252-4f74-b634-3967bd351f91"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9330620-9a08-4f41-b6b0-f8cd7684b21b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e96d8e3c-455d-4944-ae45-31db51b0a596"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea8fa612-51e4-43d6-8881-d6f2d389edbf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ebae126d-d840-46a7-aaa1-e93760d104c2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ebd8de32-006d-4318-8982-2c38c90774cd"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed742b48-dee1-4b36-bb1b-288432549ae9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee0c018f-07a9-46d2-bc44-46f5d735ab29"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef0f4ed2-1120-45db-915e-ba5611532c35"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef79a351-ad65-4085-b57a-eafca68639b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0aa77cc-e515-4f30-928c-b1f7edf1aaa4"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6b7a907-dbfb-4340-b84f-69ad30dec057"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6c50c2b-6ec1-4720-b51b-a4a92e5f323f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7be6a54-ec0b-455a-befd-5b7c063a0a29"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa2cd0f8-2213-44d6-881a-cf2ba0f48b70"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb52c87f-78c2-47ec-952b-7f1cba659dde"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa931d-dba7-49bb-852f-054e40bba8dc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd0cba73-63a0-41c8-b95f-2515181bd4a0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("feea3cc0-9249-4da5-9d48-60b0bb8d38b3"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff3186d6-2a67-4b5b-99af-41883a4a393e"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff4d45d4-1905-486f-bcc2-83d617573483"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("0d653e96-aab2-4790-ad55-fbb2199f5db9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("17c58dc3-df5f-4881-8795-4f1aa4376030"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("1d82fa0c-8e9c-4d8f-9e2f-da0822c0e79b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("21410879-6a0a-405b-8b3e-5fefdd5f8276"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("3f58c5b3-9709-449f-a4b3-79ddef80eed7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("408c251f-940d-41bc-82f9-15b569fab948"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("507d65fb-da7e-4585-8c9a-7b8245917a0a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6231e569-64e5-4c21-9a28-bbee0cdd26ff"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("6482dc7f-43f1-4e5c-a16c-26e23893e4dc"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("8354792d-1bac-4cc9-b363-199f4fa90cbb"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("86a46030-791d-403e-830c-31311b5b5a0d"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("a4d621bc-b195-4fc6-b1ea-0e573e516e8b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("bfc89c79-79cb-42e0-8e94-8949d9abc30b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c43f7418-720e-425c-8aeb-03318f493351"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("c51f591e-9a3e-47bb-a9b4-0d7830a4bc11"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("de8c6a1e-3f59-4ed7-a8fd-44567076130e"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f5c1a47f-0162-42ab-93bb-33fed2dd71fe"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fdd856ac-b5f7-49c7-87b2-bd5a81247654"));

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("11b1af00-5e2e-48fc-b22e-31c1a58be30b"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("1674e06b-019c-479f-9ea1-89e82e42cb31"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2021b739-d41a-43be-90e7-b4a057bf2798"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("38e37d0e-d870-4a65-8c80-c3e6808cbae6"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4658ba2b-395f-45d4-8400-8f27e8ce95b2"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4ab65e5e-36da-4c54-90cd-775fa36833e5"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("4fecff68-43ec-4568-ba42-615341c243ae"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac"), new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("61e800b0-f6fa-4223-be18-41a37e9444a9"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("61e800b0-f6fa-4223-be18-41a37e9444a9"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6a4f515e-7aa6-4d28-b1dc-3f6cd187b040"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7de161a9-2a13-4533-a2c1-d19d9c77ef6d"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"), new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("a4e65971-fc09-4ad0-806b-bbccf10ca121"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed"), new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("d1b830dc-68db-41f6-a299-441fbf8d1533"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e42844d7-0fc1-4527-a6a4-03c74aac572b"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCategory",
                keyColumns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"), new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("7da18893-482d-4250-920f-a3a35328a0ca"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), new Guid("c64a35ed-5365-4a43-a478-d6e57e913011") });

            migrationBuilder.DeleteData(
                table: "ProviderPlacePlaceCondition",
                keyColumns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                keyValues: new object[] { new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"), new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983") });

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("066a0f5d-742f-4a3f-bea3-bdbf067c5377"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("0a27fa41-5ac7-4b18-9540-f267d0722939"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("0df06959-728d-426d-91ca-738a809db26d"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("2e264e70-afd0-4513-8b57-0688faa11032"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("58cd666e-7c92-42f1-98d4-101f9f27aa3d"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("70596f19-d673-4d53-a12c-0e33992988c5"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("81a345ae-36e2-49da-8669-0d5f3e5e080d"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("876f4a6b-b18c-4d83-94b9-72b7a1789f92"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("8ff18e61-d161-4d60-87a2-8ae7881c14e7"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("949e219b-e28d-458e-b0aa-b5f85c67562d"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("c9bf1f5b-c68b-4501-bf71-cc9f065cb4de"));

            migrationBuilder.DeleteData(
                table: "TransferPoints",
                keyColumn: "Id",
                keyValue: new Guid("da6572a2-e506-4ae5-b1dd-ec7e322ed5c1"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("322aa444-6fb1-4b22-81da-354019667f75"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("0f00f65f-6ac7-49ad-86ac-9c5a36741992"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("17e7b8a8-48e3-4ce5-9b1b-d628b6e41592"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("1cbf3868-e124-4e6b-a85b-01f1f869222f"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("207f8107-5919-4957-b723-9aa263888b97"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("21a5bf75-7548-49b5-8a05-4379646283d5"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("36ad4322-9a57-40f7-867b-db17dfb7e60a"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("46347cad-e41c-41cd-a61a-e6f398178c8f"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("4e5ebf49-54f8-493e-866f-86077825e749"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("5acb4922-92d4-4a36-b56a-48b261c1aa7a"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("5c4c7a33-4ac9-43eb-98a9-ee3f665ba6d1"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("87b7d7e0-f646-4129-b2e4-43ace2a131de"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("880e3f3c-8836-4576-b550-e9fde68d31e5"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("b2c2d061-5cb8-4126-bae1-a8985def6c93"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("bed8a290-1380-49bc-bcd4-920df2ee5b61"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("c2d1cb86-de01-448e-b2b4-26c69cf80be3"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("d28560f5-c6f8-44e8-b2f9-cbb7f2640f6e"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("dd0185d0-e698-4448-8906-c8b9951b96e1"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("e00a4425-6715-4878-a352-8a4fad4b4e23"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("e12b7ba5-21d6-4514-93c9-56633b174202"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("e18ec75a-ec52-4de1-91c1-e38a20d7a5cf"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("ee24dca3-3153-4172-a815-0699e14ee5f1"));

            migrationBuilder.DeleteData(
                table: "TripPointReviews",
                keyColumn: "Id",
                keyValue: new Guid("eef82b5d-a32d-4709-a827-78f27810c6c4"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("00b0955e-9610-4e67-96a2-4658f6453520"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e78cf3a1-c3a9-446a-9cb5-aad66c0869e9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("11b1af00-5e2e-48fc-b22e-31c1a58be30b"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1bcc3c4e-ea11-470f-84f4-87e413663aee"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2021b739-d41a-43be-90e7-b4a057bf2798"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("2e7838d0-c3d5-464c-9b28-2c97cbe62adf"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("38e37d0e-d870-4a65-8c80-c3e6808cbae6"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4658ba2b-395f-45d4-8400-8f27e8ce95b2"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ab65e5e-36da-4c54-90cd-775fa36833e5"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c0280b9-3007-42b7-bd10-be031e5b49ac"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("61e800b0-f6fa-4223-be18-41a37e9444a9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a4f515e-7aa6-4d28-b1dc-3f6cd187b040"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b62950f-cac4-41c6-b20b-78c2196a3eb9"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("834d04d7-efe3-4c99-aef8-5d6aee9079fc"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("864c464f-3c90-42f3-83b3-31abec960f04"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("934a3eb0-512b-40ad-930e-f2e7a58de2f0"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1b830dc-68db-41f6-a299-441fbf8d1533"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("dad1066f-9795-4a00-a3df-255753f3d481"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("df1cc19b-4691-457f-9b02-e396fcfa8231"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("e42844d7-0fc1-4527-a6a4-03c74aac572b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("051006a6-91d3-4656-8c1c-f61b343055e0"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("2db73173-d512-44cc-ab12-7e0b702a04b1"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("323d7282-c2dc-4df9-87cd-f48400082749"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("4a9ae4ac-c257-42a5-b6ce-a747db359f39"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("5f74588d-069d-4c08-b83d-7f3cd5fccff9"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("7da18893-482d-4250-920f-a3a35328a0ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9774a53a-9eb2-45de-a0e7-495484097f6b"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("9876f981-1891-494b-815d-40d28a5b8f04"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("d22fc313-353b-4eca-9117-955ac920a8ca"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("dd5215df-ed53-40cf-8bc3-ca6ac8587bcf"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("e85f7000-a581-46ca-9252-9b9ee16521b7"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("f294cc06-6a3d-4a25-be9a-368b74642b7a"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("fd93d17a-26d7-4071-ac68-73583be3354b"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5e992a5f-502a-4b73-8dd6-535d2f30a16c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("68a201ca-f5ea-432b-b1ef-190bb68c3419"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("6f8a92f2-0be1-4952-8b29-ddf9f9655a58"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("95bf8ac8-1cc2-4faf-88ed-34594de3ace2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("bafe366e-100d-4074-9b69-e64304e9ec1b"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("bed9a815-2afa-439c-acc5-1f4e0cd6f6eb"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c00e5be9-0a23-4a68-96ea-66e7a5abc4a0"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("c64a35ed-5365-4a43-a478-d6e57e913011"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("ef0b4e60-6c01-4f70-9c02-db59cc65acf0"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("f2322dd8-ba00-42f5-abe7-8b359976d983"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("00ec45ba-df3f-43e3-81dc-426f4b929aa6"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("0dfd2b86-2dee-4230-80cf-1ba8c7b1aa72"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("13c73b67-cc3f-4129-8a9d-6c55a620c766"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("184bad3e-9ae9-4e8a-93e7-5b34586967ff"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("336ffc7a-0f9c-4ed1-9e49-720b2b9645cc"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3bbed6f4-5460-439e-b5b3-6b4609707b70"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("3f65c39e-a19a-410a-8913-e8a65a214994"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("55c64124-e17b-4922-81bd-8ff910fb3b64"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("5e914133-85da-4d45-9e4a-26e583ed6719"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("74875004-2aa5-4c20-b692-e239c5fb9a6f"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("b1137605-cef1-42e1-b888-53f141634187"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("e6710aff-f78f-4e61-adeb-f10101579913"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("ea8d3ff1-0cd7-4789-bf0a-aa8a475386f8"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("edeb45d4-c629-42c6-a48e-305f5ba4b750"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("fb5dc2e9-563e-4709-be54-1b51435122a2"));

            migrationBuilder.DeleteData(
                table: "TripPoints",
                keyColumn: "Id",
                keyValue: new Guid("fc34f1b2-9edf-4e60-aba2-520602726869"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("8f6be2a5-7db9-4005-b252-e4736cfaac96"));

            migrationBuilder.DeleteData(
                table: "CategoryProfiles",
                keyColumn: "Id",
                keyValue: new Guid("f5d484cd-0e84-4e1f-bec8-e68cc3530431"));

            migrationBuilder.DeleteData(
                table: "ConditionProfiles",
                keyColumn: "Id",
                keyValue: new Guid("87e81585-21b0-4d0f-a3e3-eae1cd312936"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("1674e06b-019c-479f-9ea1-89e82e42cb31"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("4fecff68-43ec-4568-ba42-615341c243ae"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("69f7398e-b596-4587-841b-cb8d98a055fb"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d693e75-7c38-49b5-8c46-3a9b3f6e690f"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("abb0c773-c4df-4062-9f50-2531bbe1ac1c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("aca5a758-38c1-4ad9-bf45-26bd9a3c0914"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("cdc58766-5263-4da6-92a5-6ca09d3b3bed"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc4490fe-3a03-4c90-a093-7a5c91472786"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("27cc6f00-7dae-4465-8f12-c1f73ceb5823"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("311c046a-8a85-484e-84fc-85210fdc07a3"));

            migrationBuilder.DeleteData(
                table: "PlaceConditions",
                keyColumn: "Id",
                keyValue: new Guid("b566e6ec-87ee-4b44-b14b-d9a56045da0d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("0d1f5704-d246-4410-bcf1-846d109f8822"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5b3985df-2aa2-4a08-a3b8-95ca3d7bbc0c"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("648f47a2-b4fe-437a-b79f-6afa3a23592f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("6df0caf7-a54a-4371-916f-3dd4daa47d7d"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("8b04966c-1ccb-4860-8600-f3dc66981583"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("8e49a300-7a0b-4801-a35d-7ff185be656f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("92dff543-3914-42d9-9a5b-8cdd8142c5a2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("9a1b2f11-2dd4-4e20-a36d-09415dee31d3"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("b7879409-b368-48dc-aa3d-ba4106344d5f"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("d138987b-de42-4ed2-9115-84ef37581ba1"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("e7549e92-5c33-40f2-b8a3-53ea6d03ea2e"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("f6689b7d-319f-48de-81ef-e0bdb8b0d65f"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("2f6952c7-d7db-467d-9a68-4602edceecc6"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("49f60ec7-9350-44c2-adbb-910f1058c2ec"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("a4bcb065-14f2-4bbe-80b6-acd2a0965458"));

            migrationBuilder.DeleteData(
                table: "TripDays",
                keyColumn: "Id",
                keyValue: new Guid("a5e03678-6329-4fd6-8191-cc0ee6fa1571"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("7de161a9-2a13-4533-a2c1-d19d9c77ef6d"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a0cc894-2d69-4b25-a14c-dba690fa858c"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4e65971-fc09-4ad0-806b-bbccf10ca121"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("2d11ce1c-beba-4d72-be93-a2b6f98763e0"));

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: new Guid("dd47bded-d6c0-4e93-a28b-c69348d32300"));

            migrationBuilder.DeleteData(
                table: "PlaceCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b2aaede-b26c-4f23-b30f-0f155f0425b2"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("5a31a5a7-1905-487c-89f2-193d81a86b3c"));

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Trips");

            migrationBuilder.InsertData(
                table: "CategoryProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "ConditionProfiles",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), "Podstawowy", "c324c822-30c1-7029-7c4f-00799aadf54a" });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), null, "entertainment", null },
                    { new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"), null, "leisure", null },
                    { new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b"), null, "commercial", null },
                    { new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"), null, "natural", null },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), null, "heritage", null },
                    { new Guid("69282965-78a1-4163-a28a-7c330b688c34"), null, "other", null },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), null, "tourism", null },
                    { new Guid("824a9051-cb95-46d5-8995-5420a6af3fae"), null, "activity", null },
                    { new Guid("af8af887-2e25-4edf-86ca-c54430573908"), null, "sport", null },
                    { new Guid("c0e1751b-701d-45d3-a8d7-a3cf86dd4149"), null, "national_park", null },
                    { new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"), null, "religion", null },
                    { new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"), null, "catering", null }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("054c1e5d-2f56-4fb2-8617-310e9ff3855b"), null, "access_limited", null },
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), null, "fee", null },
                    { new Guid("1ce23c66-1b40-4f22-b02f-6609aa59d24d"), "Name property defined for the place", "named", null },
                    { new Guid("2651ead4-0c97-4141-b622-39fb1b8cce8e"), "Places where you can buy or eat vegan food", "vegan", null },
                    { new Guid("30788876-73cf-4fed-98b4-dc4e83bcb2b5"), "Places where you can buy or eat organic food", "organic", null },
                    { new Guid("3837d52a-adb1-4c86-ab1c-3ad79dd19c86"), "Places where you can buy or eat gluten free food", "gluten_free", null },
                    { new Guid("4b449869-57d0-4fe4-9f2b-676402d89967"), "Places where you can buy or eat halal food", "halal", null },
                    { new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e"), null, "access", null },
                    { new Guid("61dffa8a-3270-486a-b628-2392a41b27c5"), "Places where you can buy or eat sugar free food", "sugar_free", null },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), null, "wheelchair", null },
                    { new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b"), "There is no fee or it's not specified", "no_fee", null },
                    { new Guid("822a74ae-7e39-4bb8-8cd2-39fc729e59ad"), null, "no_dogs", null },
                    { new Guid("937b2203-3282-4abf-b885-8ce74231d594"), "Places where you can buy or eat vegetarian food", "vegetarian", null },
                    { new Guid("b0011601-c240-4508-8cec-e6a35bf0e863"), "Places where you can buy or eat kosher food", "kosher", null },
                    { new Guid("de1385b2-ffee-4562-b818-759a4ecf6250"), null, "internet_access", null },
                    { new Guid("edad88d7-3158-4ad5-9cc8-f01304b5ed06"), "Places where you can buy or eat egg free food", "egg_free", null },
                    { new Guid("f1e67864-3da2-4172-b4dd-7d57bc0083d6"), "Places where you can buy or eat soy free food", "soy_free", null },
                    { new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296"), null, "dogs", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("076737d2-16b9-489c-b157-39f97aba1af2"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("07989400-6725-4976-a1ec-77ca23b74255"), "Wrocław", "Poland", "9", 51.11288660m, 17.02688220m, "Muzeum Archeologiczne", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "5133d879c0e106314059f2ec6d11738e4940f00103f901710a264c000000009203154d757a65756d2041726368656f6c6f6769637a6e65", "Lower Silesian Voivodeship", "Antoniego Cieszyńskiego" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("09afec0e-1382-4578-8ffd-000971cbbc19"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("1c6cc576-778a-4808-954c-c046472c7036"), "Wrocław", "Poland", null, 51.10957585m, 17.03206577m, "Ratusz", "We-Sa 10:00-17:00; Su 10:00-18:00", "ProviderPlace", "51b849627635083140596870d894068e4940f00102f90138ce3f330000000092030652617475737a", "Lower Silesian Voivodeship", "Rynek Ratusz" },
                    { new Guid("1e70f971-a497-42c8-a563-23a68447418e"), "Wrocław", "Poland", "1", 51.10688750m, 17.07731849m, "Hala Stulecia", "Su-Th 09:00-18:00; Fr-Sa 09:00-19:00", "ProviderPlace", "5159f5f324cb1331405964c6547dae8d4940f00102f90136e6691c0000000092030d48616c61205374756c65636961", "Lower Silesian Voivodeship", "Wystawowa" },
                    { new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"), "Raszków", "Poland", null, 51.7165523m, 17.7274935m, "Jana Pawła II", null, "ProviderPlace", "51768d96033dba314059315a59fcb7db4940f00103f901262f10ed0100000092030e4a616e6120506177c58261204949", "Greater Poland Voivodeship", "Kościelna" },
                    { new Guid("32a817b9-6d03-4311-807b-d3d993feaca5"), "Wrocław", "Poland", null, 51.10897760m, 17.03266890m, "Wrocław", null, "ProviderPlace", "51dfc081e697fa30405906310a6025904940f00101f901bce3060000000000c0020992030857726f63c5826177", "Lower Silesian Voivodeship", null },
                    { new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"), "Wrocław", "Poland", null, 51.10432090m, 17.03133350m, "Bolesław Chrobry", "24/7", "ProviderPlace", "51eac4e5780508314059b43e21635a8d4940f00103f901ace8111000000000920311426f6c6573c5826177204368726f627279", "Lower Silesian Voivodeship", null },
                    { new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"), "Wrocław", "Poland", null, 51.10248345m, 17.08599881m, "Kościół Najświętszej Maryi Panny Matki Pocieszenia", null, "ProviderPlace", "51324592040416314059a36a7b2d1e8d4940f00102f9010d300706000000009203374b6fc59b6369c3b3c582204e616ac59b7769c49974737a656a204d617279692050616e6e79204d61746b6920506f636965737a656e6961", "Lower Silesian Voivodeship", "Edwarda Wittiga" },
                    { new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"), "Ostrów Wielkopolski", "Poland", null, 51.6550975m, 17.8059913m, "Samolot MIG", null, "ProviderPlace", "514b5c227255ce314059cd461f3cdad34940f00103f901c95100f70000000092030b53616d6f6c6f74204d4947", "Greater Poland Voivodeship", "Raszkowska" },
                    { new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"), null, null, null, null, null, "Kaplica loretańska", null, "ProviderPlace", "51429f46469ebd314059b810faa9f1dd4940f00102f901f7527713000000009203134b61706c696361206c6f72657461c584736b61", null, null },
                    { new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"), "Raszków", "Poland", "32", 51.71827680m, 17.72748940m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, "ProviderPlace", "51c92fcdbe3cba31405921e7807ef0db4940f00103f901e5860fed0100000092033e426f68617465726f6d204920776f6a6e7920c59b776961746f77656a206920506f6c6567c582796d207a6120576f6c6e6fc59bc487204f6a637a797a6e79", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), "Ostrów Wielkopolski", "Poland", "15", 51.6494557m, 17.8174638m, "Bistro Bravo", "Mo-Th 12:00-24:00; Fr-Su 12:00-24:00+", "ProviderPlace", "51f4a9be4e45d13140596108465d21d34940f00103f901d44b66110100000092030c42697374726f20427261766f", "Greater Poland Voivodeship", "Rynek" },
                    { new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"), "Wrocław", "Poland", null, 51.10864425m, 17.07875630m, "Wrocławska Fontanna", "May-Oct: 00:00-24:00; Nov-Apr: Off", "ProviderPlace", "51299d5f5f291431405946ac040ee88d4940f00102f901e25aa7020000000092031457726f63c5826177736b6120466f6e74616e6e61", "Lower Silesian Voivodeship", null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("9a0ddf04-1fc7-40a0-99d2-a52ea24c3edb"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null },
                    { new Guid("aea1d075-f00d-4966-bb07-09cc2f5ddd4a"), "Raszków", "Poland", null, 51.711806m, 17.721194m, "Zalew", "CustomPlace", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), "Wrocław", "Poland", null, 51.10994465m, 17.07986499m, "Ogród Japoński", "Apr-Oct: Mo-Su,PH 09:00-19:00", "ProviderPlace", "51d8ce250872143140598b6890aa128e4940f00102f9014c34de0f000000009203104f6772c3b364204a61706fc584736b69", "Lower Silesian Voivodeship", "aleja Dąbska" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("be0b4d83-d85d-4ab5-bec0-d0c912a71e18"), "Przybysławice", "Poland", null, 51.707396m, 17.720968m, "Kościół w parku", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[] { new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), "Wrocław", "Poland", "1-5", 51.10425535m, 17.07484842m, "ZOO Wrocław", "Mar: Mo-Su 09:00-16:00; Apr-Sep: Mo-Fr 09:00-17:00; Apr-Sep: Sa,Su,PH 09:00-18:00; Oct: Mo-Su 09:00-16:00; Nov-Feb: Mo-Su 09:00-15:00", "ProviderPlace", "513a952f4429133140591ab1413d588d4940f00102f901012324020000000092030c5a4f4f2057726f63c5826177", "Lower Silesian Voivodeship", "Zygmunta Wróblewskiego" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "PlaceType", "State", "Street", "SuperCategoryId" },
                values: new object[] { new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"), "Ostrów Wielkopolski", "Poland", null, 51.6514858m, 17.810879178559084m, "Parowóz TKi3-120", "CustomPlace", null, null, null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "Latitude", "Longitude", "Name", "OpeningHours", "PlaceType", "ProviderId", "State", "Street" },
                values: new object[,]
                {
                    { new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"), "Ostrów Wielkopolski", "Poland", null, 51.652452m, 17.8150573m, "Pomnik 60 Pułku Piechoty", null, "ProviderPlace", "51b6dd5f98a7d031405953490f8c83d34940f00103f901c3b040f600000000920319506f6d6e696b203630205075c5826b752050696563686f7479", null, null },
                    { new Guid("da044dbf-0f05-493d-a498-27156beeca18"), "Moszczanka", "Poland", null, 51.73196580m, 17.76554860m, "Moszczanka", null, "ProviderPlace", "51a37f38fefac33140592e652a0eb1dd4940f00103f9010828e50100000000c0020792030936332d3434302b706c", "Greater Poland Voivodeship", null },
                    { new Guid("f282d667-d800-4009-9e50-8e8f3cf67113"), "Wrocław", "Poland", "35", 51.10744710m, 17.02887780m, "Muzeum Historyczne i Muzeum Sztuki Medalierskiej", "We-Sa 11:00-17:00; Su 10:00-18:00", "ProviderPlace", "51979416896407314059ca9f98d3c08d4940f00103f9010992932b020000009203304d757a65756d20486973746f7279637a6e652069204d757a65756d20537a74756b69204d6564616c696572736b69656a", "Lower Silesian Voivodeship", "Kazimierza Wielkiego" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProfilePlaceCategory",
                columns: new[] { "CategoryProfileId", "PlaceCategoryId" },
                values: new object[,]
                {
                    { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") }
                });

            migrationBuilder.InsertData(
                table: "ConditionProfilePlaceCondition",
                columns: new[] { "ConditionProfileId", "PlaceConditionId" },
                values: new object[] { new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("08cc3914-f217-47b0-9a60-848f002837c3"), null, "ice_cream", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("0b13c9c2-d128-44f8-9186-f6a9de63318e"), null, "forest", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("0ba72609-b79f-44e4-8380-26c041a93053"), null, "pub", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("117503b7-014f-4c85-950e-68140b86a670"), null, "gift_and_souvenir", new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b") },
                    { new Guid("195c2f29-6a95-4da5-8637-f05892583cb0"), null, "mountain", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("1d2725bd-c96a-4a10-917c-0dc8af9e4768"), null, "aquarium", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"), null, "restaurant", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f"), null, "culture", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), null, "attraction", new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), null, "sights", new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3") },
                    { new Guid("68b0c129-7b2a-49d0-9aeb-c6f7d7daf73a"), null, "sand", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("69f51b64-8e50-4f68-ae19-f8bbbc33aef0"), null, "taproom", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("74ed3423-a4c4-4b63-a1d0-2acc15c2689b"), null, "biergarten", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"), null, "unesco", new Guid("65156b12-b55d-4e2e-8344-41f149eb4925") },
                    { new Guid("a14d0b28-a448-414d-acfc-7037c12906c6"), null, "bar", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("a2fa84cc-b2e9-40da-9ecd-110717b4433b"), null, "stadium", new Guid("af8af887-2e25-4edf-86ca-c54430573908") },
                    { new Guid("af0d7109-d550-4537-8b51-affb642297b2"), null, "cafe", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a"), null, "fast_food", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("bbda8310-c9a6-4a0e-a44b-93aad421895e"), null, "planetarium", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"), null, "place_of_worship", new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868") },
                    { new Guid("da2a75c1-f704-470b-a7e3-e2e83a5715d9"), null, "food_court", new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe") },
                    { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), null, "museum", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") },
                    { new Guid("e80583c1-fb35-492f-828a-45441253fc43"), null, "water", new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3") },
                    { new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"), null, "park", new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402") },
                    { new Guid("e99d71b0-5e47-4b97-85d2-88b29e7ad9f4"), null, "art", new Guid("300a9809-d88a-47ef-b14e-8a9a6db5dc6b") },
                    { new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"), null, "zoo", new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473") }
                });

            migrationBuilder.InsertData(
                table: "PlaceConditions",
                columns: new[] { "Id", "Description", "Name", "SuperConditionId" },
                values: new object[,]
                {
                    { new Guid("2252e854-7c22-41d8-85ca-859d2a716b54"), null, "only", new Guid("4b449869-57d0-4fe4-9f2b-676402d89967") },
                    { new Guid("41db4974-d535-4d5c-8733-09ddea0c34cb"), null, "only", new Guid("30788876-73cf-4fed-98b4-dc4e83bcb2b5") },
                    { new Guid("4b8f3174-fc4e-4896-8b7d-3783319e027b"), null, "not_specified", new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), "Places that are available for public", "yes", new Guid("5865a59f-ff2c-40b4-ad5a-e4eee77b2f7e") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), null, "limited", new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") },
                    { new Guid("65c4d2b2-e6a7-4c66-8249-94d8f7463539"), null, "not_specified", new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), null, "yes", new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296") },
                    { new Guid("8bb82328-5dbf-414e-bcdc-c22aeefca54c"), null, "only", new Guid("b0011601-c240-4508-8cec-e6a35bf0e863") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), null, "yes", new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f") },
                    { new Guid("c1db5cb5-25ef-4286-bc20-b602eeb18b6b"), null, "for_customers", new Guid("de1385b2-ffee-4562-b818-759a4ecf6250") },
                    { new Guid("c73a511c-fca8-40f0-b39b-021d0440cafb"), null, "only", new Guid("937b2203-3282-4abf-b885-8ce74231d594") },
                    { new Guid("d3ad5bdd-0ec0-47f1-9530-341f255cb427"), null, "only", new Guid("2651ead4-0c97-4141-b622-39fb1b8cce8e") },
                    { new Guid("d3f9041e-420f-4ee1-a267-837b8baeb63f"), null, "no", new Guid("77cc2cc5-7c56-4690-8689-f3ef38d0614b") },
                    { new Guid("d5629a3f-e5ac-4687-967e-ad3ad69787df"), null, "customers", new Guid("054c1e5d-2f56-4fb2-8617-310e9ff3855b") },
                    { new Guid("d88cdd99-2402-4ba4-a1f4-b05f9a75d1b5"), null, "free", new Guid("de1385b2-ffee-4562-b818-759a4ecf6250") },
                    { new Guid("ed1ab986-6da8-4a11-a229-107baf578281"), null, "leashed", new Guid("fde4d999-7fb1-4862-aaca-9bfe5581c296") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") },
                    { new Guid("06f5f508-952d-4dc5-abaa-4fdc4ecc1473"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("1fb666e4-7832-4923-9af7-ec98be8b2402"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("37ea2d4e-d56a-42f2-9409-092f992584a3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("65156b12-b55d-4e2e-8344-41f149eb4925"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("6de08d43-acfe-4aa9-9e24-6c47296a8fa3"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") },
                    { new Guid("c6c0dc62-9c5a-4ea5-980f-27cec8258868"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("dfeb4e83-e314-4326-ab56-390de97e8efe"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("14baa244-c331-41f8-b2a6-8f778702dcdc"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") },
                    { new Guid("6e240d58-ecf4-4a13-94a5-db78f8df746f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a97dea-1347-44a7-acf2-16e8956d43d2"), 25m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("1c6cc576-778a-4808-954c-c046472c7036"), 4m, null, "0ef31cb3-e48e-4799-a460-391da39ccb47" },
                    { new Guid("193b8039-c7a4-48de-a3a3-a0d2351a3654"), 20m, new TimeSpan(0, 0, 50, 0, 0), "PLN", 1m, new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), 5m, null, "25dfbbfe-9aba-4d77-8457-ad753d71318b" },
                    { new Guid("2054631d-b31c-4038-ba13-0e2f231a29c4"), 10m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("07989400-6725-4976-a1ec-77ca23b74255"), 3.5m, null, "328793f4-2f3d-4a53-9403-926667fc61f2" },
                    { new Guid("28a809c3-2991-476b-965b-541c9cd80c27"), 20m, new TimeSpan(0, 0, 30, 0, 0), "PLN", 1m, new Guid("1e70f971-a497-42c8-a563-23a68447418e"), 5m, null, "77b3590e-1f18-4260-87a5-e005e3bb0da3" },
                    { new Guid("2bef4837-2fe9-4937-bb96-e13007a35a74"), 100m, new TimeSpan(0, 1, 45, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 4.5m, null, "49889cd9-ee66-49df-bffb-48144249ef5d" },
                    { new Guid("30babcf1-0e4c-4e80-a0a8-e9bf3c3fd211"), 14m, new TimeSpan(0, 1, 10, 0, 0), "PLN", 1m, new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), 5m, null, "3aa3cd1a-deb5-4568-be3b-7997378cd923" },
                    { new Guid("30f9b4a8-3829-46fa-980e-9860e3aa6022"), 5m, new TimeSpan(0, 0, 8, 0, 0), "PLN", 1m, new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"), 4m, null, "d2d8eef9-47a8-489e-bc9a-20f3d3de812e" },
                    { new Guid("3a50037a-02ba-4ad1-8a48-66e499e6c729"), 75m, new TimeSpan(0, 2, 0, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 5m, null, "90ded25c-90c8-4947-8864-b77a9acf51b9" },
                    { new Guid("40cb2e38-bb8d-46f2-98b6-4f1c74dcdb48"), 0m, new TimeSpan(0, 0, 7, 0, 0), "PLN", 1m, new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"), 5m, null, "808cd363-8a33-45b9-82ba-eebe021c26e0" },
                    { new Guid("49090605-1fa0-45d9-9a11-472bd5482619"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778"), 3.5m, null, "a65b8292-e780-48d8-973b-d45057ffa389" },
                    { new Guid("80f18f18-b4b5-4b91-919e-c77ea3b117a9"), 80m, new TimeSpan(0, 1, 30, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 4m, null, "40eb2d40-86c8-4358-977a-07a04fc0a9f0" },
                    { new Guid("9978502b-a95d-4a61-af6e-122b0a1f7aff"), 15m, new TimeSpan(0, 0, 35, 0, 0), "PLN", 1m, new Guid("07989400-6725-4976-a1ec-77ca23b74255"), 4m, null, "04b65761-5489-4dd9-a534-1493ec8204b4" },
                    { new Guid("afe43f25-0e27-442f-a357-35279fdad74c"), 17m, new TimeSpan(0, 0, 25, 0, 0), "PLN", 1m, new Guid("1e70f971-a497-42c8-a563-23a68447418e"), 5m, null, "93d98a2a-bf84-4649-9dc6-5cce8c9d71a7" },
                    { new Guid("b94c6142-70d9-4dff-96cc-6da6f6c2c5a5"), 0m, new TimeSpan(0, 0, 5, 0, 0), "PLN", 1m, new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97"), 5m, null, "8f483cbb-e6a6-450d-92af-d353203ff9d1" },
                    { new Guid("c5e43721-9435-4bc7-9ca6-ab0bd1d194c8"), 0m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"), 4m, null, "638bd700-6b24-4f21-95d9-d1f94d57a95d" },
                    { new Guid("c7ca1758-6264-40b6-9b61-58f0cf86ebc2"), 14m, new TimeSpan(0, 1, 20, 0, 0), "PLN", 1m, new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5"), 5m, null, "aef4af29-be4f-4d6d-bd22-50cd00019fdb" },
                    { new Guid("c8997bd5-e449-4d01-96e0-758eae15aa28"), 85m, new TimeSpan(0, 1, 37, 0, 0), "PLN", 1m, new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce"), 5m, null, "7b87c90b-5f6d-411d-86c2-f25a7a33bbb1" },
                    { new Guid("d069a5c7-3f6c-48dd-8a7f-fb7538a157ba"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("1e70f971-a497-42c8-a563-23a68447418e"), 4.5m, null, "3c8a78b9-4c27-4b09-b9e0-657a64e3f4af" },
                    { new Guid("d723542b-2c5a-4a60-9dcf-0fbdac053fa6"), 30m, new TimeSpan(0, 0, 20, 0, 0), "PLN", 1m, new Guid("1c6cc576-778a-4808-954c-c046472c7036"), 3m, null, "884de7d6-cad5-4992-81bf-548f37018396" },
                    { new Guid("f4559608-4d94-4790-bd6f-281a38a91461"), 0m, new TimeSpan(0, 0, 15, 0, 0), "PLN", 1m, new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4"), 4.5m, null, "c55f773f-6b4f-4827-ad99-999576c8eeda" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "CategoryProfileId", "ConditionProfileId", "CurrencyCode", "DestinationId", "EndDate", "ExchangeRate", "Name", "NumberOfTravelers", "StartDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("44609932-1913-412e-9682-ee17fab551a1"), 200m, new Guid("45668788-b90b-47a0-b0fa-56b4436ad3d8"), new Guid("68d29256-4bcd-4609-9749-25a68ce199f5"), "PLN", new Guid("32a817b9-6d03-4311-807b-d3d993feaca5"), new DateOnly(2025, 12, 6), 1m, "Wycieczka do Wrocławia", 1, new DateOnly(2025, 12, 6), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7"), 100m, null, null, "PLN", new Guid("da044dbf-0f05-493d-a498-27156beeca18"), new DateOnly(2024, 12, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 12, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9"), 100m, null, null, "PLN", new Guid("da044dbf-0f05-493d-a498-27156beeca18"), new DateOnly(2024, 11, 21), 1m, "Wycieczka do Moszczanki", 1, new DateOnly(2024, 11, 20), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("0126b355-6f1d-4d65-baa4-df9f725656d7"), null, "gallery", new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f") },
                    { new Guid("0168dfdd-b23f-474f-9bcf-a435ddba8cb9"), null, "wings", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("01c5086c-1e1d-4804-9b0b-ae9b18ad8807"), null, "caribbean", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("01ce27ed-3189-42ef-816c-e64b963f2fa0"), null, "taiwanese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("046b33d9-8b9c-4ef1-8e76-02232bceb9d5"), null, "battlefield", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("055e9136-7904-4b2f-9f2c-e9fc0b65a094"), null, "curry", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("065c53eb-a19f-46cd-b0fb-7e165b17b64d"), null, "hawaiian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("07fd6909-b4e5-4fb1-b307-d7fe7141e8a5"), null, "croatian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("08cf52df-3bf6-499b-96b5-54f4d8d8e2f0"), null, "archaeological_site", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"), null, "christianity", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("0c2b9ca9-59b7-4502-a6d8-ca12d88946d4"), null, "cave_entrance", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("0c37c56a-7eab-41d5-97cb-393558c6654d"), null, "fort", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("0cf3fa9d-cf26-4cb2-a77c-5c250ca16d7a"), null, "uzbek", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("0f4534ff-4f24-4f7d-8474-6f686a4b77e4"), null, "artwork", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("1056f1f8-8cf2-4523-8553-28e631d52fec"), null, "bridge", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("116c209a-c3e2-4f55-bc8a-39b2f70ebc03"), null, "salad", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("11f382c1-9019-43ca-a323-40ffcb4846f0"), null, "donut", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("12ad7960-6fd4-47b6-8b40-d4d3e0130a5f"), null, "kebab", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("13bfd3dc-abb6-4f9e-9df1-622be15faa64"), null, "reef", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("15af10de-7037-409e-9970-94f0a77377cb"), null, "african", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("16cad34c-5dce-4710-819a-530da999b184"), null, "fish_and_chips", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("17c05f8b-ce87-40bb-bf5c-d254a67c8558"), null, "arab", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("17f85471-d607-4fdb-ae84-5076dc9f32bd"), null, "tacos", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("18e97a14-3ca6-430a-adee-395a9bb0a157"), null, "western", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("1a55c164-2126-4bfc-99a7-32905023c89e"), null, "geyser", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("1b995dc2-5f5f-4d95-baec-c36b638bc2a0"), null, "crepe", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("20edc26f-539b-430c-a5f8-e74a4c152655"), null, "european", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("25451861-2605-43b8-a19e-8335ca4e013f"), null, "belgian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("26a70dbb-9fe6-4c31-88aa-9c9175a64c36"), null, "lighthouse", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("28184ebf-d6b3-4c24-a0a4-cceafb897086"), null, "ramen", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("28d9bfb8-cc35-4529-9335-f215d4c9199f"), null, "czech", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("2edb7842-63c3-47b2-a134-2e36078c45ad"), null, "beef_bowl", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("321ab057-22a7-47fc-ac72-8464c2c8d96b"), null, "islam", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("36f50eca-a3cc-4f23-a4f4-b457f6e2f705"), null, "ethiopian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("38590d77-ae64-447f-82ad-4e497c23afc3"), null, "multifaith", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("38aaae4c-c1f9-43fd-b695-908ace5fc2bd"), null, "city_gate", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("38ab4808-e9b4-475b-8f4f-efb5b307ceea"), null, "moroccan", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("3c422a5d-31be-4803-a24f-c4beea2638ba"), null, "nature_reserve", new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf") },
                    { new Guid("3d984a1c-2297-4bc9-96c8-aedcca0939ac"), null, "thai", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("419eced0-4518-4220-90f3-6863accf4f9e"), null, "georgian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("41ae3a96-7efd-4789-846d-28527d28977e"), null, "tapas", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4363b2af-5f65-42ca-931a-4a5050d7491c"), null, "burger", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("46cd0446-ab4a-40c5-9318-b7232adeda52"), null, "chinese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4a280d10-e352-4d8b-9bc5-43feb1b4fe72"), null, "soup", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("4a77bc45-b094-4ad0-b6c4-41c15b44b600"), null, "friture", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4acf6e56-4121-4371-a799-6a910119cfd1"), null, "indian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4b2c8d4f-1c96-44e6-950c-e2cdb2a2f71f"), null, "french", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4cf4196d-43d4-443b-a3e9-c9005d2d80a8"), null, "balkan", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("4df95354-121a-4f30-9947-271c60f6de30"), null, "spring", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("4e565498-7b82-4a9f-aad8-2c1e0bc8d9b4"), null, "monastery", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("55367cdc-ed3f-4a79-bcff-a990ac590ddd"), null, "frozen_yogurt", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("56225a55-c6dd-47c8-a6bf-01e74e200cf2"), null, "noodle", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("5bc4a1ed-c117-454c-856c-ea26dab74428"), null, "turkish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5c1c5e8f-6d5f-4ca2-bd1c-087ea29cf38d"), null, "danish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5c80b244-7229-47a5-86ad-da2f2da61963"), null, "asian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5cbcc5d1-d7c1-4b94-8516-ba7d0df77e95"), null, "argentinian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5e2029dd-e171-484c-87e1-02ca1c13d2fa"), null, "italian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("5fea80b5-0d90-4eb2-b830-b9ca8fe6d4ab"), null, "indonesian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("616842da-f458-4b93-bbd4-a024bb018a30"), null, "coffee", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("62b78d55-5d36-4eb7-a9ad-8d10e53fd765"), null, "tex-mex", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("62bf80f5-f610-4489-b62e-99422475a86c"), null, "hot_dog", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("63de6e24-42c9-48e3-b14e-1e95b6f60f49"), null, "ramen", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("664eed32-ce6f-4325-b65e-ed037cfb5fe2"), null, "coffee_shop", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("67117fa3-d333-40c5-9257-e36853ec8f18"), null, "buddhism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("676c4e49-cf10-4544-845f-ae7179961166"), null, "cake", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("6779f792-ac5d-48d0-87b6-430f8ae52193"), null, "brazilian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("691f025a-ea50-4c1f-801e-5822622248f8"), null, "windmill", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("6b5d23f5-6b6a-4e19-8763-ebcca7bd04f8"), null, "cuban", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6d07bbbd-9e1a-4534-a65b-b2da9404988c"), null, "steak_house", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6e4e3ffc-3cb6-425e-9017-73464e85dcb2"), null, "malay", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6f69cea0-38c1-4b94-af21-b5b6d2e38096"), null, "afghan", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("6fa0f10e-64c1-47c1-98e6-c06b8d75c45c"), null, "chicken", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("702a29fb-72fb-498c-8e0e-3ec05bf5381a"), null, "noodle", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("71aa1f04-b071-439b-bd64-9463eb02ca6c"), null, "korean", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("72dd952e-756c-4db0-a522-f38a3c7844d9"), null, "soup", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"), null, "garden", new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf") },
                    { new Guid("73cac96d-76ad-4228-9d6e-456b898fc47e"), null, "dumpling", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("772cf39f-b185-48f4-8809-b1854e429a6c"), null, "regional", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("777f4839-4e56-46ad-b4dd-87516a61e9e2"), null, "nepalese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("7aa1a097-be64-484b-a280-b64e87c6c22d"), null, "theatre", new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f") },
                    { new Guid("7ba18aba-c3fb-4f85-aefb-1ad064bc8322"), null, "seafood", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("7bae482d-d487-4f6d-b1a6-af6a8b6eb1be"), null, "portuguese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("7cd67dbd-211f-45af-842c-517fb143d427"), null, "rock", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("7e57978a-2a11-4416-aa2e-2fecc617bacf"), null, "sikhism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("7e9e5b63-d9c6-4a36-bfcb-7a7247f4477f"), null, "international", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("82e4b38b-ac1c-478a-9cbd-bb99a216088a"), null, "vietnamese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("83883b63-d6e9-4f31-b9ac-1616e99e0060"), null, "castle", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("83d6c6be-0525-4dba-a607-927ed8f52d47"), null, "tea", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("85e46b8c-a538-4eb6-b1af-b68fa4c777c7"), null, "glacier", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("860501f2-bbaf-4eaf-b567-45230f5a854b"), null, "tacos", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("89d19266-7810-46ba-bcae-fd029692046e"), null, "fountain", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("8ab7915a-765b-452b-88ac-759e3e4dbd40"), null, "swedish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("8b77d44e-2e2d-4d86-8a27-f6cb5311c53c"), null, "pizza", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("8df7ecc4-0f73-49d0-a042-3a9a6473998b"), null, "lebanese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("8f04736b-88dd-4f29-8fdf-969061551261"), null, "sandwich", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("920d9df6-eeb1-45b7-93c3-6f551e96f781"), null, "pita", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("95212037-5b17-44db-b428-faac48a381c9"), null, "austrian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("9863d8b1-d870-427a-ae43-53f8e4f8d25e"), null, "mediterranean", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("99ff2070-d0d5-45d4-b1ab-5844ed17fbf1"), null, "city_hall", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("9a31b172-a604-4385-9f4b-0456f78fce45"), null, "chili", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("9b0ae92e-f413-4307-8469-4ae39763a68d"), null, "cliff", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("9b5a3108-da70-49f8-8583-d658ab9f480e"), null, "syrian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"), null, "ruines", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("9c8295ec-3c6f-4f0c-a90e-04a7246f6b2a"), null, "arts_centre", new Guid("318394e1-56b4-4a3c-a6fb-fa0c7215122f") },
                    { new Guid("9e08208a-62a5-48d2-831e-0a648b21ba51"), null, "sandwich", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("9fed8c4a-a02d-49e5-a0bf-7cebd7689221"), null, "fish_and_chips", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("a27e3c60-a9b7-4063-b9fa-cbd891d89861"), null, "ice_cream", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("a2d83129-d2c3-4a30-a73e-ae1495776a56"), null, "pizza", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("a3048f41-31c5-4f9f-9ebe-113ea6a92251"), null, "barbecue", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("a65bf379-0463-4cfb-8ee4-3a416fce3227"), null, "clock", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("a8ab258d-2ed1-4549-8252-f5d095e8a25f"), null, "kebab", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("ac954a86-9eb7-4ad1-92e5-f721838a6e4a"), null, "dessert", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("ad1354ce-cf5f-409b-8e11-8e559e862546"), null, "jamaican", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("ae2b912a-1d1d-4965-9c77-8791a402532a"), null, "peruvian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("b3756827-83aa-4861-a456-2325966c1893"), null, "hungarian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("b420764f-a6d8-4400-8228-fe33ce4a2b6c"), null, "oriental", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("b9cd7bb4-7760-4c57-bbf6-5b7f33dfee2d"), null, "shinto", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), null, "memorial", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("bd9f78a2-7d71-43ca-ab8d-2c58f3cdc051"), null, "latin_american", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("bf39d4b4-76be-4344-aba5-403bfad4fe83"), null, "waffle", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("bf4b9bb2-a715-47a6-9411-a1a64fded83a"), null, "viewpoint", new Guid("511b1c02-92a9-4157-8760-35b25407b752") },
                    { new Guid("c25db3ee-36fc-4753-8118-adf025dc545e"), null, "ukrainian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("c35b7c22-2e96-4960-970a-7a1c95072b50"), null, "bolivian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("c45b3112-885e-4536-bec5-26c55eb85589"), null, "bavarian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("cef013f5-8cf0-4812-8b8b-dd89f1a5b26a"), null, "sea", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("d3ffbaa8-175e-44b5-9660-50263497edcc"), null, "burger", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("d4194cd1-2b90-4336-93d7-47a2117845ce"), null, "dune", new Guid("68b0c129-7b2a-49d0-9aeb-c6f7d7daf73a") },
                    { new Guid("d8866c2a-8e3f-4674-9a45-e7c4ffe5e821"), null, "wings", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("d9b805f8-82a3-4cc3-b09e-743c75da6b53"), null, "sushi", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("e047a8ae-b475-49f6-a1d3-0f3744fc1cba"), null, "hinduism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("e0b5dac3-3109-4e6c-8e99-a286343f95c7"), null, "peak", new Guid("195c2f29-6a95-4da5-8637-f05892583cb0") },
                    { new Guid("e2fa4130-1244-4a2b-99af-0a4a55353a3b"), null, "pita", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("e3bcd580-f240-4114-9665-d3d8c6ceb391"), null, "greek", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("e76af9b6-2612-42ac-9b12-fbb40278db22"), null, "irish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("e7a4045a-44e7-4502-87b9-da4111f116dd"), null, "russian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("ecb4aa2e-f6b0-48ee-8f01-62c2a35b7a25"), null, "malaysian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("edae1a3a-7fb1-4786-9400-09fde31d49c4"), null, "persian", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("ee3371ed-5ac0-47ab-8e0f-9f8104d0ee9a"), null, "hot_spring", new Guid("e80583c1-fb35-492f-828a-45441253fc43") },
                    { new Guid("efeb3f4d-2c29-4251-a4c8-a5c7aa0a28f0"), null, "tower", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("f204e07d-57c6-42cf-bf0e-8c3cb459f6d0"), null, "german", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f4f2d192-f326-47d8-85f5-b1fc47016f3e"), null, "japanese", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f621a46b-5df6-4179-9303-3ced690aa344"), null, "judaism", new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2") },
                    { new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"), null, "place_of_worship", new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551") },
                    { new Guid("f8d4b314-3bdc-46f1-9ac7-09b68a9daa2d"), null, "pakistani", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f94992cd-8c9c-4da3-bbd0-aef3d12049ee"), null, "fish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("f9f46c35-c17f-48e2-a3b8-ecff8172daf5"), null, "tapas", new Guid("b2d4c0cd-d940-4c54-a3e2-a09880a7469a") },
                    { new Guid("fa7fff4a-41e7-4049-a4ce-760a9bfa7e45"), null, "mexican", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("fb6d1113-680d-41ba-a449-f09ac7c8e94f"), null, "american", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("fbaf9948-24e0-4685-b313-60d1e57740f5"), null, "bubble_tea", new Guid("af0d7109-d550-4537-8b51-affb642297b2") },
                    { new Guid("fd80e5df-397b-4b09-ae23-4f3af5306403"), null, "spanish", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") },
                    { new Guid("fd869253-419d-4195-bed8-2e90c0eff5b8"), null, "filipino", new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("30404c27-3f07-45ce-9f34-058c9cc355e1"), new Guid("977c8178-9039-47ff-ad5b-98373b292abc") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("511b1c02-92a9-4157-8760-35b25407b752"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") },
                    { new Guid("5764b4ea-f364-4aff-b095-d5b7d1e3e551"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") },
                    { new Guid("81cd1d0a-8eb4-42e0-9920-2c90a0ceefdb"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("c0317d66-8ba3-4173-9550-5b52ccbc15b2"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("e1c4ec55-b790-458f-a4bf-40aaf035e702"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("e80583c1-fb35-492f-828a-45441253fc43"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("e8c1f874-bc49-474f-8dd8-7e2bab92aebf"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("f5975d83-d5c0-457f-9e79-987e572f50bd"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCondition",
                columns: new[] { "PlaceConditionId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("5f75f368-d0d1-4b94-b775-b8b760aed5df"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("64738042-1334-4889-b98f-09e6e4f257db"), new Guid("c3636533-a9d9-4e08-98eb-19f92fd574ce") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("7875ec0e-799f-4abf-b519-70656bc18167"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("07989400-6725-4976-a1ec-77ca23b74255") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1c6cc576-778a-4808-954c-c046472c7036") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("1e70f971-a497-42c8-a563-23a68447418e") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("ad332da8-4b11-4a64-90f2-d1f1fe645b5f"), new Guid("f282d667-d800-4009-9e50-8e8f3cf67113") }
                });

            migrationBuilder.InsertData(
                table: "TripDays",
                columns: new[] { "Id", "Date", "TripId" },
                values: new object[,]
                {
                    { new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd"), new DateOnly(2024, 12, 21), new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7") },
                    { new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93"), new DateOnly(2024, 12, 20), new Guid("9ea3d559-e80c-455c-a7dc-ca654cc58ce7") },
                    { new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3"), new DateOnly(2024, 11, 20), new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9") },
                    { new Guid("9cc42d97-9d65-43ee-8ec8-df1ebf2aab6a"), new DateOnly(2025, 12, 6), new Guid("44609932-1913-412e-9682-ee17fab551a1") },
                    { new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa"), new DateOnly(2024, 11, 21), new Guid("bc3e7c63-e650-4f61-88ba-c3ae17a438a9") }
                });

            migrationBuilder.InsertData(
                table: "PlaceCategories",
                columns: new[] { "Id", "Description", "Name", "SuperCategoryId" },
                values: new object[,]
                {
                    { new Guid("02ef024c-503c-4ac2-8b9e-f4622e38c7f6"), null, "temple", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("1c44a946-013f-4153-ae11-10d144010b53"), null, "pillory", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("1dcaa3a5-fa93-4fef-af39-3a8ae634efd0"), null, "ship", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("20f717e2-d40b-48d5-8cd7-8723779955c1"), null, "railway_car", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("3dbad5e2-f915-4a4d-98b0-b688edc3ec20"), null, "cathedral", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("4025efcf-7415-48c4-bb5c-f6225fc3e12d"), null, "locomotive", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("4a1a601c-b676-4426-8484-55eed89b78f0"), null, "boundary_stone", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"), null, "church", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("50ec1d4e-8ce7-41ae-af51-b0a803ab3a36"), null, "tank", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("51ad71a3-f27c-42fa-82dc-7c35a4acb920"), null, "tomb", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("851873d1-0a04-4b5a-8f37-2f7ee2b42577"), null, "synagogue", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("8cfde417-44e2-443a-af48-ac4384693d29"), null, "milestone", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("a9ef90cd-d224-4016-a884-38f3241b47e1"), null, "wayside_cross", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("b1c2b6ee-4236-4f66-bb97-cafe9f9d7bac"), null, "shrine", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("b3c350f0-fe62-44b4-a956-228b24141d8f"), null, "monument", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("c3d6b494-e243-4d05-823c-a6e72a0e3928"), null, "chapel", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") },
                    { new Guid("d27ae70c-9ee5-4e1b-9bfc-6f8b48d2a595"), null, "aircraft", new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112") },
                    { new Guid("e740971c-54c7-474e-97ef-042891bbe916"), null, "mosque", new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[,]
                {
                    { new Guid("0b7733ca-e3a2-4aa5-a8e0-0f18d86d0f0c"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") },
                    { new Guid("73bcf016-32bc-48cb-bb8a-061b3c07384b"), new Guid("b37a2c20-cea9-40db-9812-f35dcfc9f6b5") },
                    { new Guid("89d19266-7810-46ba-bcae-fd029692046e"), new Guid("99f54a0b-5ec1-41f9-976d-433cb97f57b4") },
                    { new Guid("9b78a07d-6bdd-48e1-8cba-bb2d86388973"), new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("36b96af6-7a48-4632-a8e4-9be77881ec97") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("53758522-0a17-4211-baa2-165cf08b0d2e") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c") },
                    { new Guid("bc8139f7-e45e-46c8-8eda-fada66f2b112"), new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2") },
                    { new Guid("f89b63bf-69b4-45eb-9a30-1f523c1b5441"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") }
                });

            migrationBuilder.InsertData(
                table: "TripPoints",
                columns: new[] { "Id", "ClosingTime", "Comment", "EndTime", "ExchangeRate", "Name", "OpeningTime", "PlaceId", "PredictedCost", "StartTime", "Status", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("021389c6-d6d4-4b8a-a275-3d1d04292e97"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("be0b4d83-d85d-4ab5-bec0-d0c912a71e18"), 0m, new TimeOnly(13, 30, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("1b70c4cf-4bf6-4508-8011-75370c0f786a"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"), 0m, new TimeOnly(10, 0, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"), 0m, new TimeOnly(11, 50, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("25dc4853-cf52-437a-9b99-f8b0cce72d72"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"), 5m, new TimeOnly(16, 30, 0), 3, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), 30m, new TimeOnly(14, 0, 0), 3, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("4da954c1-f554-4de5-bb03-7aac1a334fb6"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"), 0m, new TimeOnly(11, 0, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("53aaf231-b2d0-40ef-a78b-a82543a5bc11"), null, null, new TimeOnly(17, 0, 0), 1m, "Parowóz TKi3-120", null, new Guid("9a0ddf04-1fc7-40a0-99d2-a52ea24c3edb"), 0m, new TimeOnly(16, 30, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"), 0m, new TimeOnly(13, 0, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("568ec6c8-0084-4f45-a5fd-0070cee6c48e"), null, null, new TimeOnly(11, 20, 0), 1m, "Bohaterom I wojny światowej i Poległym za Wolność Ojczyzny", null, new Guid("7b9d6aa4-a0fe-4c00-a58e-7e18228bec5c"), 0m, new TimeOnly(11, 0, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("09afec0e-1382-4578-8ffd-000971cbbc19"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("783f44f9-d17d-4a30-83c4-587474792929"), null, null, new TimeOnly(10, 20, 0), 1m, "Kaplica loretanska", null, new Guid("5bdc04d7-975d-4ae8-9714-7ee0bb24e72d"), 0m, new TimeOnly(10, 0, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"), null, null, new TimeOnly(13, 10, 0), 1m, "Pomnik 60 Pułku Piechoty", null, new Guid("d151d7c2-31f7-4ff7-9a44-2bf6c7d6cfb2"), 0m, new TimeOnly(13, 0, 0), 1, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"), null, null, new TimeOnly(12, 0, 0), 1m, "Jana Pawła II", null, new Guid("24d8420a-93c9-48a9-9c87-323a592e3aed"), 0m, new TimeOnly(11, 50, 0), 1, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"), new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), "Czas na jedzonko", new TimeOnly(15, 30, 0), 1m, "Bistro Bravo", new TimeOnly(12, 0, 0), new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), 30m, new TimeOnly(14, 0, 0), 0, new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("e379fa4d-3419-45de-85d3-bfcb6ca62145"), null, "Czy to lata?", new TimeOnly(12, 40, 0), 1m, "Samolot MIG", null, new Guid("53758522-0a17-4211-baa2-165cf08b0d2e"), 0m, new TimeOnly(12, 30, 0), 1, new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("e8d519bb-e0e4-4ece-bfe9-c0bc148183e5"), null, null, new TimeOnly(14, 0, 0), 1m, "Kościół w parku", null, new Guid("076737d2-16b9-489c-b157-39f97aba1af2"), 0m, new TimeOnly(13, 30, 0), 2, new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"), null, null, new TimeOnly(13, 0, 0), 1m, "Zalew", null, new Guid("aea1d075-f00d-4966-bb07-09cc2f5ddd4a"), 0m, new TimeOnly(12, 30, 0), 0, new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") }
                });

            migrationBuilder.InsertData(
                table: "ProviderPlacePlaceCategory",
                columns: new[] { "PlaceCategoryId", "ProviderPlaceId" },
                values: new object[] { new Guid("505f6152-a2ae-4f9e-a26f-0b4194fcea9a"), new Guid("46ed1569-f1b2-4b2f-b290-09cc6f08b778") });

            migrationBuilder.InsertData(
                table: "TransferPoints",
                columns: new[] { "Id", "FromTripPointId", "Mode", "ToTripPointId", "TransferTime", "TripDayId" },
                values: new object[,]
                {
                    { new Guid("09cb0b5d-3b36-4f28-bc20-26a1d9561205"), new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"), 1, new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"), new TimeSpan(0, 0, 0, 55, 0), new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("33471b65-36ef-4e45-b65e-0b82cc328232"), new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), 3, new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"), new TimeSpan(0, 0, 13, 30, 0), new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("416d95a7-d16b-41c7-a918-a56bd96ba51c"), new Guid("e379fa4d-3419-45de-85d3-bfcb6ca62145"), 2, new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"), new TimeSpan(0, 0, 3, 13, 0), new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("679ee69f-3983-4352-a317-29ff898de647"), new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"), null, new Guid("021389c6-d6d4-4b8a-a275-3d1d04292e97"), new TimeSpan(0, 0, 20, 0, 0), new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("b6c0088e-83eb-4ec3-bd2c-e94cd1175662"), new Guid("5f7a1df6-373c-4a4b-80bc-f288180def03"), null, new Guid("e8d519bb-e0e4-4ece-bfe9-c0bc148183e5"), new TimeSpan(0, 0, 20, 0, 0), new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("b8829d9f-b889-4c3b-86bd-82cd9d53d9c2"), new Guid("568ec6c8-0084-4f45-a5fd-0070cee6c48e"), 0, new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"), new TimeSpan(0, 0, 4, 21, 0), new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("c57269bb-fd4e-4ea7-93f1-b8cf99d0d419"), new Guid("4da954c1-f554-4de5-bb03-7aac1a334fb6"), 0, new Guid("c3aa8e7d-4848-4d72-8de7-92ff3072bd28"), new TimeSpan(0, 0, 4, 21, 0), new Guid("8b5184ef-1249-4813-9e5e-ee73faa8a8e3") },
                    { new Guid("c72e1fde-4425-40ca-a465-892650635787"), new Guid("9d634ad2-089f-4031-bed6-257958eb5d5d"), 3, new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), new TimeSpan(0, 0, 8, 18, 0), new Guid("bb2cfd42-d5d1-40ac-823b-745e893573aa") },
                    { new Guid("de2538d8-bb9b-4e71-96f8-d624510527c5"), new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"), 3, new Guid("53aaf231-b2d0-40ef-a78b-a82543a5bc11"), new TimeSpan(0, 0, 13, 30, 0), new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("e8d7055f-08bc-42d7-b6e2-bc3768f6cc2f"), new Guid("1c6861f9-7a1e-428d-a5b1-eb85d4838790"), 1, new Guid("fca502ae-d0ea-450f-849b-b653bf577bf8"), new TimeSpan(0, 0, 0, 55, 0), new Guid("670f19a0-651e-4e4f-88e3-26f6a54e6d93") },
                    { new Guid("f07bfe27-358f-4189-a251-9f9f6113499e"), new Guid("25dc4853-cf52-437a-9b99-f8b0cce72d72"), 2, new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"), new TimeSpan(0, 0, 3, 13, 0), new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") },
                    { new Guid("f26cac79-8bbf-4867-a60c-1c72fea085bc"), new Guid("54f8d7e9-c511-4830-8879-da9839da12ad"), 3, new Guid("c58946d3-354a-4834-a602-f98b36abfe3b"), new TimeSpan(0, 0, 8, 18, 0), new Guid("5999444f-74a0-4232-a7bc-21cfa48544cd") }
                });

            migrationBuilder.InsertData(
                table: "TripPointReviews",
                columns: new[] { "Id", "ActualCostPerPerson", "ActualTimeSpent", "CurrencyCode", "ExchangeRate", "PlaceId", "Rating", "TripPointId", "UserId" },
                values: new object[,]
                {
                    { new Guid("400db1c9-1a82-4447-b610-a53b83b34bcb"), 10m, new TimeSpan(0, 0, 10, 0, 0), "PLN", 1m, new Guid("c8eb6289-5dc7-495d-873a-66cea43164a5"), 4.5m, new Guid("3468e2f0-f165-4cf4-a66a-58de98a44272"), "c324c822-30c1-7029-7c4f-00799aadf54a" },
                    { new Guid("6180b39d-9a99-4546-81fe-c393efbb30eb"), 40m, new TimeSpan(0, 1, 0, 0, 0), "PLN", 1m, new Guid("977c8178-9039-47ff-ad5b-98373b292abc"), 5m, new Guid("47ddf113-4e44-4e77-b518-f7fd725c530a"), "c324c822-30c1-7029-7c4f-00799aadf54a" }
                });
        }
    }
}
