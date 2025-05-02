using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotNetStore.Models;

public class Produit : ISoftDeletable
{
    public int Id { get; set; }
    public required string Nom { get; set; }
    public decimal? Prix { get; set; }
    public decimal? PrixAncien { get; set; }
    public decimal? PrixShipping { get; set; }
    public string? Description { get; set; }
    public bool ReductionFolle { get; set; } = false;
    public bool TopVente { get; set; } = false;
    public bool BadgeNew { get; set; } = false;
    public int BadgeReduction { get; set; } = 0;
    public bool Autre1 { get; set; } = false;
    public bool Autre2 { get; set; } = false;
    public bool Autre3 { get; set; } = false;
    public string? Photo1 { get; set; }
    public string? Photo2 { get; set; }
    public string? Photo3 { get; set; }
    public string? Photo4 { get; set; }
    public bool IsDeleted { get; set; } = false;

    [ForeignKey("CategorieProduit")]
    public int? CategorieId { get; set; }
    [DeleteBehavior(DeleteBehavior.SetNull)]
    public CategorieProduit? Categorie { get; set; }

    [ForeignKey("Marque")]
    public int? MarqueId { get; set; }
    [DeleteBehavior(DeleteBehavior.SetNull)]
    public Marque? Marque { get; set; }

    public ICollection<Commande>? Commandes { get; set; }
}
