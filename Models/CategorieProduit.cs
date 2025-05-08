using System.ComponentModel.DataAnnotations;

namespace dotNetStore.Models;

public class CategorieProduit
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Entrez la Catégorie")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "Entrez de 3 a 10 caractères")]
    public string Categorie { get; set; }
    public string? SousCategorie { get; set; }
    public string? Photo { get; set; }

    public ICollection<Produit>? Produits { get; set; }
}

