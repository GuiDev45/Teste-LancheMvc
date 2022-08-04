namespace LancheMvc.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        //Relacionamento entre as entidades/propriedade de navegação,
        //relacionamento entre Lanche e Categoria, CategoriaId vai ser a chave estrangeira.
        //Esses dois atributos não vão ser criados na tabela do banco de dados, 
        //vão ser usados para definir o relacionamento entre Lanche e Categoria
        public int CategoriaId { get; set; }
        //Propriedade de navegação Categora Categoria.
        //Lembrando que para um método comum possa ser sobreposto/override, deve ser incluído nele o virtual.
        public virtual Categoria Categoria { get; set; }
    }
}
