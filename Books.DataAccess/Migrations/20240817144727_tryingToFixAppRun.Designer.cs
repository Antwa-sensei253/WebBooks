using Books.DataAccess.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240817144727_tryingToFixAppRun")]
    partial class tryingToFixAppRun : Migration // Added inheritance from Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Books.Models.Category", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("DisplayOrder")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("nvarchar(30)");

                b.HasKey("Id");

                b.ToTable("Categories");
            });
#pragma warning restore 612, 618
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
