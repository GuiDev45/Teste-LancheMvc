namespace LancheMvc.Models
{
    public class Categoria
    {
        //Propriedade com Id ou NomeEntidadeId vai gerar uma chave primária na tabela.
        //Propriedades da classe vão gerar colunas com o mesmo nome na tabela.
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //Relacionamento (1 - N) entre a entidade Categoria e a entidade Lanche.
        public List<Lanche> Lanches { get; set; }
    }
}
