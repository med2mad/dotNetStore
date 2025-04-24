namespace dotNetStore.Models;

public class Marque
{
    public int Id { get; set; }
    public string Nom { get; set; }

    public ICollection<Produit>? Produits { get; set; }
}
