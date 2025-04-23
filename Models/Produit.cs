namespace dotNetStore.Models;

public class Produit : ISoftDeletable
{
    public int Id { get; set; }
    public required string Nom { get; set; }
    public string? Categorie { get; set; }
    public decimal? Prix { get; set; }
    public decimal? PrixAncien { get; set; }
    public string? Description { get; set; }
    public bool ReductionMax { get; set; } = false;
    public bool Top { get; set; } = false; //Top des ventes
    public bool BadgeNew { get; set; } = false;
    public int? BadgeReduction { get; set; }
    public string? Photo1 { get; set; }
    public string? Photo2 { get; set; }
    public string? Photo3 { get; set; }
    public string? Photo4 { get; set; }
    public bool IsDeleted { get; set; } = false;

    public ICollection<Commande>? Commandes { get; set; }
}
