using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotNetStore.Models;

public class Commande
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Prix { get; set; }
    public decimal PrixShipping { get; set; }
    public int Qte { get; set; }
    public decimal Total { get; set; }

    [ForeignKey("Produit")]
    public int? ProduitId { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Produit? Produit { get; set; }

    [ForeignKey("Facture")]
    public int? FactureId { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Facture? Facture { get; set; }
}
