using System.ComponentModel.DataAnnotations;

namespace dotNetStore.Models;

public class Marque
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Entrez la Marque")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "Entrez de 3 a 10 caractères")]
    public string Nom { get; set; }

    public ICollection<Produit>? Produits { get; set; }
}
