using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LepecydLanches.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Categorias(CategoriaNome,Descricao) " + 
                "Values('Normal', 'Lanche feito com ingredientes normais')");
            mb.Sql("Insert Into Categorias(CategoriaNome,Descricao) " +
                "Values('Natural', 'Lanche feito com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
