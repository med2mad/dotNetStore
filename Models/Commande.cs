using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetStore.Models;

public class Commande
{
    public int Id { get; set; }
    public decimal Prix { get; set; }
    public int Quantite { get; set; }
    public decimal Total { get; set; }

    [ForeignKey("Produit")]
    public int? ProduiId { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Produit? Produit { get; set; }

    [ForeignKey("Facture")]
    public int? FactureId { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Facture? Facture { get; set; }
}
