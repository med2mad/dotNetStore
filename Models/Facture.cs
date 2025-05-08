namespace dotNetStore.Models;

public class Facture : ISoftDeletable
{
    public int Id { get; set; }
    public string Reference { get; set; }
    public string NomClient { get; set; }
    public string Telephone { get; set; }
    public string? Email { get; set; }
    public string? Adresse { get; set; }
    public decimal PrixShipping { get; set; }
    public decimal Total { get; set; }
    public DateTime Date { get; set; }
    public bool IsDeleted { get; set; } = false;

    public ICollection<Commande>? Commandes { get; set; }
}
