using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Required(ErrorMessage = "Descrição obrigatória!")]
    public string Descricao { get; set; }

    public double Preco { get; set; }

    public int Estoque { get; set; }

    [Required(ErrorMessage = "Código do produto não pode estar vazio")]
    [RegularExpression(@"^[A-Z]{3}-\d{4}$", ErrorMessage = "Código do produto deve seguir o formato AAA-1234")]
    public string CodigoProduto { get; set; }
}
